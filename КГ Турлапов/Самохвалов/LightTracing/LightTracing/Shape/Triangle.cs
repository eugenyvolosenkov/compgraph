using System;
using System.Drawing;

namespace LightTracing
{
    public class Triangle : Shape
    {
        public Vector V0 = new Vector();
        public Vector V1 = new Vector();
        public Vector V2 = new Vector();
        public Vector Normal;

        public Triangle(Vector v0, Vector v1, Vector v2, Vector n, Material m, Color c)
        {
            this.V0 = v0;
            this.V1 = v1;
            this.V2 = v2;
            Normal = n;
            Material = m;
            Color = c;
        }

        public override bool Intersect(ref Ray ray)
        {
            Vector u, v, n;
            Vector w0, w;
            float r, a, b;

            u = V1 - V0;
            v = V2 - V0;
            n = Vector.Cross(u, v);

            w0 = ray.Origin - V0;

            a = -Vector.Dot(n, w0);
            b = Vector.Dot(n, ray.Direction);
            
            if (Math.Abs(b) < Eps)
                return false;

            r = a / b;

            if (r < 0.0f)
                return false;

            var p = ray.Origin + (ray.Direction * r);

            float uu, uv, vv, wu, wv, D;
            uu = Vector.Dot(u, u);
            uv = Vector.Dot(u, v);
            vv = Vector.Dot(v, v);
            
            w = p - V0;
            wu = Vector.Dot(w, u);
            wv = Vector.Dot(w, v);
            D = uv * uv - uu * vv;

            float s, t;
            s = (uv * wv - vv * wu) / D;
            if (s < 0.0f || s > 1.0f)
                return false;
            t = (uv * wu - uu * wv) / D;
            if (t < 0.0f || (s + t) > 1.0f)
                return false;

            ray.LastHitDistance = (p - ray.Origin).Length();

            return true;
        }

        public bool Intersect2(ref Ray ray)
        {
            var ao = V0 - ray.Origin;
            var bo = V1 - ray.Origin;
            var co = V2 - ray.Origin;

             var v00 = Vector.Cross(co, bo);
             var v10 = Vector.Cross(bo, ao);
             var v20 = Vector.Cross(ao, co);

             var v0d = Vector.Dot(v00, ray.Direction);
             var v1d = Vector.Dot(v10, ray.Direction);
             var v2d = Vector.Dot(v20, ray.Direction);

            if (((v0d < 0.0f) && (v1d < 0.0f) && (v2d < 0.0f)) ||
               ((v0d >= 0.0f) && (v1d >= 0.0f) && (v2d >= 0.0f)))
            {
                float distance = Vector.Dot(Normal, ao) / Vector.Dot(Normal, ray.Direction);

                /*if (ray.LastHitDistance < ray.ClosestHitDistance && ray.LastHitDistance > 0)
                {
                    ray.ClosestHitObject = this;
                    ray.ClosestHitDistance = distance;

                    return true;
                }*/

                if ((ray.LastHitDistance < distance) && (distance < ray.ClosestHitDistance))
                {
                    //ray.ClosestHitObject. = mNormal;
                    
                        ray.ClosestHitObject = this;
                        ray.ClosestHitDistance = distance;  
                    
                    return true;
                }
            }

            return false;
        }

        public override Vector GetNormalAtPoint(Vector p)
        {
            //return normal;
            var vect = Vector.Cross(V1 - V0, V2 - V0);
            vect.Normalize();
            return vect;
        }
    }
}