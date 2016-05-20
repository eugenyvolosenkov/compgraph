namespace SceneEditor
{
	partial class TransformDialog
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
			this.groupBoxTransform = new System.Windows.Forms.GroupBox();
			this.numericUpDownAngleZ = new System.Windows.Forms.NumericUpDown();
			this.numericUpDownAngleY = new System.Windows.Forms.NumericUpDown();
			this.numericUpDownAngleX = new System.Windows.Forms.NumericUpDown();
			this.numericUpDownScalingZ = new System.Windows.Forms.NumericUpDown();
			this.numericUpDownScalingY = new System.Windows.Forms.NumericUpDown();
			this.numericUpDownScalingX = new System.Windows.Forms.NumericUpDown();
			this.labelScaling = new System.Windows.Forms.Label();
			this.labelZ = new System.Windows.Forms.Label();
			this.labelY = new System.Windows.Forms.Label();
			this.labelX = new System.Windows.Forms.Label();
			this.labelRotZRange = new System.Windows.Forms.Label();
			this.labelRotYRange = new System.Windows.Forms.Label();
			this.labelRotXRange = new System.Windows.Forms.Label();
			this.numericUpDownPositionZ = new System.Windows.Forms.NumericUpDown();
			this.numericUpDownPositionY = new System.Windows.Forms.NumericUpDown();
			this.numericUpDownPositionX = new System.Windows.Forms.NumericUpDown();
			this.labelOrientation = new System.Windows.Forms.Label();
			this.labelPosition = new System.Windows.Forms.Label();
			this.buttonOk = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.groupBoxTransform.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownAngleZ)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownAngleY)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownAngleX)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownScalingZ)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownScalingY)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownScalingX)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownPositionZ)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownPositionY)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownPositionX)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBoxTransform
			// 
			this.groupBoxTransform.Controls.Add(this.numericUpDownAngleZ);
			this.groupBoxTransform.Controls.Add(this.numericUpDownAngleY);
			this.groupBoxTransform.Controls.Add(this.numericUpDownAngleX);
			this.groupBoxTransform.Controls.Add(this.numericUpDownScalingZ);
			this.groupBoxTransform.Controls.Add(this.numericUpDownScalingY);
			this.groupBoxTransform.Controls.Add(this.numericUpDownScalingX);
			this.groupBoxTransform.Controls.Add(this.labelScaling);
			this.groupBoxTransform.Controls.Add(this.labelZ);
			this.groupBoxTransform.Controls.Add(this.labelY);
			this.groupBoxTransform.Controls.Add(this.labelX);
			this.groupBoxTransform.Controls.Add(this.labelRotZRange);
			this.groupBoxTransform.Controls.Add(this.labelRotYRange);
			this.groupBoxTransform.Controls.Add(this.labelRotXRange);
			this.groupBoxTransform.Controls.Add(this.numericUpDownPositionZ);
			this.groupBoxTransform.Controls.Add(this.numericUpDownPositionY);
			this.groupBoxTransform.Controls.Add(this.numericUpDownPositionX);
			this.groupBoxTransform.Controls.Add(this.labelOrientation);
			this.groupBoxTransform.Controls.Add(this.labelPosition);
			this.groupBoxTransform.Location = new System.Drawing.Point(13, 13);
			this.groupBoxTransform.Name = "groupBoxTransform";
			this.groupBoxTransform.Size = new System.Drawing.Size(604, 227);
			this.groupBoxTransform.TabIndex = 0;
			this.groupBoxTransform.TabStop = false;
			this.groupBoxTransform.Text = "Параметры преобразования";
			// 
			// numericUpDownAngleZ
			// 
			this.numericUpDownAngleZ.Location = new System.Drawing.Point(472, 165);
			this.numericUpDownAngleZ.Maximum = new decimal(new int[] {
									360,
									0,
									0,
									0});
			this.numericUpDownAngleZ.Minimum = new decimal(new int[] {
									360,
									0,
									0,
									-2147483648});
			this.numericUpDownAngleZ.Name = "numericUpDownAngleZ";
			this.numericUpDownAngleZ.Size = new System.Drawing.Size(87, 20);
			this.numericUpDownAngleZ.TabIndex = 29;
			// 
			// numericUpDownAngleY
			// 
			this.numericUpDownAngleY.Location = new System.Drawing.Point(336, 165);
			this.numericUpDownAngleY.Maximum = new decimal(new int[] {
									360,
									0,
									0,
									0});
			this.numericUpDownAngleY.Minimum = new decimal(new int[] {
									360,
									0,
									0,
									-2147483648});
			this.numericUpDownAngleY.Name = "numericUpDownAngleY";
			this.numericUpDownAngleY.Size = new System.Drawing.Size(87, 20);
			this.numericUpDownAngleY.TabIndex = 28;
			// 
			// numericUpDownAngleX
			// 
			this.numericUpDownAngleX.Location = new System.Drawing.Point(200, 165);
			this.numericUpDownAngleX.Maximum = new decimal(new int[] {
									360,
									0,
									0,
									0});
			this.numericUpDownAngleX.Minimum = new decimal(new int[] {
									360,
									0,
									0,
									-2147483648});
			this.numericUpDownAngleX.Name = "numericUpDownAngleX";
			this.numericUpDownAngleX.Size = new System.Drawing.Size(87, 20);
			this.numericUpDownAngleX.TabIndex = 27;
			// 
			// numericUpDownScalingZ
			// 
			this.numericUpDownScalingZ.DecimalPlaces = 2;
			this.numericUpDownScalingZ.Increment = new decimal(new int[] {
									1,
									0,
									0,
									131072});
			this.numericUpDownScalingZ.Location = new System.Drawing.Point(472, 103);
			this.numericUpDownScalingZ.Minimum = new decimal(new int[] {
									1,
									0,
									0,
									131072});
			this.numericUpDownScalingZ.Name = "numericUpDownScalingZ";
			this.numericUpDownScalingZ.Size = new System.Drawing.Size(87, 20);
			this.numericUpDownScalingZ.TabIndex = 26;
			this.numericUpDownScalingZ.Value = new decimal(new int[] {
									1,
									0,
									0,
									0});
			// 
			// numericUpDownScalingY
			// 
			this.numericUpDownScalingY.DecimalPlaces = 2;
			this.numericUpDownScalingY.Increment = new decimal(new int[] {
									1,
									0,
									0,
									131072});
			this.numericUpDownScalingY.Location = new System.Drawing.Point(336, 103);
			this.numericUpDownScalingY.Minimum = new decimal(new int[] {
									1,
									0,
									0,
									131072});
			this.numericUpDownScalingY.Name = "numericUpDownScalingY";
			this.numericUpDownScalingY.Size = new System.Drawing.Size(87, 20);
			this.numericUpDownScalingY.TabIndex = 25;
			this.numericUpDownScalingY.Value = new decimal(new int[] {
									1,
									0,
									0,
									0});
			// 
			// numericUpDownScalingX
			// 
			this.numericUpDownScalingX.DecimalPlaces = 2;
			this.numericUpDownScalingX.Increment = new decimal(new int[] {
									1,
									0,
									0,
									131072});
			this.numericUpDownScalingX.Location = new System.Drawing.Point(200, 103);
			this.numericUpDownScalingX.Minimum = new decimal(new int[] {
									1,
									0,
									0,
									131072});
			this.numericUpDownScalingX.Name = "numericUpDownScalingX";
			this.numericUpDownScalingX.Size = new System.Drawing.Size(87, 20);
			this.numericUpDownScalingX.TabIndex = 24;
			this.numericUpDownScalingX.Value = new decimal(new int[] {
									1,
									0,
									0,
									0});
			// 
			// labelScaling
			// 
			this.labelScaling.Location = new System.Drawing.Point(33, 101);
			this.labelScaling.Name = "labelScaling";
			this.labelScaling.Size = new System.Drawing.Size(161, 20);
			this.labelScaling.TabIndex = 23;
			this.labelScaling.Text = "Масштабирование объекта:";
			this.labelScaling.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// labelZ
			// 
			this.labelZ.AutoSize = true;
			this.labelZ.ForeColor = System.Drawing.Color.Blue;
			this.labelZ.Location = new System.Drawing.Point(470, 33);
			this.labelZ.Name = "labelZ";
			this.labelZ.Size = new System.Drawing.Size(89, 13);
			this.labelZ.TabIndex = 22;
			this.labelZ.Text = "-∞ - - - <Z> - - - +∞";
			this.labelZ.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// labelY
			// 
			this.labelY.AutoSize = true;
			this.labelY.ForeColor = System.Drawing.Color.Green;
			this.labelY.Location = new System.Drawing.Point(334, 33);
			this.labelY.Name = "labelY";
			this.labelY.Size = new System.Drawing.Size(89, 13);
			this.labelY.TabIndex = 21;
			this.labelY.Text = "-∞ - - - <Y> - - - +∞";
			this.labelY.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// labelX
			// 
			this.labelX.AutoSize = true;
			this.labelX.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelX.ForeColor = System.Drawing.Color.Red;
			this.labelX.Location = new System.Drawing.Point(198, 33);
			this.labelX.Name = "labelX";
			this.labelX.Size = new System.Drawing.Size(89, 13);
			this.labelX.TabIndex = 20;
			this.labelX.Text = "-∞ - - - <X> - - - +∞";
			this.labelX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// labelRotZRange
			// 
			this.labelRotZRange.AutoSize = true;
			this.labelRotZRange.ForeColor = System.Drawing.Color.Blue;
			this.labelRotZRange.Location = new System.Drawing.Point(468, 142);
			this.labelRotZRange.Name = "labelRotZRange";
			this.labelRotZRange.Size = new System.Drawing.Size(94, 13);
			this.labelRotZRange.TabIndex = 19;
			this.labelRotZRange.Text = "-360 - - <γ> - - 360";
			this.labelRotZRange.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// labelRotYRange
			// 
			this.labelRotYRange.AutoSize = true;
			this.labelRotYRange.ForeColor = System.Drawing.Color.Green;
			this.labelRotYRange.Location = new System.Drawing.Point(332, 142);
			this.labelRotYRange.Name = "labelRotYRange";
			this.labelRotYRange.Size = new System.Drawing.Size(94, 13);
			this.labelRotYRange.TabIndex = 18;
			this.labelRotYRange.Text = "-360 - - <β> - - 360";
			this.labelRotYRange.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// labelRotXRange
			// 
			this.labelRotXRange.AutoSize = true;
			this.labelRotXRange.ForeColor = System.Drawing.Color.Red;
			this.labelRotXRange.Location = new System.Drawing.Point(195, 142);
			this.labelRotXRange.Name = "labelRotXRange";
			this.labelRotXRange.Size = new System.Drawing.Size(95, 13);
			this.labelRotXRange.TabIndex = 17;
			this.labelRotXRange.Text = "-360 - - <α> - - 360";
			this.labelRotXRange.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// numericUpDownPositionZ
			// 
			this.numericUpDownPositionZ.DecimalPlaces = 2;
			this.numericUpDownPositionZ.Increment = new decimal(new int[] {
									1,
									0,
									0,
									131072});
			this.numericUpDownPositionZ.Location = new System.Drawing.Point(472, 57);
			this.numericUpDownPositionZ.Maximum = new decimal(new int[] {
									1000,
									0,
									0,
									0});
			this.numericUpDownPositionZ.Minimum = new decimal(new int[] {
									1000,
									0,
									0,
									-2147483648});
			this.numericUpDownPositionZ.Name = "numericUpDownPositionZ";
			this.numericUpDownPositionZ.Size = new System.Drawing.Size(87, 20);
			this.numericUpDownPositionZ.TabIndex = 16;
			// 
			// numericUpDownPositionY
			// 
			this.numericUpDownPositionY.DecimalPlaces = 2;
			this.numericUpDownPositionY.Increment = new decimal(new int[] {
									1,
									0,
									0,
									131072});
			this.numericUpDownPositionY.Location = new System.Drawing.Point(336, 57);
			this.numericUpDownPositionY.Maximum = new decimal(new int[] {
									1000,
									0,
									0,
									0});
			this.numericUpDownPositionY.Minimum = new decimal(new int[] {
									1000,
									0,
									0,
									-2147483648});
			this.numericUpDownPositionY.Name = "numericUpDownPositionY";
			this.numericUpDownPositionY.Size = new System.Drawing.Size(87, 20);
			this.numericUpDownPositionY.TabIndex = 15;
			// 
			// numericUpDownPositionX
			// 
			this.numericUpDownPositionX.DecimalPlaces = 2;
			this.numericUpDownPositionX.Increment = new decimal(new int[] {
									1,
									0,
									0,
									131072});
			this.numericUpDownPositionX.Location = new System.Drawing.Point(200, 57);
			this.numericUpDownPositionX.Maximum = new decimal(new int[] {
									1000,
									0,
									0,
									0});
			this.numericUpDownPositionX.Minimum = new decimal(new int[] {
									1000,
									0,
									0,
									-2147483648});
			this.numericUpDownPositionX.Name = "numericUpDownPositionX";
			this.numericUpDownPositionX.Size = new System.Drawing.Size(87, 20);
			this.numericUpDownPositionX.TabIndex = 14;
			// 
			// labelOrientation
			// 
			this.labelOrientation.Location = new System.Drawing.Point(33, 151);
			this.labelOrientation.Name = "labelOrientation";
			this.labelOrientation.Size = new System.Drawing.Size(143, 45);
			this.labelOrientation.TabIndex = 7;
			this.labelOrientation.Text = "Ориентация объекта:";
			this.labelOrientation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// labelPosition
			// 
			this.labelPosition.Location = new System.Drawing.Point(33, 55);
			this.labelPosition.Name = "labelPosition";
			this.labelPosition.Size = new System.Drawing.Size(149, 20);
			this.labelPosition.TabIndex = 6;
			this.labelPosition.Text = "Положение объекта:";
			this.labelPosition.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// buttonOk
			// 
			this.buttonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.buttonOk.Location = new System.Drawing.Point(423, 255);
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.Size = new System.Drawing.Size(87, 28);
			this.buttonOk.TabIndex = 4;
			this.buttonOk.Text = "Применить";
			this.buttonOk.UseVisualStyleBackColor = true;
			// 
			// buttonCancel
			// 
			this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.Location = new System.Drawing.Point(530, 255);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(87, 28);
			this.buttonCancel.TabIndex = 3;
			this.buttonCancel.Text = "Отмена";
			this.buttonCancel.UseVisualStyleBackColor = true;
			// 
			// TransformDialog
			// 
			this.AcceptButton = this.buttonOk;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.buttonCancel;
			this.ClientSize = new System.Drawing.Size(629, 297);
			this.Controls.Add(this.buttonOk);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.groupBoxTransform);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "TransformDialog";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Преобразование объекта";
			this.Load += new System.EventHandler(this.TransformDialogLoad);
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TransformDialogFormClosed);
			this.groupBoxTransform.ResumeLayout(false);
			this.groupBoxTransform.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownAngleZ)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownAngleY)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownAngleX)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownScalingZ)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownScalingY)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownScalingX)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownPositionZ)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownPositionY)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownPositionX)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.NumericUpDown numericUpDownAngleX;
		private System.Windows.Forms.NumericUpDown numericUpDownAngleY;
		private System.Windows.Forms.NumericUpDown numericUpDownAngleZ;
		private System.Windows.Forms.Label labelScaling;
		private System.Windows.Forms.NumericUpDown numericUpDownScalingZ;
		private System.Windows.Forms.NumericUpDown numericUpDownScalingY;
		private System.Windows.Forms.NumericUpDown numericUpDownScalingX;
		private System.Windows.Forms.Label labelRotXRange;
		private System.Windows.Forms.Label labelRotYRange;
		private System.Windows.Forms.Label labelRotZRange;
		private System.Windows.Forms.Label labelOrientation;
		private System.Windows.Forms.Label labelY;
		private System.Windows.Forms.Label labelZ;
		private System.Windows.Forms.Label labelX;
		private System.Windows.Forms.NumericUpDown numericUpDownPositionX;
		private System.Windows.Forms.NumericUpDown numericUpDownPositionY;
		private System.Windows.Forms.NumericUpDown numericUpDownPositionZ;
		private System.Windows.Forms.Label labelPosition;
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.Button buttonOk;
		private System.Windows.Forms.GroupBox groupBoxTransform;
	}
}
