using System;

namespace LightTracing
{
    public class Vector
    {
        public float X, Y, Z;

        public Vector()
        {
            X = 0.0f;
            Y = 0.0f;
            Z = 0.0f;
        }

        public Vector(float x, float y, float z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public static float Dot(Vector v1, Vector v2) //скалярное произведение (норма)
        {
            return v1.X * v2.X + v1.Y * v2.Y + v1.Z * v2.Z;
        }

        public static Vector Cross(Vector v1, Vector v2) //векторное произведение
        {
            var v = new Vector
            {
                X = v1.Y*v2.Z - v1.Z*v2.Y,
                Y = v1.Z*v2.X - v1.X*v2.Z,
                Z = v1.X*v2.Y - v1.Y*v2.X
            };

            return v;
        }

        public static Vector Zero
        {
            get
            {
                return new Vector(0, 0, 0);
            }
        }

        public void Normalize()
        {
            var k = (float)(1.0f / Math.Sqrt(Dot(this, this)));

            X *= k;
            Y *= k;
            Z *= k;
        }

        public float Length()
        {
            return (float)Math.Sqrt(Dot(this, this));
        }

        public static Vector operator +(Vector v1, Vector v2)
        {
            return new Vector(v1.X + v2.X, v1.Y + v2.Y, v1.Z + v2.Z);
        }

        public static Vector operator -(Vector v1, Vector v2)
        {
            return new Vector(v1.X - v2.X, v1.Y - v2.Y, v1.Z - v2.Z);
        }

        public static Vector operator -(Vector v)
        {
            return new Vector(-v.X, -v.Y, -v.Z);
        }

        public static Vector operator *(Vector left, float right)
        {
            return new Vector(left.X * right, left.Y * right, left.Z * right);
        }

        public static Vector operator *(float left, Vector right)
        {
            return new Vector(left * right.X, left * right.Y, left * right.Z);
        }

        public static Vector operator *(Vector left, Vector right)
        {
            return new Vector(left.X * right.X, left.Y * right.Y, left.Z * right.Z);
        }

        public static Vector Reflect(Vector incident, Vector normal)
        {
            return incident - 2 * Dot(normal, incident) * normal;
        }

        public static Vector operator /(Vector left, float right)
        {
            return new Vector(left.X / right, left.Y / right, left.Z / right);
        }
    }
}