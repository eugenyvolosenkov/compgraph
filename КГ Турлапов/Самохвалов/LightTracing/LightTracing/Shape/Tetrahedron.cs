using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace LightTracing
{
    public class Tetrahedron : Shape
    {
        public override bool Intersect(ref Ray ray)
        {
            const float maxDistance = 1000000;
            var distance = maxDistance;
            var triangle = new Vector[3];
            Vector outPoint = null;

            for (var i = 0; i < 4; i++)
            {
                GetTriangleAndPoint(i, ref triangle, ref outPoint);
                var TUY = Vector.Zero;

                var triag = new Triangle(triangle[0], triangle[1], triangle[2], TUY, Material, Color);

                if (triag.Intersect(ref ray))
                {
                    var curDistance = TUY.X;
                    //нашли перечесение  
                    if (curDistance < distance)
                    {
                        distance = curDistance;
                    }
                }
            }

            if (Math.Abs(distance - maxDistance) < 0.001)
            {
                return false;
            }

            return true;
        }

        public override Vector GetNormalAtPoint(Vector point)
        {
            var triangle = new Vector[3];
            Vector outPoint = null;

            for (var i = 0; i < 4; i++)
            {
                GetTriangleAndPoint(i, ref triangle, ref outPoint);
                if (TrianglePlaneHasPoint(triangle[0], triangle[1], triangle[2], point))
                {
                    break;
                }
            }

            var normal = Vector.Cross(triangle[0] - triangle[1], triangle[2] - triangle[1]);
            var scalarMult = Vector.Dot(normal, point - triangle[1]);

            normal.Normalize();

            if (scalarMult < 0)
            {
                return normal;
            }
            return normal * (-1);
        }

        private readonly Vector[] _points = new Vector[4];

        public Tetrahedron(Vector p1, Vector p2, Vector p3, Vector p4, Material m, Color c)
        {
            _points[0] = p1;
            _points[1] = p2;
            _points[2] = p3;
            _points[3] = p4;
            Material = m;
            Color = c;
        }

        private void GetTriangleAndPoint(int numberOfPoint, ref Vector[] array, ref Vector point)
        {
            point = _points[numberOfPoint];
            var k = 0;
            for (var i = 0; i < 4; i++)
            {
                if (i == numberOfPoint)
                {
                    continue;
                }
                array[k++] = _points[i];
            }
        }

        public static bool TrianglePlaneHasPoint(Vector a, Vector b, Vector c, Vector point)
        {
            var normal = Vector.Cross(a - b, c - b);
            var scalarMult = Vector.Dot(normal, point - b);
            var result = Math.Abs(scalarMult) < 0.00001;
            return result;
        }

        /*public float Hit(Ray ray)
        {
            const float maxDistance = 1000000;
            var distance = maxDistance;
            var triangle = new Vector[3];
            Vector outPoint = null;

            for (var i = 0; i < 4; i++)
            {
                GetTriangleAndPoint(i, ref triangle, ref outPoint);
                var TUY = Vector.Zero;
                float curDistance = maxDistance;
                if (intersect_triangle(ray, triangle[0], triangle[1], triangle[2], ref TUY) == 1)
                {
                    curDistance = TUY.x;
                    //нашли перечесение  
                    if (curDistance < distance)
                    {
                        distance = curDistance;
                    }
                }
            }

            if (distance == maxDistance)
            {
                return -1;
            }
            return distance;
        }*/

        public void setColor(Vector point)
        {
        }
    }
}
