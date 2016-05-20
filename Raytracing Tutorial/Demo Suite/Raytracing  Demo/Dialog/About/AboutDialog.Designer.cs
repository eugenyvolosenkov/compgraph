namespace SceneEditor
{
	partial class AboutDialog
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutDialog));
			this.buttonOK = new System.Windows.Forms.Button();
			this.pictureBoxImage = new System.Windows.Forms.PictureBox();
			this.labelCaption = new System.Windows.Forms.Label();
			this.labelLine = new System.Windows.Forms.Label();
			this.labelIntelStudio = new System.Windows.Forms.Label();
			this.labelNames = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).BeginInit();
			this.SuspendLayout();
			// 
			// buttonOK
			// 
			this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.buttonOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonOK.Location = new System.Drawing.Point(373, 183);
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.Size = new System.Drawing.Size(275, 30);
			this.buttonOK.TabIndex = 0;
			this.buttonOK.Text = "OK";
			this.buttonOK.UseVisualStyleBackColor = true;
			// 
			// pictureBoxImage
			// 
			this.pictureBoxImage.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxImage.Image")));
			this.pictureBoxImage.Location = new System.Drawing.Point(12, 12);
			this.pictureBoxImage.Name = "pictureBoxImage";
			this.pictureBoxImage.Size = new System.Drawing.Size(340, 201);
			this.pictureBoxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBoxImage.TabIndex = 1;
			this.pictureBoxImage.TabStop = false;
			// 
			// labelCaption
			// 
			this.labelCaption.Font = new System.Drawing.Font("Consolas", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.labelCaption.Location = new System.Drawing.Point(373, 12);
			this.labelCaption.Name = "labelCaption";
			this.labelCaption.Size = new System.Drawing.Size(275, 42);
			this.labelCaption.TabIndex = 2;
			this.labelCaption.Text = "Демонстрация  метода трассировки лучей";
			this.labelCaption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// labelLine
			// 
			this.labelLine.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelLine.ForeColor = System.Drawing.Color.Black;
			this.labelLine.Location = new System.Drawing.Point(373, 40);
			this.labelLine.Name = "labelLine";
			this.labelLine.Size = new System.Drawing.Size(275, 30);
			this.labelLine.TabIndex = 3;
			this.labelLine.Text = "__________________________";
			this.labelLine.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// labelIntelStudio
			// 
			this.labelIntelStudio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelIntelStudio.Location = new System.Drawing.Point(373, 73);
			this.labelIntelStudio.Name = "labelIntelStudio";
			this.labelIntelStudio.Size = new System.Drawing.Size(275, 40);
			this.labelIntelStudio.TabIndex = 4;
			this.labelIntelStudio.Text = "Приложение разработано в рамках проекта Intel Studio Graphics 2008";
			this.labelIntelStudio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// labelNames
			// 
			this.labelNames.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelNames.Location = new System.Drawing.Point(373, 131);
			this.labelNames.Name = "labelNames";
			this.labelNames.Size = new System.Drawing.Size(275, 37);
			this.labelNames.TabIndex = 5;
			this.labelNames.Text = "Боголепов Денис";
			this.labelNames.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// AboutDialog
			// 
			this.AcceptButton = this.buttonOK;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(668, 230);
			this.Controls.Add(this.labelNames);
			this.Controls.Add(this.labelIntelStudio);
			this.Controls.Add(this.labelCaption);
			this.Controls.Add(this.labelLine);
			this.Controls.Add(this.pictureBoxImage);
			this.Controls.Add(this.buttonOK);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "AboutDialog";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "О программе";
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).EndInit();
			this.ResumeLayout(false);
		}
		
		private System.Windows.Forms.Label labelNames;
		private System.Windows.Forms.Label labelIntelStudio;
		private System.Windows.Forms.Label labelLine;
		private System.Windows.Forms.Label labelCaption;
		private System.Windows.Forms.PictureBox pictureBoxImage;
		private System.Windows.Forms.Button buttonOK;
	}
}
