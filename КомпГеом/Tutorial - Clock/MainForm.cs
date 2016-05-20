using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Tutorial.Clock
{
	/// <summary> Главная форма приложения. </summary>
	public partial class MainForm : Form
	{
		/// <summary> Создает главную форму приложения. </summary>
		public MainForm()
		{
			InitializeComponent();
		}
		
		/// <summary> Возвращает координаты точки по заданному времени. </summary>
		private Point RadialPoint(int radius, int tick)
		{
			// находим центр окна
			Point center = new Point(ClientRectangle.Width / 2,
			                         ClientRectangle.Height / 2);
					
			// находим угол отклонения стрелки от вертикали (в радианах)
			double angle = tick * Math.PI / 30;
			
			// находим соответствующую точку на круге
			Point point = new Point(center.X + (int) (radius * Math.Sin(angle)),
			                        center.Y - (int) (radius * Math.Cos(angle)));
			
			return point;
		}
		
		/// <summary> Отрисовывает содержимое главного окна. </summary> 
		private void MainFormPaint(object sender, PaintEventArgs e)
		{
			// получаем текущее время
			DateTime time = DateTime.Now;
			
			// получаем объект для рисования на поверхности окна
			Graphics graphics = e.Graphics;
			
			// включаем сглаживание линий
			graphics.SmoothingMode = SmoothingMode.HighQuality;
			
			// находим центральную точку окна
			Point center = new Point(ClientRectangle.Width / 2, ClientRectangle.Height / 2);
			
			// находим радиус круга часов как минимум из половины ширины и высоты
			int radius = Math.Min(ClientRectangle.Width, ClientRectangle.Height) / 2;
			
			// создаем кисть для градиентной заливки циферблата
			using (LinearGradientBrush brush = new LinearGradientBrush(ClientRectangle,
			                                                          Color.White,
			                                                          Color.DarkGray,
			                                                          LinearGradientMode.BackwardDiagonal))
			{
				graphics.FillEllipse(brush, center.X - radius, center.Y - radius, radius * 2, radius * 2);
			}
			
			// создаем карандаш для рисования круга часов
			using (Pen pen = new Pen(Color.Black))
			{
				graphics.DrawEllipse(pen, center.X - radius, center.Y - radius, radius * 2, radius * 2);
			}

			// рисуем минутные деления
			for (int minute = 0; minute < 60; minute++)
			{
				// находим соответствующую точку на круге
				Point point = RadialPoint(radius - 10, minute);
				
				// создаем кисть для заливки деления
				using (SolidBrush brush = new SolidBrush(Color.Black))
				{
					// если деление кратно пяти...
					if (minute % 5 == 0)
						// ... то рисуем большой прямоугольник
						graphics.FillRectangle(brush, point.X - 3, point.Y - 3, 6, 6);
					else
						// иначе рисуем маленький прямоугольник
						graphics.FillRectangle(brush, point.X - 1, point.Y - 1, 2, 2);
				}
			}
			
			// рисуем часовую стрелку
			using (Pen pen = new Pen(Color.Black, 8))
			{
				// задаем стиль начала линии -- треугольный
				pen.StartCap = LineCap.Triangle;
				
				// задаем стиль завершения линии -- в виде ромба
				pen.EndCap = LineCap.DiamondAnchor;
				
				// создаем шаблон линии -- 'узкая полоса - широкая полоса - узкая полоса'
				float[] compVals = new float[] {0.0f, 0.1f, 0.35f, 0.65f, 0.9f, 1.0f};
				
				// задаем карандашу шаблон линии
				pen.CompoundArray = compVals;
				
				// отрисовываем часовую стрелку
				graphics.DrawLine(pen,
				                  RadialPoint(15, 30 + time.Hour * 5 + time.Minute / 12),
				                  RadialPoint((int) (radius * 0.75), time.Hour * 5 + time.Minute / 12));
			}

			// рисуем минутную стрелку
			using (Pen pen = new Pen(Color.FromArgb(150, 0, 0, 0), 6))
			{
				// задаем стиль начала линии -- треугольный
				pen.StartCap = LineCap.Triangle;
				
				// задаем стиль завершения линии -- в виде кружка
				pen.EndCap = LineCap.RoundAnchor;
				
				// отрисовываем минутную стрелку
				graphics.DrawLine(pen,
				                  RadialPoint(15, 30 + time.Minute),
				                  RadialPoint((int) (radius * 0.8), time.Minute));
			}

			// рисуем секундную стрелку
			using(Pen pen = new Pen(Color.FromArgb(100, 20, 70, 80), 4))
			{
				// задаем стиль начала линии -- треугольный
				pen.StartCap = LineCap.Triangle;
				
				// задаем стиль завершения линии -- настраиваемая стрелка
				pen.CustomEndCap = new AdjustableArrowCap(4, 5, true);
				
				// отрисовываем секундную стрелку
				graphics.DrawLine(pen,
				                  RadialPoint(20, time.Second + 30),
				                  RadialPoint(radius - 12, time.Second));
			}		
		}
		
		/// <summary> Обрабатывает 'тики' таймера. </summary> 
		private void TimerTick(object sender, EventArgs e)
		{
			Refresh();
		}
	}
}
