using System;
using System.ComponentModel;

namespace Tutorial.ImageProcessing
{
    /// <summary> ����������� ������ ��� ��������� �����������. </summary>
    public abstract class ImageFilter
    {
        #region Public Methods

        /// <summary> ������������ �������� �����. </summary>
        public abstract Raster ProcessImage(Raster source, bool half, BackgroundWorker worker);

        #endregion
    }
    
    /// <summary> �������� ������ ��� �������������� �����. </summary>
    public class InvertFilter : ImageFilter
    {
        #region Public Methods
        
        /// <summary> ������������ �������� �����. </summary>
        public override Raster ProcessImage(Raster source, bool half, BackgroundWorker worker)
        {
            // ������� �������������� �����
            Raster result = new Raster(source.Width, source.Height);

            // ���������� ��������� ������� �������� ��� ���������
            int start = half ? source.Width / 2 : 0;

            // ��������� ����� ������ ���������
            DateTime startTime = DateTime.Now;

            // ������������ �������� �����
            for (int j = 0; j < source.Height; j++)
            {
                // ������ �������� ������ �� ������� ���������
                for (int i = 0; i < start; i++)
                    result[i, j] = source[i, j];

                // ��� ������ �������� ������ ��������� ������
                for (int i = start; i < source.Width; i++)
                    result[i, j] = Vector.White - source[i, j];

                // �������� ������� �������� � ����� ���������
                worker.ReportProgress((int)(100f * j / source.Height), DateTime.Now - startTime);
            }

            return result;
        }

        #endregion
    }
    
    /// <summary> �������� ������ ���������� �������. </summary>
    public class IntensityFilter : ImageFilter
    {
        #region Private Fields

        /// <summary> �������� ���������� �����. </summary>
    	private Vector increment = new Vector(0.5f, 0.5f, 0.5f);

        #endregion

        #region Constructor and Destructor

        /// <summary> ������� ����� �������� ������ ���������� �������. </summary>
    	public IntensityFilter() { }
    	
    	/// <summary> ������� ����� �������� ������ ���������� �������. </summary>
    	public IntensityFilter(Vector inc)
    	{
    		increment = inc;
        }

        #endregion

        #region Public Methods

        /// <summary> ������������ �������� �����. </summary>
        public override Raster ProcessImage(Raster source, bool half, BackgroundWorker worker)
        {
            // ������� �������������� �����
            Raster result = new Raster(source.Width, source.Height);

            // ���������� ��������� ������� �������� ��� ���������
            int start = half ? source.Width / 2 : 0;

            // ��������� ����� ������ ���������
            DateTime startTime = DateTime.Now;

            // ������������ �������� �����
            for (int j = 0; j < source.Height; j++)
            {
                // ������ �������� ������ �� ������� ���������
                for (int i = 0; i < start; i++)
                    result[i, j] = source[i, j];

                // ��� ������ �������� ������ ��������� ������
                for (int i = start; i < source.Width; i++)
                    result[i, j] = Vector.Clamp(increment + source[i, j], 0f, 1f);

                // �������� ������� �������� � ����� ���������
                worker.ReportProgress((int) (100f * j / source.Height), DateTime.Now - startTime);
            }

            return result;
        }

        #endregion
    }
    
    /// <summary> �������� ������ '�����'. </summary>
    public class SepiaFilter : ImageFilter
    {
        #region Private Fields

        /// <summary> ������������ ������������� ��������� �����. </summary>
		private static Vector luminance = new Vector(0.3f, 0.59f, 0.11f);

		/// <summary> ���� ������� 'Sepia'. </summary>
		private static Vector sepiacolor = new Vector(1.0f, 0.89f, 0.54f);

        #endregion

        #region Constructor and Destructor

        /// <summary> ������� ����� �������� ������ '�����'. </summary>
    	public SepiaFilter() { }
		
    	/// <summary> ������� ����� �������� ������ '�����'. </summary>
    	public SepiaFilter(Vector color)
    	{
    		sepiacolor = color;
        }

        #endregion

        #region Public Methods

        /// <summary> ������������ �������� �����. </summary>
        public override Raster ProcessImage(Raster source, bool half, BackgroundWorker worker)
        {
            // ������� �������������� �����
            Raster result = new Raster(source.Width, source.Height);

            // ���������� ��������� ������� �������� ��� ���������
            int start = half ? source.Width / 2 : 0;

            // ��������� ����� ������ ���������
            DateTime startTime = DateTime.Now;

            // ������������ �������� �����
            for (int j = 0; j < source.Height; j++)
            {
                // ������ �������� ������ �� ������� ���������
                for (int i = 0; i < start; i++)
                    result[i, j] = source[i, j];

                // ��� ������ �������� ������ ��������� ������
                for (int i = start; i < source.Width; i++)
                    result[i, j] = sepiacolor * Vector.Dot(source[i, j], luminance);

                // �������� ������� �������� � ����� ���������
                worker.ReportProgress((int) (100f * j / source.Height), DateTime.Now - startTime);
            }

            return result;
        }

        #endregion
    }
    
    /// <summary> �������� ������ '�����-���������'. </summary>
    public class GammaCorrectionFilter : ImageFilter
    {
        #region Private Fields

        /// <summary> ����������� �����-���������. </summary>
        private Vector gamma = new Vector(0.8f, 0.8f, 0.8f);

        #endregion

        #region Constructor and Destructor

        /// <summary> ������� ����� �������� ������ '�����-���������'. </summary>
    	public GammaCorrectionFilter() { }
		
    	/// <summary> ������� ����� �������� ������ '�����-���������'. </summary>
    	public GammaCorrectionFilter(Vector gamma)
    	{
    		this.gamma = gamma;
        }

        #endregion

        #region Public Methods

        /// <summary> ������������ �������� �����. </summary>
        public override Raster ProcessImage(Raster source, bool half, BackgroundWorker worker)
        {
            // ������� �������������� �����
            Raster result = new Raster(source.Width, source.Height);

            // ���������� ��������� ������� �������� ��� ���������
            int start = half ? source.Width / 2 : 0;

            // ��������� ����� ������ ���������
            DateTime startTime = DateTime.Now;

            // ������������ �������� �����
            for (int j = 0; j < source.Height; j++)
            {
                // ������ �������� ������ �� ������� ���������
                for (int i = 0; i < start; i++)
                    result[i, j] = source[i, j];

                // ��� ������ �������� ������ ��������� ������
                for (int i = start; i < source.Width; i++)
                    result[i, j] = Vector.Pow(source[i, j], Vector.White / gamma);

                // �������� ������� �������� � ����� ���������
                worker.ReportProgress((int) (100f * j / source.Height), DateTime.Now - startTime);
            }

            return result;
        }

        #endregion
    }
    
    /// <summary> �������� ������ '����� ���'. </summary>
    public class GreyWorldFilter : ImageFilter
    {
        #region Constructor and Destructor

        /// <summary> ������� ����� �������� ������ '����� ���'. </summary>
    	public GreyWorldFilter() { }

        #endregion

        #region Public Methods

        /// <summary> ������������ �������� �����. </summary>
        public override Raster ProcessImage(Raster source, bool half, BackgroundWorker worker)
        {
        	// ������� ���� �����������
        	Vector color = Vector.Black;
        	
        	// ������������ ������� ���� �������
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
        	
        	// ������������ ������� ������� ���������
            float average = Vector.Dot(Vector.White, color) / 3.0f;
            
            // ������� �������������� �����
            Raster result = new Raster(source.Width, source.Height);

            // ���������� ��������� ������� �������� ��� ���������
            int start = half ? source.Width / 2 : 0;

            // ��������� ����� ������ ���������
            DateTime startTime = DateTime.Now;

            // ������������ �������� �����
            for (int j = 0; j < source.Height; j++)
            {
                // ������ �������� ������ �� ������� ���������
                for (int i = 0; i < start; i++)
                    result[i, j] = source[i, j];

                // ��� ������ �������� ������ ��������� ������
                for (int i = start; i < source.Width; i++)
                	result[i, j] = Vector.Clamp(source[i, j] * average / color, 0.0f, 1.0f);

                // �������� ������� �������� � ����� ���������
                worker.ReportProgress((int) (100f * j / source.Height), DateTime.Now - startTime);
            }

            return result;
        }

        #endregion
    }

    /// <summary> �������� ������ ��� ��������� �����������. </summary>
    public class LinearFilter : ImageFilter
    {
        #region Private Fields

        /// <summary> ���� ��������� �������. </summary>
        private float[,] kernel = null;

        #endregion

        #region Constructor and Destructor

        /// <summary> ������� ����� �������� ������ �� ��������� ����. </summary>
        public LinearFilter(float[,] ker)
        {
            kernel = ker;
        }

        #endregion

        #region Public Methods

        /// <summary> ������������ �������� �����. </summary>
        public override Raster ProcessImage(Raster source, bool half, BackgroundWorker worker)
        {
            // ������� �������������� �����
            Raster result = new Raster(source.Width, source.Height);

            // ���������� ��������� ������� �������� ��� ���������
            int start = half ? source.Width / 2 : 0;

            // ���������� ������ �������� ������� �� ��� X
            int radiusX = kernel.GetLength(0) / 2;

            // ���������� ������ �������� ������� �� ��� Y
            int radiusY = kernel.GetLength(1) / 2;

            // ��������� ����� ������ ���������
            DateTime startTime = DateTime.Now;

            // ������������ �������� �����
            for (int j = 0; j < source.Height; j++)
            {
                // ������ �������� ������ �� ������� ���������
                for (int i = 0; i < start; i++)
                    result[i, j] = source[i, j];

                // ��� ������ �������� ������ ��������� ������
                for (int i = start; i < source.Width; i++)
                {
                    for (int l = -radiusY; l <= radiusY; l++)
                        for (int k = -radiusX; k <= radiusX; k++)
                            result[i, j] += source[i + k, j + l] * kernel[k + radiusX, l + radiusY];

                    result[i, j] = Vector.Clamp(result[i, j], 0f, 1f);
                }

                // �������� ������� �������� � ����� ���������                
                worker.ReportProgress((int) (100f * j / source.Height), DateTime.Now - startTime);
            }

            return result;
        }

        #region Linear filters samples

        /// <summary> ���������� ������� ������ �����������. </summary>
        public static LinearFilter SimpleBlurFilter(int radius)
        {
            // ���������� ������ ����
            int size = 2 * radius + 1;

            // ������� ���� �������
            float[,] kernel = new float[size, size];

            // ��������� ���� ����������
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    kernel[i, j] = 1.0f / (size * size);
                }
            }

            return new LinearFilter(kernel);
        }

        /// <summary> ���������� ������ ������������ �����������. </summary>
        public static LinearFilter GaussBlurFilter(int radius, float sigma)
        {
            // ���������� ������ ����
            int size = 2 * radius + 1;

            // ������� ���� �������
            float[,] kernel = new float[size, size];
            
            // ������ �������� ����
            int half = size / 2;
            
            // ����������� ���������� ����
            float norm = 0;
            
            // ������������ ���� ��������� �������
            for (int i = -half; i <= half; i++)
            {
            	for (int j = -half; j <= half; j++)
            	{
                    kernel[i + half, j + half] = (float) (Math.Exp(-(i * i + j * j) / (sigma * sigma)));

                    norm += kernel[i + half, j + half];
            	}
            }

            // ��������� ����
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    kernel[i, j] /= norm;
                }
            }

            return new LinearFilter(kernel);
        }

        /// <summary> ���������� ������ ������������������� ������. </summary>
        public static LinearFilter LightContrastFilter()
        {
            // ������� ���� ��������� �������
            float[,] kernel = { { 0.0f, -1.0f,  0.0f}, 
			                    {-1.0f,  5.0f, -1.0f},
			                    { 0.0f, -1.0f,  0.0f} };

            return new LinearFilter(kernel);
        }

        /// <summary> ���������� ������� ������������������� ������. </summary>
        public static LinearFilter HightContrastFilter()
        {
            // ������� ���� ��������� �������
            float[,] kernel = { {-1.0f, -1.0f, -1.0f}, 
			                    {-1.0f,  9.0f, -1.0f},
			                    {-1.0f, -1.0f, -1.0f} };

            return new LinearFilter(kernel);
        }

        /// <summary> ���������� �������� ������ ������. </summary>
        public static LinearFilter PrewittFilter()
        {
            // ������� ���� ��������� �������
            float[,] kernel = { {-1.0f, 0.0f, 1.0f}, 
			                    {-1.0f, 0.0f, 1.0f},
			                    {-1.0f, 0.0f, 1.0f} };

            return new LinearFilter(kernel);
        }

        /// <summary> ���������� �������� ������ ������. </summary>
        public static LinearFilter SobelFilter()
        {
            // ������� ���� ��������� �������
            float[,] kernel = { {-1.0f, 0.0f, 1.0f}, 
			                    {-2.0f, 0.0f, 2.0f},
			                    {-1.0f, 0.0f, 1.0f} };

            return new LinearFilter(kernel);
        }
        
        /// <summary> ���������� �������� ������ �������. </summary>
        public static LinearFilter LaplasFilter()
        {
            // ������� ���� ��������� �������
            float[,] kernel = { {0.0f,  1.0f,  0.0f}, 
			                    {1.0f, -4.0f,  1.0f},
			                    {0.0f,  1.0f,  0.0f} };

            return new LinearFilter(kernel);
        }      
        
        #endregion

        #endregion
    }
}
