using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Tutorial.Curves
{
	/// <summary> √лавна€ форма приложени€. </summary>
	public partial class MainForm : Form
	{
		// контрольные точки дл€ рисовани€ кривых
		private Point [] points = null;
		
		// номер выделенной точки
		private int selectIndex = 0;
		
		/// <summary> —оздает главное окно приложени€. </summary> 
		public MainForm()
		{
			InitializeComponent();
			
			// устанавливаем контрольные точки по умолчанию
			points = new Point [] {new Point(100, 250), new Point(200, 150),
				                   new Point(300, 350), new Point(400, 250)};
		}
		
		/// <summary> –исует кубический сплайн. </summary> 
		private void DrawSpline(Graphics graphics)
		{
		    // устанавливаем сглаживание линий
			graphics.SmoothingMode = SmoothingMode.HighQuality;
		    
			// создаем карандаш дл€ рисовани€ кривой
		    using (Pen pen = new Pen(Color.Blue, 2))
		    {
		    	// рисуем кубический сплайн средствами GDI+
		    	graphics.DrawCurve(pen, points);
		    }
		}
		
		/// <summary> –исует кривую Ѕезье. </summary> 
		private void DrawBezier(Graphics graphics)
		{
			// устанавливаем сглаживание линий
		    graphics.SmoothingMode = SmoothingMode.HighQuality;
		    
		    // создаем карандаш дл€ рисовани€ контрольных отрезков
		    using (Pen pen = new Pen(Color.Gray, 1))
		    {
		    	// рисуем контрольные отрезки кривой Ѕезье
			    graphics.DrawLine(pen, points[0], points[1]);
			    graphics.DrawLine(pen, points[2], points[3]);
		    }
		    		  
		    // создаем карандаш дл€ рисовани€ кривой
		    using (Pen pen = new Pen(Color.Blue, 2))
		    {
		    	// рисуем кривую Ѕезье средствами GDI+
			    graphics.DrawBezier(pen,
		    	                    points[0], points[1],
		    	                    points[2], points[3]);
		    }
		}
		
		/// <summary> –исует контрольные точки. </summary> 
		private void DrawPoints(Graphics graphics)
		{
			// размер кружков контрольных точек
			int size = 5;
			
		    for (int i = 0; i < points.Length; i++)
		    {
		    	// если контрольна€ точка выделена...
		    	if (selectIndex == i)
		    	{
		    		// ...рисуем ее красным карандашом
				    using (Pen pen = new Pen(Color.Red, 3))
				    {
				    	graphics.DrawEllipse(pen,
				    	                     points[i].X - size / 2, points[i].Y - size / 2,
				    	                     size, size);
				    }		    	   
		    	}
		    	else
		    	{
		    		// иначе рисуем ее зеленым карандашом
				    using (Pen pen = new Pen(Color.Green, 3))
				    {
				    	graphics.DrawEllipse(pen,
				    	                     points[i].X - size / 2, points[i].Y - size / 2,
				    	                     size, size);
				    }			    		
		    	}
		    }			
		}
		
		/// <summary> ќтрисовывает содержимое главного окна. </summary> 
		private void MainFormPaint(object sender, PaintEventArgs e)
		{
			// получаем объект дл€ рисовани€ на панели
			Graphics graphics = e.Graphics;
			
			// рисуем выбранную кривую
			if (menuItemSpline.Checked)
			{
				DrawSpline(graphics);
			}
			else
			{
				DrawBezier(graphics);
			}
			
			// рисуем контрольные точки поверх кривой
			DrawPoints(graphics);
		}
		
		/// <summary> ќбрабатывает перемещение мыши. </summary>
		private void MainFormMouseMove(object sender, MouseEventArgs e)
		{
		    // перебираем все контрольные точки
			for (int i = 0; i < points.Length; i++)
		    {
				// если указатель мыши попал в окрестность точки...
		    	if (Math.Abs(points[i].X - e.X) < 4)
		    	{
		    	    if (Math.Abs(points[i].Y - e.Y) < 4)
		        	{
		            	// ...выдел€ем данную точку
		    	    	selectIndex = i;
		            	break;
		    	    }
		    	}
		    }
		    
			// если нажата лева€ кнопка мыши...
		    if (MouseButtons.Left == e.Button)
		    {
		        // ...перемещаем выделенную контрольную точку
		    	points[selectIndex] = e.Location;
		    }
		    
		    // перерисовываем главное окно
		    Invalidate();
		}

		/// <summary> ¬ыбирает тип кривой ' рива€ Ѕезье'. </summary>
		private void MenuItemBezierClick(object sender, EventArgs e)
		{
			menuItemBezier.Checked = true;
			menuItemSpline.Checked = false;
		}
		
		/// <summary> ¬ыбирает тип кривой ' убический —плайн'. </summary>
		private void MenuItemSplineClick(object sender, EventArgs e)
		{
			menuItemBezier.Checked = false;
			menuItemSpline.Checked = true;			
		}
	}
}
