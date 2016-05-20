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
			this.timer = new System.Windows.Forms.Timer(this.components);
			this.SuspendLayout();
			// 
			// timer
			// 
			this.timer.Enabled = true;
			this.timer.Interval = 15;
			this.timer.Tick += new System.EventHandler(this.TimerTick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(642, 639);
			this.DoubleBuffered = true;
			this.Name = "MainForm";
			this.Text = "Tutorial - Arcanoid";
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.MainFormPaint);
			this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainFormMouseMove);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Timer timer;
	}
}
