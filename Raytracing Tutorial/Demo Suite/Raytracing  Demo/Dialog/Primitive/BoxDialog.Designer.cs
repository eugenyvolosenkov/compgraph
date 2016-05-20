namespace SceneEditor
{
	partial class BoxDialog
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
			this.groupBoxBox = new System.Windows.Forms.GroupBox();
			this.numericUpDownSizeZ = new System.Windows.Forms.NumericUpDown();
			this.textBoxName = new System.Windows.Forms.TextBox();
			this.labelName = new System.Windows.Forms.Label();
			this.labelMaterial = new System.Windows.Forms.Label();
			this.labelTransform = new System.Windows.Forms.Label();
			this.buttonMaterial = new System.Windows.Forms.Button();
			this.buttonTransform = new System.Windows.Forms.Button();
			this.numericUpDownSizeY = new System.Windows.Forms.NumericUpDown();
			this.numericUpDownSizeX = new System.Windows.Forms.NumericUpDown();
			this.labelSize = new System.Windows.Forms.Label();
			this.buttonOK = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.labelZ = new System.Windows.Forms.Label();
			this.labelY = new System.Windows.Forms.Label();
			this.labelX = new System.Windows.Forms.Label();
			this.groupBoxBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownSizeZ)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownSizeY)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownSizeX)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBoxBox
			// 
			this.groupBoxBox.Controls.Add(this.labelZ);
			this.groupBoxBox.Controls.Add(this.labelY);
			this.groupBoxBox.Controls.Add(this.labelX);
			this.groupBoxBox.Controls.Add(this.numericUpDownSizeZ);
			this.groupBoxBox.Controls.Add(this.textBoxName);
			this.groupBoxBox.Controls.Add(this.labelName);
			this.groupBoxBox.Controls.Add(this.labelMaterial);
			this.groupBoxBox.Controls.Add(this.labelTransform);
			this.groupBoxBox.Controls.Add(this.buttonMaterial);
			this.groupBoxBox.Controls.Add(this.buttonTransform);
			this.groupBoxBox.Controls.Add(this.numericUpDownSizeY);
			this.groupBoxBox.Controls.Add(this.numericUpDownSizeX);
			this.groupBoxBox.Controls.Add(this.labelSize);
			this.groupBoxBox.Location = new System.Drawing.Point(12, 12);
			this.groupBoxBox.Name = "groupBoxBox";
			this.groupBoxBox.Size = new System.Drawing.Size(540, 274);
			this.groupBoxBox.TabIndex = 0;
			this.groupBoxBox.TabStop = false;
			this.groupBoxBox.Text = "Объект \'Параллелипипед\'";
			// 
			// numericUpDownSizeZ
			// 
			this.numericUpDownSizeZ.DecimalPlaces = 2;
			this.numericUpDownSizeZ.Increment = new decimal(new int[] {
									1,
									0,
									0,
									65536});
			this.numericUpDownSizeZ.Location = new System.Drawing.Point(419, 109);
			this.numericUpDownSizeZ.Maximum = new decimal(new int[] {
									1000,
									0,
									0,
									0});
			this.numericUpDownSizeZ.Minimum = new decimal(new int[] {
									1,
									0,
									0,
									131072});
			this.numericUpDownSizeZ.Name = "numericUpDownSizeZ";
			this.numericUpDownSizeZ.Size = new System.Drawing.Size(87, 20);
			this.numericUpDownSizeZ.TabIndex = 36;
			this.numericUpDownSizeZ.Value = new decimal(new int[] {
									1,
									0,
									0,
									0});
			// 
			// textBoxName
			// 
			this.textBoxName.Location = new System.Drawing.Point(192, 49);
			this.textBoxName.Name = "textBoxName";
			this.textBoxName.Size = new System.Drawing.Size(314, 20);
			this.textBoxName.TabIndex = 34;
			this.textBoxName.Text = "Параллелипипед";
			// 
			// labelName
			// 
			this.labelName.Location = new System.Drawing.Point(32, 48);
			this.labelName.Name = "labelName";
			this.labelName.Size = new System.Drawing.Size(154, 20);
			this.labelName.TabIndex = 33;
			this.labelName.Text = "Название объекта:";
			this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// labelMaterial
			// 
			this.labelMaterial.Location = new System.Drawing.Point(32, 216);
			this.labelMaterial.Name = "labelMaterial";
			this.labelMaterial.Size = new System.Drawing.Size(154, 20);
			this.labelMaterial.TabIndex = 30;
			this.labelMaterial.Text = "Материал объекта:";
			this.labelMaterial.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// labelTransform
			// 
			this.labelTransform.Location = new System.Drawing.Point(32, 163);
			this.labelTransform.Name = "labelTransform";
			this.labelTransform.Size = new System.Drawing.Size(154, 20);
			this.labelTransform.TabIndex = 29;
			this.labelTransform.Text = "Преобразование объекта:";
			this.labelTransform.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// buttonMaterial
			// 
			this.buttonMaterial.Location = new System.Drawing.Point(192, 211);
			this.buttonMaterial.Name = "buttonMaterial";
			this.buttonMaterial.Size = new System.Drawing.Size(314, 30);
			this.buttonMaterial.TabIndex = 28;
			this.buttonMaterial.Text = "Выбрать";
			this.buttonMaterial.UseVisualStyleBackColor = true;
			this.buttonMaterial.Click += new System.EventHandler(this.ButtonMaterialClick);
			// 
			// buttonTransform
			// 
			this.buttonTransform.Location = new System.Drawing.Point(192, 158);
			this.buttonTransform.Name = "buttonTransform";
			this.buttonTransform.Size = new System.Drawing.Size(314, 30);
			this.buttonTransform.TabIndex = 27;
			this.buttonTransform.Text = "Выбрать";
			this.buttonTransform.UseVisualStyleBackColor = true;
			this.buttonTransform.Click += new System.EventHandler(this.ButtonTransformClick);
			// 
			// numericUpDownSizeY
			// 
			this.numericUpDownSizeY.DecimalPlaces = 2;
			this.numericUpDownSizeY.Increment = new decimal(new int[] {
									1,
									0,
									0,
									65536});
			this.numericUpDownSizeY.Location = new System.Drawing.Point(305, 109);
			this.numericUpDownSizeY.Maximum = new decimal(new int[] {
									1000,
									0,
									0,
									0});
			this.numericUpDownSizeY.Minimum = new decimal(new int[] {
									1,
									0,
									0,
									131072});
			this.numericUpDownSizeY.Name = "numericUpDownSizeY";
			this.numericUpDownSizeY.Size = new System.Drawing.Size(87, 20);
			this.numericUpDownSizeY.TabIndex = 24;
			this.numericUpDownSizeY.Value = new decimal(new int[] {
									1,
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
									65536});
			this.numericUpDownSizeX.Location = new System.Drawing.Point(192, 109);
			this.numericUpDownSizeX.Maximum = new decimal(new int[] {
									1000,
									0,
									0,
									0});
			this.numericUpDownSizeX.Minimum = new decimal(new int[] {
									1,
									0,
									0,
									131072});
			this.numericUpDownSizeX.Name = "numericUpDownSizeX";
			this.numericUpDownSizeX.Size = new System.Drawing.Size(87, 20);
			this.numericUpDownSizeX.TabIndex = 23;
			this.numericUpDownSizeX.Value = new decimal(new int[] {
									1,
									0,
									0,
									0});
			// 
			// labelSize
			// 
			this.labelSize.Location = new System.Drawing.Point(32, 107);
			this.labelSize.Name = "labelSize";
			this.labelSize.Size = new System.Drawing.Size(154, 20);
			this.labelSize.TabIndex = 22;
			this.labelSize.Text = "Размер параллелипипеда:";
			this.labelSize.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// buttonOK
			// 
			this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.buttonOK.Location = new System.Drawing.Point(358, 300);
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.Size = new System.Drawing.Size(87, 28);
			this.buttonOK.TabIndex = 6;
			this.buttonOK.Text = "Применить";
			this.buttonOK.UseVisualStyleBackColor = true;
			// 
			// buttonCancel
			// 
			this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.Location = new System.Drawing.Point(465, 300);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(87, 28);
			this.buttonCancel.TabIndex = 5;
			this.buttonCancel.Text = "Отмена";
			this.buttonCancel.UseVisualStyleBackColor = true;
			// 
			// labelZ
			// 
			this.labelZ.AutoSize = true;
			this.labelZ.ForeColor = System.Drawing.Color.Blue;
			this.labelZ.Location = new System.Drawing.Point(416, 88);
			this.labelZ.Name = "labelZ";
			this.labelZ.Size = new System.Drawing.Size(89, 13);
			this.labelZ.TabIndex = 52;
			this.labelZ.Text = "-∞ - - - <Z> - - - +∞";
			this.labelZ.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// labelY
			// 
			this.labelY.AutoSize = true;
			this.labelY.ForeColor = System.Drawing.Color.Green;
			this.labelY.Location = new System.Drawing.Point(302, 88);
			this.labelY.Name = "labelY";
			this.labelY.Size = new System.Drawing.Size(89, 13);
			this.labelY.TabIndex = 51;
			this.labelY.Text = "-∞ - - - <Y> - - - +∞";
			this.labelY.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// labelX
			// 
			this.labelX.AutoSize = true;
			this.labelX.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelX.ForeColor = System.Drawing.Color.Red;
			this.labelX.Location = new System.Drawing.Point(189, 88);
			this.labelX.Name = "labelX";
			this.labelX.Size = new System.Drawing.Size(89, 13);
			this.labelX.TabIndex = 50;
			this.labelX.Text = "-∞ - - - <X> - - - +∞";
			this.labelX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// BoxDialog
			// 
			this.AcceptButton = this.buttonOK;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.buttonCancel;
			this.ClientSize = new System.Drawing.Size(565, 342);
			this.Controls.Add(this.buttonOK);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.groupBoxBox);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "BoxDialog";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Параметры объекта \'Параллелипипед\'";
			this.Load += new System.EventHandler(this.SquareDialogLoad);
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SquareDialogFormClosed);
			this.groupBoxBox.ResumeLayout(false);
			this.groupBoxBox.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownSizeZ)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownSizeY)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownSizeX)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.GroupBox groupBoxBox;
		private System.Windows.Forms.Button buttonOK;
		private System.Windows.Forms.TextBox textBoxName;
		private System.Windows.Forms.Label labelName;
		private System.Windows.Forms.NumericUpDown numericUpDownSizeZ;
		private System.Windows.Forms.Label labelZ;
		private System.Windows.Forms.NumericUpDown numericUpDownSizeY;
		private System.Windows.Forms.NumericUpDown numericUpDownSizeX;
		private System.Windows.Forms.Label labelSize;
		private System.Windows.Forms.Button buttonMaterial;
		private System.Windows.Forms.Button buttonTransform;
		private System.Windows.Forms.Label labelMaterial;
		private System.Windows.Forms.Label labelTransform;
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.Label labelX;
		private System.Windows.Forms.Label labelY;
	}
}
