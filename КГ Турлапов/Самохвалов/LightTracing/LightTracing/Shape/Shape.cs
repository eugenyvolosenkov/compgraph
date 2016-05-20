using System;
using System.Drawing;

namespace LightTracing
{
    public abstract class Shape
    {
        public Material Material;
        public Color Color;

        public const float Eps = 0.0000000001f;

        public abstract bool Intersect(ref Ray ray);
        public abstract Vector GetNormalAtPoint(Vector p);
    }
}
