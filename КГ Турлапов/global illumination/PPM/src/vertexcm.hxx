#ifndef __VERTEXCM_HXX__
#define __VERTEXCM_HXX__

#include <vector>
#include <cmath>
#include <cassert>
#include "renderer.hxx"
#include "bsdf.hxx"
#include "rng.hxx"
#include "hashgrid.hxx"

class VertexCM : public AbstractRenderer
{
    // The sole point of this structure is to make carrying around the ray baggage easier.
    struct SubPathState
    {
        Vec3f mOrigin;             // Path origin
        Vec3f mDirection;          // Where to go next
        Vec3f mThroughput;         // Path throughput
        uint  mPathLength    : 30; // Number of path segments, including this
        uint  mIsFiniteLight :  1; // Just generate by finite light
        uint  mSpecularPath  :  1; // All scattering events so far were specular
    };

    // Path vertex, used for merging and connection
    template<bool tFromLight>
    struct PathVertex
    {
        Vec3f mHitpoint;   // Position of the vertex
        Vec3f mThroughput; // Path throughput (including emission)
        uint  mPathLength; // Number of segments between source and vertex

        // Stores all required local information, including incoming direction.
        BSDF<tFromLight> mBsdf;

        // Used by HashGrid
        const Vec3f& GetPosition() const
        {
            return mHitpoint;
        }
    };

    typedef PathVertex<false> CameraVertex;
    typedef PathVertex<true>  LightVertex;

    typedef BSDF<false>       CameraBSDF;
    typedef BSDF<true>        LightBSDF;

    // Range query used for PPM, BPT, and VCM. When HashGrid finds a vertex
    // within range -- Process() is called and vertex
    // merging is performed. BSDF of the camera vertex is used.
    class RangeQuery
    {
    public:

        RangeQuery(
            const VertexCM     &aVertexCM,
            const Vec3f        &aCameraPosition,
            const CameraBSDF   &aCameraBsdf,
            const SubPathState &aCameraState
        ) : 
            mVertexCM(aVertexCM),
            mCameraPosition(aCameraPosition),
            mCameraBsdf(aCameraBsdf),
            mCameraState(aCameraState),
            mContrib(0)
        {}

        const Vec3f& GetPosition() const 
		{ 
			return mCameraPosition; 
		}

        const Vec3f& GetContrib() const 
		{ 
			return mContrib; 
		}

        void Process(const LightVertex& aLightVertex)
        {
            // Reject if full path length below/above min/max path length
            if((aLightVertex.mPathLength + mCameraState.mPathLength > mVertexCM.mMaxPathLength) ||
               (aLightVertex.mPathLength + mCameraState.mPathLength < mVertexCM.mMinPathLength))
                 return;

            // Retrieve light incoming direction in world coordinates
            const Vec3f lightDirection = aLightVertex.mBsdf.WorldDirFix();

            float cosCamera, cameraBsdfDirPdfW, cameraBsdfRevPdfW;
            const Vec3f cameraBsdfFactor = mCameraBsdf.Evaluate(
                mVertexCM.mScene, lightDirection, cosCamera, &cameraBsdfDirPdfW,
                &cameraBsdfRevPdfW);

            if(cameraBsdfFactor.IsZero())
                return;

            cameraBsdfDirPdfW *= mCameraBsdf.ContinuationProb();

            // Even though this is pdf from camera BSDF, the continuation probability
            // must come from light BSDF, because that would govern it if light path
            // actually continued
            cameraBsdfRevPdfW *= aLightVertex.mBsdf.ContinuationProb();

            mContrib += cameraBsdfFactor * aLightVertex.mThroughput;
        }

    private:

        const VertexCM     &mVertexCM;
        const Vec3f        &mCameraPosition;
        const CameraBSDF   &mCameraBsdf;
        const SubPathState &mCameraState;
        Vec3f              mContrib;
    };

public:

    enum AlgorithmType
    {
        kPpm
    };

public:

    VertexCM(
        const Scene&  aScene,
        AlgorithmType aAlgorithm,
        const float   aRadiusFactor,
        const float   aRadiusAlpha,
        int           aSeed = 1234
    ) :
        AbstractRenderer(aScene),
        mRng(aSeed),
        mUseVM(false),
        mPpm(false)
    {
		mPpm   = true;
		mUseVM = true;
        mBaseRadius  = aRadiusFactor * mScene.mSceneSphere.mSceneRadius;
        mRadiusAlpha = aRadiusAlpha;
    }

    virtual void RunIteration(int aIteration, int PhotonNumber)
    {
        // While we have the same number of pixels (camera paths)
        // and light paths, we do keep them separate for clarity reasons
        const int resX = int(mScene.mCamera.mResolution.x);
        const int resY = int(mScene.mCamera.mResolution.y);
        const int pathCount = resX * resY;
        mScreenPixelCount = float(resX * resY);
        mLightSubPathCount   = float(resX * resY);

        // Setup our radius, 1st iteration has aIteration == 0, thus offset
        float radius = mBaseRadius;
        radius /= std::pow(float(aIteration + 1), 0.5f * (1 - mRadiusAlpha));
        radius = std::max(radius, 1e-7f);
        const float radiusSqr = Sqr(radius);

        // Factor used to normalise vertex merging contribution.
        // We divide the summed up energy by disk radius and number of light paths
        mVmNormalization = 1.f / (radiusSqr * PI_F * mLightSubPathCount);

        // MIS weight constant [tech. rep. (20)], with n_VC = 1 and n_VM = mLightPathCount
        //const float etaVCM = (PI_F * radiusSqr) * mLightSubPathCount;
        mMisVmWeightFactor = (PI_F * radiusSqr) * mLightSubPathCount;
        mMisVcWeightFactor = 0.f;

        // Clear path ends, nothing ends anywhere
        //mPathEnds.resize(PhotonNumber);
		mPathEnds.resize(pathCount);
        memset(&mPathEnds[0], 0, mPathEnds.size() * sizeof(int));

        // Remove all light vertices and reserve space for some
        mLightVertices.reserve(pathCount);
        mLightVertices.clear();

        //////////////////////////////////////////////////////////////////////////
        // Generate light paths
        //////////////////////////////////////////////////////////////////////////
		for(int pathIdx = 0; pathIdx < pathCount; pathIdx++)//PhotonNumber; pathIdx++)
        {
			//if (pathIdx % 1000 == 0) printf("\r%i from %i", pathIdx, pathCount); fflush(stdout);
			// Формируем луч (фотон)
            SubPathState lightState;
            GenerateLightSample(lightState);

            //////////////////////////////////////////////////////////////////////////
            // Trace light path
            for(;; ++lightState.mPathLength)
            {
                // Offset ray origin instead of setting tmin due to numeric
                // issues in ray-sphere intersection. The isect.dist has to be
                // extended by this EPS_RAY after hit point is determined
                Ray ray(lightState.mOrigin + lightState.mDirection * EPS_RAY,
                    lightState.mDirection, 0);

				// Нашли пересечение луча со сценой
                Isect isect(1e36f);
                if(!mScene.Intersect(ray, isect))
                    break;
                const Vec3f hitPoint = ray.org + ray.dir * isect.dist;
                isect.dist += EPS_RAY;

                LightBSDF bsdf(ray, isect, mScene);
                if(!bsdf.IsValid())
                    break;

				// Сохраняем если не на зеркале
                if(!bsdf.IsDelta())
                {
                    LightVertex lightVertex;
                    lightVertex.mHitpoint   = hitPoint;
                    lightVertex.mThroughput = lightState.mThroughput;
                    lightVertex.mPathLength = lightState.mPathLength;
                    lightVertex.mBsdf       = bsdf;
					
                    mLightVertices.push_back(lightVertex);
                }

                // Terminate if the path would become too long after scattering
                if(lightState.mPathLength + 2 > mMaxPathLength)
                    break;

                // Continue random walk
				// Находим следующее направление и мб останавливаемся
                if(!SampleScattering(bsdf, hitPoint, lightState))
                    break;
            }

            mPathEnds[pathIdx] = (int)mLightVertices.size();
        }

        //////////////////////////////////////////////////////////////////////////
        // Build hash grid
        //////////////////////////////////////////////////////////////////////////

        // Only build grid when merging (VCM, BPM, and PPM)
        if(mUseVM)
        {
            // The number of cells is somewhat arbitrary, but seems to work ok
            mHashGrid.Reserve(pathCount);
            mHashGrid.Build(mLightVertices, radius);
        }

        //////////////////////////////////////////////////////////////////////////
        // Generate camera paths
        //////////////////////////////////////////////////////////////////////////

        // Unless rendering with traditional light tracing
        for(int pathIdx = 0; (pathIdx < pathCount); ++pathIdx)
        {
            SubPathState cameraState;
            const Vec2f screenSample = GenerateCameraSample(pathIdx, cameraState);
            Vec3f color(0);

            //////////////////////////////////////////////////////////////////////
            // Trace camera path
            for(;; ++cameraState.mPathLength)
            {
                // Offset ray origin instead of setting tmin due to numeric
                // issues in ray-sphere intersection. The isect.dist has to be
                // extended by this EPS_RAY after hit point is determined
                Ray ray(cameraState.mOrigin + cameraState.mDirection * EPS_RAY,
                    cameraState.mDirection, 0);

                Isect isect(1e36f);
				if(!mScene.Intersect(ray, isect))
                    break;

                const Vec3f hitPoint = ray.org + ray.dir * isect.dist;
                isect.dist += EPS_RAY;

                CameraBSDF bsdf(ray, isect, mScene);
                if(!bsdf.IsValid())
                    break;

                // Light source has been hit; terminate afterwards, since
                // our light sources do not have reflective properties
                if(isect.lightID >= 0)
                {
                    const AbstractLight *light = mScene.GetLightPtr(isect.lightID);
                
                    if(cameraState.mPathLength >= mMinPathLength)
                    {
                        color += cameraState.mThroughput *
                            GetLightRadiance(light, cameraState, hitPoint, ray.dir);
                    }
                    
                    break;
                }

                // Terminate if eye sub-path is too long for merging
                if(cameraState.mPathLength >= mMaxPathLength)
                    break;

                ////////////////////////////////////////////////////////////////
                // Vertex merging: Merge with light vertices
				// Если не зеркало
                if(!bsdf.IsDelta() && mUseVM)
                {
                    RangeQuery query(*this, hitPoint, bsdf, cameraState);
                    mHashGrid.Process(mLightVertices, query);
                    color += cameraState.mThroughput * mVmNormalization * query.GetContrib();

                    // PPM merges only at the first non-specular surface from camera
                    break;
                }

                if(!SampleScattering(bsdf, hitPoint, cameraState))
                    break;
            }

            mFramebuffer.AddColor(screenSample, color);
        }

        mIterations++;
    }

private:

    //////////////////////////////////////////////////////////////////////////
    // Camera tracing methods
    //////////////////////////////////////////////////////////////////////////

    // Generates new camera sample given a pixel index
    Vec2f GenerateCameraSample(
        const int    aPixelIndex,
        SubPathState &oCameraState)
    {
        const Camera &camera = mScene.mCamera;
        const int resX = int(camera.mResolution.x);
        const int resY = int(camera.mResolution.y);

        // Determine pixel (x, y)
        const int x = aPixelIndex % resX;
        const int y = aPixelIndex / resX;

        // Jitter pixel position
        const Vec2f sample = Vec2f(float(x), float(y)) + mRng.GetVec2f();

        // Generate ray
        const Ray primaryRay = camera.GenerateRay(sample);

        // Compute pdf conversion factor from area on image plane to solid angle on ray
        const float cosAtCamera = Dot(camera.mForward, primaryRay.dir);
        const float imagePointToCameraDist = camera.mImagePlaneDist / cosAtCamera;
        const float imageToSolidAngleFactor = Sqr(imagePointToCameraDist) / cosAtCamera;

        // We put the virtual image plane at such a distance from the camera origin
        // that the pixel area is one and thus the image plane sampling pdf is 1.
        // The solid angle ray pdf is then equal to the conversion factor from
        // image plane area density to ray solid angle density
        const float cameraPdfW = imageToSolidAngleFactor;

        oCameraState.mOrigin       = primaryRay.org;
        oCameraState.mDirection    = primaryRay.dir;
        oCameraState.mThroughput   = Vec3f(1);

        oCameraState.mPathLength   = 1;
        oCameraState.mSpecularPath = 1;

        return sample;
    }

    // Returns the radiance of a light source when hit by a random ray,
    // multiplied by MIS weight. Can be used for both Background and Area lights.
    //
    // For Background lights:
    //    Has to be called BEFORE updating the MIS quantities.
    //    Value of aHitpoint is irrelevant (passing Vec3f(0))
    //
    // For Area lights:
    //    Has to be called AFTER updating the MIS quantities.
    Vec3f GetLightRadiance(
        const AbstractLight *aLight,
        const SubPathState  &aCameraState,
        const Vec3f         &aHitpoint,
        const Vec3f         &aRayDirection) const
    {
        // We sample lights uniformly
        const int   lightCount    = mScene.GetLightCount();
        const float lightPickProb = 1.f / lightCount;

        float directPdfA, emissionPdfW;
        const Vec3f radiance = aLight->GetRadiance(mScene.mSceneSphere,
            aRayDirection, aHitpoint, &directPdfA, &emissionPdfW);

        if(radiance.IsZero())
            return Vec3f(0);

        // If we see light source directly from camera, no weighting is required
        if(aCameraState.mPathLength == 1)
            return radiance;

        // When using only vertex merging, we want purely specular paths
        // to give radiance (cannot get it otherwise). Rest is handled
        // by merging and we should return 0.
        return aCameraState.mSpecularPath ? radiance : Vec3f(0);
    }

    void GenerateLightSample(SubPathState &oLightState)
    {
        // We sample lights uniformly
        const int   lightCount    = mScene.GetLightCount();
        const float lightPickProb = 1.f / lightCount;

        const int   lightID       = int(mRng.GetFloat() * lightCount);
        const Vec2f rndDirSamples = mRng.GetVec2f();
        const Vec2f rndPosSamples = mRng.GetVec2f();

        const AbstractLight *light = mScene.GetLightPtr(lightID);

		// Заполняем нач точку, направление
        float emissionPdfW, directPdfW, cosLight;
        oLightState.mThroughput = light->Emit(mScene.mSceneSphere, rndDirSamples, rndPosSamples,
            oLightState.mOrigin, oLightState.mDirection,
            emissionPdfW, &directPdfW, &cosLight);

        emissionPdfW *= lightPickProb;
        directPdfW   *= lightPickProb;

        oLightState.mThroughput    /= emissionPdfW;
        oLightState.mPathLength    = 1;
        oLightState.mIsFiniteLight = light->IsFinite() ? 1 : 0;

    }

    template<bool tLightSample>
    bool SampleScattering(
        const BSDF<tLightSample> &aBsdf,
        const Vec3f              &aHitPoint,
        SubPathState             &aoState)
    {
        // x,y for direction, z for component. No rescaling happens
        Vec3f rndTriplet  = mRng.GetVec3f();
        float bsdfDirPdfW, cosThetaOut;
        uint  sampledEvent;

		// находим следующее направление
        Vec3f bsdfFactor = aBsdf.Sample(mScene, rndTriplet, aoState.mDirection,
            bsdfDirPdfW, cosThetaOut, &sampledEvent);

        if(bsdfFactor.IsZero())
            return false;

        // If we sampled specular event, then the reverse probability
        // cannot be evaluated, but we know it is exactly the same as
        // forward probability, so just set it. If non-specular event happened,
        // we evaluate the pdf
        float bsdfRevPdfW = bsdfDirPdfW;
        if((sampledEvent & LightBSDF::kSpecular) == 0)
            bsdfRevPdfW = aBsdf.Pdf(mScene, aoState.mDirection, true);

        // Russian roulette
        const float contProb = aBsdf.ContinuationProb();
        if(mRng.GetFloat() > contProb)
            return false;

        bsdfDirPdfW *= contProb;
        bsdfRevPdfW *= contProb;

        if(sampledEvent & LightBSDF::kSpecular)
        {
            // Specular scattering case [tech. rep. (53)-(55)] (partially, as noted above)
            assert(bsdfDirPdfW == bsdfRevPdfW);

            aoState.mSpecularPath &= 1;
        }
        else
        {
            aoState.mSpecularPath &= 0;
        }

        aoState.mOrigin  = aHitPoint;
        aoState.mThroughput *= bsdfFactor * (cosThetaOut / bsdfDirPdfW);
        
        return true;
    }

private:

    bool  mUseVM;             // Vertex merging (of some form) is used
    bool  mPpm;               // Do PPM, same terminates camera after first merge

    float mRadiusAlpha;       // Radius reduction rate parameter
    float mBaseRadius;        // Initial merging radius
    float mMisVmWeightFactor; // Weight of vertex merging (used in VC)
    float mMisVcWeightFactor; // Weight of vertex connection (used in VM)
    float mScreenPixelCount;  // Number of pixels
    float mLightSubPathCount; // Number of light sub-paths
    float mVmNormalization;   // 1 / (Pi * radius^2 * light_path_count)

    std::vector<LightVertex> mLightVertices; //!< Stored light vertices

    // For light path belonging to pixel index [x] it stores
    // where it's light vertices end (begin is at [x-1])
    std::vector<int> mPathEnds;
    HashGrid         mHashGrid;

    Rng              mRng;
};

#endif //__VERTEXCM_HXX__
