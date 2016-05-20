using System;
using System.Drawing;

namespace LightTracing
{
    public class CColor
    {
        public int Count;
        public float R;
        public float G;
        public float B;

        public CColor()
        {
            Count = 0;
            R = 0.0f;
            G = 0.0f;
            B = 0.0f;
        }

        public void Add(float r, float g, float b)
        {
            R = (Count * R / (Count + 1)) + (r / (Count + 1));
            G = (Count * G / (Count + 1)) + (g / (Count + 1));
            B = (Count * B / (Count + 1)) + (b / (Count + 1));

            Count++;
        }

        public Color Get()
        {
            var r = (int)R;
            r = r > 255 ? 255 : r;
            var g = (int)G;
            g = g > 255 ? 255 : g;
            var b = (int)B;
            b = b > 255 ? 255 : b;

            return Color.FromArgb(r, g, b);
        }
    }
}