namespace Tutorial.Butterfly
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

			this.timer.Enabled = true;
			this.timer.Interval = 30;
			this.timer.Tick += new System.EventHandler(this.TimerTick);

			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(683, 547);
			this.DoubleBuffered = true;
			this.Name = "MainForm";
			this.Text = "Tutorial - Butterfly";
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.MainFormPaint);
			this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainFormMouseMove);
			this.ResumeLayout(false);
		}
		
		private System.Windows.Forms.Timer timer;
	}
}
