using System;
using System.Drawing;
using System.Windows.Forms;

namespace Tutorial.ImageProcessing
{
	/// <summary> Диалоговое окно для вывода гистограммы изображения. </summary>
	public partial class HistogramDialog : Form
	{
		#region Private Fields
		
		/// <summary> Гистограмма изображения. </summary>
		private Histogram histogram = null;
		
		/// <summary> Коэффициент масштабирования гистограммы. </summary>
		private float scaling = 60.0f;
		
		#endregion
		
		#region Constructor and Destructor
		
		/// <summary> Создаем новое диалоговое окно для вывода гистограммы изображения. </summary>
		public HistogramDialog(Raster raster)
		{
			histogram = new Histogram(raster);
			
			InitializeComponent();
		}
		
		#endregion
		
		#region Private Fields
		
		/// <summary> Выводим гистограмму изображения. </summary>
		private void ShowHistogram()
		{
			int height = panelRedHistogram.Height;
			
			// Выводим гистограмму для красного канала
			{
				Graphics graphics = panelRedHistogram.CreateGraphics();
				
				Pen pen = new Pen(Color.Red);
				
				for (int index = 0; index < 255; index++)
				{
					float value = Math.Min(1.0f, scaling * histogram.RedHistogram[index]);
					
					graphics.DrawLine(pen, index, height, index, height - (int) (height * value));
				}
			}
			
			// Выводим гистограмму для зеленого канала
			{
				Graphics graphics = panelGreenHistogram.CreateGraphics();
				
				Pen pen = new Pen(Color.Green);
				
				for (int index = 0; index < 255; index++)
				{
					float value = Math.Min(1.0f, scaling * histogram.GreenHistogram[index]);
					
					graphics.DrawLine(pen, index, height, index, height - (int) (height * value));
				}
			}
			
			// Выводим гистограмму для синего канала
			{
				Graphics graphics = panelBlueHistogram.CreateGraphics();
				
				Pen pen = new Pen(Color.Blue);
				
				for (int index = 0; index < 255; index++)
				{
					float value = Math.Min(1.0f, scaling * histogram.BlueHistogram[index]);
					
					graphics.DrawLine(pen, index, height, index, height - (int) (height * value));
				}
			}
			
			// Выводим интегральную гистограмму (на основе свертки компонент цвета)
			{
				Graphics graphics = panelTotalHistogram.CreateGraphics();
				
				Pen pen = new Pen(Color.DimGray);
				
				for (int index = 0; index < 255; index++)
				{
					float value = Math.Min(1.0f, scaling * histogram.TotalHistogram[index]);
					
					graphics.DrawLine(pen, index, height, index, height - (int) (height * value));
				}
			}			
		}
		
		#endregion
		
		#region Event Handlers
		
		private void HistogramDialogPaint(object sender, PaintEventArgs e)
		{
			ShowHistogram();
		}
		
		#endregion
	}
}