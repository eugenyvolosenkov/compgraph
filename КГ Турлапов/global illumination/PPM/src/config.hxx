#ifndef __CONFIG_HXX__
#define __CONFIG_HXX__

#include <vector>
#include <cmath>
#include <time.h>
#include <cstdlib>
#include "math.hxx"
#include "ray.hxx"
#include "geometry.hxx"
#include "camera.hxx"
#include "framebuffer.hxx"
#include "scene.hxx"
//#include "eyelight.hxx"
//#include "pathtracer.hxx"
#include "bsdf.hxx"
#include "vertexcm.hxx"
//#include "html_writer.hxx"

#include <omp.h>
#include <string>
#include <set>
#include <sstream>

// Renderer configuration, holds algorithm, scene, and all other settings
struct Config
{
    enum Algorithm
    {
        kProgressivePhotonMapping
    };

    const Scene *mScene;
    Algorithm   mAlgorithm;
    int         mIterations;
    float       mRadiusFactor;
    float       mRadiusAlpha;
    Framebuffer *mFramebuffer;
    int         mNumThreads;
    int         mBaseSeed;
    uint        mMaxPathLength;
    uint        mMinPathLength;
    std::string mOutputName;
    Vec2i       mResolution;
	Vec3f		mLightIntensity;
	int			mPhotonNumber;
};

// Utility function, essentially a renderer factory
AbstractRenderer* CreateRenderer(const Config& aConfig, const int     aSeed)
{
    const Scene& scene = *aConfig.mScene;
	return new VertexCM(scene, VertexCM::kPpm, aConfig.mRadiusFactor, aConfig.mRadiusAlpha, aSeed);
}

// Utility function, gives length of array
template <typename T, size_t N>
inline int SizeOfArray( const T(&)[ N ] )
{
    return int(N);
}

// Parses command line, setting up config
void ParseCommandline(int argc, const char *argv[], Config &oConfig)
{
    oConfig.mScene			= NULL;                  // When NULL, renderer will not run
	oConfig.mAlgorithm		= Config::kProgressivePhotonMapping;
    oConfig.mIterations		= 4;
    //oConfig.mOutputName		= "result.bmp";
    oConfig.mNumThreads		= 1;
    oConfig.mBaseSeed		= 7765;
    oConfig.mMaxPathLength	= 10;
    oConfig.mMinPathLength	= 0;
    oConfig.mResolution		= Vec2i(256, 256);//Vec2i(512, 512);
    oConfig.mRadiusFactor	= 0.023f;
    oConfig.mRadiusAlpha	= 0.75f;
	oConfig.mLightIntensity	= 25.0f;
	oConfig.mPhotonNumber	= oConfig.mResolution.x * oConfig.mResolution.y;

	char filename[30]; 
	sprintf(filename, "res_%i/result%03i.bmp", oConfig.mResolution.x, oConfig.mIterations); 
	oConfig.mOutputName		= std::string(filename);

    // Load scene
	//uint CurrentScene = Scene::kGlossyFloor | Scene::kBothSmallSpheres | Scene::kLightCeiling;
	uint CurrentScene = Scene::kGlossyFloor /*| Scene::k3Spheres*/ | Scene::kLightCeiling;
	//uint CurrentScene = Scene::kGlossyFloor | Scene::kBothSmallSphereTetrahedron | Scene::kLightCeiling;
    Scene *scene = new Scene;
    scene->LoadCornellBox(oConfig.mResolution, CurrentScene);
    scene->BuildSceneSphere();

    oConfig.mScene = scene;
}

#endif  //__CONFIG_HXX__
