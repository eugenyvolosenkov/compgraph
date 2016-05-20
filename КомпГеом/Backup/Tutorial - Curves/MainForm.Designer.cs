namespace Tutorial.Curves
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
			this.menuStrip = new System.Windows.Forms.MenuStrip();
			this.menuItemFile = new System.Windows.Forms.ToolStripMenuItem();
			this.menuItemExit = new System.Windows.Forms.ToolStripMenuItem();
			this.menuItemCurve = new System.Windows.Forms.ToolStripMenuItem();
			this.menuItemBezier = new System.Windows.Forms.ToolStripMenuItem();
			this.menuItemSpline = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip
			// 
			this.menuStrip.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.menuItemFile,
									this.menuItemCurve});
			this.menuStrip.Location = new System.Drawing.Point(0, 0);
			this.menuStrip.Name = "menuStrip";
			this.menuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
			this.menuStrip.Size = new System.Drawing.Size(521, 24);
			this.menuStrip.TabIndex = 3;
			// 
			// menuItemFile
			// 
			this.menuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.menuItemExit});
			this.menuItemFile.Name = "menuItemFile";
			this.menuItemFile.Size = new System.Drawing.Size(45, 20);
			this.menuItemFile.Text = "Файл";
			// 
			// menuItemExit
			// 
			this.menuItemExit.Name = "menuItemExit";
			this.menuItemExit.Size = new System.Drawing.Size(152, 22);
			this.menuItemExit.Text = "Выход";
			// 
			// menuItemCurve
			// 
			this.menuItemCurve.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.menuItemBezier,
									this.menuItemSpline});
			this.menuItemCurve.Name = "menuItemCurve";
			this.menuItemCurve.Size = new System.Drawing.Size(76, 20);
			this.menuItemCurve.Text = "Тип кривой";
			// 
			// menuItemBezier
			// 
			this.menuItemBezier.Name = "menuItemBezier";
			this.menuItemBezier.Size = new System.Drawing.Size(212, 22);
			this.menuItemBezier.Text = "GDI+ Безье";
			this.menuItemBezier.Click += new System.EventHandler(this.MenuItemBezierClick);
			// 
			// menuItemSpline
			// 
			this.menuItemSpline.Checked = true;
			this.menuItemSpline.CheckState = System.Windows.Forms.CheckState.Checked;
			this.menuItemSpline.Name = "menuItemSpline";
			this.menuItemSpline.Size = new System.Drawing.Size(212, 22);
			this.menuItemSpline.Text = "GDI+ Кубический сплайн";
			this.menuItemSpline.Click += new System.EventHandler(this.MenuItemSplineClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(521, 508);
			this.Controls.Add(this.menuStrip);
			this.DoubleBuffered = true;
			this.MainMenuStrip = this.menuStrip;
			this.Name = "MainForm";
			this.Text = "Tutorial - Curves";
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.MainFormPaint);
			this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainFormMouseMove);
			this.menuStrip.ResumeLayout(false);
			this.menuStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.MenuStrip menuStrip;
		private System.Windows.Forms.ToolStripMenuItem menuItemSpline;
		private System.Windows.Forms.ToolStripMenuItem menuItemBezier;
		private System.Windows.Forms.ToolStripMenuItem menuItemCurve;
		private System.Windows.Forms.ToolStripMenuItem menuItemExit;
		private System.Windows.Forms.ToolStripMenuItem menuItemFile;
	}
}
