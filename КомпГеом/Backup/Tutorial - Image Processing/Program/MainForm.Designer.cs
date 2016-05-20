namespace Tutorial.ImageProcessing
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
        	this.menuStrip = new System.Windows.Forms.MenuStrip();
        	this.menuItemFile = new System.Windows.Forms.ToolStripMenuItem();
        	this.menuItemOpen = new System.Windows.Forms.ToolStripMenuItem();
        	this.menuItemSave = new System.Windows.Forms.ToolStripMenuItem();
        	this.menuItemSaveSeparator = new System.Windows.Forms.ToolStripSeparator();
        	this.menuItemExit = new System.Windows.Forms.ToolStripMenuItem();
        	this.menuItemEdit = new System.Windows.Forms.ToolStripMenuItem();
        	this.menuItemUndo = new System.Windows.Forms.ToolStripMenuItem();
        	this.menuItemUndoSeparator = new System.Windows.Forms.ToolStripSeparator();
        	this.menuItemHalf = new System.Windows.Forms.ToolStripMenuItem();
        	this.menuItemHalfSeparator = new System.Windows.Forms.ToolStripSeparator();
        	this.menuItemDotFilters = new System.Windows.Forms.ToolStripMenuItem();
        	this.menuItemInvert = new System.Windows.Forms.ToolStripMenuItem();
        	this.menuItemIntensity = new System.Windows.Forms.ToolStripMenuItem();
        	this.menuItemGrayscale = new System.Windows.Forms.ToolStripMenuItem();
        	this.menuItemGamma = new System.Windows.Forms.ToolStripMenuItem();
        	this.menuItemSepia = new System.Windows.Forms.ToolStripMenuItem();
        	this.menuItemMatrixFilters = new System.Windows.Forms.ToolStripMenuItem();
        	this.menuItemBlurFilters = new System.Windows.Forms.ToolStripMenuItem();
        	this.menuItemSimpleBlur = new System.Windows.Forms.ToolStripMenuItem();
        	this.menuItemGaussBlur = new System.Windows.Forms.ToolStripMenuItem();
        	this.menuItemContrastFilters = new System.Windows.Forms.ToolStripMenuItem();
        	this.menuItemLightContrast = new System.Windows.Forms.ToolStripMenuItem();
        	this.menuItemHightContrast = new System.Windows.Forms.ToolStripMenuItem();
        	this.menuItemEdgeFilters = new System.Windows.Forms.ToolStripMenuItem();
        	this.menuItemPrewitt = new System.Windows.Forms.ToolStripMenuItem();
        	this.menuItemSobel = new System.Windows.Forms.ToolStripMenuItem();
        	this.menuItemLaplas = new System.Windows.Forms.ToolStripMenuItem();
        	this.menuItemCorrectionFilters = new System.Windows.Forms.ToolStripMenuItem();
        	this.menuItemGreyWorld = new System.Windows.Forms.ToolStripMenuItem();
        	this.menuItemHistogramSeparator = new System.Windows.Forms.ToolStripSeparator();
        	this.menuItemHistogram = new System.Windows.Forms.ToolStripMenuItem();
        	this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
        	this.panelBottom = new System.Windows.Forms.Panel();
        	this.progressBar = new System.Windows.Forms.ProgressBar();
        	this.labelTime = new System.Windows.Forms.Label();
        	this.pictureBox = new System.Windows.Forms.PictureBox();
        	this.menuStrip.SuspendLayout();
        	this.panelBottom.SuspendLayout();
        	((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
        	this.SuspendLayout();
        	// 
        	// menuStrip
        	// 
        	this.menuStrip.BackColor = System.Drawing.SystemColors.ActiveBorder;
        	this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
        	        	        	this.menuItemFile,
        	        	        	this.menuItemEdit});
        	this.menuStrip.Location = new System.Drawing.Point(0, 0);
        	this.menuStrip.Name = "menuStrip";
        	this.menuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
        	this.menuStrip.Size = new System.Drawing.Size(802, 24);
        	this.menuStrip.TabIndex = 2;
        	// 
        	// menuItemFile
        	// 
        	this.menuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
        	        	        	this.menuItemOpen,
        	        	        	this.menuItemSave,
        	        	        	this.menuItemSaveSeparator,
        	        	        	this.menuItemExit});
        	this.menuItemFile.Name = "menuItemFile";
        	this.menuItemFile.Size = new System.Drawing.Size(45, 20);
        	this.menuItemFile.Text = "Файл";
        	// 
        	// menuItemOpen
        	// 
        	this.menuItemOpen.Name = "menuItemOpen";
        	this.menuItemOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
        	this.menuItemOpen.Size = new System.Drawing.Size(167, 22);
        	this.menuItemOpen.Text = "Открыть";
        	this.menuItemOpen.Click += new System.EventHandler(this.MenuItemOpenClick);
        	// 
        	// menuItemSave
        	// 
        	this.menuItemSave.Name = "menuItemSave";
        	this.menuItemSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
        	this.menuItemSave.Size = new System.Drawing.Size(167, 22);
        	this.menuItemSave.Text = "Сохранить";
        	this.menuItemSave.Click += new System.EventHandler(this.MenuItemSaveClick);
        	// 
        	// menuItemSaveSeparator
        	// 
        	this.menuItemSaveSeparator.Name = "menuItemSaveSeparator";
        	this.menuItemSaveSeparator.Size = new System.Drawing.Size(164, 6);
        	// 
        	// menuItemExit
        	// 
        	this.menuItemExit.Name = "menuItemExit";
        	this.menuItemExit.Size = new System.Drawing.Size(167, 22);
        	this.menuItemExit.Text = "Выход";
        	this.menuItemExit.Click += new System.EventHandler(this.MenuItemExitClick);
        	// 
        	// menuItemEdit
        	// 
        	this.menuItemEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
        	        	        	this.menuItemUndo,
        	        	        	this.menuItemUndoSeparator,
        	        	        	this.menuItemHalf,
        	        	        	this.menuItemHalfSeparator,
        	        	        	this.menuItemDotFilters,
        	        	        	this.menuItemMatrixFilters,
        	        	        	this.menuItemHistogramSeparator,
        	        	        	this.menuItemHistogram});
        	this.menuItemEdit.Name = "menuItemEdit";
        	this.menuItemEdit.Size = new System.Drawing.Size(56, 20);
        	this.menuItemEdit.Text = "Правка";
        	// 
        	// menuItemUndo
        	// 
        	this.menuItemUndo.Name = "menuItemUndo";
        	this.menuItemUndo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
        	this.menuItemUndo.Size = new System.Drawing.Size(243, 22);
        	this.menuItemUndo.Text = "Отменить";
        	this.menuItemUndo.Click += new System.EventHandler(this.MenuItemUndoClick);
        	// 
        	// menuItemUndoSeparator
        	// 
        	this.menuItemUndoSeparator.Name = "menuItemUndoSeparator";
        	this.menuItemUndoSeparator.Size = new System.Drawing.Size(240, 6);
        	// 
        	// menuItemHalf
        	// 
        	this.menuItemHalf.Checked = true;
        	this.menuItemHalf.CheckOnClick = true;
        	this.menuItemHalf.CheckState = System.Windows.Forms.CheckState.Checked;
        	this.menuItemHalf.Name = "menuItemHalf";
        	this.menuItemHalf.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
        	this.menuItemHalf.Size = new System.Drawing.Size(243, 22);
        	this.menuItemHalf.Text = "Редактировать половину";
        	// 
        	// menuItemHalfSeparator
        	// 
        	this.menuItemHalfSeparator.Name = "menuItemHalfSeparator";
        	this.menuItemHalfSeparator.Size = new System.Drawing.Size(240, 6);
        	// 
        	// menuItemDotFilters
        	// 
        	this.menuItemDotFilters.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
        	        	        	this.menuItemInvert,
        	        	        	this.menuItemIntensity,
        	        	        	this.menuItemGrayscale,
        	        	        	this.menuItemGamma,
        	        	        	this.menuItemSepia});
        	this.menuItemDotFilters.Name = "menuItemDotFilters";
        	this.menuItemDotFilters.Size = new System.Drawing.Size(243, 22);
        	this.menuItemDotFilters.Text = "Точечные фильтры";
        	// 
        	// menuItemInvert
        	// 
        	this.menuItemInvert.Name = "menuItemInvert";
        	this.menuItemInvert.Size = new System.Drawing.Size(219, 22);
        	this.menuItemInvert.Text = "Инвертировать цвета";
        	this.menuItemInvert.Click += new System.EventHandler(this.MenuItemInvertClick);
        	// 
        	// menuItemIntensity
        	// 
        	this.menuItemIntensity.Name = "menuItemIntensity";
        	this.menuItemIntensity.Size = new System.Drawing.Size(219, 22);
        	this.menuItemIntensity.Text = "Увеличить яркость";
        	this.menuItemIntensity.Click += new System.EventHandler(this.MenuItemIntensityClick);
        	// 
        	// menuItemGrayscale
        	// 
        	this.menuItemGrayscale.Name = "menuItemGrayscale";
        	this.menuItemGrayscale.Size = new System.Drawing.Size(219, 22);
        	this.menuItemGrayscale.Text = "Привести к оттенкам серого";
        	this.menuItemGrayscale.Click += new System.EventHandler(this.MenuItemGrayscaleClick);
        	// 
        	// menuItemGamma
        	// 
        	this.menuItemGamma.Name = "menuItemGamma";
        	this.menuItemGamma.Size = new System.Drawing.Size(219, 22);
        	this.menuItemGamma.Text = "Гамма-коррекция";
        	this.menuItemGamma.Click += new System.EventHandler(this.MenuItemGammaClick);
        	// 
        	// menuItemSepia
        	// 
        	this.menuItemSepia.Name = "menuItemSepia";
        	this.menuItemSepia.Size = new System.Drawing.Size(219, 22);
        	this.menuItemSepia.Text = "Фильтр Сепия";
        	this.menuItemSepia.Click += new System.EventHandler(this.MenuItemSepiaClick);
        	// 
        	// menuItemMatrixFilters
        	// 
        	this.menuItemMatrixFilters.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
        	        	        	this.menuItemBlurFilters,
        	        	        	this.menuItemContrastFilters,
        	        	        	this.menuItemEdgeFilters,
        	        	        	this.menuItemCorrectionFilters});
        	this.menuItemMatrixFilters.Name = "menuItemMatrixFilters";
        	this.menuItemMatrixFilters.Size = new System.Drawing.Size(243, 22);
        	this.menuItemMatrixFilters.Text = "Матричные фильтры";
        	// 
        	// menuItemBlurFilters
        	// 
        	this.menuItemBlurFilters.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
        	        	        	this.menuItemSimpleBlur,
        	        	        	this.menuItemGaussBlur});
        	this.menuItemBlurFilters.Name = "menuItemBlurFilters";
        	this.menuItemBlurFilters.Size = new System.Drawing.Size(247, 22);
        	this.menuItemBlurFilters.Text = "Сглаживающие фильтры";
        	// 
        	// menuItemSimpleBlur
        	// 
        	this.menuItemSimpleBlur.Name = "menuItemSimpleBlur";
        	this.menuItemSimpleBlur.Size = new System.Drawing.Size(206, 22);
        	this.menuItemSimpleBlur.Text = "Простое сглаживание";
        	this.menuItemSimpleBlur.Click += new System.EventHandler(this.MenuItemSimpleBlurClick);
        	// 
        	// menuItemGaussBlur
        	// 
        	this.menuItemGaussBlur.Name = "menuItemGaussBlur";
        	this.menuItemGaussBlur.Size = new System.Drawing.Size(206, 22);
        	this.menuItemGaussBlur.Text = "Гауссовское сглаживание";
        	this.menuItemGaussBlur.Click += new System.EventHandler(this.MenuItemGaussBlurClick);
        	// 
        	// menuItemContrastFilters
        	// 
        	this.menuItemContrastFilters.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
        	        	        	this.menuItemLightContrast,
        	        	        	this.menuItemHightContrast});
        	this.menuItemContrastFilters.Name = "menuItemContrastFilters";
        	this.menuItemContrastFilters.Size = new System.Drawing.Size(247, 22);
        	this.menuItemContrastFilters.Text = "Контрастоповышающие фильтры";
        	// 
        	// menuItemLightContrast
        	// 
        	this.menuItemLightContrast.Name = "menuItemLightContrast";
        	this.menuItemLightContrast.Size = new System.Drawing.Size(236, 22);
        	this.menuItemLightContrast.Text = "Слабое увеличение контраста";
        	this.menuItemLightContrast.Click += new System.EventHandler(this.MenuItemLightContrastClick);
        	// 
        	// menuItemHightContrast
        	// 
        	this.menuItemHightContrast.Name = "menuItemHightContrast";
        	this.menuItemHightContrast.Size = new System.Drawing.Size(236, 22);
        	this.menuItemHightContrast.Text = "Сильное увеличение контраста";
        	this.menuItemHightContrast.Click += new System.EventHandler(this.MenuItemHightContrastClick);
        	// 
        	// menuItemEdgeFilters
        	// 
        	this.menuItemEdgeFilters.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
        	        	        	this.menuItemPrewitt,
        	        	        	this.menuItemSobel,
        	        	        	this.menuItemLaplas});
        	this.menuItemEdgeFilters.Name = "menuItemEdgeFilters";
        	this.menuItemEdgeFilters.Size = new System.Drawing.Size(247, 22);
        	this.menuItemEdgeFilters.Text = "Разностные фильтры";
        	// 
        	// menuItemPrewitt
        	// 
        	this.menuItemPrewitt.Name = "menuItemPrewitt";
        	this.menuItemPrewitt.Size = new System.Drawing.Size(157, 22);
        	this.menuItemPrewitt.Text = "Фильтр Прюита";
        	this.menuItemPrewitt.Click += new System.EventHandler(this.MenuItemPrewittClick);
        	// 
        	// menuItemSobel
        	// 
        	this.menuItemSobel.Name = "menuItemSobel";
        	this.menuItemSobel.Size = new System.Drawing.Size(157, 22);
        	this.menuItemSobel.Text = "Фильтр Собеля";
        	this.menuItemSobel.Click += new System.EventHandler(this.MenuItemSobelClick);
        	// 
        	// menuItemLaplas
        	// 
        	this.menuItemLaplas.Name = "menuItemLaplas";
        	this.menuItemLaplas.Size = new System.Drawing.Size(157, 22);
        	this.menuItemLaplas.Text = "Фильтр Лапласа";
        	this.menuItemLaplas.Click += new System.EventHandler(this.MenuItemLaplasClick);
        	// 
        	// menuItemCorrectionFilters
        	// 
        	this.menuItemCorrectionFilters.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
        	        	        	this.menuItemGreyWorld});
        	this.menuItemCorrectionFilters.Name = "menuItemCorrectionFilters";
        	this.menuItemCorrectionFilters.Size = new System.Drawing.Size(247, 22);
        	this.menuItemCorrectionFilters.Text = "Корректирующие фильтры";
        	// 
        	// menuItemGreyWorld
        	// 
        	this.menuItemGreyWorld.Name = "menuItemGreyWorld";
        	this.menuItemGreyWorld.Size = new System.Drawing.Size(173, 22);
        	this.menuItemGreyWorld.Text = "Фильтр \'Серый мир\'";
        	this.menuItemGreyWorld.Click += new System.EventHandler(this.MenuItemGreyWorldClick);
        	// 
        	// menuItemHistogramSeparator
        	// 
        	this.menuItemHistogramSeparator.Name = "menuItemHistogramSeparator";
        	this.menuItemHistogramSeparator.Size = new System.Drawing.Size(240, 6);
        	// 
        	// menuItemHistogram
        	// 
        	this.menuItemHistogram.Name = "menuItemHistogram";
        	this.menuItemHistogram.Size = new System.Drawing.Size(243, 22);
        	this.menuItemHistogram.Text = "Гистограмма";
        	this.menuItemHistogram.Click += new System.EventHandler(this.MenuItemHistogramClick);
        	// 
        	// backgroundWorker
        	// 
        	this.backgroundWorker.WorkerReportsProgress = true;
        	this.backgroundWorker.WorkerSupportsCancellation = true;
        	this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorkerDoWork);
        	this.backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BackgroundWorkerProgressChanged);
        	// 
        	// panelBottom
        	// 
        	this.panelBottom.Controls.Add(this.progressBar);
        	this.panelBottom.Controls.Add(this.labelTime);
        	this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
        	this.panelBottom.Location = new System.Drawing.Point(0, 626);
        	this.panelBottom.Name = "panelBottom";
        	this.panelBottom.Size = new System.Drawing.Size(802, 22);
        	this.panelBottom.TabIndex = 4;
        	// 
        	// progressBar
        	// 
        	this.progressBar.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.progressBar.Location = new System.Drawing.Point(0, 0);
        	this.progressBar.Name = "progressBar";
        	this.progressBar.Size = new System.Drawing.Size(682, 22);
        	this.progressBar.TabIndex = 3;
        	// 
        	// labelTime
        	// 
        	this.labelTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        	this.labelTime.Dock = System.Windows.Forms.DockStyle.Right;
        	this.labelTime.Location = new System.Drawing.Point(682, 0);
        	this.labelTime.Name = "labelTime";
        	this.labelTime.Size = new System.Drawing.Size(120, 22);
        	this.labelTime.TabIndex = 2;
        	this.labelTime.Text = "--:--";
        	this.labelTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        	// 
        	// pictureBox
        	// 
        	this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        	this.pictureBox.Cursor = System.Windows.Forms.Cursors.Arrow;
        	this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.pictureBox.Location = new System.Drawing.Point(0, 24);
        	this.pictureBox.Name = "pictureBox";
        	this.pictureBox.Size = new System.Drawing.Size(802, 602);
        	this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
        	this.pictureBox.TabIndex = 5;
        	this.pictureBox.TabStop = false;
        	// 
        	// MainForm
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.ClientSize = new System.Drawing.Size(802, 648);
        	this.Controls.Add(this.pictureBox);
        	this.Controls.Add(this.panelBottom);
        	this.Controls.Add(this.menuStrip);
        	this.MainMenuStrip = this.menuStrip;
        	this.Name = "MainForm";
        	this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        	this.Text = "Tutorial - Image Processing";
        	this.menuStrip.ResumeLayout(false);
        	this.menuStrip.PerformLayout();
        	this.panelBottom.ResumeLayout(false);
        	((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
        	this.ResumeLayout(false);
        	this.PerformLayout();
        }
        private System.Windows.Forms.ToolStripSeparator menuItemHistogramSeparator;
        private System.Windows.Forms.ToolStripMenuItem menuItemGreyWorld;
        private System.Windows.Forms.ToolStripMenuItem menuItemHistogram;
        private System.Windows.Forms.ToolStripMenuItem menuItemCorrectionFilters;
        private System.Windows.Forms.ToolStripMenuItem menuItemGamma;
        private System.Windows.Forms.ToolStripMenuItem menuItemMatrixFilters;
        private System.Windows.Forms.ToolStripMenuItem menuItemGrayscale;
        private System.Windows.Forms.ToolStripMenuItem menuItemSepia;
        private System.Windows.Forms.ToolStripMenuItem menuItemIntensity;
        private System.Windows.Forms.ToolStripMenuItem menuItemLaplas;
        private System.Windows.Forms.ToolStripMenuItem menuItemSobel;
        private System.Windows.Forms.ToolStripMenuItem menuItemPrewitt;
        private System.Windows.Forms.ToolStripMenuItem menuItemContrastFilters;
        private System.Windows.Forms.ToolStripMenuItem menuItemEdgeFilters;
        private System.Windows.Forms.ToolStripMenuItem menuItemDotFilters;
        private System.Windows.Forms.ToolStripMenuItem menuItemBlurFilters;
        private System.Windows.Forms.ToolStripMenuItem menuItemGaussBlur;
        private System.Windows.Forms.ToolStripMenuItem menuItemSimpleBlur;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Panel panelBottom;
        private System.ComponentModel.BackgroundWorker backgroundWorker;

        #endregion

        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.ToolStripMenuItem menuItemFile;
        private System.Windows.Forms.ToolStripMenuItem menuItemOpen;
        private System.Windows.Forms.ToolStripMenuItem menuItemSave;
        private System.Windows.Forms.ToolStripSeparator menuItemSaveSeparator;
        private System.Windows.Forms.ToolStripMenuItem menuItemExit;
        private System.Windows.Forms.ToolStripMenuItem menuItemEdit;
        private System.Windows.Forms.ToolStripMenuItem menuItemUndo;
        private System.Windows.Forms.ToolStripSeparator menuItemUndoSeparator;
        private System.Windows.Forms.ToolStripMenuItem menuItemHalf;
        private System.Windows.Forms.ToolStripSeparator menuItemHalfSeparator;
        private System.Windows.Forms.ToolStripMenuItem menuItemInvert;
        private System.Windows.Forms.ToolStripMenuItem menuItemLightContrast;
        private System.Windows.Forms.ToolStripMenuItem menuItemHightContrast;
    }
}

