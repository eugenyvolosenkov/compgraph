using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace Tutorial.Arcanoid
{
	/// <summary> ������� ����� ����������. </summary>
	public partial class MainForm : Form
	{
		#region Private Fields
		
		/// <summary> ������������� -- ������� �������� ����. </summary>
		private Rectangle areaRect = new Rectangle(20, 20, 600, 600);
		
		/// <summary> ������������� -- ��������� ��� ������. </summary>
		private Rectangle blockRect = new Rectangle(300, 595, 100, 22);		
		
		/// <summary> ����������� -- ���������� �����. </summary>
		private Bitmap ballImage = new Bitmap("..\\..\\football.gif");
		
		/// <summary> ������� ��������� ������. </summary>
		private Point ballPosition = new Point(300, 200);
		
		/// <summary> ������� ����������� ������. </summary>
		private Point ballVelocity = new Point(5, 4);		
		
		/// <summary> ������� ���� �������� ����������� ������. </summary>
		private int ballFrame = 0;
		
		/// <summary> ����� ��� ��������� ��������. </summary>
        private Font font = new Font("Arial", 48, FontStyle.Bold);

        /// <summary> ��������� ��������� ��������. </summary>
        private StringFormat stringFormat = new StringFormat();
        
        #endregion
		
        #region Constructor and Destructor
        
        /// <summary> ������� ������� ���� ����������. </summary> 
		public MainForm()
		{
			InitializeComponent();
			
			// ������������� ��������� ��������� �������� (������������ �� ������)
            stringFormat.Alignment = StringAlignment.Center;
            stringFormat.LineAlignment = StringAlignment.Center;			
		}
		
		#endregion
		
		#region Private Methods
		
		/// <summary> ������������ ��� ����. </summary> 
		private void DrawBackground(Graphics graphics)
		{
			// �������� ������� ����
            using (HatchBrush brush = new HatchBrush(HatchStyle.HorizontalBrick,
                                                     Color.LightGray, Color.White))
            {
                graphics.FillRectangle(brush, areaRect);
			}
			
			// ������ ��� �������
			using (Pen pen = new Pen(Color.DarkGray, 2))
            {
                graphics.DrawRectangle(pen, areaRect);
            }				
		}
		
		/// <summary> ������������ ���������. </summary> 
		private void DrawBlock(Graphics graphics)
		{
			// �������� ���������
			using (Brush brush = new LinearGradientBrush(blockRect,
			                                             Color.LightBlue, Color.SteelBlue,
			                                             LinearGradientMode.Vertical))
            {
                graphics.FillRectangle(brush, blockRect);
			}
			
			// ������ �� �������
			using (Pen pen = new Pen(Color.RoyalBlue, 2))
            {
                graphics.DrawRectangle(pen, blockRect);
            }	
		}
		
		/// <summary> ���������� ���������� ����������� ��� ��������� ����������� � �������. </summary> 
		private Point Reflect(Point incident, Point normal)
		{
			// ��������� ��������� ������������
			double dot = normal.X * incident.X + normal.Y * incident.Y;
			
			// ��������� ���������� �����������
			return new Point((int) (incident.X - 2.0 * dot * normal.X),
			                 (int) (incident.Y - 2.0 * dot * normal.Y));
		}
		
		/// <summary> ������������ ������������� ����������� ������. </summary> 
        private void PaintBall(Graphics graphics)
        {
            // ���� ����������� �� ������� ���������...
        	if (null == ballImage)
            {
        		// ... ������� ��������� �� ������
        		MessageBox.Show("������! �� ������� ��������� ����������� ����������� ����!");
        	}
        	else
        	{
        		// ��� ������?
        		if (!areaRect.Contains(ballPosition))
        		{
					// ������������ ������� � ������� ����������� �����
					using (LinearGradientBrush brush = new LinearGradientBrush(ClientRectangle,
					                                                           Color.Green, Color.Red,
					                                                           LinearGradientMode.BackwardDiagonal))
					{
					    graphics.DrawString("�� ���������!", font, brush, ClientRectangle, stringFormat);                                                          
					}
					
					return;
        		}        		
        		
        		// ������ ��������� ������ � ������������ � ������������ ��������
        		ballPosition.X += ballVelocity.X;
        		ballPosition.Y += ballVelocity.Y;
        		
        		// ��� ������� �� ������ ������?
        		if (ballPosition.X + ballImage.Width >= areaRect.Right)
        			ballVelocity = Reflect(ballVelocity, new Point(-1, 0));
        		
        		// ��� ������� �� ����� ������?
        		if (ballPosition.X <= areaRect.Left)
        			ballVelocity = Reflect(ballVelocity, new Point(1, 0));
        		
        		// ��� ������� �� �������?
        		if (ballPosition.Y <= areaRect.Top)
        			ballVelocity = Reflect(ballVelocity, new Point(0, 1));
        		
        		// ��� ������� �� ���������?
        		if (ballPosition.Y + ballImage.Height >= blockRect.Top)
        		{
        			// � ��������� ��������� �����?
        			if (ballPosition.X + ballImage.Width / 2 >= blockRect.Left)
        			{
        				if (ballPosition.X + ballImage.Width / 2 <= blockRect.Right)
        				{
        					ballVelocity = Reflect(ballVelocity, new Point(0, -1));
        				}
        			}
        		}
        		        		
	            // ������� ��������� ���� �������� (� ������ ������������)
	            ballFrame = (ballFrame + 1) % ballImage.GetFrameCount(FrameDimension.Time);
	           
	            // ������������� ����� ���� �������� 
	            ballImage.SelectActiveFrame(FrameDimension.Time, ballFrame);
	            
	            // ������������ ����������� ������
	            graphics.DrawImage(ballImage,
	                               ballPosition.X, ballPosition.Y,
	                               ballImage.Width, ballImage.Height);
        	}
        }		
		
        #endregion
        
        #region Event Handlers
        
        /// <summary> ������������ ����������� ������� ����. </summary> 
		private void MainFormMouseMove(object sender, MouseEventArgs e)
		{
			// ���� ��������� ���� ��������� � ������� ����...
			if (e.X >= areaRect.Left)
			{
				if (e.X <= areaRect.Right - blockRect.Width)
				{
					// ...������������� ����� ��������� ���������
					blockRect.X = e.X;
				}
			}
		}
		
		/// <summary> ������������ ���������� �������� ����. </summary> 
		private void MainFormPaint(object sender, PaintEventArgs e)
		{
			DrawBackground(e.Graphics);
			
			DrawBlock(e.Graphics);
			
			PaintBall(e.Graphics);
		}		
		
		/// <summary> ������������ '����' �������. </summary> 
		private void TimerTick(object sender, EventArgs e)
		{
			Invalidate();
		}
		
		#endregion
	}
}
