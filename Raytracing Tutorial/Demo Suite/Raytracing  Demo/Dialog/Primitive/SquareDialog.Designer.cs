/*
 * Created by SharpDevelop.
 * User: Denis Bogolepov
 * Date: 17.04.2008
 * Time: 0:25
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace SceneEditor
{
	partial class SquareDialog
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
			this.groupBoxSquare = new System.Windows.Forms.GroupBox();
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.groupBoxSquare.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownSizeY)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownSizeX)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBoxSquare
			// 
			this.groupBoxSquare.Controls.Add(this.label1);
			this.groupBoxSquare.Controls.Add(this.label2);
			this.groupBoxSquare.Controls.Add(this.textBoxName);
			this.groupBoxSquare.Controls.Add(this.labelName);
			this.groupBoxSquare.Controls.Add(this.labelMaterial);
			this.groupBoxSquare.Controls.Add(this.labelTransform);
			this.groupBoxSquare.Controls.Add(this.buttonMaterial);
			this.groupBoxSquare.Controls.Add(this.buttonTransform);
			this.groupBoxSquare.Controls.Add(this.numericUpDownSizeY);
			this.groupBoxSquare.Controls.Add(this.numericUpDownSizeX);
			this.groupBoxSquare.Controls.Add(this.labelSize);
			this.groupBoxSquare.Location = new System.Drawing.Point(12, 12);
			this.groupBoxSquare.Name = "groupBoxSquare";
			this.groupBoxSquare.Size = new System.Drawing.Size(425, 267);
			this.groupBoxSquare.TabIndex = 0;
			this.groupBoxSquare.TabStop = false;
			this.groupBoxSquare.Text = "Объект \'Прямоугольник\'";
			// 
			// textBoxName
			// 
			this.textBoxName.Location = new System.Drawing.Point(192, 41);
			this.textBoxName.Name = "textBoxName";
			this.textBoxName.Size = new System.Drawing.Size(197, 20);
			this.textBoxName.TabIndex = 38;
			this.textBoxName.Text = "Прямоугольник";
			// 
			// labelName
			// 
			this.labelName.Location = new System.Drawing.Point(32, 40);
			this.labelName.Name = "labelName";
			this.labelName.Size = new System.Drawing.Size(154, 20);
			this.labelName.TabIndex = 37;
			this.labelName.Text = "Название объекта:";
			this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// labelMaterial
			// 
			this.labelMaterial.Location = new System.Drawing.Point(32, 207);
			this.labelMaterial.Name = "labelMaterial";
			this.labelMaterial.Size = new System.Drawing.Size(154, 20);
			this.labelMaterial.TabIndex = 30;
			this.labelMaterial.Text = "Материал объекта:";
			this.labelMaterial.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// labelTransform
			// 
			this.labelTransform.Location = new System.Drawing.Point(32, 154);
			this.labelTransform.Name = "labelTransform";
			this.labelTransform.Size = new System.Drawing.Size(154, 20);
			this.labelTransform.TabIndex = 29;
			this.labelTransform.Text = "Преобразование объекта:";
			this.labelTransform.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// buttonMaterial
			// 
			this.buttonMaterial.Location = new System.Drawing.Point(192, 202);
			this.buttonMaterial.Name = "buttonMaterial";
			this.buttonMaterial.Size = new System.Drawing.Size(197, 30);
			this.buttonMaterial.TabIndex = 28;
			this.buttonMaterial.Text = "Выбрать";
			this.buttonMaterial.UseVisualStyleBackColor = true;
			this.buttonMaterial.Click += new System.EventHandler(this.ButtonMaterialClick);
			// 
			// buttonTransform
			// 
			this.buttonTransform.Location = new System.Drawing.Point(192, 149);
			this.buttonTransform.Name = "buttonTransform";
			this.buttonTransform.Size = new System.Drawing.Size(197, 30);
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
			this.numericUpDownSizeY.Location = new System.Drawing.Point(302, 102);
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
			this.numericUpDownSizeX.Location = new System.Drawing.Point(192, 102);
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
			this.labelSize.Location = new System.Drawing.Point(32, 100);
			this.labelSize.Name = "labelSize";
			this.labelSize.Size = new System.Drawing.Size(154, 20);
			this.labelSize.TabIndex = 22;
			this.labelSize.Text = "Размеры прямоугольника:";
			this.labelSize.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// buttonOK
			// 
			this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.buttonOK.Location = new System.Drawing.Point(243, 293);
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.Size = new System.Drawing.Size(87, 28);
			this.buttonOK.TabIndex = 6;
			this.buttonOK.Text = "Применить";
			this.buttonOK.UseVisualStyleBackColor = true;
			// 
			// buttonCancel
			// 
			this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.Location = new System.Drawing.Point(350, 293);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(87, 28);
			this.buttonCancel.TabIndex = 5;
			this.buttonCancel.Text = "Отмена";
			this.buttonCancel.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.ForeColor = System.Drawing.Color.Green;
			this.label1.Location = new System.Drawing.Point(299, 80);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(89, 13);
			this.label1.TabIndex = 53;
			this.label1.Text = "-∞ - - - <Y> - - - +∞";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.ForeColor = System.Drawing.Color.Red;
			this.label2.Location = new System.Drawing.Point(189, 80);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(89, 13);
			this.label2.TabIndex = 52;
			this.label2.Text = "-∞ - - - <X> - - - +∞";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// SquareDialog
			// 
			this.AcceptButton = this.buttonOK;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.buttonCancel;
			this.ClientSize = new System.Drawing.Size(449, 334);
			this.Controls.Add(this.buttonOK);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.groupBoxSquare);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "SquareDialog";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Параметры объекта \'Прямоугольник\'";
			this.Load += new System.EventHandler(this.SquareDialogLoad);
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SquareDialogFormClosed);
			this.groupBoxSquare.ResumeLayout(false);
			this.groupBoxSquare.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownSizeY)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownSizeX)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button buttonOK;
		private System.Windows.Forms.Label labelName;
		private System.Windows.Forms.TextBox textBoxName;
		private System.Windows.Forms.NumericUpDown numericUpDownSizeY;
		private System.Windows.Forms.NumericUpDown numericUpDownSizeX;
		private System.Windows.Forms.Label labelSize;
		private System.Windows.Forms.Button buttonMaterial;
		private System.Windows.Forms.Button buttonTransform;
		private System.Windows.Forms.Label labelMaterial;
		private System.Windows.Forms.Label labelTransform;
		private System.Windows.Forms.GroupBox groupBoxSquare;
		private System.Windows.Forms.Button buttonCancel;
	}
}
