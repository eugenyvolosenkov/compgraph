using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LightTracing
{
    public class Ray
    {
        public Vector Origin;
        public Vector Direction;

        public float LastHitDistance;
        public float ClosestHitDistance;

        public Shape ClosestHitObject;
        public Vector HitPoint;

        public Ray(Vector o, Vector d)
        {
            Origin = o;
            Direction = d;

            LastHitDistance = float.MaxValue;
            ClosestHitDistance = float.MaxValue;
            
            ClosestHitObject = null;
            HitPoint = null;
        }
    }
}