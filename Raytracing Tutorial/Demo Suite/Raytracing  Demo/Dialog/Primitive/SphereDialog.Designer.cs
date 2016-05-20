namespace SceneEditor
{
	partial class SphereDialog
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
			this.groupBoxSphere = new System.Windows.Forms.GroupBox();
			this.textBoxName = new System.Windows.Forms.TextBox();
			this.labelName = new System.Windows.Forms.Label();
			this.labelMaterial = new System.Windows.Forms.Label();
			this.labelTransform = new System.Windows.Forms.Label();
			this.buttonMaterial = new System.Windows.Forms.Button();
			this.buttonTransform = new System.Windows.Forms.Button();
			this.numericUpDownRadius = new System.Windows.Forms.NumericUpDown();
			this.labelRadius = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.groupBoxSphere.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownRadius)).BeginInit();
			this.SuspendLayout();
			// 
			// buttonOK
			// 
			this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.buttonOK.Location = new System.Drawing.Point(214, 284);
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.Size = new System.Drawing.Size(87, 28);
			this.buttonOK.TabIndex = 9;
			this.buttonOK.Text = "Применить";
			this.buttonOK.UseVisualStyleBackColor = true;
			// 
			// buttonCancel
			// 
			this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.Location = new System.Drawing.Point(321, 284);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(87, 28);
			this.buttonCancel.TabIndex = 8;
			this.buttonCancel.Text = "Отмена";
			this.buttonCancel.UseVisualStyleBackColor = true;
			// 
			// groupBoxSphere
			// 
			this.groupBoxSphere.Controls.Add(this.label2);
			this.groupBoxSphere.Controls.Add(this.textBoxName);
			this.groupBoxSphere.Controls.Add(this.labelName);
			this.groupBoxSphere.Controls.Add(this.labelMaterial);
			this.groupBoxSphere.Controls.Add(this.labelTransform);
			this.groupBoxSphere.Controls.Add(this.buttonMaterial);
			this.groupBoxSphere.Controls.Add(this.buttonTransform);
			this.groupBoxSphere.Controls.Add(this.numericUpDownRadius);
			this.groupBoxSphere.Controls.Add(this.labelRadius);
			this.groupBoxSphere.Location = new System.Drawing.Point(12, 12);
			this.groupBoxSphere.Name = "groupBoxSphere";
			this.groupBoxSphere.Size = new System.Drawing.Size(396, 259);
			this.groupBoxSphere.TabIndex = 7;
			this.groupBoxSphere.TabStop = false;
			this.groupBoxSphere.Text = "Объект \'Сфера\'";
			// 
			// textBoxName
			// 
			this.textBoxName.Location = new System.Drawing.Point(192, 42);
			this.textBoxName.Name = "textBoxName";
			this.textBoxName.Size = new System.Drawing.Size(167, 20);
			this.textBoxName.TabIndex = 36;
			this.textBoxName.Text = "Сфера";
			// 
			// labelName
			// 
			this.labelName.Location = new System.Drawing.Point(32, 41);
			this.labelName.Name = "labelName";
			this.labelName.Size = new System.Drawing.Size(154, 20);
			this.labelName.TabIndex = 35;
			this.labelName.Text = "Название объекта:";
			this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// labelMaterial
			// 
			this.labelMaterial.Location = new System.Drawing.Point(32, 197);
			this.labelMaterial.Name = "labelMaterial";
			this.labelMaterial.Size = new System.Drawing.Size(154, 20);
			this.labelMaterial.TabIndex = 30;
			this.labelMaterial.Text = "Материал объекта:";
			this.labelMaterial.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// labelTransform
			// 
			this.labelTransform.Location = new System.Drawing.Point(32, 144);
			this.labelTransform.Name = "labelTransform";
			this.labelTransform.Size = new System.Drawing.Size(154, 20);
			this.labelTransform.TabIndex = 29;
			this.labelTransform.Text = "Преобразование объекта:";
			this.labelTransform.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// buttonMaterial
			// 
			this.buttonMaterial.Location = new System.Drawing.Point(192, 192);
			this.buttonMaterial.Name = "buttonMaterial";
			this.buttonMaterial.Size = new System.Drawing.Size(167, 30);
			this.buttonMaterial.TabIndex = 28;
			this.buttonMaterial.Text = "Выбрать";
			this.buttonMaterial.UseVisualStyleBackColor = true;
			this.buttonMaterial.Click += new System.EventHandler(this.ButtonMaterialClick);
			// 
			// buttonTransform
			// 
			this.buttonTransform.Location = new System.Drawing.Point(192, 139);
			this.buttonTransform.Name = "buttonTransform";
			this.buttonTransform.Size = new System.Drawing.Size(167, 30);
			this.buttonTransform.TabIndex = 27;
			this.buttonTransform.Text = "Выбрать";
			this.buttonTransform.UseVisualStyleBackColor = true;
			this.buttonTransform.Click += new System.EventHandler(this.ButtonTransformClick);
			// 
			// numericUpDownRadius
			// 
			this.numericUpDownRadius.DecimalPlaces = 2;
			this.numericUpDownRadius.Increment = new decimal(new int[] {
									2,
									0,
									0,
									131072});
			this.numericUpDownRadius.Location = new System.Drawing.Point(192, 98);
			this.numericUpDownRadius.Maximum = new decimal(new int[] {
									1000,
									0,
									0,
									0});
			this.numericUpDownRadius.Minimum = new decimal(new int[] {
									1,
									0,
									0,
									131072});
			this.numericUpDownRadius.Name = "numericUpDownRadius";
			this.numericUpDownRadius.Size = new System.Drawing.Size(167, 20);
			this.numericUpDownRadius.TabIndex = 23;
			this.numericUpDownRadius.Value = new decimal(new int[] {
									1,
									0,
									0,
									131072});
			// 
			// labelRadius
			// 
			this.labelRadius.Location = new System.Drawing.Point(32, 96);
			this.labelRadius.Name = "labelRadius";
			this.labelRadius.Size = new System.Drawing.Size(154, 20);
			this.labelRadius.TabIndex = 22;
			this.labelRadius.Text = "Радиус сферы:";
			this.labelRadius.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label2.Location = new System.Drawing.Point(188, 78);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(174, 13);
			this.label2.TabIndex = 53;
			this.label2.Text = "-∞ - - - - - - - - - - <R> - - - - - - - - - - +∞";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// SphereDialog
			// 
			this.AcceptButton = this.buttonOK;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.buttonCancel;
			this.ClientSize = new System.Drawing.Size(420, 325);
			this.Controls.Add(this.buttonOK);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.groupBoxSphere);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "SphereDialog";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Параметры объекта \'Сфера\'";
			this.Load += new System.EventHandler(this.SphereDialogLoad);
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SphereDialogFormClosed);
			this.groupBoxSphere.ResumeLayout(false);
			this.groupBoxSphere.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownRadius)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label labelName;
		private System.Windows.Forms.TextBox textBoxName;
		private System.Windows.Forms.Button buttonOK;
		private System.Windows.Forms.GroupBox groupBoxSphere;
		private System.Windows.Forms.Button buttonTransform;
		private System.Windows.Forms.Button buttonMaterial;
		private System.Windows.Forms.Label labelTransform;
		private System.Windows.Forms.Label labelMaterial;
		private System.Windows.Forms.Label labelRadius;
		private System.Windows.Forms.NumericUpDown numericUpDownRadius;
		private System.Windows.Forms.Button buttonCancel;
	}
}
