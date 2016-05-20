using System;
using System.Drawing;
using System.Windows.Forms;

namespace Tutorial.ImageProcessing
{
	/// <summary> ���������� ���� ��� ������ ����������� �����������. </summary>
	public partial class HistogramDialog : Form
	{
		#region Private Fields
		
		/// <summary> ����������� �����������. </summary>
		private Histogram histogram = null;
		
		/// <summary> ����������� ��������������� �����������. </summary>
		private float scaling = 60.0f;
		
		#endregion
		
		#region Constructor and Destructor
		
		/// <summary> ������� ����� ���������� ���� ��� ������ ����������� �����������. </summary>
		public HistogramDialog(Raster raster)
		{
			histogram = new Histogram(raster);
			
			InitializeComponent();
		}
		
		#endregion
		
		#region Private Fields
		
		/// <summary> ������� ����������� �����������. </summary>
		private void ShowHistogram()
		{
			int height = panelRedHistogram.Height;
			
			// ������� ����������� ��� �������� ������
			{
				Graphics graphics = panelRedHistogram.CreateGraphics();
				
				Pen pen = new Pen(Color.Red);
				
				for (int index = 0; index < 255; index++)
				{
					float value = Math.Min(1.0f, scaling * histogram.RedHistogram[index]);
					
					graphics.DrawLine(pen, index, height, index, height - (int) (height * value));
				}
			}
			
			// ������� ����������� ��� �������� ������
			{
				Graphics graphics = panelGreenHistogram.CreateGraphics();
				
				Pen pen = new Pen(Color.Green);
				
				for (int index = 0; index < 255; index++)
				{
					float value = Math.Min(1.0f, scaling * histogram.GreenHistogram[index]);
					
					graphics.DrawLine(pen, index, height, index, height - (int) (height * value));
				}
			}
			
			// ������� ����������� ��� ������ ������
			{
				Graphics graphics = panelBlueHistogram.CreateGraphics();
				
				Pen pen = new Pen(Color.Blue);
				
				for (int index = 0; index < 255; index++)
				{
					float value = Math.Min(1.0f, scaling * histogram.BlueHistogram[index]);
					
					graphics.DrawLine(pen, index, height, index, height - (int) (height * value));
				}
			}
			
			// ������� ������������ ����������� (�� ������ ������� ��������� �����)
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