using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace Tutorial.Butterfly
{
	/// <summary> Главная форма приложения. </summary>
	public partial class MainForm : Form
	{
		// изображение бабочки
        private Bitmap butterflyImage = null;

        // изображение цветка
        private Bitmap flowerImage = null;
		
        // положение бабочки
        private Point butterflyPosition = new Point(0, 0);

        // положение цветка
        private Point flowerPosition = new Point(200, 200);
        
        // текущий кадр анимации бабочки
        private int butterflyFrame = 0;
        
        // шрифт для рисования надписей
        private Font font = new Font("Arial", 18);

        // параметры рисования надписей
        private StringFormat stringFormat = new StringFormat();

        /// <summary> Создает главное окно приложения. </summary> 
		public MainForm()
		{
			InitializeComponent();
			
			// загружаем изображения бабочки и цветка из файлов
			butterflyImage = new Bitmap("..\\..\\Images\\Butterfly.gif");			
			flowerImage = new Bitmap("..\\..\\Images\\Flower.gif");
			
			// устанавливаем параметры рисования надписей (выравнивание по центру)
            stringFormat.Alignment = StringAlignment.Center;
            stringFormat.LineAlignment = StringAlignment.Center;
		}
				
		/// <summary> Отрисовывает содержимое главного окна. </summary> 
		private void MainFormPaint(object sender, PaintEventArgs e)
		{
			// получаем объект для рисования на поверхности окна
			Graphics graphics = e.Graphics;

			// отрисовываем фон
            PaintBackground(graphics, ClientRectangle);
            
            // отрисовываем изображение цветка
            PaintFlower(graphics, ClientRectangle);            
            
            // отрисовываем изображение бабочки
            PaintButterfly(graphics, ClientRectangle);
		}

		/// <summary> Отрисовывает фон. </summary> 
		private void PaintBackground(Graphics graphics, Rectangle rectangle)
        {
            string text = "Демонстрация работы\n" +
            	          "с прозрачными и анимированными\n" + 
            	          "файлами формата GIF";

            // рисуем фон
            using (HatchBrush brush = new HatchBrush(HatchStyle.DottedDiamond,
                                                     Color.LightBlue,
                                                     Color.SteelBlue))
            {
                graphics.FillRectangle(brush, rectangle);
            }

            // рисуем надпись поверх фона
            using (SolidBrush brush = new SolidBrush(Color.White))
            {
                graphics.DrawString(text, font, brush,
                                    new Point(rectangle.Width / 2, rectangle.Height / 2), stringFormat);
            }
        }

		/// <summary> Отрисовывает анимированное изображение бабочки. </summary> 
        private void PaintButterfly(Graphics graphics, Rectangle rectangle)
        {
            // если изображение не удалось загрузить...
        	if (null == butterflyImage)
            {
        		// ... выводим сообщение об ошибке
                using (SolidBrush brush = new SolidBrush(Color.FromArgb(180, 0, 0, 255)))
                {
                    graphics.DrawString("Butterfly image load error", font, brush,
                                        new Point(rectangle.Width / 2, 20), stringFormat);
                }
        	}
        	else
        	{
	        	// если цветок находится правее бабочки...
	            if (flowerPosition.X - butterflyPosition.X > 0)
	            	// ...перемещаем бабочку на один пиксель вправо
	                butterflyPosition.X++;
	            else
	            	// иначе перемещаем бабочку на один пиксель влево
	                butterflyPosition.X--;
	
	            // если цветок находится ниже бабочки...
	            if (flowerPosition.Y - butterflyPosition.Y > 0)
	            	// ...перемещаем бабочку на один пиксель вниз
	                butterflyPosition.Y++;
	            else
	            	// иначе перемещаем бабочку на один пиксель вверх
	                butterflyPosition.Y--;
	            
	            // находим следующий кадр анимации (с учетом зацикливания)
	            butterflyFrame = (butterflyFrame + 1) % butterflyImage.GetFrameCount(FrameDimension.Time);
	           
	            // устанавливаем новый кадр анимации 
	            butterflyImage.SelectActiveFrame(FrameDimension.Time, butterflyFrame);
	            
	            // отрисовываем изображение бабочки
	            graphics.DrawImage(butterflyImage,
	                               butterflyPosition.X, butterflyPosition.Y,
	                               butterflyImage.Width, butterflyImage.Height);
        	}
        }

        /// <summary> Отрисовывает изображение цветка. </summary> 
        private void PaintFlower(Graphics graphics, Rectangle rectangle)
        {
        	// если изображение не удалось загрузить...
            if (null == flowerImage)
            {
            	// ... выводим сообщение об ошибке
                using (SolidBrush brush = new SolidBrush(Color.FromArgb(180, 0, 0, 255)))
                {
                    graphics.DrawString("Flower image load error", font, brush,
                                        new Point(rectangle.Width / 2, rectangle.Height - 20),
                                        stringFormat);
                }
            }
            else
            {	            
	            // отрисовываем изображение цветка
	            graphics.DrawImage(flowerImage,
	                               flowerPosition.X, flowerPosition.Y,
	                               flowerImage.Width, flowerImage.Height);
            }
        }

        /// <summary> Обрабатывает перемещение мыши. </summary> 
        private void MainFormMouseMove(object sender, MouseEventArgs e)
		{
        	// устанавливаем новое положение цветка
			flowerPosition = e.Location;
		}
        
        /// <summary> Обрабатывает 'тики' таймера. </summary> 
		private void TimerTick(object sender, EventArgs e)
		{
			// обновляем главное окно приложения
			Refresh();
		}
	}
}
