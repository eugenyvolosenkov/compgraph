using System;
using System.Drawing;

namespace LightTracing
{
    public class Rectangle : Shape
    {
        public Triangle T0;
        public Triangle T1;
        public Vector Normal;
        public Vector Maximum;
        public Vector Minimum;
        public float Translation;

        /* 
         * v0---v1
         * |   / |
         * |  /  |
         * | /   |
         * v2---v3
         */

        public Rectangle(Vector v0, Vector v1, Vector v2, Vector v3, Vector n, Material m, Color c, bool isFloor = false)
        {
            T0 = new Triangle(v0, v1, v2, n, m, c);
            T1 = new Triangle(v3, v2, v1, n, m, c);

            var tNorm = Vector.Cross(v1 - v0, v2 - v0);
            if (tNorm.X * n.X < 0.0f || tNorm.Y * n.Y < 0.0f || tNorm.Z * n.Z < 0.0f)
            {
                T0.V1 = v2;
                T0.V2 = v1;
            }

            tNorm = Vector.Cross(v2 - v3, v1 - v3);
            if (tNorm.X * n.X < 0.0f || tNorm.Y * n.Y < 0.0f || tNorm.Z * n.Z < 0.0f)
            {
                T1.V1 = v1;
                T1.V2 = v2;
            }

            Normal = n;
            Material = m;
            Color = c;
        }

        public override bool Intersect(ref Ray ray)
        {
            return T0.Intersect(ref ray) || T1.Intersect(ref ray);
        }

        public override Vector GetNormalAtPoint(Vector p)
        {
            return Normal;
        }
    }
}