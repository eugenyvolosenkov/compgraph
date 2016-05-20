using System;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace Tutorial.ImageProcessing
{
	/// <summary> Главная форма приложения. </summary>
    public partial class MainForm : Form
    {
    	#region Private Fields
    	
        /// <summary> Изображение для обработки. </summary>
        Raster raster = new Raster("..\\..\\Images\\Image_1.jpg");
        
        /// <summary> Список предыдущих изображений для многошаговой отмены. </summary>
        ArrayList undolist = new ArrayList();

        #endregion
        
        #region Constructor and Destructor
        
        /// <summary> Создает главное окно приложения. </summary>
        public MainForm()
        {
            InitializeComponent();

            // отображаем изображение на экране
            ShowImage();
        }

        #endregion
        
        #region Private Methods
        
        /// <summary> Отображает растр в главном окне. </summary>
        private void ShowImage()
        {
        	// устанавливаем новое изображение для компонента PictureBox
            pictureBox.Image = raster.ToBitmap();

            // выполняем перерисовку компонента PictureBox
            pictureBox.Refresh();
        }
        
        /// <summary> Открывает графический файл. </summary>
        private void OpenImage()
        {
        	// создаем диалог для открытия файла
            OpenFileDialog dialog = new OpenFileDialog();

            dialog.Filter = "All Files (*.*) | *.*";

            // если пользователь выбрал файл...
            if (dialog.ShowDialog() == DialogResult.OK)
            {
            	// ...загружаем его
                raster = new Raster(dialog.FileName);

                // и отображаем на экране
                ShowImage();
                
                // очищаем список отмены предыдущего изображения
                undolist.Clear();
            }
        }
        
        /// <summary> Сохраняет изображение в графический файл. </summary>
        private void SaveImage()
        {
        	// создаем диалог для сохранения файла
            SaveFileDialog dialog = new SaveFileDialog();

            dialog.Filter = "All Files (*.*) | *.*";

            // если пользователь указал имя файла...
            if (dialog.ShowDialog() == DialogResult.OK)
            {
            	// ...сохраняем изображение в данный файл
                raster.Save(dialog.FileName);
            }
        }

        /// <summary> Применяет заданный фильтр к изображению. </summary>
        private void ApplyFilter(ImageFilter filter)
        {
            // сохраняем текущее изображение в списке отмены
            undolist.Add(raster);
            
            // получаем новое изображение (применяем фильтр)
        	raster = filter.ProcessImage(raster, menuItemHalf.Checked, backgroundWorker);

        	// отображаем новое изображение на экране
            ShowImage();
        }

        /// <summary> Отменяет последний примененный фильтр. </summary>
        private void UndoFilter()
        {        
        	// список пуст?
        	if (undolist.Count < 1)
        		return;
        	
            // излекаем предыдущее изображение из списка отмены...
            raster = (Raster) undolist[undolist.Count - 1];

            // ...и удаляем его из списка
            undolist.RemoveAt(undolist.Count - 1);
            
        	// отображаем изображение на экране
            ShowImage();
        }
        
        #endregion
        
        #region Event Handlers

        private void MenuItemUndoClick(object sender, EventArgs e)
        {
        	UndoFilter();
        }
        
        private void MenuItemInvertClick(object sender, EventArgs e)
        {
            ImageFilter filter = new InvertFilter();

            backgroundWorker.RunWorkerAsync(filter);
        }
    
        private void MenuItemIntensityClick(object sender, EventArgs e)
        {
            ImageFilter filter = new IntensityFilter();

            backgroundWorker.RunWorkerAsync(filter);          	
        }
        
        private void MenuItemSepiaClick(object sender, EventArgs e)
        {
        	ImageFilter filter = new SepiaFilter();

            backgroundWorker.RunWorkerAsync(filter);          	
        }
        
        private void MenuItemGrayscaleClick(object sender, EventArgs e)
        {
        	ImageFilter filter = new SepiaFilter(new Vector(1f, 1f, 1f));

            backgroundWorker.RunWorkerAsync(filter);            	
        }
        
        private void MenuItemGammaClick(object sender, EventArgs e)
        {
        	ImageFilter filter = new GammaCorrectionFilter();

            backgroundWorker.RunWorkerAsync(filter);          	
        }
        
        private void MenuItemSimpleBlurClick(object sender, EventArgs e)
        {
            ImageFilter filter = LinearFilter.SimpleBlurFilter(3);

            backgroundWorker.RunWorkerAsync(filter);
        }

        private void MenuItemGaussBlurClick(object sender, EventArgs e)
        {
            ImageFilter filter = LinearFilter.GaussBlurFilter(3, 2f);

             backgroundWorker.RunWorkerAsync(filter);
        }

        private void MenuItemLightContrastClick(object sender, EventArgs e)
        {
            ImageFilter filter = LinearFilter.LightContrastFilter();

            backgroundWorker.RunWorkerAsync(filter);
        }

        private void MenuItemHightContrastClick(object sender, EventArgs e)
        {
            ImageFilter filter = LinearFilter.HightContrastFilter();

            backgroundWorker.RunWorkerAsync(filter);
        }

        private void MenuItemPrewittClick(object sender, EventArgs e)
        {
            ImageFilter filter = LinearFilter.PrewittFilter();

            backgroundWorker.RunWorkerAsync(filter);        	
        }
        
        private void MenuItemSobelClick(object sender, EventArgs e)
        {
            ImageFilter filter = LinearFilter.SobelFilter();

            backgroundWorker.RunWorkerAsync(filter);         	
        }
        
        private void MenuItemLaplasClick(object sender, EventArgs e)
        {
            ImageFilter filter = LinearFilter.LaplasFilter();

            backgroundWorker.RunWorkerAsync(filter);          	
        }
        
        private void MenuItemGreyWorldClick(object sender, EventArgs e)
        {
        	ImageFilter filter = new GreyWorldFilter();

            backgroundWorker.RunWorkerAsync(filter);          	
        }
        
        private void MenuItemOpenClick(object sender, EventArgs e)
        {
        	OpenImage();
        }
        
        private void MenuItemSaveClick(object sender, EventArgs e)
        {
        	SaveImage();
        }
        
        private void MenuItemExitClick(object sender, EventArgs e)
        {
        	Close();
        }
        
        private void MenuItemHistogramClick(object sender, EventArgs e)
        {
        	HistogramDialog dialog = new HistogramDialog(raster);
        	
        	dialog.ShowDialog();
        }
        
        private void BackgroundWorkerProgressChanged(object sender, ProgressChangedEventArgs e)
        {
        	if (e.ProgressPercentage < progressBar.Maximum)
			{
				progressBar.Value = e.ProgressPercentage;
			}
			
			labelTime.Text = ((TimeSpan) e.UserState).ToString();
        }
        
        private void BackgroundWorkerDoWork(object sender, DoWorkEventArgs e)
        {
        	ApplyFilter((ImageFilter) e.Argument);
        }        
      
        #endregion
    }
}
