using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace Tutorial.Arcanoid
{
	/// <summary> Главная форма приложения. </summary>
	public partial class MainForm : Form
	{
		#region Private Fields
		
		/// <summary> Прямоугольник -- границы игрового поля. </summary>
		private Rectangle areaRect = new Rectangle(20, 20, 600, 600);
		
		/// <summary> Прямоугольник -- подставка для мячика. </summary>
		private Rectangle blockRect = new Rectangle(300, 595, 100, 22);		
		
		/// <summary> Изображение -- футбольный мячик. </summary>
		private Bitmap ballImage = new Bitmap("..\\..\\football.gif");
		
		/// <summary> Текущее положение мячика. </summary>
		private Point ballPosition = new Point(300, 200);
		
		/// <summary> Текущее направление мячика. </summary>
		private Point ballVelocity = new Point(5, 4);		
		
		/// <summary> Текущий кадр анимации футбольного мячика. </summary>
		private int ballFrame = 0;
		
		/// <summary> Шрифт для рисования надписей. </summary>
        private Font font = new Font("Arial", 48, FontStyle.Bold);

        /// <summary> Параметры рисования надписей. </summary>
        private StringFormat stringFormat = new StringFormat();
        
        #endregion
		
        #region Constructor and Destructor
        
        /// <summary> Создает главное окно приложения. </summary> 
		public MainForm()
		{
			InitializeComponent();
			
			// устанавливаем параметры рисования надписей (выравнивание по центру)
            stringFormat.Alignment = StringAlignment.Center;
            stringFormat.LineAlignment = StringAlignment.Center;			
		}
		
		#endregion
		
		#region Private Methods
		
		/// <summary> Отрисовывает фон игры. </summary> 
		private void DrawBackground(Graphics graphics)
		{
			// заливаем игровое поле
            using (HatchBrush brush = new HatchBrush(HatchStyle.HorizontalBrick,
                                                     Color.LightGray, Color.White))
            {
                graphics.FillRectangle(brush, areaRect);
			}
			
			// рисуем его границу
			using (Pen pen = new Pen(Color.DarkGray, 2))
            {
                graphics.DrawRectangle(pen, areaRect);
            }				
		}
		
		/// <summary> Отрисовывает подставку. </summary> 
		private void DrawBlock(Graphics graphics)
		{
			// заливаем подставку
			using (Brush brush = new LinearGradientBrush(blockRect,
			                                             Color.LightBlue, Color.SteelBlue,
			                                             LinearGradientMode.Vertical))
            {
                graphics.FillRectangle(brush, blockRect);
			}
			
			// рисуем ее границу
			using (Pen pen = new Pen(Color.RoyalBlue, 2))
            {
                graphics.DrawRectangle(pen, blockRect);
            }	
		}
		
		/// <summary> Возвращает отраженное направление для заданного направления и нормали. </summary> 
		private Point Reflect(Point incident, Point normal)
		{
			// вычисляем скалярное произведение
			double dot = normal.X * incident.X + normal.Y * incident.Y;
			
			// вычисляем отраженное направление
			return new Point((int) (incident.X - 2.0 * dot * normal.X),
			                 (int) (incident.Y - 2.0 * dot * normal.Y));
		}
		
		/// <summary> Отрисовывает анимированное изображение мячика. </summary> 
        private void PaintBall(Graphics graphics)
        {
            // если изображение не удалось загрузить...
        	if (null == ballImage)
            {
        		// ... выводим сообщение об ошибке
        		MessageBox.Show("Ошибка! Не удалось загрузить изображение футбольного мяча!");
        	}
        	else
        	{
        		// мяч улетел?
        		if (!areaRect.Contains(ballPosition))
        		{
					// отрисовываем надпись с помощью градиентной кисти
					using (LinearGradientBrush brush = new LinearGradientBrush(ClientRectangle,
					                                                           Color.Green, Color.Red,
					                                                           LinearGradientMode.BackwardDiagonal))
					{
					    graphics.DrawString("Вы проиграли!", font, brush, ClientRectangle, stringFormat);                                                          
					}
					
					return;
        		}        		
        		
        		// меняем положение мячика в соответствии с направлением движения
        		ballPosition.X += ballVelocity.X;
        		ballPosition.Y += ballVelocity.Y;
        		
        		// мяч долетел до правой стенки?
        		if (ballPosition.X + ballImage.Width >= areaRect.Right)
        			ballVelocity = Reflect(ballVelocity, new Point(-1, 0));
        		
        		// мяч долетел до левой стенки?
        		if (ballPosition.X <= areaRect.Left)
        			ballVelocity = Reflect(ballVelocity, new Point(1, 0));
        		
        		// мяч долетел до потолка?
        		if (ballPosition.Y <= areaRect.Top)
        			ballVelocity = Reflect(ballVelocity, new Point(0, 1));
        		
        		// мяч долетел до подставки?
        		if (ballPosition.Y + ballImage.Height >= blockRect.Top)
        		{
        			// а подставка оказалась рядом?
        			if (ballPosition.X + ballImage.Width / 2 >= blockRect.Left)
        			{
        				if (ballPosition.X + ballImage.Width / 2 <= blockRect.Right)
        				{
        					ballVelocity = Reflect(ballVelocity, new Point(0, -1));
        				}
        			}
        		}
        		        		
	            // находим следующий кадр анимации (с учетом зацикливания)
	            ballFrame = (ballFrame + 1) % ballImage.GetFrameCount(FrameDimension.Time);
	           
	            // устанавливаем новый кадр анимации 
	            ballImage.SelectActiveFrame(FrameDimension.Time, ballFrame);
	            
	            // отрисовываем изображение мячика
	            graphics.DrawImage(ballImage,
	                               ballPosition.X, ballPosition.Y,
	                               ballImage.Width, ballImage.Height);
        	}
        }		
		
        #endregion
        
        #region Event Handlers
        
        /// <summary> Обрабатывает перемещение курсора мыши. </summary> 
		private void MainFormMouseMove(object sender, MouseEventArgs e)
		{
			// если указатель мыши находится в игровом поле...
			if (e.X >= areaRect.Left)
			{
				if (e.X <= areaRect.Right - blockRect.Width)
				{
					// ...устанавливаем новое положение подставки
					blockRect.X = e.X;
				}
			}
		}
		
		/// <summary> Отрисовывает содержимое главного окна. </summary> 
		private void MainFormPaint(object sender, PaintEventArgs e)
		{
			DrawBackground(e.Graphics);
			
			DrawBlock(e.Graphics);
			
			PaintBall(e.Graphics);
		}		
		
		/// <summary> Обрабатывает 'тики' таймера. </summary> 
		private void TimerTick(object sender, EventArgs e)
		{
			Invalidate();
		}
		
		#endregion
	}
}
