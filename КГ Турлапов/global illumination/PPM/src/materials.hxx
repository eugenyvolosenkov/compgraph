#ifndef __MATERIALS_HXX__
#define __MATERIALS_HXX__

#include <vector>
#include <cmath>
#include "math.hxx"
#include "frame.hxx"
#include "ray.hxx"
#include "scene.hxx"
#include "utils.hxx"

class Material
{
public:
    Material()
    {
        Reset();
    }

    void Reset()
    {
        mDiffuseReflectance = Vec3f(0);
        mPhongReflectance   = Vec3f(0);
        mPhongExponent      = 1.f;
        mMirrorReflectance  = Vec3f(0);
        mIOR = -1.f;
    }

    // diffuse is simply added to the others
    Vec3f mDiffuseReflectance;
    // Phong is simply added to the others
    Vec3f mPhongReflectance;
    float mPhongExponent;

    // mirror can be either simply added, or mixed using Fresnel term
    // this is governed by mIOR, if it is >= 0, fresnel is used, otherwise
    // it is not
	// Зеркальное отражение
    Vec3f mMirrorReflectance;

    // When mIOR >= 0, we also transmit (just clear glass)
	// Преломляемся
    float mIOR;
};

#endif //__MATERIALS_HXX__
