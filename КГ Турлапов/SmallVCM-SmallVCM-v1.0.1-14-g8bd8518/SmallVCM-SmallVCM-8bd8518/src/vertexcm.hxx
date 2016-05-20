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
    struct SubPathState
    {
        Vec3f mOrigin;             // Path origin
        Vec3f mDirection;          // Where to go next
        Vec3f mThroughput;         // Path throughput
        uint  mPathLength    : 30; // Number of path segments, including this
        uint  mIsFiniteLight :  1; // Just generate by finite light
        uint  mSpecularPath  :  1; // All scattering events so far were specular

        float dVCM; // MIS quantity used for vertex connection and merging
        float dVC;  // MIS quantity used for vertex connection
        float dVM;  // MIS quantity used for vertex merging
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

        float dVCM; // MIS quantity used for vertex connection and merging
        float dVC;  // MIS quantity used for vertex connection
        float dVM;  // MIS quantity used for vertex merging

        const Vec3f& GetPosition() const
        {
            return mHitpoint;
        }
    };

    typedef PathVertex<false> CameraVertex;
    typedef PathVertex<true>  LightVertex;

    typedef BSDF<false>       CameraBSDF;
    typedef BSDF<true>        LightBSDF;

public:

    enum AlgorithmType
    {
        // light vertices contribute to camera,
        // No MIS weights (dVCM, dVM, dVC all ignored)
        kLightTrace = 0,
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
        mLightTraceOnly(false),
        mUseVC(false),
        mUseVM(false),
        mPpm(false)
    {
        switch(aAlgorithm)
        {
        case kLightTrace:
            mLightTraceOnly = true;
            break;
        default:
            printf("Unknown algorithm requested\n");
            break;
        }

        if(mPpm)
        {
            // We will check the scene to make sure it does not contain mixed
            // specular and non-specular materials
            for(int i = 0; i < mScene.GetMaterialCount(); ++i)
            {
                const Material &mat = mScene.GetMaterial(i);

                const bool hasNonSpecular =
                    (mat.mDiffuseReflectance.Max() > 0) ||
                    (mat.mPhongReflectance.Max() > 0);

                const bool hasSpecular =
                    (mat.mMirrorReflectance.Max() > 0) ||
                    (mat.mIOR > 0);
            }
        }

        mBaseRadius  = aRadiusFactor * mScene.mSceneSphere.mSceneRadius;
        mRadiusAlpha = aRadiusAlpha;
    }

    virtual void RunIteration(int aIteration)
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
        // Purely for numeric stability
        radius = std::max(radius, 1e-7f);
        const float radiusSqr = Sqr(radius);

        // Factor used to normalise vertex merging contribution.
        // We divide the summed up energy by disk radius and number of light paths
        mVmNormalization = 1.f / (radiusSqr * PI_F * mLightSubPathCount);

        const float etaVCM = (PI_F * radiusSqr) * mLightSubPathCount;
        mMisVmWeightFactor = mUseVM ? Mis(etaVCM)       : 0.f;
        mMisVcWeightFactor = mUseVC ? Mis(1.f / etaVCM) : 0.f;

        // Clear path ends, nothing ends anywhere
        mPathEnds.resize(pathCount);
        memset(&mPathEnds[0], 0, mPathEnds.size() * sizeof(int));

        // Remove all light vertices and reserve space for some
        mLightVertices.reserve(pathCount);
        mLightVertices.clear();

        for(int pathIdx = 0; pathIdx < pathCount; pathIdx++)
        {
            SubPathState lightState;
            GenerateLightSample(lightState);

            for(;; ++lightState.mPathLength)
            {
                Ray ray(lightState.mOrigin + lightState.mDirection * EPS_RAY,
                    lightState.mDirection, 0);
                Isect isect(1e36f);

                if(!mScene.Intersect(ray, isect))
                    break;

                const Vec3f hitPoint = ray.org + ray.dir * isect.dist;
                isect.dist += EPS_RAY;

                LightBSDF bsdf(ray, isect, mScene);
                if(!bsdf.IsValid())
                    break;

                {
                    if(lightState.mPathLength > 1 || lightState.mIsFiniteLight == 1)
                        lightState.dVCM *= Mis(Sqr(isect.dist));

                    lightState.dVCM /= Mis(std::abs(bsdf.CosThetaFix()));
                    lightState.dVC  /= Mis(std::abs(bsdf.CosThetaFix()));
                    lightState.dVM  /= Mis(std::abs(bsdf.CosThetaFix()));
                }

                if(!bsdf.IsDelta() && (mUseVC || mUseVM))
                {
                    LightVertex lightVertex;
                    lightVertex.mHitpoint   = hitPoint;
                    lightVertex.mThroughput = lightState.mThroughput;
                    lightVertex.mPathLength = lightState.mPathLength;
                    lightVertex.mBsdf       = bsdf;

                    lightVertex.dVCM = lightState.dVCM;
                    lightVertex.dVC  = lightState.dVC;
                    lightVertex.dVM  = lightState.dVM;

                    mLightVertices.push_back(lightVertex);
                }

                // Connect to camera, unless BSDF is purely specular
                if(!bsdf.IsDelta() && (mUseVC || mLightTraceOnly))
                {
                    if(lightState.mPathLength + 1 >= mMinPathLength)
                        ConnectToCamera(lightState, hitPoint, bsdf);
                }

                // Terminate if the path would become too long after scattering
                if(lightState.mPathLength + 2 > mMaxPathLength)
                    break;

                // Continue random walk
                if(!SampleScattering(bsdf, hitPoint, lightState))
                    break;
            }

            mPathEnds[pathIdx] = (int)mLightVertices.size();
        }

        mIterations++;
    }

private:

    // Mis power, we use balance heuristic
    float Mis(float aPdf) const
    {
        //return std::pow(aPdf, /*power*/);
        return aPdf;
    }

    //////////////////////////////////////////////////////////////////////////
    // Light tracing methods
    //////////////////////////////////////////////////////////////////////////

    // Samples light emission
    void GenerateLightSample(SubPathState &oLightState)
    {
        // We sample lights uniformly
        const int   lightCount    = mScene.GetLightCount();
        const float lightPickProb = 1.f / lightCount;

        const int   lightID       = int(mRng.GetFloat() * lightCount);
        const Vec2f rndDirSamples = mRng.GetVec2f();
        const Vec2f rndPosSamples = mRng.GetVec2f();

        const AbstractLight *light = mScene.GetLightPtr(lightID);

        float emissionPdfW, directPdfW, cosLight;
        oLightState.mThroughput = light->Emit(mScene.mSceneSphere, rndDirSamples, rndPosSamples,
            oLightState.mOrigin, oLightState.mDirection,
            emissionPdfW, &directPdfW, &cosLight);

        emissionPdfW *= lightPickProb;
        directPdfW   *= lightPickProb;

        oLightState.mThroughput    /= emissionPdfW;
        oLightState.mPathLength    = 1;
        oLightState.mIsFiniteLight = light->IsFinite() ? 1 : 0;

        {
            oLightState.dVCM = Mis(directPdfW / emissionPdfW);

            if(!light->IsDelta())
            {
                const float usedCosLight = light->IsFinite() ? cosLight : 1.f;
                oLightState.dVC = Mis(usedCosLight / emissionPdfW);
            }
            else
            {
                oLightState.dVC = 0.f;
            }

            oLightState.dVM = oLightState.dVC * mMisVcWeightFactor;
        }
    }

    // Computes contribution of light sample to camera by splatting is onto the
    // framebuffer. Multiplies by throughput (obviously, as nothing is returned).
    void ConnectToCamera(
        const SubPathState &aLightState,
        const Vec3f        &aHitpoint,
        const LightBSDF    &aBsdf)
    {
        const Camera &camera    = mScene.mCamera;
        Vec3f directionToCamera = camera.mPosition - aHitpoint;

        // Check point is in front of camera
        if(Dot(camera.mForward, -directionToCamera) <= 0.f)
            return;

        // Check it projects to the screen (and where)
        const Vec2f imagePos = camera.WorldToRaster(aHitpoint);
        if(!camera.CheckRaster(imagePos))
            return;

        // Compute distance and normalize direction to camera
        const float distEye2 = directionToCamera.LenSqr();
        const float distance = std::sqrt(distEye2);
        directionToCamera   /= distance;

        // Get the BSDF
        float cosToCamera, bsdfDirPdfW, bsdfRevPdfW;
        const Vec3f bsdfFactor = aBsdf.Evaluate(mScene,
            directionToCamera, cosToCamera, &bsdfDirPdfW, &bsdfRevPdfW);

        if(bsdfFactor.IsZero())
            return;

        bsdfRevPdfW *= aBsdf.ContinuationProb();

        // Compute pdf conversion factor from image plane area to surface area
        const float cosAtCamera = Dot(camera.mForward, -directionToCamera);
        const float imagePointToCameraDist = camera.mImagePlaneDist / cosAtCamera;
        const float imageToSolidAngleFactor = Sqr(imagePointToCameraDist) / cosAtCamera;
        const float imageToSurfaceFactor = imageToSolidAngleFactor * std::abs(cosToCamera) / Sqr(distance);

        const float cameraPdfA = imageToSurfaceFactor;
        const float wLight = Mis(cameraPdfA / mLightSubPathCount) * (
            mMisVmWeightFactor + aLightState.dVCM + aLightState.dVC * Mis(bsdfRevPdfW));


        const float misWeight = mLightTraceOnly ? 1.f : (1.f / (wLight + 1.f));

        const float surfaceToImageFactor = 1.f / imageToSurfaceFactor;

        const Vec3f contrib = misWeight * aLightState.mThroughput * bsdfFactor /
            (mLightSubPathCount * surfaceToImageFactor);

        if(!contrib.IsZero())
        {
            if(mScene.Occluded(aHitpoint, directionToCamera, distance))
                return;

            mFramebuffer.AddColor(imagePos, contrib);
        }
    }

    template<bool tLightSample>
    bool SampleScattering(
        const BSDF<tLightSample> &aBsdf,
        const Vec3f              &aHitPoint,
        SubPathState             &aoState)
    {
        Vec3f rndTriplet  = mRng.GetVec3f();
        float bsdfDirPdfW, cosThetaOut;
        uint  sampledEvent;

        Vec3f bsdfFactor = aBsdf.Sample(mScene, rndTriplet, aoState.mDirection,
            bsdfDirPdfW, cosThetaOut, &sampledEvent);

        if(bsdfFactor.IsZero())
            return false;

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
            aoState.dVCM = 0.f;
            assert(bsdfDirPdfW == bsdfRevPdfW);
            aoState.dVC *= Mis(cosThetaOut);
            aoState.dVM *= Mis(cosThetaOut);

            aoState.mSpecularPath &= 1;
        }
        else
        {
            aoState.dVC = Mis(cosThetaOut / bsdfDirPdfW) * (
                aoState.dVC * Mis(bsdfRevPdfW) +
                aoState.dVCM + mMisVmWeightFactor);

            aoState.dVM = Mis(cosThetaOut / bsdfDirPdfW) * (
                aoState.dVM * Mis(bsdfRevPdfW) +
                aoState.dVCM * mMisVcWeightFactor + 1.f);

            aoState.dVCM = Mis(1.f / bsdfDirPdfW);

            aoState.mSpecularPath &= 0;
        }

        aoState.mOrigin  = aHitPoint;
        aoState.mThroughput *= bsdfFactor * (cosThetaOut / bsdfDirPdfW);
        
        return true;
    }

private:

    bool  mUseVM;             // Vertex merging (of some form) is used
    bool  mUseVC;             // Vertex connection (BPT) is used
    bool  mLightTraceOnly;    // Do only light tracing
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
