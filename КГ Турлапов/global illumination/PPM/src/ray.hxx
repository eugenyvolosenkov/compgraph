#ifndef __RAY_HXX__
#define __RAY_HXX__

#include <vector>
#include <cmath>
#include "math.hxx"

//////////////////////////////////////////////////////////////////////////
// Ray casting
struct Ray
{
    Ray()
    {}

    Ray(const Vec3f& aOrg,
        const Vec3f& aDir,
        float aTMin
    ) :
        org(aOrg),
        dir(aDir),
        tmin(aTMin)
    {}

    Vec3f org;  // Начало
    Vec3f dir;  // Направление
    float tmin; // Расстояние до ближайшего пересечения
};

struct Isect
{
    Isect()
    {}

    Isect(float aMaxDist):dist(aMaxDist)
    {}

    float dist;    // Расстояние до ближайшего пересечения
    int   matID;   // ID материала пересекаемого предмета
    int   lightID; // ID пересекаемого источника света (если < 0, не пересекаем)
    Vec3f normal;  // Нормаль в пересечении
};

#endif //__RAY_HXX__
