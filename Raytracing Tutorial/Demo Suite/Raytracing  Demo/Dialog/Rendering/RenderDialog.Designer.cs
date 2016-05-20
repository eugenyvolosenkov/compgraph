namespace SceneEditor
{
	partial class RenderDialog
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.buttonOK = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.groupBoxPreview = new System.Windows.Forms.GroupBox();
			this.labelZ = new System.Windows.Forms.Label();
			this.labelY = new System.Windows.Forms.Label();
			this.labelX = new System.Windows.Forms.Label();
			this.numericUpDownSizeZ = new System.Windows.Forms.NumericUpDown();
			this.numericUpDownSizeY = new System.Windows.Forms.NumericUpDown();
			this.numericUpDownSizeX = new System.Windows.Forms.NumericUpDown();
			this.labelSize = new System.Windows.Forms.Label();
			this.numericUpDownThreadsCount = new System.Windows.Forms.NumericUpDown();
			this.trackBarKeyboard = new System.Windows.Forms.TrackBar();
			this.labelThreadsCount = new System.Windows.Forms.Label();
			this.trackBarMouse = new System.Windows.Forms.TrackBar();
			this.labelTraceDepth = new System.Windows.Forms.Label();
			this.numericUpDownTraceDepth = new System.Windows.Forms.NumericUpDown();
			this.labelKeyboard = new System.Windows.Forms.Label();
			this.labelMouse = new System.Windows.Forms.Label();
			this.groupBoxInput = new System.Windows.Forms.GroupBox();
			this.groupBoxRendering = new System.Windows.Forms.GroupBox();
			this.groupBoxImage = new System.Windows.Forms.GroupBox();
			this.labelResolution = new System.Windows.Forms.Label();
			this.numericUpDownWidth = new System.Windows.Forms.NumericUpDown();
			this.numericUpDownHeight = new System.Windows.Forms.NumericUpDown();
			this.label2 = new System.Windows.Forms.Label();
			this.groupBoxCamera = new System.Windows.Forms.GroupBox();
			this.labelFieldOfView = new System.Windows.Forms.Label();
			this.numericUpDownFieldOfView = new System.Windows.Forms.NumericUpDown();
			this.groupBoxPreview.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownSizeZ)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownSizeY)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownSizeX)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownThreadsCount)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBarKeyboard)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBarMouse)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownTraceDepth)).BeginInit();
			this.groupBoxInput.SuspendLayout();
			this.groupBoxRendering.SuspendLayout();
			this.groupBoxImage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownWidth)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownHeight)).BeginInit();
			this.groupBoxCamera.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownFieldOfView)).BeginInit();
			this.SuspendLayout();
			// 
			// buttonOK
			// 
			this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.buttonOK.Location = new System.Drawing.Point(434, 361);
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.Size = new System.Drawing.Size(87, 28);
			this.buttonOK.TabIndex = 9;
			this.buttonOK.Text = "Применить";
			this.buttonOK.UseVisualStyleBackColor = true;
			// 
			// buttonCancel
			// 
			this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.Location = new System.Drawing.Point(540, 361);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(87, 28);
			this.buttonCancel.TabIndex = 8;
			this.buttonCancel.Text = "Отмена";
			this.buttonCancel.UseVisualStyleBackColor = true;
			// 
			// groupBoxPreview
			// 
			this.groupBoxPreview.Controls.Add(this.labelZ);
			this.groupBoxPreview.Controls.Add(this.labelY);
			this.groupBoxPreview.Controls.Add(this.labelX);
			this.groupBoxPreview.Controls.Add(this.numericUpDownSizeZ);
			this.groupBoxPreview.Controls.Add(this.numericUpDownSizeY);
			this.groupBoxPreview.Controls.Add(this.numericUpDownSizeX);
			this.groupBoxPreview.Controls.Add(this.labelSize);
			this.groupBoxPreview.Location = new System.Drawing.Point(12, 146);
			this.groupBoxPreview.Name = "groupBoxPreview";
			this.groupBoxPreview.Size = new System.Drawing.Size(615, 99);
			this.groupBoxPreview.TabIndex = 7;
			this.groupBoxPreview.TabStop = false;
			this.groupBoxPreview.Text = "Предварительный просмотр";
			// 
			// labelZ
			// 
			this.labelZ.AutoSize = true;
			this.labelZ.ForeColor = System.Drawing.Color.Blue;
			this.labelZ.Location = new System.Drawing.Point(503, 32);
			this.labelZ.Name = "labelZ";
			this.labelZ.Size = new System.Drawing.Size(86, 13);
			this.labelZ.TabIndex = 59;
			this.labelZ.Text = "0 - - - <Z> - - - +∞";
			this.labelZ.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// labelY
			// 
			this.labelY.AutoSize = true;
			this.labelY.ForeColor = System.Drawing.Color.Green;
			this.labelY.Location = new System.Drawing.Point(354, 32);
			this.labelY.Name = "labelY";
			this.labelY.Size = new System.Drawing.Size(86, 13);
			this.labelY.TabIndex = 58;
			this.labelY.Text = "0 - - - <Y> - - - +∞";
			this.labelY.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// labelX
			// 
			this.labelX.AutoSize = true;
			this.labelX.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelX.ForeColor = System.Drawing.Color.Red;
			this.labelX.Location = new System.Drawing.Point(219, 32);
			this.labelX.Name = "labelX";
			this.labelX.Size = new System.Drawing.Size(86, 13);
			this.labelX.TabIndex = 57;
			this.labelX.Text = "0 - - - <X> - - - +∞";
			this.labelX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// numericUpDownSizeZ
			// 
			this.numericUpDownSizeZ.DecimalPlaces = 2;
			this.numericUpDownSizeZ.Increment = new decimal(new int[] {
									1,
									0,
									0,
									131072});
			this.numericUpDownSizeZ.Location = new System.Drawing.Point(503, 53);
			this.numericUpDownSizeZ.Maximum = new decimal(new int[] {
									1000,
									0,
									0,
									0});
			this.numericUpDownSizeZ.Minimum = new decimal(new int[] {
									1,
									0,
									0,
									196608});
			this.numericUpDownSizeZ.Name = "numericUpDownSizeZ";
			this.numericUpDownSizeZ.Size = new System.Drawing.Size(90, 20);
			this.numericUpDownSizeZ.TabIndex = 53;
			this.numericUpDownSizeZ.Value = new decimal(new int[] {
									5,
									0,
									0,
									0});
			// 
			// numericUpDownSizeY
			// 
			this.numericUpDownSizeY.DecimalPlaces = 2;
			this.numericUpDownSizeY.Increment = new decimal(new int[] {
									1,
									0,
									0,
									131072});
			this.numericUpDownSizeY.Location = new System.Drawing.Point(354, 53);
			this.numericUpDownSizeY.Maximum = new decimal(new int[] {
									1000,
									0,
									0,
									0});
			this.numericUpDownSizeY.Minimum = new decimal(new int[] {
									1,
									0,
									0,
									196608});
			this.numericUpDownSizeY.Name = "numericUpDownSizeY";
			this.numericUpDownSizeY.Size = new System.Drawing.Size(90, 20);
			this.numericUpDownSizeY.TabIndex = 52;
			this.numericUpDownSizeY.Value = new decimal(new int[] {
									5,
									0,
									0,
									0});
			// 
			// numericUpDownSizeX
			// 
			this.numericUpDownSizeX.DecimalPlaces = 2;
			this.numericUpDownSizeX.Increment = new decimal(new int[] {
									1,
									0,
									0,
									131072});
			this.numericUpDownSizeX.Location = new System.Drawing.Point(219, 53);
			this.numericUpDownSizeX.Maximum = new decimal(new int[] {
									1000,
									0,
									0,
									0});
			this.numericUpDownSizeX.Minimum = new decimal(new int[] {
									1,
									0,
									0,
									196608});
			this.numericUpDownSizeX.Name = "numericUpDownSizeX";
			this.numericUpDownSizeX.Size = new System.Drawing.Size(90, 20);
			this.numericUpDownSizeX.TabIndex = 51;
			this.numericUpDownSizeX.Value = new decimal(new int[] {
									5,
									0,
									0,
									0});
			// 
			// labelSize
			// 
			this.labelSize.Location = new System.Drawing.Point(19, 51);
			this.labelSize.Name = "labelSize";
			this.labelSize.Size = new System.Drawing.Size(170, 20);
			this.labelSize.TabIndex = 50;
			this.labelSize.Text = "Половинный размер объема:";
			this.labelSize.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// numericUpDownThreadsCount
			// 
			this.numericUpDownThreadsCount.Location = new System.Drawing.Point(168, 84);
			this.numericUpDownThreadsCount.Maximum = new decimal(new int[] {
									8,
									0,
									0,
									0});
			this.numericUpDownThreadsCount.Minimum = new decimal(new int[] {
									1,
									0,
									0,
									0});
			this.numericUpDownThreadsCount.Name = "numericUpDownThreadsCount";
			this.numericUpDownThreadsCount.Size = new System.Drawing.Size(69, 20);
			this.numericUpDownThreadsCount.TabIndex = 49;
			this.numericUpDownThreadsCount.Value = new decimal(new int[] {
									2,
									0,
									0,
									0});
			// 
			// trackBarKeyboard
			// 
			this.trackBarKeyboard.Location = new System.Drawing.Point(204, 71);
			this.trackBarKeyboard.Maximum = 100;
			this.trackBarKeyboard.Minimum = 1;
			this.trackBarKeyboard.Name = "trackBarKeyboard";
			this.trackBarKeyboard.Size = new System.Drawing.Size(125, 42);
			this.trackBarKeyboard.TabIndex = 36;
			this.trackBarKeyboard.TickFrequency = 10;
			this.trackBarKeyboard.TickStyle = System.Windows.Forms.TickStyle.Both;
			this.trackBarKeyboard.Value = 50;
			// 
			// labelThreadsCount
			// 
			this.labelThreadsCount.AutoSize = true;
			this.labelThreadsCount.Location = new System.Drawing.Point(20, 86);
			this.labelThreadsCount.Name = "labelThreadsCount";
			this.labelThreadsCount.Size = new System.Drawing.Size(86, 13);
			this.labelThreadsCount.TabIndex = 48;
			this.labelThreadsCount.Text = "Число потоков:";
			this.labelThreadsCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// trackBarMouse
			// 
			this.trackBarMouse.Location = new System.Drawing.Point(204, 24);
			this.trackBarMouse.Maximum = 100;
			this.trackBarMouse.Minimum = 1;
			this.trackBarMouse.Name = "trackBarMouse";
			this.trackBarMouse.Size = new System.Drawing.Size(125, 42);
			this.trackBarMouse.TabIndex = 35;
			this.trackBarMouse.TickFrequency = 10;
			this.trackBarMouse.TickStyle = System.Windows.Forms.TickStyle.Both;
			this.trackBarMouse.Value = 50;
			// 
			// labelTraceDepth
			// 
			this.labelTraceDepth.AutoSize = true;
			this.labelTraceDepth.Location = new System.Drawing.Point(20, 37);
			this.labelTraceDepth.Name = "labelTraceDepth";
			this.labelTraceDepth.Size = new System.Drawing.Size(119, 13);
			this.labelTraceDepth.TabIndex = 45;
			this.labelTraceDepth.Text = "Глубина трассировки:";
			this.labelTraceDepth.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// numericUpDownTraceDepth
			// 
			this.numericUpDownTraceDepth.Location = new System.Drawing.Point(168, 35);
			this.numericUpDownTraceDepth.Maximum = new decimal(new int[] {
									8,
									0,
									0,
									0});
			this.numericUpDownTraceDepth.Name = "numericUpDownTraceDepth";
			this.numericUpDownTraceDepth.Size = new System.Drawing.Size(69, 20);
			this.numericUpDownTraceDepth.TabIndex = 46;
			this.numericUpDownTraceDepth.Value = new decimal(new int[] {
									3,
									0,
									0,
									0});
			// 
			// labelKeyboard
			// 
			this.labelKeyboard.Location = new System.Drawing.Point(19, 72);
			this.labelKeyboard.Name = "labelKeyboard";
			this.labelKeyboard.Size = new System.Drawing.Size(170, 41);
			this.labelKeyboard.TabIndex = 34;
			this.labelKeyboard.Text = "Чувствительность клавиатуры:";
			this.labelKeyboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// labelMouse
			// 
			this.labelMouse.Location = new System.Drawing.Point(19, 24);
			this.labelMouse.Name = "labelMouse";
			this.labelMouse.Size = new System.Drawing.Size(154, 39);
			this.labelMouse.TabIndex = 33;
			this.labelMouse.Text = "Чувствительность мыши:";
			this.labelMouse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// groupBoxInput
			// 
			this.groupBoxInput.Controls.Add(this.labelMouse);
			this.groupBoxInput.Controls.Add(this.labelKeyboard);
			this.groupBoxInput.Controls.Add(this.trackBarMouse);
			this.groupBoxInput.Controls.Add(this.trackBarKeyboard);
			this.groupBoxInput.Location = new System.Drawing.Point(12, 12);
			this.groupBoxInput.Name = "groupBoxInput";
			this.groupBoxInput.Size = new System.Drawing.Size(347, 128);
			this.groupBoxInput.TabIndex = 10;
			this.groupBoxInput.TabStop = false;
			this.groupBoxInput.Text = "Управление камерой";
			// 
			// groupBoxRendering
			// 
			this.groupBoxRendering.Controls.Add(this.labelTraceDepth);
			this.groupBoxRendering.Controls.Add(this.numericUpDownTraceDepth);
			this.groupBoxRendering.Controls.Add(this.labelThreadsCount);
			this.groupBoxRendering.Controls.Add(this.numericUpDownThreadsCount);
			this.groupBoxRendering.Location = new System.Drawing.Point(368, 12);
			this.groupBoxRendering.Name = "groupBoxRendering";
			this.groupBoxRendering.Size = new System.Drawing.Size(259, 128);
			this.groupBoxRendering.TabIndex = 11;
			this.groupBoxRendering.TabStop = false;
			this.groupBoxRendering.Text = "Рендеринг";
			// 
			// groupBoxImage
			// 
			this.groupBoxImage.Controls.Add(this.label2);
			this.groupBoxImage.Controls.Add(this.numericUpDownHeight);
			this.groupBoxImage.Controls.Add(this.labelResolution);
			this.groupBoxImage.Controls.Add(this.numericUpDownWidth);
			this.groupBoxImage.Location = new System.Drawing.Point(12, 251);
			this.groupBoxImage.Name = "groupBoxImage";
			this.groupBoxImage.Size = new System.Drawing.Size(347, 99);
			this.groupBoxImage.TabIndex = 12;
			this.groupBoxImage.TabStop = false;
			this.groupBoxImage.Text = "Изображение";
			// 
			// labelResolution
			// 
			this.labelResolution.AutoSize = true;
			this.labelResolution.Location = new System.Drawing.Point(19, 47);
			this.labelResolution.Name = "labelResolution";
			this.labelResolution.Size = new System.Drawing.Size(120, 13);
			this.labelResolution.TabIndex = 50;
			this.labelResolution.Text = "Размер изображения:";
			this.labelResolution.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// numericUpDownWidth
			// 
			this.numericUpDownWidth.Location = new System.Drawing.Point(160, 45);
			this.numericUpDownWidth.Maximum = new decimal(new int[] {
									4096,
									0,
									0,
									0});
			this.numericUpDownWidth.Minimum = new decimal(new int[] {
									16,
									0,
									0,
									0});
			this.numericUpDownWidth.Name = "numericUpDownWidth";
			this.numericUpDownWidth.Size = new System.Drawing.Size(69, 20);
			this.numericUpDownWidth.TabIndex = 51;
			this.numericUpDownWidth.Value = new decimal(new int[] {
									512,
									0,
									0,
									0});
			// 
			// numericUpDownHeight
			// 
			this.numericUpDownHeight.Location = new System.Drawing.Point(253, 45);
			this.numericUpDownHeight.Maximum = new decimal(new int[] {
									4096,
									0,
									0,
									0});
			this.numericUpDownHeight.Minimum = new decimal(new int[] {
									16,
									0,
									0,
									0});
			this.numericUpDownHeight.Name = "numericUpDownHeight";
			this.numericUpDownHeight.Size = new System.Drawing.Size(69, 20);
			this.numericUpDownHeight.TabIndex = 52;
			this.numericUpDownHeight.Value = new decimal(new int[] {
									512,
									0,
									0,
									0});
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(234, 47);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(12, 13);
			this.label2.TabIndex = 53;
			this.label2.Text = "x";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// groupBoxCamera
			// 
			this.groupBoxCamera.Controls.Add(this.labelFieldOfView);
			this.groupBoxCamera.Controls.Add(this.numericUpDownFieldOfView);
			this.groupBoxCamera.Location = new System.Drawing.Point(368, 251);
			this.groupBoxCamera.Name = "groupBoxCamera";
			this.groupBoxCamera.Size = new System.Drawing.Size(259, 99);
			this.groupBoxCamera.TabIndex = 13;
			this.groupBoxCamera.TabStop = false;
			this.groupBoxCamera.Text = "Камера";
			// 
			// labelFieldOfView
			// 
			this.labelFieldOfView.AutoSize = true;
			this.labelFieldOfView.Location = new System.Drawing.Point(20, 47);
			this.labelFieldOfView.Name = "labelFieldOfView";
			this.labelFieldOfView.Size = new System.Drawing.Size(128, 13);
			this.labelFieldOfView.TabIndex = 50;
			this.labelFieldOfView.Text = "Угол раствора камеры:";
			this.labelFieldOfView.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// numericUpDownFieldOfView
			// 
			this.numericUpDownFieldOfView.Location = new System.Drawing.Point(168, 45);
			this.numericUpDownFieldOfView.Maximum = new decimal(new int[] {
									360,
									0,
									0,
									0});
			this.numericUpDownFieldOfView.Minimum = new decimal(new int[] {
									1,
									0,
									0,
									0});
			this.numericUpDownFieldOfView.Name = "numericUpDownFieldOfView";
			this.numericUpDownFieldOfView.Size = new System.Drawing.Size(69, 20);
			this.numericUpDownFieldOfView.TabIndex = 51;
			this.numericUpDownFieldOfView.Value = new decimal(new int[] {
									90,
									0,
									0,
									0});
			// 
			// RenderDialog
			// 
			this.AcceptButton = this.buttonOK;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.buttonCancel;
			this.ClientSize = new System.Drawing.Size(637, 400);
			this.Controls.Add(this.groupBoxCamera);
			this.Controls.Add(this.groupBoxImage);
			this.Controls.Add(this.groupBoxRendering);
			this.Controls.Add(this.groupBoxInput);
			this.Controls.Add(this.buttonOK);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.groupBoxPreview);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "RenderDialog";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Параметры визуализации";
			this.Load += new System.EventHandler(this.RenderDialogLoad);
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RenderDialogFormClosed);
			this.groupBoxPreview.ResumeLayout(false);
			this.groupBoxPreview.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownSizeZ)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownSizeY)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownSizeX)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownThreadsCount)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBarKeyboard)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBarMouse)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownTraceDepth)).EndInit();
			this.groupBoxInput.ResumeLayout(false);
			this.groupBoxInput.PerformLayout();
			this.groupBoxRendering.ResumeLayout(false);
			this.groupBoxRendering.PerformLayout();
			this.groupBoxImage.ResumeLayout(false);
			this.groupBoxImage.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownWidth)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownHeight)).EndInit();
			this.groupBoxCamera.ResumeLayout(false);
			this.groupBoxCamera.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownFieldOfView)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.GroupBox groupBoxRendering;
		private System.Windows.Forms.GroupBox groupBoxInput;
		private System.Windows.Forms.NumericUpDown numericUpDownHeight;
		private System.Windows.Forms.NumericUpDown numericUpDownWidth;
		private System.Windows.Forms.Label labelResolution;
		private System.Windows.Forms.NumericUpDown numericUpDownFieldOfView;
		private System.Windows.Forms.Label labelFieldOfView;
		private System.Windows.Forms.GroupBox groupBoxCamera;
		private System.Windows.Forms.GroupBox groupBoxImage;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label labelTraceDepth;
		private System.Windows.Forms.Label labelThreadsCount;
		private System.Windows.Forms.NumericUpDown numericUpDownThreadsCount;
		private System.Windows.Forms.NumericUpDown numericUpDownTraceDepth;
		private System.Windows.Forms.NumericUpDown numericUpDownSizeZ;
		private System.Windows.Forms.NumericUpDown numericUpDownSizeY;
		private System.Windows.Forms.NumericUpDown numericUpDownSizeX;
		private System.Windows.Forms.Label labelSize;
		private System.Windows.Forms.Label labelKeyboard;
		private System.Windows.Forms.TrackBar trackBarKeyboard;
		private System.Windows.Forms.GroupBox groupBoxPreview;
		private System.Windows.Forms.Label labelMouse;
		private System.Windows.Forms.TrackBar trackBarMouse;
		private System.Windows.Forms.Label labelX;
		private System.Windows.Forms.Label labelY;
		private System.Windows.Forms.Label labelZ;
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.Button buttonOK;
	}
}
