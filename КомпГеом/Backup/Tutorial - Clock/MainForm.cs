using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Tutorial.Clock
{
	/// <summary> ������� ����� ����������. </summary>
	public partial class MainForm : Form
	{
		/// <summary> ������� ������� ����� ����������. </summary>
		public MainForm()
		{
			InitializeComponent();
		}
		
		/// <summary> ���������� ���������� ����� �� ��������� �������. </summary>
		private Point RadialPoint(int radius, int tick)
		{
			// ������� ����� ����
			Point center = new Point(ClientRectangle.Width / 2,
			                         ClientRectangle.Height / 2);
					
			// ������� ���� ���������� ������� �� ��������� (� ��������)
			double angle = tick * Math.PI / 30;
			
			// ������� ��������������� ����� �� �����
			Point point = new Point(center.X + (int) (radius * Math.Sin(angle)),
			                        center.Y - (int) (radius * Math.Cos(angle)));
			
			return point;
		}
		
		/// <summary> ������������ ���������� �������� ����. </summary> 
		private void MainFormPaint(object sender, PaintEventArgs e)
		{
			// �������� ������� �����
			DateTime time = DateTime.Now;
			
			// �������� ������ ��� ��������� �� ����������� ����
			Graphics graphics = e.Graphics;
			
			// �������� ����������� �����
			graphics.SmoothingMode = SmoothingMode.HighQuality;
			
			// ������� ����������� ����� ����
			Point center = new Point(ClientRectangle.Width / 2, ClientRectangle.Height / 2);
			
			// ������� ������ ����� ����� ��� ������� �� �������� ������ � ������
			int radius = Math.Min(ClientRectangle.Width, ClientRectangle.Height) / 2;
			
			// ������� ����� ��� ����������� ������� ����������
			using (LinearGradientBrush brush = new LinearGradientBrush(ClientRectangle,
			                                                          Color.White,
			                                                          Color.DarkGray,
			                                                          LinearGradientMode.BackwardDiagonal))
			{
				graphics.FillEllipse(brush, center.X - radius, center.Y - radius, radius * 2, radius * 2);
			}
			
			// ������� �������� ��� ��������� ����� �����
			using (Pen pen = new Pen(Color.Black))
			{
				graphics.DrawEllipse(pen, center.X - radius, center.Y - radius, radius * 2, radius * 2);
			}

			// ������ �������� �������
			for (int minute = 0; minute < 60; minute++)
			{
				// ������� ��������������� ����� �� �����
				Point point = RadialPoint(radius - 10, minute);
				
				// ������� ����� ��� ������� �������
				using (SolidBrush brush = new SolidBrush(Color.Black))
				{
					// ���� ������� ������ ����...
					if (minute % 5 == 0)
						// ... �� ������ ������� �������������
						graphics.FillRectangle(brush, point.X - 3, point.Y - 3, 6, 6);
					else
						// ����� ������ ��������� �������������
						graphics.FillRectangle(brush, point.X - 1, point.Y - 1, 2, 2);
				}
			}
			
			// ������ ������� �������
			using (Pen pen = new Pen(Color.Black, 8))
			{
				// ������ ����� ������ ����� -- �����������
				pen.StartCap = LineCap.Triangle;
				
				// ������ ����� ���������� ����� -- � ���� �����
				pen.EndCap = LineCap.DiamondAnchor;
				
				// ������� ������ ����� -- '����� ������ - ������� ������ - ����� ������'
				float[] compVals = new float[] {0.0f, 0.1f, 0.35f, 0.65f, 0.9f, 1.0f};
				
				// ������ ��������� ������ �����
				pen.CompoundArray = compVals;
				
				// ������������ ������� �������
				graphics.DrawLine(pen,
				                  RadialPoint(15, 30 + time.Hour * 5 + time.Minute / 12),
				                  RadialPoint((int) (radius * 0.75), time.Hour * 5 + time.Minute / 12));
			}

			// ������ �������� �������
			using (Pen pen = new Pen(Color.FromArgb(150, 0, 0, 0), 6))
			{
				// ������ ����� ������ ����� -- �����������
				pen.StartCap = LineCap.Triangle;
				
				// ������ ����� ���������� ����� -- � ���� ������
				pen.EndCap = LineCap.RoundAnchor;
				
				// ������������ �������� �������
				graphics.DrawLine(pen,
				                  RadialPoint(15, 30 + time.Minute),
				                  RadialPoint((int) (radius * 0.8), time.Minute));
			}

			// ������ ��������� �������
			using(Pen pen = new Pen(Color.FromArgb(100, 20, 70, 80), 4))
			{
				// ������ ����� ������ ����� -- �����������
				pen.StartCap = LineCap.Triangle;
				
				// ������ ����� ���������� ����� -- ������������� �������
				pen.CustomEndCap = new AdjustableArrowCap(4, 5, true);
				
				// ������������ ��������� �������
				graphics.DrawLine(pen,
				                  RadialPoint(20, time.Second + 30),
				                  RadialPoint(radius - 12, time.Second));
			}		
		}
		
		/// <summary> ������������ '����' �������. </summary> 
		private void TimerTick(object sender, EventArgs e)
		{
			Refresh();
		}
	}
}
