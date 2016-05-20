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
			this.SuspendLayout();
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(616, 464);
			this.DoubleBuffered = true;
			this.Name = "MainForm";
			this.Text = "Tutorial - Welcome";
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.MainFormPaint);
			this.Resize += new System.EventHandler(this.MainFormResize);
			this.ResumeLayout(false);
		}
	}
}
