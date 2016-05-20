using System;
using System.Drawing;

namespace Tutorial.ImageProcessing
{
    /// <summary> ������� ����� ��� ������������� ������. </summary>
    public class Raster
    {
        #region Private Fields

        /// <summary> ������ �������� ������. </summary>
        private Vector[,] pixels = null;

        #endregion

        #region Constructor and Destructor

        /// <summary> ������� ����� ����� �� �������� ������ � ������. </summary>
        public Raster(int width, int height)
        {
        	// ������� ������ ��������
            pixels = new Vector[width, height];

            // ����������� ���� �������� ������ ����
            for (int j = 0; j < height; j++)
            {
                for (int i = 0; i < width; i++)
                {
                    pixels[i, j] = Vector.Black;
                }
            }
        }

        /// <summary> ������� ����� ����� �� ��������� ������������ ����� (��������!). </summary>
        public Raster(string filename)
        {
        	// ������� ������ Bitmap �� �����
            Bitmap bitmap = new Bitmap(filename);

            // ������� ������ ��������
            pixels = new Vector[bitmap.Width, bitmap.Height];

            // �������� ������� �� ������� Bitmap � ����� (����� ��������!)
            for (int j = 0; j < bitmap.Height; j++)
            {
                for (int i = 0; i < bitmap.Width; i++)
                {
                    Color color = bitmap.GetPixel(i, j);

                    pixels[i, j] = new Vector(color.R / 255f, color.G / 255f, color.B / 255f);
                }
            }
        }

        #endregion

        #region Public Methods

        /// <summary> ������������ ����� � ������ Bitmap (��������!). </summary>
        public Bitmap ToBitmap()
        {
            // ������� ����� ������ Bitmap
            Bitmap bitmap = new Bitmap(Width, Height);

            // �������� ���������� ������ (����� ��������!)
            for (int j = 0; j < Height; j++)
            {
                for (int i = 0; i < Width; i++)
                {
                    bitmap.SetPixel(i, j,
                	                Color.FromArgb((int) (255 * pixels[i, j].R),
                	                               (int) (255 * pixels[i, j].G),
                	                               (int) (255 * pixels[i, j].B)));
                }
            }

            return bitmap;
        }

        /// <summary> ��������� ����� � �������� ����������� ����. </summary>
        public void Save(string filename)
        {
            // �������� ������ Bitmap
            Bitmap bitmap = ToBitmap();

            // ��������� ������ Bitmap � ����
            bitmap.Save(filename);
        }

        #endregion

        #region Properties

        /// <summary> ������ ������. </summary>
        public int Width
        {
            get
            {
                return pixels.GetLength(0);
            }
        }

        /// <summary> ������ ������. </summary>
        public int Height
        {
            get
            {
                return pixels.GetLength(1);
            }
        }

        /// <summary> ������������ ������ ������ � �������� ������. </summary>
        public Vector this[int i, int j]
        {
            get
            {
            	if (i < 0) i  = 0;
               
            	if (i > Width - 1) i  = Width - 1;
            	
            	if (j < 0) j  = 0;
            	
            	if (j > Height - 1) j  = Height - 1;
                	
                return pixels[i, j];
            }

            set
            {
                if (i > -1 && i < Width)
                    if (j > -1 && j < Height)
                        pixels[i, j] = value;
            }
        }

        #endregion
    }
}
