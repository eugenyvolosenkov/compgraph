using System;

namespace Tutorial.ImageProcessing
{
	/// <summary> ��������������� ����� ��� ������ ����������� �����������. </summary>
	public class Histogram
	{
		#region Public Fields
		
		/// <summary> ����������� �������� ������. </summary>
		public float [] RedHistogram = new float[256];
		
		/// <summary> ����������� �������� ������. </summary>
		public float [] GreenHistogram = new float[256];
		
		/// <summary> ����������� ������ ������. </summary>
		public float [] BlueHistogram = new float[256];
		
		/// <summary> ������������ �����������. </summary>
		public float [] TotalHistogram = new float[256];
		
		/// <summary> ������������ �������� ������� ��� ���������� �������. </summary>
		public static Vector Luminance = new Vector(0.3f, 0.59f, 0.11f);
		
		#endregion
		
		#region Constructor and Destructor
		
		/// <summary> ������� ����������� ��� ��������� �����������. </summary>
		public Histogram(Raster raster)
		{
			// ������������ ��� ������� �����������...
			for (int i = 0; i < raster.Width; i++)
			{
				for (int j = 0; j < raster.Height; j++)
				{
					RedHistogram[Convert.ToInt32(255 * raster[i, j].R)]++;
					
					GreenHistogram[Convert.ToInt32(255 * raster[i, j].G)]++;
					
					BlueHistogram[Convert.ToInt32(255 * raster[i, j].B)]++;
					
					TotalHistogram[Convert.ToInt32(255 * Vector.Dot(raster[i, j], Luminance))]++;
				}
			}
			
			// ������������ ����� �������� �����������
			int count = raster.Width * raster.Height;
			
			// ��������� �����������...
			for (int index = 0; index < 255; index++)
			{
				RedHistogram[index] /= count;
				
				GreenHistogram[index] /= count;
					
				BlueHistogram[index] /= count;
					
				TotalHistogram[index] /= count;				
			}
		}
		
		#endregion
	}
}
