namespace Tutorial.ImageProcessing
{
	partial class HistogramDialog
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
			this.panelRedHistogram = new System.Windows.Forms.Panel();
			this.panelGreenHistogram = new System.Windows.Forms.Panel();
			this.panelBlueHistogram = new System.Windows.Forms.Panel();
			this.panelTotalHistogram = new System.Windows.Forms.Panel();
			this.SuspendLayout();
			// 
			// panelRedHistogram
			// 
			this.panelRedHistogram.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panelRedHistogram.Location = new System.Drawing.Point(12, 12);
			this.panelRedHistogram.Name = "panelRedHistogram";
			this.panelRedHistogram.Size = new System.Drawing.Size(255, 100);
			this.panelRedHistogram.TabIndex = 0;
			// 
			// panelGreenHistogram
			// 
			this.panelGreenHistogram.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panelGreenHistogram.Location = new System.Drawing.Point(280, 12);
			this.panelGreenHistogram.Name = "panelGreenHistogram";
			this.panelGreenHistogram.Size = new System.Drawing.Size(255, 100);
			this.panelGreenHistogram.TabIndex = 1;
			// 
			// panelBlueHistogram
			// 
			this.panelBlueHistogram.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panelBlueHistogram.Location = new System.Drawing.Point(12, 125);
			this.panelBlueHistogram.Name = "panelBlueHistogram";
			this.panelBlueHistogram.Size = new System.Drawing.Size(255, 100);
			this.panelBlueHistogram.TabIndex = 2;
			// 
			// panelTotalHistogram
			// 
			this.panelTotalHistogram.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panelTotalHistogram.Location = new System.Drawing.Point(280, 125);
			this.panelTotalHistogram.Name = "panelTotalHistogram";
			this.panelTotalHistogram.Size = new System.Drawing.Size(255, 100);
			this.panelTotalHistogram.TabIndex = 3;
			// 
			// HistogramDialog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(548, 238);
			this.Controls.Add(this.panelTotalHistogram);
			this.Controls.Add(this.panelBlueHistogram);
			this.Controls.Add(this.panelGreenHistogram);
			this.Controls.Add(this.panelRedHistogram);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "HistogramDialog";
			this.Text = "Гистограмма";
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.HistogramDialogPaint);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Panel panelTotalHistogram;
		private System.Windows.Forms.Panel panelBlueHistogram;
		private System.Windows.Forms.Panel panelGreenHistogram;
		private System.Windows.Forms.Panel panelRedHistogram;
	}
}
