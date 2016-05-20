using System;
using System.Drawing;

namespace LightTracing
{
    public class Sphere : Shape
    {
        public Vector Position;
        public float Radius;

        public Sphere(Vector p, float r, Material m, Color c)
        {
            Position = p;
            Radius = r;
            Material = m;
            Color = c;
        }

        public override bool Intersect(ref Ray ray)
        {
            /*
             * Shere: (P-C).(P-C) - r^2 = 0
             * P(t) = O + t*D;
             * P - point on sphere
             * C - center of sphere
             * O - ray origin
             * D - ray direction
             * 
             * t^2 * (D.D) + 2 * D.(O-C) + (O-C).(O-C) - r^2 = 0
             * t = D.(C-O) +/- sqrt( (D.(C-O)^2 - (C-O).(C-O) + r^2 )
             */

            var dirToSphere = Position - ray.Origin; // C-O

            var v = Vector.Dot(dirToSphere, ray.Direction); // D.(C-O)

            var hitDistance = v * v - Vector.Dot(dirToSphere, dirToSphere) + Radius * Radius; // discriminant

            if (hitDistance < 0.0f) // no hit
                return false;

            hitDistance = (float)Math.Sqrt(hitDistance);

            var hD0 = v - hitDistance;
            var hD1 = v + hitDistance;

            if (hD0 > Eps)
                hitDistance = hD0;
            else if (hD1 > Eps)
                hitDistance = hD1;
            else
                hitDistance = 0.0f;

            ray.LastHitDistance = hitDistance;

            return true;
        }

        public override Vector GetNormalAtPoint(Vector p)
        {
            var normal = p - Position;
            normal.Normalize();

            return normal;
        }
    }
}