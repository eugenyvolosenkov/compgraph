using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace Tutorial.Butterfly
{
	/// <summary> ������� ����� ����������. </summary>
	public partial class MainForm : Form
	{
		// ����������� �������
        private Bitmap butterflyImage = null;

        // ����������� ������
        private Bitmap flowerImage = null;
		
        // ��������� �������
        private Point butterflyPosition = new Point(0, 0);

        // ��������� ������
        private Point flowerPosition = new Point(200, 200);
        
        // ������� ���� �������� �������
        private int butterflyFrame = 0;
        
        // ����� ��� ��������� ��������
        private Font font = new Font("Arial", 18);

        // ��������� ��������� ��������
        private StringFormat stringFormat = new StringFormat();

        /// <summary> ������� ������� ���� ����������. </summary> 
		public MainForm()
		{
			InitializeComponent();
			
			// ��������� ����������� ������� � ������ �� ������
			butterflyImage = new Bitmap("..\\..\\Images\\Butterfly.gif");			
			flowerImage = new Bitmap("..\\..\\Images\\Flower.gif");
			
			// ������������� ��������� ��������� �������� (������������ �� ������)
            stringFormat.Alignment = StringAlignment.Center;
            stringFormat.LineAlignment = StringAlignment.Center;
		}
				
		/// <summary> ������������ ���������� �������� ����. </summary> 
		private void MainFormPaint(object sender, PaintEventArgs e)
		{
			// �������� ������ ��� ��������� �� ����������� ����
			Graphics graphics = e.Graphics;

			// ������������ ���
            PaintBackground(graphics, ClientRectangle);
            
            // ������������ ����������� ������
            PaintFlower(graphics, ClientRectangle);            
            
            // ������������ ����������� �������
            PaintButterfly(graphics, ClientRectangle);
		}

		/// <summary> ������������ ���. </summary> 
		private void PaintBackground(Graphics graphics, Rectangle rectangle)
        {
            string text = "������������ ������\n" +
            	          "� ����������� � ��������������\n" + 
            	          "������� ������� GIF";

            // ������ ���
            using (HatchBrush brush = new HatchBrush(HatchStyle.DottedDiamond,
                                                     Color.LightBlue,
                                                     Color.SteelBlue))
            {
                graphics.FillRectangle(brush, rectangle);
            }

            // ������ ������� ������ ����
            using (SolidBrush brush = new SolidBrush(Color.White))
            {
                graphics.DrawString(text, font, brush,
                                    new Point(rectangle.Width / 2, rectangle.Height / 2), stringFormat);
            }
        }

		/// <summary> ������������ ������������� ����������� �������. </summary> 
        private void PaintButterfly(Graphics graphics, Rectangle rectangle)
        {
            // ���� ����������� �� ������� ���������...
        	if (null == butterflyImage)
            {
        		// ... ������� ��������� �� ������
                using (SolidBrush brush = new SolidBrush(Color.FromArgb(180, 0, 0, 255)))
                {
                    graphics.DrawString("Butterfly image load error", font, brush,
                                        new Point(rectangle.Width / 2, 20), stringFormat);
                }
        	}
        	else
        	{
	        	// ���� ������ ��������� ������ �������...
	            if (flowerPosition.X - butterflyPosition.X > 0)
	            	// ...���������� ������� �� ���� ������� ������
	                butterflyPosition.X++;
	            else
	            	// ����� ���������� ������� �� ���� ������� �����
	                butterflyPosition.X--;
	
	            // ���� ������ ��������� ���� �������...
	            if (flowerPosition.Y - butterflyPosition.Y > 0)
	            	// ...���������� ������� �� ���� ������� ����
	                butterflyPosition.Y++;
	            else
	            	// ����� ���������� ������� �� ���� ������� �����
	                butterflyPosition.Y--;
	            
	            // ������� ��������� ���� �������� (� ������ ������������)
	            butterflyFrame = (butterflyFrame + 1) % butterflyImage.GetFrameCount(FrameDimension.Time);
	           
	            // ������������� ����� ���� �������� 
	            butterflyImage.SelectActiveFrame(FrameDimension.Time, butterflyFrame);
	            
	            // ������������ ����������� �������
	            graphics.DrawImage(butterflyImage,
	                               butterflyPosition.X, butterflyPosition.Y,
	                               butterflyImage.Width, butterflyImage.Height);
        	}
        }

        /// <summary> ������������ ����������� ������. </summary> 
        private void PaintFlower(Graphics graphics, Rectangle rectangle)
        {
        	// ���� ����������� �� ������� ���������...
            if (null == flowerImage)
            {
            	// ... ������� ��������� �� ������
                using (SolidBrush brush = new SolidBrush(Color.FromArgb(180, 0, 0, 255)))
                {
                    graphics.DrawString("Flower image load error", font, brush,
                                        new Point(rectangle.Width / 2, rectangle.Height - 20),
                                        stringFormat);
                }
            }
            else
            {	            
	            // ������������ ����������� ������
	            graphics.DrawImage(flowerImage,
	                               flowerPosition.X, flowerPosition.Y,
	                               flowerImage.Width, flowerImage.Height);
            }
        }

        /// <summary> ������������ ����������� ����. </summary> 
        private void MainFormMouseMove(object sender, MouseEventArgs e)
		{
        	// ������������� ����� ��������� ������
			flowerPosition = e.Location;
		}
        
        /// <summary> ������������ '����' �������. </summary> 
		private void TimerTick(object sender, EventArgs e)
		{
			// ��������� ������� ���� ����������
			Refresh();
		}
	}
}
