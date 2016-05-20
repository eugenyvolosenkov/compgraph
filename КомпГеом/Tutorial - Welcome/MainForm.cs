using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Tutorial.Arcanoid
{
	/// <summary> ������� ����� ����������. </summary>
	public partial class MainForm : Form
	{
        // ����������� ����
        Bitmap backgroundImage =  new Bitmap("..\\..\\Images\\backgrnd.gif");  
		
		// ����� ��� ��������� ��������
        private Font font = new Font("Arial", 48, FontStyle.Bold);

        // ��������� ��������� ��������
        private StringFormat stringFormat = new StringFormat();
        
        /// <summary> ������� ������� ���� ����������. </summary> 
		public MainForm()
		{
			InitializeComponent();
			
			// ������������� ��������� ��������� �������� (������������ �� ������)
            stringFormat.Alignment = StringAlignment.Center;
            stringFormat.LineAlignment = StringAlignment.Center;
		}
		
		/// <summary> ������������ ���������� �������� ����. </summary> 
		private void MainFormPaint(object sender, PaintEventArgs e)
		{
			// �������� ������ ��� ��������� �� ����������� ����
			Graphics graphics = e.Graphics;	
			
			// ������������ ������� �������
			graphics.DrawImage(backgroundImage, ClientRectangle);
			
			// ������� ��� ���������
			string welcome = "Welcome, GDI+!";
			
			// ������������ ������� � ������� ����������� �����
			using (LinearGradientBrush brush =
			                new LinearGradientBrush(ClientRectangle,
			                                        Color.FromArgb(130, 255, 0, 0),
			                                        Color.FromArgb(255, 0, 0, 255),
			                                        LinearGradientMode.BackwardDiagonal))
			{
			    graphics.DrawString(welcome, font, brush, ClientRectangle, stringFormat);                                                          
			}	                                                           
		}
		
		/// <summary> ������������ ��������� ������� �������� ����. </summary> 
		private void MainFormResize(object sender, EventArgs e)
		{
			Invalidate();
		}
	}
}
