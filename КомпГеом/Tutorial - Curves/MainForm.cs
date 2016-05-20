using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Tutorial.Curves
{
	/// <summary> ������� ����� ����������. </summary>
	public partial class MainForm : Form
	{
		// ����������� ����� ��� ��������� ������
		private Point [] points = null;
		
		// ����� ���������� �����
		private int selectIndex = 0;
		
		/// <summary> ������� ������� ���� ����������. </summary> 
		public MainForm()
		{
			InitializeComponent();
			
			// ������������� ����������� ����� �� ���������
			points = new Point [] {new Point(100, 250), new Point(200, 150),
				                   new Point(300, 350), new Point(400, 250)};
		}
		
		/// <summary> ������ ���������� ������. </summary> 
		private void DrawSpline(Graphics graphics)
		{
		    // ������������� ����������� �����
			graphics.SmoothingMode = SmoothingMode.HighQuality;
		    
			// ������� �������� ��� ��������� ������
		    using (Pen pen = new Pen(Color.Blue, 2))
		    {
		    	// ������ ���������� ������ ���������� GDI+
		    	graphics.DrawCurve(pen, points);
		    }
		}
		
		/// <summary> ������ ������ �����. </summary> 
		private void DrawBezier(Graphics graphics)
		{
			// ������������� ����������� �����
		    graphics.SmoothingMode = SmoothingMode.HighQuality;
		    
		    // ������� �������� ��� ��������� ����������� ��������
		    using (Pen pen = new Pen(Color.Gray, 1))
		    {
		    	// ������ ����������� ������� ������ �����
			    graphics.DrawLine(pen, points[0], points[1]);
			    graphics.DrawLine(pen, points[2], points[3]);
		    }
		    		  
		    // ������� �������� ��� ��������� ������
		    using (Pen pen = new Pen(Color.Blue, 2))
		    {
		    	// ������ ������ ����� ���������� GDI+
			    graphics.DrawBezier(pen,
		    	                    points[0], points[1],
		    	                    points[2], points[3]);
		    }
		}
		
		/// <summary> ������ ����������� �����. </summary> 
		private void DrawPoints(Graphics graphics)
		{
			// ������ ������� ����������� �����
			int size = 5;
			
		    for (int i = 0; i < points.Length; i++)
		    {
		    	// ���� ����������� ����� ��������...
		    	if (selectIndex == i)
		    	{
		    		// ...������ �� ������� ����������
				    using (Pen pen = new Pen(Color.Red, 3))
				    {
				    	graphics.DrawEllipse(pen,
				    	                     points[i].X - size / 2, points[i].Y - size / 2,
				    	                     size, size);
				    }		    	   
		    	}
		    	else
		    	{
		    		// ����� ������ �� ������� ����������
				    using (Pen pen = new Pen(Color.Green, 3))
				    {
				    	graphics.DrawEllipse(pen,
				    	                     points[i].X - size / 2, points[i].Y - size / 2,
				    	                     size, size);
				    }			    		
		    	}
		    }			
		}
		
		/// <summary> ������������ ���������� �������� ����. </summary> 
		private void MainFormPaint(object sender, PaintEventArgs e)
		{
			// �������� ������ ��� ��������� �� ������
			Graphics graphics = e.Graphics;
			
			// ������ ��������� ������
			if (menuItemSpline.Checked)
			{
				DrawSpline(graphics);
			}
			else
			{
				DrawBezier(graphics);
			}
			
			// ������ ����������� ����� ������ ������
			DrawPoints(graphics);
		}
		
		/// <summary> ������������ ����������� ����. </summary>
		private void MainFormMouseMove(object sender, MouseEventArgs e)
		{
		    // ���������� ��� ����������� �����
			for (int i = 0; i < points.Length; i++)
		    {
				// ���� ��������� ���� ����� � ����������� �����...
		    	if (Math.Abs(points[i].X - e.X) < 4)
		    	{
		    	    if (Math.Abs(points[i].Y - e.Y) < 4)
		        	{
		            	// ...�������� ������ �����
		    	    	selectIndex = i;
		            	break;
		    	    }
		    	}
		    }
		    
			// ���� ������ ����� ������ ����...
		    if (MouseButtons.Left == e.Button)
		    {
		        // ...���������� ���������� ����������� �����
		    	points[selectIndex] = e.Location;
		    }
		    
		    // �������������� ������� ����
		    Invalidate();
		}

		/// <summary> �������� ��� ������ '������ �����'. </summary>
		private void MenuItemBezierClick(object sender, EventArgs e)
		{
			menuItemBezier.Checked = true;
			menuItemSpline.Checked = false;
		}
		
		/// <summary> �������� ��� ������ '���������� ������'. </summary>
		private void MenuItemSplineClick(object sender, EventArgs e)
		{
			menuItemBezier.Checked = false;
			menuItemSpline.Checked = true;			
		}
	}
}
