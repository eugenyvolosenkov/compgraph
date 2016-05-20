using System;
using System.Drawing;
using System.Windows.Forms;

using KarlsTools;

namespace Tutorial.Arcanoid
{
	/// <summary> ������� ����� ����������. </summary>
	public partial class MainForm : Form
	{        
		#region Constructor and Destructor
		
        /// <summary> ������� ������� ���� ����������. </summary> 
		public MainForm()
		{
			InitializeComponent();
		}
		
		#endregion
		
		#region Private Methods
				
		/// <summary> ���������� ������� ��� �������� ����������. </summary>
		private void BuildFractal()
		{
			// ������� ����� �����������
			Bitmap image = new Bitmap(pictureBox.Width, pictureBox.Height);
			
			// �������� ������� ������� ��� ������������
			double minX = (double) upDownMinX.Value;
			double maxX = (double) upDownMaxX.Value;			
			double minY = (double) upDownMinY.Value;	
			double maxY = (double) upDownMaxY.Value;
			
			// ������������ ���� �� ���������� X � Y
			double stepX = (maxX - minX) / pictureBox.Width;
			double stepY = (maxY - minY) / pictureBox.Height;

			for (int j = 0; j < pictureBox.Height; j++)
			{
				double y = maxY - j * stepY;
				
				for (int i = 0; i < pictureBox.Width; i++)
				{
					double x = minX + i * stepX;
							
					// ���������� ����������� ����� c
					Complex c = radioButtonMandel.Checked ? new Complex(x, y) : new Complex(0.36, 0.36);
									
					// ���������� ������ ������� ������������������
					Complex z = radioButtonMandel.Checked ? new Complex(0, 0) : new Complex(x, y);
					
					// ����� ������������������ ��������
					bool inner = true;
					
					// ����� ��������
					int iter = 0;
					
					// ���������� ��������
					while (iter < 80)
					{
						// ��������� ��������� ������� ������������������
						z = z * z + c;
						
						// ���� ����� ������� ������...
						if (Double.IsInfinity(z.Real()) | Double.IsInfinity(z.Imag()))
						{
							// ...�� ������������������ ����������
							inner = false; break;
						}
						
						iter++;
					}
					
					// ���� ������������������ ��������...
					if (inner)
					{
						// ...����������� ����� ������ ������...
						image.SetPixel(i, j, Color.Black);
					}
					else
					{
						// ...����� �������� ���� � ����������� �� �������� ������������
						Color color = GradientColor(Color.Red, Color.Yellow, (double) iter / 80);
						
						image.SetPixel(i, j, color);
					}
				}
			}
			
			pictureBox.Image = image;
			
			pictureBox.Refresh();
		}
		
		/// <summary> ��������� ��� �����. </summary>
		private Color GradientColor(Color start, Color end, double delta)
		{
			return Color.FromArgb(GradientColorValue(start.R, end.R, delta),
			                      GradientColorValue(start.G, end.G, delta),
			                      GradientColorValue(start.B, end.B, delta));
		}
		
		/// <summary> ��������� ��� ����� �����. </summary>
		private int GradientColorValue(int start, int end, double delta)
		{
			return (int) (start + (end - start) * delta);
		}
		
		#endregion
		
		#region Event Handlers
		
		private void ButtonBuildClick(object sender, EventArgs e)
		{
			BuildFractal();
		}
		
		private void ButtonUpClick(object sender, EventArgs e)
		{	
			double minY = (double) upDownMinY.Value;	
			double maxY = (double) upDownMaxY.Value;
			
			upDownMinY.Value = (decimal) (minY + (maxY - minY) / 2);
			upDownMaxY.Value = (decimal) (maxY + (maxY - minY) / 2);
			
			BuildFractal();
		}
		
		private void ButtonLeftClick(object sender, EventArgs e)
		{
			double minX = (double) upDownMinX.Value;	
			double maxX = (double) upDownMaxX.Value;
			
			upDownMinX.Value = (decimal) (minX - (maxX - minX) / 2);
			upDownMaxX.Value = (decimal) (maxX - (maxX - minX) / 2);
			
			BuildFractal();			
		}
		
		private void ButtonDownClick(object sender, EventArgs e)
		{
			double minY = (double) upDownMinY.Value;	
			double maxY = (double) upDownMaxY.Value;
			
			upDownMinY.Value = (decimal) (minY - (maxY - minY) / 2);
			upDownMaxY.Value = (decimal) (maxY - (maxY - minY) / 2);
			
			BuildFractal();
		}
		
		private void ButtonRightClick(object sender, EventArgs e)
		{
			double minX = (double) upDownMinX.Value;	
			double maxX = (double) upDownMaxX.Value;
		
			
			upDownMinX.Value = (decimal) (minX + (maxX - minX) / 2);
			upDownMaxX.Value = (decimal) (maxX + (maxX - minX) / 2);
			
			BuildFractal();				
		}
		
		private void ButtonZoomInClick(object sender, EventArgs e)
		{
			double minX = (double) upDownMinX.Value;	
			double maxX = (double) upDownMaxX.Value;
			double minY = (double) upDownMinY.Value;	
			double maxY = (double) upDownMaxY.Value;				
			
			upDownMinX.Value = (decimal) (minX + (maxX - minX) / 4);
			upDownMaxX.Value = (decimal) (maxX - (maxX - minX) / 4);
			upDownMinY.Value = (decimal) (minY + (maxY - minY) / 4);
			upDownMaxY.Value = (decimal) (maxY - (maxY - minY) / 4);
			
			BuildFractal();				
		}
		
		private void ButtonZoomOutClick(object sender, EventArgs e)
		{
			double minX = (double) upDownMinX.Value;	
			double maxX = (double) upDownMaxX.Value;
			double minY = (double) upDownMinY.Value;	
			double maxY = (double) upDownMaxY.Value;				
			
			upDownMinX.Value = (decimal) (2 * minX);
			upDownMaxX.Value = (decimal) (2 * maxX);
			upDownMinY.Value = (decimal) (2 * minY);
			upDownMaxY.Value = (decimal) (2 * maxY);
			
			BuildFractal();				
		}
	
		#endregion
	}
}
