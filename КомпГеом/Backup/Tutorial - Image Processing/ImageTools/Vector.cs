using System;

namespace Tutorial.ImageProcessing
{
    /// <summary>  Трехкомпонентный вектор для представления цвета. </summary>
    public class Vector
	{
        #region Public Fields

        public float R;

        public float G;

        public float B;

        #endregion

        #region Constructor and Destructor

        public Vector(float r, float g, float b)
        {
            R = r;
            G = g;
            B = b;
        }
        
        #endregion

        #region Operators

        public static Vector operator -(Vector value)
        {
            return new Vector(-value.R, -value.G, -value.B);
        }

        public static Vector operator +(Vector left, Vector right)
        {
            return new Vector(left.R + right.R, left.G + right.G, left.B + right.B);
        }

        public static Vector operator -(Vector left, Vector right)
        {
            return new Vector(left.R - right.R, left.G - right.G, left.B - right.B);
        }

        public static Vector operator *(Vector left, float right)
        {
            return new Vector(left.R * right, left.G * right, left.B * right);
        }

        public static Vector operator *(Vector left, Vector right)
        {
            return new Vector(left.R * right.R, left.G * right.G, left.B * right.B);
        }

        public static Vector operator /(Vector left, float right)
        {
            return new Vector(left.R / right, left.G / right, left.B / right);
        }

        public static Vector operator /(Vector left, Vector right)
        {
            return new Vector(left.R / right.R, left.G / right.G, left.B / right.B);
        }

        #endregion

        #region Public Methods

        public float[] ToArray()
        {
            return new float[] { R, G, B };
        }
               
        public static Vector Clamp(Vector source, float min, float max)
        {
        	Vector result = source;
        	
        	if (result.R < min) result.R = min;
        	
        	if (result.R > max) result.R = max;
        	
        	if (result.G < min) result.G = min;
        	
        	if (result.G > max) result.G = max;
        	
        	if (result.B < min) result.B = min;
        	
        	if (result.B > max) result.B = max;
        	
        	return result;
        }
        
        public static Vector Mix(Vector left, Vector right, float coeff)
        {        	
        	return left * (1.0f - coeff) + right * coeff;
        }
        
        public static Vector Pow(Vector left, Vector right)
        {        	
        	return new Vector((float) Math.Pow(left.R, right.R),
        	                  (float) Math.Pow(left.G, right.G),
        	                  (float) Math.Pow(left.B, right.B));
        }
        
        public static float Dot(Vector left, Vector right)
        {
            return left.R * right.R + left.G * right.G + left.B * right.B;
        }
        
        #endregion

        #region Properties
        
        public float this[int index]
        {
            get
            {
                if (0 == index)
                    return R;
                else
                    if (1 == index)
                        return G;
                    else
                        return B;
            }

            set
            {
                if (0 == index)
                    R = value;
                else
                    if (1 == index)
                        G = value;
                    else
                        B = value;
            }
        }

        public static Vector Black
        {
            get
            {
                return new Vector(0, 0, 0);
            }
        }

        public static Vector White
        {
            get
            {
                return new Vector(1f, 1f, 1f);
            }
        }
        
        public static Vector Red
        {
            get
            {
                return new Vector(1f, 0, 0);
            }
        }

        public static Vector Green
        {
            get
            {
                return new Vector(0, 1f, 0);
            }
        }

        public static Vector Blue
        {
            get
            {
                return new Vector(0, 0, 1f);
            }
        }

        #endregion
	}
}