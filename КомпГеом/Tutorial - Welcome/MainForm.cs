using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Tutorial.Arcanoid
{
	/// <summary> Главная форма приложения. </summary>
	public partial class MainForm : Form
	{
        // изображение фона
        Bitmap backgroundImage =  new Bitmap("..\\..\\Images\\backgrnd.gif");  
		
		// шрифт для рисования надписей
        private Font font = new Font("Arial", 48, FontStyle.Bold);

        // параметры рисования надписей
        private StringFormat stringFormat = new StringFormat();
        
        /// <summary> Создает главное окно приложения. </summary> 
		public MainForm()
		{
			InitializeComponent();
			
			// устанавливаем параметры рисования надписей (выравнивание по центру)
            stringFormat.Alignment = StringAlignment.Center;
            stringFormat.LineAlignment = StringAlignment.Center;
		}
		
		/// <summary> Отрисовывает содержимое главного окна. </summary> 
		private void MainFormPaint(object sender, PaintEventArgs e)
		{
			// получаем объект для рисования на поверхности окна
			Graphics graphics = e.Graphics;	
			
			// отрисовываем фоновый рисунок
			graphics.DrawImage(backgroundImage, ClientRectangle);
			
			// надпись для рисования
			string welcome = "Welcome, GDI+!";
			
			// отрисовываем надпись с помощью градиентной кисти
			using (LinearGradientBrush brush =
			                new LinearGradientBrush(ClientRectangle,
			                                        Color.FromArgb(130, 255, 0, 0),
			                                        Color.FromArgb(255, 0, 0, 255),
			                                        LinearGradientMode.BackwardDiagonal))
			{
			    graphics.DrawString(welcome, font, brush, ClientRectangle, stringFormat);                                                          
			}	                                                           
		}
		
		/// <summary> Обрабатывает изменение размера главного окна. </summary> 
		private void MainFormResize(object sender, EventArgs e)
		{
			Invalidate();
		}
	}
}
