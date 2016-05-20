using System;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace Tutorial.ImageProcessing
{
	/// <summary> ������� ����� ����������. </summary>
    public partial class MainForm : Form
    {
    	#region Private Fields
    	
        /// <summary> ����������� ��� ���������. </summary>
        Raster raster = new Raster("..\\..\\Images\\Image_1.jpg");
        
        /// <summary> ������ ���������� ����������� ��� ������������ ������. </summary>
        ArrayList undolist = new ArrayList();

        #endregion
        
        #region Constructor and Destructor
        
        /// <summary> ������� ������� ���� ����������. </summary>
        public MainForm()
        {
            InitializeComponent();

            // ���������� ����������� �� ������
            ShowImage();
        }

        #endregion
        
        #region Private Methods
        
        /// <summary> ���������� ����� � ������� ����. </summary>
        private void ShowImage()
        {
        	// ������������� ����� ����������� ��� ���������� PictureBox
            pictureBox.Image = raster.ToBitmap();

            // ��������� ����������� ���������� PictureBox
            pictureBox.Refresh();
        }
        
        /// <summary> ��������� ����������� ����. </summary>
        private void OpenImage()
        {
        	// ������� ������ ��� �������� �����
            OpenFileDialog dialog = new OpenFileDialog();

            dialog.Filter = "All Files (*.*) | *.*";

            // ���� ������������ ������ ����...
            if (dialog.ShowDialog() == DialogResult.OK)
            {
            	// ...��������� ���
                raster = new Raster(dialog.FileName);

                // � ���������� �� ������
                ShowImage();
                
                // ������� ������ ������ ����������� �����������
                undolist.Clear();
            }
        }
        
        /// <summary> ��������� ����������� � ����������� ����. </summary>
        private void SaveImage()
        {
        	// ������� ������ ��� ���������� �����
            SaveFileDialog dialog = new SaveFileDialog();

            dialog.Filter = "All Files (*.*) | *.*";

            // ���� ������������ ������ ��� �����...
            if (dialog.ShowDialog() == DialogResult.OK)
            {
            	// ...��������� ����������� � ������ ����
                raster.Save(dialog.FileName);
            }
        }

        /// <summary> ��������� �������� ������ � �����������. </summary>
        private void ApplyFilter(ImageFilter filter)
        {
            // ��������� ������� ����������� � ������ ������
            undolist.Add(raster);
            
            // �������� ����� ����������� (��������� ������)
        	raster = filter.ProcessImage(raster, menuItemHalf.Checked, backgroundWorker);

        	// ���������� ����� ����������� �� ������
            ShowImage();
        }

        /// <summary> �������� ��������� ����������� ������. </summary>
        private void UndoFilter()
        {        
        	// ������ ����?
        	if (undolist.Count < 1)
        		return;
        	
            // �������� ���������� ����������� �� ������ ������...
            raster = (Raster) undolist[undolist.Count - 1];

            // ...� ������� ��� �� ������
            undolist.RemoveAt(undolist.Count - 1);
            
        	// ���������� ����������� �� ������
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
