using System;
using System.Drawing;

namespace LightTracing
{
    public class Material
    {
        public enum MaterialType { Diffuse, Specular, Transparent };

        public MaterialType Type;

        public const float Kabsorption = 0.8f; //0.8
        public const float Krefraction = 1.5f; //1.5

        public Material(MaterialType t)
        {
            Type = t;
        }

        public static Ray Sample(MaterialType t, Ray inRay, Vector n)
        {
            if (t == MaterialType.Diffuse)
            {
                var rand = new Random(DateTime.Now.Millisecond);

                //var Rnd = new Random();
                //var dd = (float)Rnd.NextDouble();

                var r1 = (float)rand.NextDouble();
                var r2 = (float)rand.NextDouble();

               // float r1 = (float)(rand.NextDouble() * Math.PI * 2.0f);
                //float r2 = (float)(rand.NextDouble() * Math.PI * 2.0f);
                //float r2s = (float)Math.Sqrt(r2);

                var vect = MapSampleToCosineDistribution(r1, r2);

                if (Vector.Dot(n, inRay.Direction) >= 0.0f)
                    n = n * (-1.0f);

                var u = new Vector(1.0f, 0.0f, 0.0f);
                if (Math.Abs(n.X) > 0.1f)
                {
                    u.X = 0.0f;
                    u.Y = 1.0f;
                }
                u = Vector.Cross(u, n);
                u.Normalize();
                //Vector v = Vector.Cross(n, u);

                vect.Normalize();

                return new Ray(inRay.HitPoint, vect);
            }
            else if (t == MaterialType.Specular)
            {
                var reflDir = inRay.Direction - n * 2.0f * Vector.Dot(n, inRay.Direction);
                reflDir.Normalize();

                return new Ray(inRay.HitPoint, reflDir);
            }
            else if (t == MaterialType.Transparent)
            {
                /*
                 * |v1| = n1, |v2| = n2
                 * v2 = v1 + (sqrt(q / v^2 + 1) - 1) * (v) * norm
                 * q = n2 ^ 2 - n1 ^ 2
                 * v = v1.norm
                 * */

                var v = Vector.Dot(inRay.Direction, n);
                float q;

                if (v < 0.0f) // from air into glass
                {
                    q = Krefraction * Krefraction - 1.0f * 1.0f;
                    v *= 1.0f;
                }
                else
                {
                    q = 1.0f * 1.0f - Krefraction * Krefraction;
                    v *= Krefraction;
                }

                var vv = v * v;
                var refrDir = inRay.Direction + n * (float)((Math.Sqrt(q / vv + 1) - 1) * v);

                return new Ray(inRay.HitPoint, refrDir);
            }
            else
                return null;
        }

        public Vector Sample3(MaterialType type, Ray inRay, Vector normal, Color oldColor, ref Color newColor)
        {
            Vector input;
            var ls = new LocalSpace(normal);

            switch (type)
            {
                case MaterialType.Diffuse:
                {
                    var rand = new Random(DateTime.Now.Millisecond);

                    var r1 = (float)rand.NextDouble();
                    var r2 = (float)rand.NextDouble();

                    /*var vect = MapSampleToCosineDistribution(r1, r2);

                    if (Vector.Dot(normal, inRay.Direction) >= 0.0f)
                        normal = normal * (-1.0f);

                    var u = new Vector(1.0f, 0.0f, 0.0f);
                    if (Math.Abs(normal.X) > 0.1f)
                    {
                        u.X = 0.0f;
                        u.Y = 1.0f;
                    }
                    u = Vector.Cross(u, normal);
                    u.Normalize();

                    vect.Normalize();

                    return vect;*/

                    input = ls.from(MapSampleToCosineDistribution(r1, r2));
                    newColor = Color.FromArgb(oldColor.A,
                        Convert.ToInt32(oldColor.R * Kd.X),
                        Convert.ToInt32(oldColor.G * Kd.Y),
                        Convert.ToInt32(oldColor.B * Kd.Z));
                    return input;
                }
                case MaterialType.Specular:
                {
                    input = Vector.Reflect(inRay.Direction, normal);
                    input.Normalize();

                    newColor = Color.FromArgb(oldColor.A,
                        Convert.ToInt32(oldColor.R * Ks.X),
                        Convert.ToInt32(oldColor.G * Ks.Y),
                        Convert.ToInt32(oldColor.B * Ks.Z));

                    return input;

                    /*var reflDir = inRay.Direction - normal * 2.0f * Vector.Dot(normal, inRay.Direction);
                    reflDir.Normalize();

                    return reflDir;*/
                }
                case MaterialType.Transparent:
                {
                    input = Vector.Zero;
                    /*if (!Refract(inRay.Direction, normal, 1.51714f, ref input))
                    {
                        input = Vector.Zero;
                    }*/

                    Refract(inRay.Direction, normal, 1.51714f, ref input);

                    newColor = Color.FromArgb(oldColor.A,
                        Convert.ToInt32(oldColor.R * Kt.X),
                        Convert.ToInt32(oldColor.G * Kt.Y),
                        Convert.ToInt32(oldColor.B * Kt.Z));
                    return input;

                    /* var v = Vector.Dot(inRay.Direction, normal);
                    float q;

                    if (v < 0.0f) // from air into glass
                    {
                        q = Krefraction * Krefraction - 1.0f * 1.0f;
                        v *= 1.0f;
                    }
                    else
                    {
                        q = 1.0f * 1.0f - Krefraction * Krefraction;
                        v *= Krefraction;
                    }

                    var vv = v * v;
                    var refrDir = inRay.Direction + normal * (float)((Math.Sqrt(q / vv + 1) - 1) * v);

                    return refrDir;*/
                }
                default:
                    return null;
            }
        }

        #region Sample2

        public Vector Kd = new Vector(1f, 1f, 1f);
        public Vector Ks = new Vector(1f, 1f, 1f);
        public Vector Kt = new Vector(1f, 1f, 1f);

        /*public Vector Kd = new Vector(0.2f, 0.2f, 0.2f);
        public Vector Ks = new Vector(0.5f, 0.5f, 0.5f);
        public Vector Kt = new Vector(1f,1f,1f);*/

        /*public Vector Sample2(Vector output, Vector normal, Vector oldColor, ref Vector newColor)
        {
            Vector input;

            var ls = new LocalSpace(normal);
            float rnd = GetRndFloat();

            float Pd = max(Kd);
            float Ps = max(Ks);
            float Pt = max(Kt);
            float sum = Pd + Ps + Pt;

            if (rnd <= Pd / sum)
            {
                //дифузное отражение
                float r1 = GetRndFloat();
                float r2 = GetRndFloat();
                input = ls.from(MapSampleToCosineDistribution(r1, r2));
                newColor = oldColor * Kd;
            }
            else if (rnd <= (Pd + Ps) / sum)
            {
                //зеркальное отражение
                input = Vector.Reflect(output, normal);
                newColor = oldColor * Ks;
            }
            else
            {
                input = Vector.Zero;
                if (!refract(output, normal, 1.51714f, ref input))
                {
                    input = Vector.Zero;
                }
                newColor = oldColor * Kt;
            }
            return input;
        }*/

        private static float Max(Vector v)
        {
            return Math.Max(v.X, v.Y);
        }

        public static Random Rnd = new Random();

        public static float GetRndFloat()
        {
            return (float)Rnd.NextDouble();
        }

        private static void Refract(Vector output, Vector normal, float eta, ref Vector input)
        {        
            normal.Normalize();
            eta = 1.0f / eta;

            float cosTheta = (float)Math.Sqrt(1 - eta*eta) * (1f - ((float)Math.Pow(Vector.Dot(normal, output), 2)));
            input = eta*output - (cosTheta + eta*Vector.Dot(normal, output)) * normal;

            /*var cosTheta = -Vector.Dot(normal, output);

            if (cosTheta < 0)
            {
                normal *= (-1);
                cosTheta *= -1.0f;
                eta = 1.0f / eta;
            }

            var k = (float)(1.0f - eta * eta * (1.0 - cosTheta * cosTheta));

            if (k > 0)
            {
                input = eta * output + (float)(eta * cosTheta - Math.Sqrt(k)) * normal;
                input.Normalize();
                return true;
            }
            return false;*/
        }

        #endregion

        public static Vector MapSampleToCosineDistribution(float r1, float r2)
        {
            var sinPhi = (float)Math.Sin(2 * r1 * Math.PI);
            var cosPhi = (float)Math.Cos(2 * r1 * Math.PI);
            ;

            var cosTheta = (float)Math.Pow(1 - r2, 0.5);
            var sinTheta = (float)Math.Sqrt(1 - cosTheta * cosTheta);

            var x = sinTheta * cosPhi;
            var y = sinTheta * sinPhi;
            var z = cosTheta;

            return new Vector(x, y, z);
        }
    }

    public struct LocalSpace
    {
        public Vector AxisX;
        public Vector AxisY;
        public Vector AxisZ;

        public LocalSpace(Vector axisX, Vector axisY, Vector axisZ)
        {
            AxisX = axisX;
            AxisY = axisY;
            AxisZ = axisZ;
        }

        public LocalSpace(Vector normal)
        {
            AxisZ = normal;

            AxisX = Vector.Cross(new Vector(0, 1, 0), normal);
            AxisY = Vector.Cross(new Vector(1, 0, 0), normal);

            float xLength = AxisX.Length(), yLength = AxisY.Length();

            if (xLength > yLength)
            {
                AxisX = AxisX / xLength;
                AxisY = Vector.Cross(AxisX, normal);
            }
            else
            {
                AxisY = AxisY / yLength;
                AxisX = Vector.Cross(AxisY, normal);
            }
        }

        // в
        public Vector to(Vector vector)
        {
            return new Vector(Vector.Dot(vector, AxisX), Vector.Dot(vector, AxisY), Vector.Dot(vector, AxisZ));
        }

        // из
        public Vector from(Vector vector)
        {
            return vector.X * AxisX + vector.Y * AxisY + vector.Z * AxisZ;
        }
    };
}