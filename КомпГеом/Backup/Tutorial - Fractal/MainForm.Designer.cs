namespace Tutorial.Arcanoid
{
	partial class MainForm
	{
		private System.ComponentModel.IContainer components = null;
		
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.groupBoxArea = new System.Windows.Forms.GroupBox();
			this.labelRangeY = new System.Windows.Forms.Label();
			this.upDownMaxY = new System.Windows.Forms.NumericUpDown();
			this.upDownMinY = new System.Windows.Forms.NumericUpDown();
			this.labelRangeX = new System.Windows.Forms.Label();
			this.upDownMaxX = new System.Windows.Forms.NumericUpDown();
			this.upDownMinX = new System.Windows.Forms.NumericUpDown();
			this.pictureBox = new System.Windows.Forms.PictureBox();
			this.buttonBuild = new System.Windows.Forms.Button();
			this.groupBoxType = new System.Windows.Forms.GroupBox();
			this.radioButtonJulia = new System.Windows.Forms.RadioButton();
			this.radioButtonMandel = new System.Windows.Forms.RadioButton();
			this.groupBoxMove = new System.Windows.Forms.GroupBox();
			this.buttonZoomOut = new System.Windows.Forms.Button();
			this.imageList = new System.Windows.Forms.ImageList(this.components);
			this.buttonZoomIn = new System.Windows.Forms.Button();
			this.buttonDown = new System.Windows.Forms.Button();
			this.buttonRight = new System.Windows.Forms.Button();
			this.buttonLeft = new System.Windows.Forms.Button();
			this.buttonUp = new System.Windows.Forms.Button();
			this.groupBoxArea.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.upDownMaxY)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.upDownMinY)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.upDownMaxX)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.upDownMinX)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
			this.groupBoxType.SuspendLayout();
			this.groupBoxMove.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBoxArea
			// 
			this.groupBoxArea.Controls.Add(this.labelRangeY);
			this.groupBoxArea.Controls.Add(this.upDownMaxY);
			this.groupBoxArea.Controls.Add(this.upDownMinY);
			this.groupBoxArea.Controls.Add(this.labelRangeX);
			this.groupBoxArea.Controls.Add(this.upDownMaxX);
			this.groupBoxArea.Controls.Add(this.upDownMinX);
			this.groupBoxArea.Location = new System.Drawing.Point(537, 12);
			this.groupBoxArea.Name = "groupBoxArea";
			this.groupBoxArea.Size = new System.Drawing.Size(196, 171);
			this.groupBoxArea.TabIndex = 0;
			this.groupBoxArea.TabStop = false;
			this.groupBoxArea.Text = "Область";
			// 
			// labelRangeY
			// 
			this.labelRangeY.AutoSize = true;
			this.labelRangeY.Location = new System.Drawing.Point(16, 95);
			this.labelRangeY.Name = "labelRangeY";
			this.labelRangeY.Size = new System.Drawing.Size(121, 13);
			this.labelRangeY.TabIndex = 5;
			this.labelRangeY.Text = "Диапазон значений Y:";
			this.labelRangeY.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// upDownMaxY
			// 
			this.upDownMaxY.DecimalPlaces = 4;
			this.upDownMaxY.Location = new System.Drawing.Point(112, 115);
			this.upDownMaxY.Minimum = new decimal(new int[] {
									100,
									0,
									0,
									-2147483648});
			this.upDownMaxY.Name = "upDownMaxY";
			this.upDownMaxY.Size = new System.Drawing.Size(69, 20);
			this.upDownMaxY.TabIndex = 4;
			this.upDownMaxY.Value = new decimal(new int[] {
									15,
									0,
									0,
									65536});
			// 
			// upDownMinY
			// 
			this.upDownMinY.DecimalPlaces = 4;
			this.upDownMinY.Location = new System.Drawing.Point(16, 115);
			this.upDownMinY.Minimum = new decimal(new int[] {
									100,
									0,
									0,
									-2147483648});
			this.upDownMinY.Name = "upDownMinY";
			this.upDownMinY.Size = new System.Drawing.Size(69, 20);
			this.upDownMinY.TabIndex = 3;
			this.upDownMinY.Value = new decimal(new int[] {
									15,
									0,
									0,
									-2147418112});
			// 
			// labelRangeX
			// 
			this.labelRangeX.AutoSize = true;
			this.labelRangeX.Location = new System.Drawing.Point(16, 34);
			this.labelRangeX.Name = "labelRangeX";
			this.labelRangeX.Size = new System.Drawing.Size(121, 13);
			this.labelRangeX.TabIndex = 2;
			this.labelRangeX.Text = "Диапазон значений X:";
			this.labelRangeX.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// upDownMaxX
			// 
			this.upDownMaxX.DecimalPlaces = 4;
			this.upDownMaxX.Location = new System.Drawing.Point(112, 54);
			this.upDownMaxX.Minimum = new decimal(new int[] {
									100,
									0,
									0,
									-2147483648});
			this.upDownMaxX.Name = "upDownMaxX";
			this.upDownMaxX.Size = new System.Drawing.Size(69, 20);
			this.upDownMaxX.TabIndex = 1;
			this.upDownMaxX.Value = new decimal(new int[] {
									1,
									0,
									0,
									0});
			// 
			// upDownMinX
			// 
			this.upDownMinX.DecimalPlaces = 4;
			this.upDownMinX.Location = new System.Drawing.Point(16, 54);
			this.upDownMinX.Minimum = new decimal(new int[] {
									100,
									0,
									0,
									-2147483648});
			this.upDownMinX.Name = "upDownMinX";
			this.upDownMinX.Size = new System.Drawing.Size(69, 20);
			this.upDownMinX.TabIndex = 0;
			this.upDownMinX.Value = new decimal(new int[] {
									2,
									0,
									0,
									-2147483648});
			// 
			// pictureBox
			// 
			this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pictureBox.Location = new System.Drawing.Point(12, 12);
			this.pictureBox.Name = "pictureBox";
			this.pictureBox.Size = new System.Drawing.Size(512, 512);
			this.pictureBox.TabIndex = 1;
			this.pictureBox.TabStop = false;
			// 
			// buttonBuild
			// 
			this.buttonBuild.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonBuild.Location = new System.Drawing.Point(54, 63);
			this.buttonBuild.Name = "buttonBuild";
			this.buttonBuild.Size = new System.Drawing.Size(25, 25);
			this.buttonBuild.TabIndex = 2;
			this.buttonBuild.UseVisualStyleBackColor = true;
			this.buttonBuild.Click += new System.EventHandler(this.ButtonBuildClick);
			// 
			// groupBoxType
			// 
			this.groupBoxType.Controls.Add(this.radioButtonJulia);
			this.groupBoxType.Controls.Add(this.radioButtonMandel);
			this.groupBoxType.Location = new System.Drawing.Point(537, 189);
			this.groupBoxType.Name = "groupBoxType";
			this.groupBoxType.Size = new System.Drawing.Size(200, 107);
			this.groupBoxType.TabIndex = 3;
			this.groupBoxType.TabStop = false;
			this.groupBoxType.Text = "Тип фрактала";
			// 
			// radioButtonJulia
			// 
			this.radioButtonJulia.AutoSize = true;
			this.radioButtonJulia.Location = new System.Drawing.Point(16, 63);
			this.radioButtonJulia.Name = "radioButtonJulia";
			this.radioButtonJulia.Size = new System.Drawing.Size(111, 17);
			this.radioButtonJulia.TabIndex = 1;
			this.radioButtonJulia.Text = "Фрактал Жюлии";
			this.radioButtonJulia.UseVisualStyleBackColor = true;
			// 
			// radioButtonMandel
			// 
			this.radioButtonMandel.AutoSize = true;
			this.radioButtonMandel.Checked = true;
			this.radioButtonMandel.Location = new System.Drawing.Point(16, 34);
			this.radioButtonMandel.Name = "radioButtonMandel";
			this.radioButtonMandel.Size = new System.Drawing.Size(148, 17);
			this.radioButtonMandel.TabIndex = 0;
			this.radioButtonMandel.TabStop = true;
			this.radioButtonMandel.Text = "Фрактал Мандельброта";
			this.radioButtonMandel.UseVisualStyleBackColor = true;
			// 
			// groupBoxMove
			// 
			this.groupBoxMove.Controls.Add(this.buttonZoomOut);
			this.groupBoxMove.Controls.Add(this.buttonZoomIn);
			this.groupBoxMove.Controls.Add(this.buttonDown);
			this.groupBoxMove.Controls.Add(this.buttonRight);
			this.groupBoxMove.Controls.Add(this.buttonBuild);
			this.groupBoxMove.Controls.Add(this.buttonLeft);
			this.groupBoxMove.Controls.Add(this.buttonUp);
			this.groupBoxMove.Location = new System.Drawing.Point(537, 302);
			this.groupBoxMove.Name = "groupBoxMove";
			this.groupBoxMove.Size = new System.Drawing.Size(200, 140);
			this.groupBoxMove.TabIndex = 4;
			this.groupBoxMove.TabStop = false;
			this.groupBoxMove.Text = "Перемещение";
			// 
			// buttonZoomOut
			// 
			this.buttonZoomOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonZoomOut.ForeColor = System.Drawing.Color.Black;
			this.buttonZoomOut.ImageList = this.imageList;
			this.buttonZoomOut.Location = new System.Drawing.Point(145, 91);
			this.buttonZoomOut.Name = "buttonZoomOut";
			this.buttonZoomOut.Size = new System.Drawing.Size(25, 25);
			this.buttonZoomOut.TabIndex = 5;
			this.buttonZoomOut.Text = "-";
			this.buttonZoomOut.UseVisualStyleBackColor = true;
			this.buttonZoomOut.Click += new System.EventHandler(this.ButtonZoomOutClick);
			// 
			// imageList
			// 
			this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
			this.imageList.TransparentColor = System.Drawing.Color.White;
			this.imageList.Images.SetKeyName(0, "4.bmp");
			this.imageList.Images.SetKeyName(1, "1.bmp");
			this.imageList.Images.SetKeyName(2, "2.bmp");
			this.imageList.Images.SetKeyName(3, "3.bmp");
			// 
			// buttonZoomIn
			// 
			this.buttonZoomIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonZoomIn.ForeColor = System.Drawing.Color.Black;
			this.buttonZoomIn.ImageList = this.imageList;
			this.buttonZoomIn.Location = new System.Drawing.Point(145, 35);
			this.buttonZoomIn.Name = "buttonZoomIn";
			this.buttonZoomIn.Size = new System.Drawing.Size(25, 25);
			this.buttonZoomIn.TabIndex = 4;
			this.buttonZoomIn.Text = "+";
			this.buttonZoomIn.UseVisualStyleBackColor = true;
			this.buttonZoomIn.Click += new System.EventHandler(this.ButtonZoomInClick);
			// 
			// buttonDown
			// 
			this.buttonDown.ForeColor = System.Drawing.SystemColors.ControlText;
			this.buttonDown.ImageIndex = 3;
			this.buttonDown.ImageList = this.imageList;
			this.buttonDown.Location = new System.Drawing.Point(54, 91);
			this.buttonDown.Name = "buttonDown";
			this.buttonDown.Size = new System.Drawing.Size(25, 25);
			this.buttonDown.TabIndex = 3;
			this.buttonDown.UseVisualStyleBackColor = true;
			this.buttonDown.Click += new System.EventHandler(this.ButtonDownClick);
			// 
			// buttonRight
			// 
			this.buttonRight.ImageIndex = 2;
			this.buttonRight.ImageList = this.imageList;
			this.buttonRight.Location = new System.Drawing.Point(82, 63);
			this.buttonRight.Name = "buttonRight";
			this.buttonRight.Size = new System.Drawing.Size(25, 25);
			this.buttonRight.TabIndex = 2;
			this.buttonRight.UseVisualStyleBackColor = true;
			this.buttonRight.Click += new System.EventHandler(this.ButtonRightClick);
			// 
			// buttonLeft
			// 
			this.buttonLeft.ImageIndex = 0;
			this.buttonLeft.ImageList = this.imageList;
			this.buttonLeft.Location = new System.Drawing.Point(26, 63);
			this.buttonLeft.Name = "buttonLeft";
			this.buttonLeft.Size = new System.Drawing.Size(25, 25);
			this.buttonLeft.TabIndex = 1;
			this.buttonLeft.UseVisualStyleBackColor = true;
			this.buttonLeft.Click += new System.EventHandler(this.ButtonLeftClick);
			// 
			// buttonUp
			// 
			this.buttonUp.ForeColor = System.Drawing.SystemColors.ControlText;
			this.buttonUp.ImageIndex = 1;
			this.buttonUp.ImageList = this.imageList;
			this.buttonUp.Location = new System.Drawing.Point(54, 35);
			this.buttonUp.Name = "buttonUp";
			this.buttonUp.Size = new System.Drawing.Size(25, 25);
			this.buttonUp.TabIndex = 0;
			this.buttonUp.UseVisualStyleBackColor = true;
			this.buttonUp.Click += new System.EventHandler(this.ButtonUpClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(744, 536);
			this.Controls.Add(this.groupBoxMove);
			this.Controls.Add(this.groupBoxType);
			this.Controls.Add(this.pictureBox);
			this.Controls.Add(this.groupBoxArea);
			this.Name = "MainForm";
			this.Text = "Tutorial - Fractal";
			this.groupBoxArea.ResumeLayout(false);
			this.groupBoxArea.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.upDownMaxY)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.upDownMinY)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.upDownMaxX)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.upDownMinX)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
			this.groupBoxType.ResumeLayout(false);
			this.groupBoxType.PerformLayout();
			this.groupBoxMove.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button buttonZoomIn;
		private System.Windows.Forms.Button buttonZoomOut;
		private System.Windows.Forms.Button buttonUp;
		private System.Windows.Forms.Button buttonLeft;
		private System.Windows.Forms.Button buttonRight;
		private System.Windows.Forms.Button buttonDown;
		private System.Windows.Forms.GroupBox groupBoxMove;
		private System.Windows.Forms.ImageList imageList;
		private System.Windows.Forms.GroupBox groupBoxType;
		private System.Windows.Forms.RadioButton radioButtonMandel;
		private System.Windows.Forms.RadioButton radioButtonJulia;
		private System.Windows.Forms.Button buttonBuild;
		private System.Windows.Forms.PictureBox pictureBox;
		private System.Windows.Forms.GroupBox groupBoxArea;
		private System.Windows.Forms.NumericUpDown upDownMaxX;
		private System.Windows.Forms.NumericUpDown upDownMinY;
		private System.Windows.Forms.NumericUpDown upDownMaxY;
		private System.Windows.Forms.Label labelRangeX;
		private System.Windows.Forms.Label labelRangeY;
		private System.Windows.Forms.NumericUpDown upDownMinX;
	}
}
