#ifndef __SCENE_HXX__
#define __SCENE_HXX__

#include <vector>
#include <map>
#include <cmath>
#include "math.hxx"
#include "geometry.hxx"
#include "camera.hxx"
#include "materials.hxx"
#include "lights.hxx"

class Scene
{
public:
    Scene() : mGeometry(NULL) {}

    ~Scene()
    {
        delete mGeometry;

        for(size_t i=0; i<mLights.size(); i++)
            delete mLights[i];
    }

    bool Intersect(
        const Ray &aRay,
        Isect     &oResult) const
    {
        bool hit = mGeometry->Intersect(aRay, oResult);

        if(hit)
        {
            oResult.lightID = -1;
            std::map<int, int>::const_iterator it =
                mMaterial2Light.find(oResult.matID);

            if(it != mMaterial2Light.end())
                oResult.lightID = it->second;
        }

        return hit;
    }

    bool Occluded(
        const Vec3f &aPoint,
        const Vec3f &aDir,
        float aTMax) const
    {
        Ray ray;
        ray.org  = aPoint + aDir * EPS_RAY;
        ray.dir  = aDir;
        ray.tmin = 0;
        Isect isect;
        isect.dist = aTMax - 2*EPS_RAY;

        return mGeometry->IntersectP(ray, isect);
    }

    const Material& GetMaterial(const int aMaterialIdx) const
    {
        return mMaterials[aMaterialIdx];
    }

    int GetMaterialCount() const
    {
        return (int)mMaterials.size();
    }

	// 2 источника света - 2 треугольника
    const AbstractLight* GetLightPtr(int aLightIdx) const
    {
        aLightIdx = std::min<int>(aLightIdx, mLights.size()-1);
        return mLights[aLightIdx];
    }

    int GetLightCount() const
    {
        return (int)mLights.size();
    }

    //////////////////////////////////////////////////////////////////////////
    // Loads a Cornell Box scene
    enum BoxMask
    {
        kLightCeiling      = 1,
        //kLightSun          = 2,
        //kLightPoint        = 4,
        //kLightBackground   = 8,
        kSmallDiffuseSphere = 16,
        kSmallGlassTetrahedron  = 32,
        kSmallMirrorSphere = 64,
        kSmallGlassSphere  = 128,
        kGlossyFloor       = 256,
        kBothSmallSpheres  = (kSmallMirrorSphere | kSmallGlassSphere),
		kBothSmallSphereTetrahedron = (kSmallMirrorSphere | kSmallGlassTetrahedron), 
		k3Spheres = (kSmallMirrorSphere | kSmallGlassSphere | kSmallDiffuseSphere),
        kDefault           = (kLightCeiling | kBothSmallSpheres),
    };

    void LoadCornellBox(
        const Vec2i &aResolution,
        uint aBoxMask = kDefault)
    {
        bool light_ceiling    = (aBoxMask & kLightCeiling)    != 0;

        bool light_box = true;

        // because it looks really weird with it
        //if(light_point)            light_box = false;

        // Camera
        mCamera.Setup(
            Vec3f(-0.f, -4.32f, 0.f),				// -0.0439815f, -4.12529f, 0.222539f
            Vec3f(0.f, 1.f, 0.f),
            Vec3f(0.f, 0.f, 1.f),
            Vec2f(float(aResolution.x), float(aResolution.y)), 45);

        // Materials
        Material mat;
        // 0) light1 - треугольник, will only emit
        mMaterials.push_back(mat);
        // 1) light2 тоже, will only emit
        mMaterials.push_back(mat);

        // 2) glossy white floor
        mat.Reset();
        mat.mDiffuseReflectance = Vec3f(0.1f);
        mat.mPhongReflectance   = Vec3f(0.7f);
        mat.mPhongExponent         = 90.f;
        mMaterials.push_back(mat);

        // 3) Полузеркальная левая зелёная стена
        mat.Reset();
        //mat.mDiffuseReflectance = Vec3f(0.156863f, 0.803922f, 0.172549f);
		mat.mMirrorReflectance = Vec3f(0.0f, 0.5f, 0.0f);
        mMaterials.push_back(mat);

        // 4) Полузеркальная правая красная стена
        mat.Reset();
        //mat.mDiffuseReflectance = Vec3f(0.803922f, 0.152941f, 0.152941f);
		mat.mMirrorReflectance = Vec3f(0.5f, 0.0f, 0.0f);
        mMaterials.push_back(mat);

        // 5) diffuse white back wall
        mat.Reset();
        mat.mDiffuseReflectance = Vec3f(0.803922f, 0.803922f, 0.803922f);
        mMaterials.push_back(mat);

        // 6) mirror ball
        mat.Reset();
        mat.mMirrorReflectance = Vec3f(1.f);
        mMaterials.push_back(mat);

        // 7) glass ball
        mat.Reset();
        mat.mMirrorReflectance  = Vec3f(0.5f, 0.5f, 0.f);
        mat.mIOR                = 1.6f;
        mMaterials.push_back(mat);

        // 8) diffuse blue wall (back wall for glossy floor)
        mat.Reset();
        mat.mDiffuseReflectance = Vec3f(0.156863f, 0.172549f, 0.803922f);
        mMaterials.push_back(mat);

		// 9) glass tetrahedron
		mat.Reset();
        mat.mMirrorReflectance  = Vec3f(1.f);
        mat.mIOR                = 1.6f;//1.6f;
        mMaterials.push_back(mat);

		// 10) diffuse white floor wall
        mat.Reset();
        mat.mDiffuseReflectance = Vec3f(204.f/255.f, 204.f/255.f, 204.f/255.f);
        mMaterials.push_back(mat);
		// 11) diffuse white floor wall
        mat.Reset();
        mat.mDiffuseReflectance = Vec3f(102.f/255.f, 102.f/255.f, 102.f/255.f);
        mMaterials.push_back(mat);

		// 12) diffuse blue wall (back wall for glossy floor)
        mat.Reset();
        mat.mDiffuseReflectance = Vec3f(1.f, 1.f, 1.f);
        mMaterials.push_back(mat);

        delete mGeometry;

        //////////////////////////////////////////////////////////////////////////
        // Cornell box
        Vec3f cb[8] = {
            Vec3f(-1.28f,  1.28f, -1.28f),
            Vec3f( 1.28f,  1.28f, -1.28f),
            Vec3f( 1.28f,  1.28f,  1.28f),
            Vec3f(-1.28f,  1.28f,  1.28f),
			/*
            Vec3f(-1.28f, -4.33f, -1.28f),
            Vec3f( 1.28f, -4.33f, -1.28f),
            Vec3f( 1.28f, -4.33f,  1.28f),
            Vec3f(-1.28f, -4.33f,  1.28f),
			*/
            Vec3f(-1.28f, -1.28f, -1.28f),
            Vec3f( 1.28f, -1.28f, -1.28f),
            Vec3f( 1.28f, -1.28f,  1.28f),
            Vec3f(-1.28f, -1.28f,  1.28f)
			
        };

        GeometryList *geometryList = new GeometryList;
        mGeometry = geometryList;
		/*
        if((aBoxMask & kGlossyFloor) != 0)
        {
            // Floor
            geometryList->mGeometry.push_back(new Triangle(cb[0], cb[4], cb[5], 2));
            geometryList->mGeometry.push_back(new Triangle(cb[5], cb[1], cb[0], 2));
            // Back wall
            geometryList->mGeometry.push_back(new Triangle(cb[0], cb[1], cb[2], 8));
            geometryList->mGeometry.push_back(new Triangle(cb[2], cb[3], cb[0], 8));
        }
        else*/
        {
            // Floor
			Vec3f fl0 = (cb[0]+cb[1])/2.f;
			Vec3f fl1 = (cb[0]+cb[4])/2.f;
			Vec3f fl2 = (cb[1]+cb[5])/2.f;
			Vec3f fl3 = (cb[4]+cb[5])/2.f;
			float stepX = (cb[1].x - cb[0].x)/8.f;
			float stepY = (cb[0].y - cb[4].y)/8.f;
            /*geometryList->mGeometry.push_back(new Triangle(cb[0], fl1, fl0, 10));
            geometryList->mGeometry.push_back(new Triangle(fl0, fl1, cb[1], 11));
            geometryList->mGeometry.push_back(new Triangle(fl1, cb[4], cb[1], 10));
            geometryList->mGeometry.push_back(new Triangle(cb[1], cb[4], fl2, 11));
            geometryList->mGeometry.push_back(new Triangle(fl2, cb[4], fl3, 10));
            geometryList->mGeometry.push_back(new Triangle(fl2, fl3, cb[5], 11));*/
			for (int i = 0; i < 8; i++) { 
				for (int j = 0; j < 8; j++) {
					if ((i+j) % 2 == 0) {
						geometryList->mGeometry.push_back(new Triangle(Vec3f(cb[0].x+j*stepX, cb[0].y - i*stepY, cb[0].z), Vec3f(cb[0].x+j*stepX, cb[0].y - (i+1)*stepY, cb[0].z), Vec3f(cb[0].x+(j+1)*stepX, cb[0].y - (i+1)*stepY, cb[0].z), 10));
						geometryList->mGeometry.push_back(new Triangle(Vec3f(cb[0].x+(j+1)*stepX, cb[0].y - (i+1)*stepY, cb[0].z), Vec3f(cb[0].x+(j+1)*stepX, cb[0].y - i*stepY, cb[0].z), Vec3f(cb[0].x+j*stepX, cb[0].y - i*stepY, cb[0].z), 10));
					}
				}
			}
			geometryList->mGeometry.push_back(new Triangle(cb[0], cb[4], cb[5], 11));
            geometryList->mGeometry.push_back(new Triangle(cb[5], cb[1], cb[0], 11));
            // Back wall
            geometryList->mGeometry.push_back(new Triangle(cb[0], cb[1], cb[2], 8));
            geometryList->mGeometry.push_back(new Triangle(cb[2], cb[3], cb[0], 8));	//5
        }


        // Потолок
        if(light_ceiling && !light_box)
        {
            geometryList->mGeometry.push_back(new Triangle(cb[2], cb[6], cb[7], 0));
            geometryList->mGeometry.push_back(new Triangle(cb[7], cb[3], cb[2], 1));
        }
        else
        {
            geometryList->mGeometry.push_back(new Triangle(cb[2], cb[6], cb[7], 5));
            geometryList->mGeometry.push_back(new Triangle(cb[7], cb[3], cb[2], 5));
        }

        // Left wall
        geometryList->mGeometry.push_back(new Triangle(cb[3], cb[7], cb[4], 3));
        geometryList->mGeometry.push_back(new Triangle(cb[4], cb[0], cb[3], 3));

        // Right wall
        geometryList->mGeometry.push_back(new Triangle(cb[1], cb[5], cb[6], 4));
        geometryList->mGeometry.push_back(new Triangle(cb[6], cb[2], cb[1], 4));

        // Ball - central
        float largeRadius = 0.8f;	//0.8f
        Vec3f center = (cb[0] + cb[1] + cb[4] + cb[5]) * (1.f / 4.f) + Vec3f(0, 0, largeRadius);
		//largeRadius = 0.5f;
		/*
        if((aBoxMask & kLargeMirrorSphere) != 0)
            geometryList->mGeometry.push_back(new Sphere(center, largeRadius, 6));

        if((aBoxMask & kLargeGlassSphere) != 0)
            geometryList->mGeometry.push_back(new Sphere(center, largeRadius, 7));
			*/
        // Balls - left and right
        float smallRadius = 0.5f;
        Vec3f leftWallCenter  = (cb[0] + cb[4]) * (1.f / 2.f) + Vec3f(0, 0, smallRadius);
        Vec3f rightWallCenter = (cb[1] + cb[5]) * (1.f / 2.f) + Vec3f(0, 0, smallRadius);
        float xlen = rightWallCenter.x - leftWallCenter.x;
        Vec3f leftBallCenter  = leftWallCenter  + Vec3f(2.f * xlen / 7.f, 0.25f, smallRadius/2);
        //Vec3f leftBallCenter  = leftWallCenter*0.5f+rightWallCenter*0.5f + Vec3f(0.f, 0.f, 0.5);
        Vec3f rightBallCenter = rightWallCenter + Vec3f(-2.f * xlen / 7.f, 0.25f, smallRadius/2);
        Vec3f rightBallCenter1  = rightBallCenter + Vec3f(0.3f, -1.f, -smallRadius);

        //if((aBoxMask & kSmallMirrorSphere) != 0)
            geometryList->mGeometry.push_back(new Sphere(leftBallCenter,  smallRadius, 6));

        //if((aBoxMask & kSmallGlassSphere) != 0)
            geometryList->mGeometry.push_back(new Sphere(rightBallCenter, smallRadius, 7));

		//if ((aBoxMask & kSmallDiffuseSphere) !=0) {
			// ДОП СФЕРА
			geometryList->mGeometry.push_back(new Sphere(rightBallCenter1,  smallRadius/2, 12));
		//}

		//if ((aBoxMask & kSmallGlassTetrahedron) != 0)
		{
			// ДОП ТЕТРАЭДР
			/*
			Vec3f tetCenter = leftBallCenter + Vec3f(0.f, -0.7f, -smallRadius);

			Vec3f tet0 = tetCenter - Vec3f(smallRadius, 0, 0);
			Vec3f tet1 = tetCenter + Vec3f(smallRadius, 0, 0);
			Vec3f tet2 = tetCenter - Vec3f(0, smallRadius, 0);
			Vec3f tet3 = tetCenter + Vec3f(0, 0, smallRadius);
			geometryList->mGeometry.push_back(new Triangle(tet0, tet1, tet2, 9));
			geometryList->mGeometry.push_back(new Triangle(tet3, tet1, tet0, 9));
			geometryList->mGeometry.push_back(new Triangle(tet2, tet3, tet0, 9));
			geometryList->mGeometry.push_back(new Triangle(tet2, tet1, tet3, 9));
			*/
		}

        //////////////////////////////////////////////////////////////////////////
        // Light box at the ceiling
        Vec3f lb[8] = {
            Vec3f(-0.25f,  0.25f, 1.26002f),
            Vec3f( 0.25f,  0.25f, 1.26002f),
            Vec3f( 0.25f,  0.25f, 1.28002f),
            Vec3f(-0.25f,  0.25f, 1.28002f),
            Vec3f(-0.25f, -0.25f, 1.26002f),
            Vec3f( 0.25f, -0.25f, 1.26002f),
            Vec3f( 0.25f, -0.25f, 1.28002f),
            Vec3f(-0.25f, -0.25f, 1.28002f)
        };

        if(light_box)
        {/*
            // Back wall
            geometryList->mGeometry.push_back(new Triangle(lb[0], lb[2], lb[1], 5));
            geometryList->mGeometry.push_back(new Triangle(lb[2], lb[0], lb[3], 5));
            // Left wall
            geometryList->mGeometry.push_back(new Triangle(lb[3], lb[4], lb[7], 5));
            geometryList->mGeometry.push_back(new Triangle(lb[4], lb[3], lb[0], 5));
            // Right wall
            geometryList->mGeometry.push_back(new Triangle(lb[1], lb[6], lb[5], 5));
            geometryList->mGeometry.push_back(new Triangle(lb[6], lb[1], lb[2], 5));
            // Front wall
            geometryList->mGeometry.push_back(new Triangle(lb[4], lb[5], lb[6], 5));
            geometryList->mGeometry.push_back(new Triangle(lb[6], lb[7], lb[4], 5));
			*/
            if(light_ceiling)
            {
                // Floor
                geometryList->mGeometry.push_back(new Triangle(lb[0], lb[5], lb[4], 0));
                geometryList->mGeometry.push_back(new Triangle(lb[5], lb[0], lb[1], 1));
            }
            else
            {
                // Floor
                geometryList->mGeometry.push_back(new Triangle(lb[0], lb[5], lb[4], 5));
                geometryList->mGeometry.push_back(new Triangle(lb[5], lb[0], lb[1], 5));
            }
        }

        //////////////////////////////////////////////////////////////////////////
        // Lights
        if(light_ceiling && !light_box)
        {
            // Without light box, whole ceiling is light
            mLights.resize(2);
            AreaLight *l = new AreaLight(cb[2], cb[6], cb[7]);
            l->mIntensity = Vec3f(0.95492965f);
            mLights[0] = l;
            mMaterial2Light.insert(std::make_pair(0, 0));
			/*
            l = new AreaLight(cb[7], cb[3], cb[2]);
            l->mIntensity = Vec3f(0.95492965f);
            mLights[1] = l;
            mMaterial2Light.insert(std::make_pair(1, 1));
			*/
        }
        else if(light_ceiling && light_box)
        {
            // With light box
            mLights.resize(2);
            AreaLight *l = new AreaLight(lb[0], lb[5], lb[4]);
            //l->mIntensity = Vec3f(0.95492965f);
            l->mIntensity = Vec3f(50.03329895614464f); //25
            mLights[0] = l;
            mMaterial2Light.insert(std::make_pair(0, 0));

            l = new AreaLight(lb[5], lb[0], lb[1]);
            //l->mIntensity = Vec3f(0.95492965f);
            l->mIntensity = Vec3f(50.03329895614464f);	// 25
            mLights[1] = l;
            mMaterial2Light.insert(std::make_pair(1, 1));
        }
    }

    void BuildSceneSphere()
    {
        Vec3f bboxMin( 1e36f);
        Vec3f bboxMax(-1e36f);
        mGeometry->GrowBBox(bboxMin, bboxMax);

        const float radius2 = (bboxMax - bboxMin).LenSqr();

        mSceneSphere.mSceneCenter = (bboxMax + bboxMin) * 0.5f;
        mSceneSphere.mSceneRadius = std::sqrt(radius2) * 0.5f;
        mSceneSphere.mInvSceneRadiusSqr = 1.f / Sqr(mSceneSphere.mSceneRadius);
    }

public:
    AbstractGeometry*			mGeometry;			// Фигуры
    Camera						mCamera;			// Камера
    std::vector<Material>		mMaterials;			// Вектор материалов
    std::vector<AbstractLight*>	mLights;			// Вектор источников света
    std::map<int, int>			mMaterial2Light;	// по номеру материала находим номер источника
    SceneSphere					mSceneSphere;		// 
    //BackgroundLight*			mBackground;
};

#endif //__SCENE_HXX__
