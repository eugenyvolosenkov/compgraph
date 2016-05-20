using System;
using System.Drawing;

namespace Tutorial.ImageProcessing
{
    /// <summary> Простой класс для представления растра. </summary>
    public class Raster
    {
        #region Private Fields

        /// <summary> Массив пикселей растра. </summary>
        private Vector[,] pixels = null;

        #endregion

        #region Constructor and Destructor

        /// <summary> Создает новый растр по заданной ширине и высоте. </summary>
        public Raster(int width, int height)
        {
        	// создаем массив пикселей
            pixels = new Vector[width, height];

            // присваиваем всем пикселям черный цвет
            for (int j = 0; j < height; j++)
            {
                for (int i = 0; i < width; i++)
                {
                    pixels[i, j] = Vector.Black;
                }
            }
        }

        /// <summary> Создает новый растр из заданного графического файла (медленно!). </summary>
        public Raster(string filename)
        {
        	// создаем объект Bitmap из файла
            Bitmap bitmap = new Bitmap(filename);

            // создаем массив пикселей
            pixels = new Vector[bitmap.Width, bitmap.Height];

            // копируем пиксели из объекта Bitmap в растр (очень медленно!)
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

        /// <summary> Конвертирует растр в объект Bitmap (медленно!). </summary>
        public Bitmap ToBitmap()
        {
            // создаем новый объект Bitmap
            Bitmap bitmap = new Bitmap(Width, Height);

            // копируем содержимое растра (очень медленно!)
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

        /// <summary> Сохраняет растр в заданный графический файл. </summary>
        public void Save(string filename)
        {
            // получаем объект Bitmap
            Bitmap bitmap = ToBitmap();

            // сохраняем объект Bitmap в файл
            bitmap.Save(filename);
        }

        #endregion

        #region Properties

        /// <summary> Ширина растра. </summary>
        public int Width
        {
            get
            {
                return pixels.GetLength(0);
            }
        }

        /// <summary> Высота растра. </summary>
        public int Height
        {
            get
            {
                return pixels.GetLength(1);
            }
        }

        /// <summary> Обеспечивает прямой доступ к пикселям растра. </summary>
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
