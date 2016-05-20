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

    Vec3f org;  // ������
    Vec3f dir;  // �����������
    float tmin; // ���������� �� ���������� �����������
};

struct Isect
{
    Isect()
    {}

    Isect(float aMaxDist):dist(aMaxDist)
    {}

    float dist;    // ���������� �� ���������� �����������
    int   matID;   // ID ��������� ������������� ��������
    int   lightID; // ID ������������� ��������� ����� (���� < 0, �� ����������)
    Vec3f normal;  // ������� � �����������
};

#endif //__RAY_HXX__
