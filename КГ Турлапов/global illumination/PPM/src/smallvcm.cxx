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
#include "bsdf.hxx"
#include "vertexcm.hxx"
#include "config.hxx"

#include <omp.h>
#include <string>
#include <set>
#include <sstream>

//////////////////////////////////////////////////////////////////////////
// The main rendering function, renders what is in aConfig

float render(
    const Config &aConfig,
    int *oUsedIterations = NULL)
{
    // Set number of used threads
    omp_set_num_threads(aConfig.mNumThreads);

    // Create 1 renderer per thread
    typedef AbstractRenderer* AbstractRendererPtr;
    AbstractRendererPtr *renderers;
    renderers = new AbstractRendererPtr[aConfig.mNumThreads];
	//////////////////////////////////////////////////////////////////////////////////
    for(int i=0; i<aConfig.mNumThreads; i++)
    {
        renderers[i] = CreateRenderer(aConfig, aConfig.mBaseSeed + i);

        renderers[i]->mMaxPathLength = aConfig.mMaxPathLength;
        renderers[i]->mMinPathLength = aConfig.mMinPathLength;
    }

    clock_t startT = clock();
    int iter = 0;
    // Iterations based loop
#pragma omp parallel for
    for(iter=0; iter < aConfig.mIterations; iter++)
    {
		// Кидаем фотоны, строим карту, собираем в "картинку", сливаем в общую "картинку"
        int threadId = omp_get_thread_num();
		renderers[threadId]->RunIteration(iter, aConfig.mPhotonNumber);
		printf("+%i ", iter);
    }

    clock_t endT = clock();

    if(oUsedIterations)
        *oUsedIterations = iter+1;

    // Accumulate from all renderers into a common framebuffer
    int usedRenderers = 0;

    // With very low number of iterations and high number of threads
    // not all created renderers had to have been used.
    // Those must not participate in accumulation.
    for(int i=0; i<aConfig.mNumThreads; i++)
    {
        if(!renderers[i]->WasUsed())
            continue;

        if(usedRenderers == 0)
        {
            renderers[i]->GetFramebuffer(*aConfig.mFramebuffer);
        }
        else
        {
            Framebuffer tmp;
            renderers[i]->GetFramebuffer(tmp);
            aConfig.mFramebuffer->Add(tmp);
        }

        usedRenderers++;
    }

    // Scale framebuffer by the number of used renderers
    aConfig.mFramebuffer->Scale(1.f / usedRenderers);

    // Clean up renderers
    for(int i=0; i<aConfig.mNumThreads; i++)
        delete renderers[i];

    delete [] renderers;

    return float(endT - startT) / CLOCKS_PER_SEC;
}

//////////////////////////////////////////////////////////////////////////
// Main

int main(int argc, const char *argv[])
{
    // Setups config based on command line
    Config config;
    ParseCommandline(argc, argv, config);

    // Sets up framebuffer and number of threads
    Framebuffer fbuffer;
    config.mFramebuffer = &fbuffer;

    // Prints what we are doing
    printf("Target:  %d iteration(s)\n", config.mIterations);

    // Renders the image
    printf("Running: PPM... ");//, config.GetName(config.mAlgorithm));
    fflush(stdout);
    float time = render(config);
    printf("done in %.2f s\n", time);

    // Saves the image
    std::string extension = config.mOutputName.substr(config.mOutputName.length() - 3, 3);
    fbuffer.SaveBMP(config.mOutputName.c_str(), 2.2f /*gamma*/);
    
	// Scene cleanup
    delete config.mScene;

    return 0;
}
