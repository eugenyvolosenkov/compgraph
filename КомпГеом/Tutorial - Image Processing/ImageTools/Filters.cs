using System;
using System.ComponentModel;

namespace Tutorial.ImageProcessing
{
    /// <summary> Абстрактный фильтр для обработки изображения. </summary>
    public abstract class ImageFilter
    {
        #region Public Methods

        /// <summary> Обрабатывает заданный растр. </summary>
        public abstract Raster ProcessImage(Raster source, bool half, BackgroundWorker worker);

        #endregion
    }
    
    /// <summary> Точечный фильтр для инвертирования цвета. </summary>
    public class InvertFilter : ImageFilter
    {
        #region Public Methods
        
        /// <summary> Обрабатывает заданный растр. </summary>
        public override Raster ProcessImage(Raster source, bool half, BackgroundWorker worker)
        {
            // создаем результирующий растр
            Raster result = new Raster(source.Width, source.Height);

            // определяем начальный столбец пикселей для обработки
            int start = half ? source.Width / 2 : 0;

            // сохраняем время начала обработки
            DateTime startTime = DateTime.Now;

            // обрабатываем исходный растр
            for (int j = 0; j < source.Height; j++)
            {
                // первая половина растра не требует обработки
                for (int i = 0; i < start; i++)
                    result[i, j] = source[i, j];

                // для второй половины растра применяем фильтр
                for (int i = start; i < source.Width; i++)
                    result[i, j] = Vector.White - source[i, j];

                // сообщаем текущий прогресс и время обработки
                worker.ReportProgress((int)(100f * j / source.Height), DateTime.Now - startTime);
            }

            return result;
        }

        #endregion
    }
    
    /// <summary> Точечный фильтр увеличения яркости. </summary>
    public class IntensityFilter : ImageFilter
    {
        #region Private Fields

        /// <summary> Величина приращения цвета. </summary>
    	private Vector increment = new Vector(0.5f, 0.5f, 0.5f);

        #endregion

        #region Constructor and Destructor

        /// <summary> Создает новый точечный фильтр увеличения яркости. </summary>
    	public IntensityFilter() { }
    	
    	/// <summary> Создает новый точечный фильтр увеличения яркости. </summary>
    	public IntensityFilter(Vector inc)
    	{
    		increment = inc;
        }

        #endregion

        #region Public Methods

        /// <summary> Обрабатывает заданный растр. </summary>
        public override Raster ProcessImage(Raster source, bool half, BackgroundWorker worker)
        {
            // создаем результирующий растр
            Raster result = new Raster(source.Width, source.Height);

            // определяем начальный столбец пикселей для обработки
            int start = half ? source.Width / 2 : 0;

            // сохраняем время начала обработки
            DateTime startTime = DateTime.Now;

            // обрабатываем исходный растр
            for (int j = 0; j < source.Height; j++)
            {
                // первая половина растра не требует обработки
                for (int i = 0; i < start; i++)
                    result[i, j] = source[i, j];

                // для второй половины растра применяем фильтр
                for (int i = start; i < source.Width; i++)
                    result[i, j] = Vector.Clamp(increment + source[i, j], 0f, 1f);

                // сообщаем текущий прогресс и время обработки
                worker.ReportProgress((int) (100f * j / source.Height), DateTime.Now - startTime);
            }

            return result;
        }

        #endregion
    }
    
    /// <summary> Точечный фильтр 'Сепия'. </summary>
    public class SepiaFilter : ImageFilter
    {
        #region Private Fields

        /// <summary> Коэффициенты интенсивности компонент цвета. </summary>
		private static Vector luminance = new Vector(0.3f, 0.59f, 0.11f);

		/// <summary> Цвет фильтра 'Sepia'. </summary>
		private static Vector sepiacolor = new Vector(1.0f, 0.89f, 0.54f);

        #endregion

        #region Constructor and Destructor

        /// <summary> Создает новый точечный фильтр 'Сепия'. </summary>
    	public SepiaFilter() { }
		
    	/// <summary> Создает новый точечный фильтр 'Сепия'. </summary>
    	public SepiaFilter(Vector color)
    	{
    		sepiacolor = color;
        }

        #endregion

        #region Public Methods

        /// <summary> Обрабатывает заданный растр. </summary>
        public override Raster ProcessImage(Raster source, bool half, BackgroundWorker worker)
        {
            // создаем результирующий растр
            Raster result = new Raster(source.Width, source.Height);

            // определяем начальный столбец пикселей для обработки
            int start = half ? source.Width / 2 : 0;

            // сохраняем время начала обработки
            DateTime startTime = DateTime.Now;

            // обрабатываем исходный растр
            for (int j = 0; j < source.Height; j++)
            {
                // первая половина растра не требует обработки
                for (int i = 0; i < start; i++)
                    result[i, j] = source[i, j];

                // для второй половины растра применяем фильтр
                for (int i = start; i < source.Width; i++)
                    result[i, j] = sepiacolor * Vector.Dot(source[i, j], luminance);

                // сообщаем текущий прогресс и время обработки
                worker.ReportProgress((int) (100f * j / source.Height), DateTime.Now - startTime);
            }

            return result;
        }

        #endregion
    }
    
    /// <summary> Точечный фильтр 'Гамма-коррекция'. </summary>
    public class GammaCorrectionFilter : ImageFilter
    {
        #region Private Fields

        /// <summary> Коэффициент гамма-коррекции. </summary>
        private Vector gamma = new Vector(0.8f, 0.8f, 0.8f);

        #endregion

        #region Constructor and Destructor

        /// <summary> Создает новый точечный фильтр 'Гамма-коррекция'. </summary>
    	public GammaCorrectionFilter() { }
		
    	/// <summary> Создает новый точечный фильтр 'Гамма-коррекция'. </summary>
    	public GammaCorrectionFilter(Vector gamma)
    	{
    		this.gamma = gamma;
        }

        #endregion

        #region Public Methods

        /// <summary> Обрабатывает заданный растр. </summary>
        public override Raster ProcessImage(Raster source, bool half, BackgroundWorker worker)
        {
            // создаем результирующий растр
            Raster result = new Raster(source.Width, source.Height);

            // определяем начальный столбец пикселей для обработки
            int start = half ? source.Width / 2 : 0;

            // сохраняем время начала обработки
            DateTime startTime = DateTime.Now;

            // обрабатываем исходный растр
            for (int j = 0; j < source.Height; j++)
            {
                // первая половина растра не требует обработки
                for (int i = 0; i < start; i++)
                    result[i, j] = source[i, j];

                // для второй половины растра применяем фильтр
                for (int i = start; i < source.Width; i++)
                    result[i, j] = Vector.Pow(source[i, j], Vector.White / gamma);

                // сообщаем текущий прогресс и время обработки
                worker.ReportProgress((int) (100f * j / source.Height), DateTime.Now - startTime);
            }

            return result;
        }

        #endregion
    }
    
    /// <summary> Точечный фильтр 'Серый мир'. </summary>
    public class GreyWorldFilter : ImageFilter
    {
        #region Constructor and Destructor

        /// <summary> Создает новый точечный фильтр 'Серый мир'. </summary>
    	public GreyWorldFilter() { }

        #endregion

        #region Public Methods

        /// <summary> Обрабатывает заданный растр. </summary>
        public override Raster ProcessImage(Raster source, bool half, BackgroundWorker worker)
        {
        	// средний цвет изображения
        	Vector color = Vector.Black;
        	
        	// подсчитываем средний цвет пикселя
        	{
	            for (int j = 0; j < source.Height; j++)
	            {
	                for (int i = 0; i < source.Height; i++)
	                {
	                	color += source[i, j];
	                }
	            }
	            
	            color /= source.Width * source.Height;
        	}
        	
        	// подсчитываем среднюю яркость компонент
            float average = Vector.Dot(Vector.White, color) / 3.0f;
            
            // создаем результирующий растр
            Raster result = new Raster(source.Width, source.Height);

            // определяем начальный столбец пикселей для обработки
            int start = half ? source.Width / 2 : 0;

            // сохраняем время начала обработки
            DateTime startTime = DateTime.Now;

            // обрабатываем исходный растр
            for (int j = 0; j < source.Height; j++)
            {
                // первая половина растра не требует обработки
                for (int i = 0; i < start; i++)
                    result[i, j] = source[i, j];

                // для второй половины растра применяем фильтр
                for (int i = start; i < source.Width; i++)
                	result[i, j] = Vector.Clamp(source[i, j] * average / color, 0.0f, 1.0f);

                // сообщаем текущий прогресс и время обработки
                worker.ReportProgress((int) (100f * j / source.Height), DateTime.Now - startTime);
            }

            return result;
        }

        #endregion
    }

    /// <summary> Линейный фильтр для обработки изображения. </summary>
    public class LinearFilter : ImageFilter
    {
        #region Private Fields

        /// <summary> Ядро линейного фильтра. </summary>
        private float[,] kernel = null;

        #endregion

        #region Constructor and Destructor

        /// <summary> Создает новый линейный фильтр по заданному ядру. </summary>
        public LinearFilter(float[,] ker)
        {
            kernel = ker;
        }

        #endregion

        #region Public Methods

        /// <summary> Обрабатывает заданный растр. </summary>
        public override Raster ProcessImage(Raster source, bool half, BackgroundWorker worker)
        {
            // создаем результирующий растр
            Raster result = new Raster(source.Width, source.Height);

            // определяем начальный столбец пикселей для обработки
            int start = half ? source.Width / 2 : 0;

            // определяем радиус действия фильтра по оси X
            int radiusX = kernel.GetLength(0) / 2;

            // определяем радиус действия фильтра по оси Y
            int radiusY = kernel.GetLength(1) / 2;

            // сохраняем время начала обработки
            DateTime startTime = DateTime.Now;

            // обрабатываем исходный растр
            for (int j = 0; j < source.Height; j++)
            {
                // первая половина растра не требует обработки
                for (int i = 0; i < start; i++)
                    result[i, j] = source[i, j];

                // для второй половины растра применяем фильтр
                for (int i = start; i < source.Width; i++)
                {
                    for (int l = -radiusY; l <= radiusY; l++)
                        for (int k = -radiusX; k <= radiusX; k++)
                            result[i, j] += source[i + k, j + l] * kernel[k + radiusX, l + radiusY];

                    result[i, j] = Vector.Clamp(result[i, j], 0f, 1f);
                }

                // сообщаем текущий прогресс и время обработки                
                worker.ReportProgress((int) (100f * j / source.Height), DateTime.Now - startTime);
            }

            return result;
        }

        #region Linear filters samples

        /// <summary> Возвращает простой фильтр сглаживания. </summary>
        public static LinearFilter SimpleBlurFilter(int radius)
        {
            // определяем размер ядра
            int size = 2 * radius + 1;

            // создаем ядро фильтра
            float[,] kernel = new float[size, size];

            // заполняем ядро значениями
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    kernel[i, j] = 1.0f / (size * size);
                }
            }

            return new LinearFilter(kernel);
        }

        /// <summary> Возвращает фильтр гауссовского сглаживания. </summary>
        public static LinearFilter GaussBlurFilter(int radius, float sigma)
        {
            // определяем размер ядра
            int size = 2 * radius + 1;

            // создаем ядро фильтра
            float[,] kernel = new float[size, size];
            
            // радиус действия ядра
            int half = size / 2;
            
            // коэффициент нормировки ядра
            float norm = 0;
            
            // рассчитываем ядро линейного фильтра
            for (int i = -half; i <= half; i++)
            {
            	for (int j = -half; j <= half; j++)
            	{
                    kernel[i + half, j + half] = (float) (Math.Exp(-(i * i + j * j) / (sigma * sigma)));

                    norm += kernel[i + half, j + half];
            	}
            }

            // нормируем ядро
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    kernel[i, j] /= norm;
                }
            }

            return new LinearFilter(kernel);
        }

        /// <summary> Возвращает слабый контрастоповышающий фильтр. </summary>
        public static LinearFilter LightContrastFilter()
        {
            // создаем ядро линейного фильтра
            float[,] kernel = { { 0.0f, -1.0f,  0.0f}, 
			                    {-1.0f,  5.0f, -1.0f},
			                    { 0.0f, -1.0f,  0.0f} };

            return new LinearFilter(kernel);
        }

        /// <summary> Возвращает сильный контрастоповышающий фильтр. </summary>
        public static LinearFilter HightContrastFilter()
        {
            // создаем ядро линейного фильтра
            float[,] kernel = { {-1.0f, -1.0f, -1.0f}, 
			                    {-1.0f,  9.0f, -1.0f},
			                    {-1.0f, -1.0f, -1.0f} };

            return new LinearFilter(kernel);
        }

        /// <summary> Возвращает линейный фильтр Прюита. </summary>
        public static LinearFilter PrewittFilter()
        {
            // создаем ядро линейного фильтра
            float[,] kernel = { {-1.0f, 0.0f, 1.0f}, 
			                    {-1.0f, 0.0f, 1.0f},
			                    {-1.0f, 0.0f, 1.0f} };

            return new LinearFilter(kernel);
        }

        /// <summary> Возвращает линейный фильтр Собеля. </summary>
        public static LinearFilter SobelFilter()
        {
            // создаем ядро линейного фильтра
            float[,] kernel = { {-1.0f, 0.0f, 1.0f}, 
			                    {-2.0f, 0.0f, 2.0f},
			                    {-1.0f, 0.0f, 1.0f} };

            return new LinearFilter(kernel);
        }
        
        /// <summary> Возвращает линейный фильтр Лапласа. </summary>
        public static LinearFilter LaplasFilter()
        {
            // создаем ядро линейного фильтра
            float[,] kernel = { {0.0f,  1.0f,  0.0f}, 
			                    {1.0f, -4.0f,  1.0f},
			                    {0.0f,  1.0f,  0.0f} };

            return new LinearFilter(kernel);
        }      
        
        #endregion

        #endregion
    }
}
