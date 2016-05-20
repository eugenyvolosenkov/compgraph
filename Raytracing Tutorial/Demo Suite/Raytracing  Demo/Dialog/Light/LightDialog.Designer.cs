namespace SceneEditor
{
	partial class LightDialog
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
            this.groupBoxLight = new System.Windows.Forms.GroupBox();
            this.labelZ = new System.Windows.Forms.Label();
            this.labelY = new System.Windows.Forms.Label();
            this.labelX = new System.Windows.Forms.Label();
            this.labelThird = new System.Windows.Forms.Label();
            this.labelSeventh = new System.Windows.Forms.Label();
            this.labelEighth = new System.Windows.Forms.Label();
            this.labelSixth = new System.Windows.Forms.Label();
            this.labelFifth = new System.Windows.Forms.Label();
            this.labelFourth = new System.Windows.Forms.Label();
            this.labelSecond = new System.Windows.Forms.Label();
            this.labelFirst = new System.Windows.Forms.Label();
            this.labelNumber = new System.Windows.Forms.Label();
            this.numericUpDownPositionZ = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownPositionY = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownPositionX = new System.Windows.Forms.NumericUpDown();
            this.labelPosition = new System.Windows.Forms.Label();
            this.labelBRange = new System.Windows.Forms.Label();
            this.labelGRange = new System.Windows.Forms.Label();
            this.labelRRange = new System.Windows.Forms.Label();
            this.trackBarSpecularB = new System.Windows.Forms.TrackBar();
            this.trackBarSpecularG = new System.Windows.Forms.TrackBar();
            this.trackBarSpecularR = new System.Windows.Forms.TrackBar();
            this.trackBarDiffuseB = new System.Windows.Forms.TrackBar();
            this.trackBarDiffuseG = new System.Windows.Forms.TrackBar();
            this.trackBarDiffuseR = new System.Windows.Forms.TrackBar();
            this.trackBarAmbiantB = new System.Windows.Forms.TrackBar();
            this.trackBarAmbiantG = new System.Windows.Forms.TrackBar();
            this.trackBarAmbiantR = new System.Windows.Forms.TrackBar();
            this.labelSpecular = new System.Windows.Forms.Label();
            this.labelDiffuse = new System.Windows.Forms.Label();
            this.labelAmbiant = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.groupBoxLight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPositionZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPositionY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPositionX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSpecularB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSpecularG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSpecularR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarDiffuseB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarDiffuseG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarDiffuseR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAmbiantB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAmbiantG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAmbiantR)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxLight
            // 
            this.groupBoxLight.Controls.Add(this.labelZ);
            this.groupBoxLight.Controls.Add(this.labelY);
            this.groupBoxLight.Controls.Add(this.labelX);
            this.groupBoxLight.Controls.Add(this.labelThird);
            this.groupBoxLight.Controls.Add(this.labelSeventh);
            this.groupBoxLight.Controls.Add(this.labelEighth);
            this.groupBoxLight.Controls.Add(this.labelSixth);
            this.groupBoxLight.Controls.Add(this.labelFifth);
            this.groupBoxLight.Controls.Add(this.labelFourth);
            this.groupBoxLight.Controls.Add(this.labelSecond);
            this.groupBoxLight.Controls.Add(this.labelFirst);
            this.groupBoxLight.Controls.Add(this.labelNumber);
            this.groupBoxLight.Controls.Add(this.numericUpDownPositionZ);
            this.groupBoxLight.Controls.Add(this.numericUpDownPositionY);
            this.groupBoxLight.Controls.Add(this.numericUpDownPositionX);
            this.groupBoxLight.Controls.Add(this.labelPosition);
            this.groupBoxLight.Controls.Add(this.labelBRange);
            this.groupBoxLight.Controls.Add(this.labelGRange);
            this.groupBoxLight.Controls.Add(this.labelRRange);
            this.groupBoxLight.Controls.Add(this.trackBarSpecularB);
            this.groupBoxLight.Controls.Add(this.trackBarSpecularG);
            this.groupBoxLight.Controls.Add(this.trackBarSpecularR);
            this.groupBoxLight.Controls.Add(this.trackBarDiffuseB);
            this.groupBoxLight.Controls.Add(this.trackBarDiffuseG);
            this.groupBoxLight.Controls.Add(this.trackBarDiffuseR);
            this.groupBoxLight.Controls.Add(this.trackBarAmbiantB);
            this.groupBoxLight.Controls.Add(this.trackBarAmbiantG);
            this.groupBoxLight.Controls.Add(this.trackBarAmbiantR);
            this.groupBoxLight.Controls.Add(this.labelSpecular);
            this.groupBoxLight.Controls.Add(this.labelDiffuse);
            this.groupBoxLight.Controls.Add(this.labelAmbiant);
            this.groupBoxLight.Location = new System.Drawing.Point(12, 12);
            this.groupBoxLight.Name = "groupBoxLight";
            this.groupBoxLight.Size = new System.Drawing.Size(675, 362);
            this.groupBoxLight.TabIndex = 0;
            this.groupBoxLight.TabStop = false;
            this.groupBoxLight.Text = "Свойства источника света (модель Уиттеда)";
            // 
            // labelZ
            // 
            this.labelZ.AutoSize = true;
            this.labelZ.ForeColor = System.Drawing.Color.Blue;
            this.labelZ.Location = new System.Drawing.Point(546, 96);
            this.labelZ.Name = "labelZ";
            this.labelZ.Size = new System.Drawing.Size(89, 13);
            this.labelZ.TabIndex = 49;
            this.labelZ.Text = "-∞ - - - <Z> - - - +∞";
            this.labelZ.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelY
            // 
            this.labelY.AutoSize = true;
            this.labelY.ForeColor = System.Drawing.Color.Green;
            this.labelY.Location = new System.Drawing.Point(411, 96);
            this.labelY.Name = "labelY";
            this.labelY.Size = new System.Drawing.Size(89, 13);
            this.labelY.TabIndex = 48;
            this.labelY.Text = "-∞ - - - <Y> - - - +∞";
            this.labelY.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelX.ForeColor = System.Drawing.Color.Red;
            this.labelX.Location = new System.Drawing.Point(277, 96);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(89, 13);
            this.labelX.TabIndex = 47;
            this.labelX.Text = "-∞ - - - <X> - - - +∞";
            this.labelX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelThird
            // 
            this.labelThird.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.labelThird.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelThird.Location = new System.Drawing.Point(372, 46);
            this.labelThird.Name = "labelThird";
            this.labelThird.Size = new System.Drawing.Size(28, 26);
            this.labelThird.TabIndex = 41;
            this.labelThird.Text = "3";
            this.labelThird.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSeventh
            // 
            this.labelSeventh.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelSeventh.Location = new System.Drawing.Point(560, 46);
            this.labelSeventh.Name = "labelSeventh";
            this.labelSeventh.Size = new System.Drawing.Size(28, 26);
            this.labelSeventh.TabIndex = 46;
            this.labelSeventh.Text = "7";
            this.labelSeventh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelEighth
            // 
            this.labelEighth.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelEighth.Location = new System.Drawing.Point(607, 46);
            this.labelEighth.Name = "labelEighth";
            this.labelEighth.Size = new System.Drawing.Size(28, 26);
            this.labelEighth.TabIndex = 45;
            this.labelEighth.Text = "8";
            this.labelEighth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSixth
            // 
            this.labelSixth.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelSixth.Location = new System.Drawing.Point(513, 46);
            this.labelSixth.Name = "labelSixth";
            this.labelSixth.Size = new System.Drawing.Size(28, 26);
            this.labelSixth.TabIndex = 44;
            this.labelSixth.Text = "6";
            this.labelSixth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelFifth
            // 
            this.labelFifth.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelFifth.Location = new System.Drawing.Point(466, 46);
            this.labelFifth.Name = "labelFifth";
            this.labelFifth.Size = new System.Drawing.Size(28, 26);
            this.labelFifth.TabIndex = 43;
            this.labelFifth.Text = "5";
            this.labelFifth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelFourth
            // 
            this.labelFourth.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelFourth.Location = new System.Drawing.Point(419, 46);
            this.labelFourth.Name = "labelFourth";
            this.labelFourth.Size = new System.Drawing.Size(28, 26);
            this.labelFourth.TabIndex = 42;
            this.labelFourth.Text = "4";
            this.labelFourth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSecond
            // 
            this.labelSecond.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelSecond.Location = new System.Drawing.Point(325, 46);
            this.labelSecond.Name = "labelSecond";
            this.labelSecond.Size = new System.Drawing.Size(28, 26);
            this.labelSecond.TabIndex = 40;
            this.labelSecond.Text = "2";
            this.labelSecond.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelFirst
            // 
            this.labelFirst.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.labelFirst.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelFirst.Location = new System.Drawing.Point(278, 46);
            this.labelFirst.Name = "labelFirst";
            this.labelFirst.Size = new System.Drawing.Size(28, 26);
            this.labelFirst.TabIndex = 39;
            this.labelFirst.Text = "1";
            this.labelFirst.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelNumber
            // 
            this.labelNumber.Location = new System.Drawing.Point(30, 49);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(219, 20);
            this.labelNumber.TabIndex = 30;
            this.labelNumber.Text = "Номер источника света:";
            this.labelNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numericUpDownPositionZ
            // 
            this.numericUpDownPositionZ.DecimalPlaces = 2;
            this.numericUpDownPositionZ.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDownPositionZ.Location = new System.Drawing.Point(548, 120);
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
            this.numericUpDownPositionZ.Size = new System.Drawing.Size(88, 20);
            this.numericUpDownPositionZ.TabIndex = 26;
            // 
            // numericUpDownPositionY
            // 
            this.numericUpDownPositionY.DecimalPlaces = 2;
            this.numericUpDownPositionY.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDownPositionY.Location = new System.Drawing.Point(413, 120);
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
            this.numericUpDownPositionY.Size = new System.Drawing.Size(88, 20);
            this.numericUpDownPositionY.TabIndex = 25;
            // 
            // numericUpDownPositionX
            // 
            this.numericUpDownPositionX.DecimalPlaces = 2;
            this.numericUpDownPositionX.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDownPositionX.Location = new System.Drawing.Point(278, 120);
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
            this.numericUpDownPositionX.Size = new System.Drawing.Size(88, 20);
            this.numericUpDownPositionX.TabIndex = 24;
            // 
            // labelPosition
            // 
            this.labelPosition.Location = new System.Drawing.Point(30, 118);
            this.labelPosition.Name = "labelPosition";
            this.labelPosition.Size = new System.Drawing.Size(219, 20);
            this.labelPosition.TabIndex = 23;
            this.labelPosition.Text = "Положение источника света:";
            this.labelPosition.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelBRange
            // 
            this.labelBRange.ForeColor = System.Drawing.Color.Blue;
            this.labelBRange.Location = new System.Drawing.Point(540, 164);
            this.labelBRange.Name = "labelBRange";
            this.labelBRange.Size = new System.Drawing.Size(104, 15);
            this.labelBRange.TabIndex = 17;
            this.labelBRange.Text = "0 - - - - <B> - - - - 1";
            this.labelBRange.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelGRange
            // 
            this.labelGRange.ForeColor = System.Drawing.Color.Green;
            this.labelGRange.Location = new System.Drawing.Point(405, 164);
            this.labelGRange.Name = "labelGRange";
            this.labelGRange.Size = new System.Drawing.Size(104, 15);
            this.labelGRange.TabIndex = 16;
            this.labelGRange.Text = "0 - - - - <G> - - - - 1";
            this.labelGRange.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelRRange
            // 
            this.labelRRange.ForeColor = System.Drawing.Color.Red;
            this.labelRRange.Location = new System.Drawing.Point(270, 164);
            this.labelRRange.Name = "labelRRange";
            this.labelRRange.Size = new System.Drawing.Size(104, 15);
            this.labelRRange.TabIndex = 15;
            this.labelRRange.Text = "0 - - - - <R> - - - - 1";
            this.labelRRange.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trackBarSpecularB
            // 
            this.trackBarSpecularB.Location = new System.Drawing.Point(540, 287);
            this.trackBarSpecularB.Maximum = 100;
            this.trackBarSpecularB.Name = "trackBarSpecularB";
            this.trackBarSpecularB.Size = new System.Drawing.Size(104, 45);
            this.trackBarSpecularB.TabIndex = 11;
            this.trackBarSpecularB.TickFrequency = 10;
            this.trackBarSpecularB.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBarSpecularB.Value = 10;
            // 
            // trackBarSpecularG
            // 
            this.trackBarSpecularG.Location = new System.Drawing.Point(405, 287);
            this.trackBarSpecularG.Maximum = 100;
            this.trackBarSpecularG.Name = "trackBarSpecularG";
            this.trackBarSpecularG.Size = new System.Drawing.Size(104, 45);
            this.trackBarSpecularG.TabIndex = 10;
            this.trackBarSpecularG.TickFrequency = 10;
            this.trackBarSpecularG.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBarSpecularG.Value = 10;
            // 
            // trackBarSpecularR
            // 
            this.trackBarSpecularR.Location = new System.Drawing.Point(270, 287);
            this.trackBarSpecularR.Maximum = 100;
            this.trackBarSpecularR.Name = "trackBarSpecularR";
            this.trackBarSpecularR.Size = new System.Drawing.Size(104, 45);
            this.trackBarSpecularR.TabIndex = 9;
            this.trackBarSpecularR.TickFrequency = 10;
            this.trackBarSpecularR.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBarSpecularR.Value = 10;
            // 
            // trackBarDiffuseB
            // 
            this.trackBarDiffuseB.Location = new System.Drawing.Point(540, 233);
            this.trackBarDiffuseB.Maximum = 100;
            this.trackBarDiffuseB.Name = "trackBarDiffuseB";
            this.trackBarDiffuseB.Size = new System.Drawing.Size(104, 45);
            this.trackBarDiffuseB.TabIndex = 8;
            this.trackBarDiffuseB.TickFrequency = 10;
            this.trackBarDiffuseB.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBarDiffuseB.Value = 10;
            // 
            // trackBarDiffuseG
            // 
            this.trackBarDiffuseG.Location = new System.Drawing.Point(405, 233);
            this.trackBarDiffuseG.Maximum = 100;
            this.trackBarDiffuseG.Name = "trackBarDiffuseG";
            this.trackBarDiffuseG.Size = new System.Drawing.Size(104, 45);
            this.trackBarDiffuseG.TabIndex = 7;
            this.trackBarDiffuseG.TickFrequency = 10;
            this.trackBarDiffuseG.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBarDiffuseG.Value = 10;
            // 
            // trackBarDiffuseR
            // 
            this.trackBarDiffuseR.Location = new System.Drawing.Point(270, 233);
            this.trackBarDiffuseR.Maximum = 100;
            this.trackBarDiffuseR.Name = "trackBarDiffuseR";
            this.trackBarDiffuseR.Size = new System.Drawing.Size(104, 45);
            this.trackBarDiffuseR.TabIndex = 6;
            this.trackBarDiffuseR.TickFrequency = 10;
            this.trackBarDiffuseR.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBarDiffuseR.Value = 10;
            // 
            // trackBarAmbiantB
            // 
            this.trackBarAmbiantB.Location = new System.Drawing.Point(540, 182);
            this.trackBarAmbiantB.Maximum = 100;
            this.trackBarAmbiantB.Name = "trackBarAmbiantB";
            this.trackBarAmbiantB.Size = new System.Drawing.Size(104, 45);
            this.trackBarAmbiantB.TabIndex = 5;
            this.trackBarAmbiantB.TickFrequency = 10;
            this.trackBarAmbiantB.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBarAmbiantB.Value = 10;
            // 
            // trackBarAmbiantG
            // 
            this.trackBarAmbiantG.Location = new System.Drawing.Point(405, 182);
            this.trackBarAmbiantG.Maximum = 100;
            this.trackBarAmbiantG.Name = "trackBarAmbiantG";
            this.trackBarAmbiantG.Size = new System.Drawing.Size(104, 45);
            this.trackBarAmbiantG.TabIndex = 4;
            this.trackBarAmbiantG.TickFrequency = 10;
            this.trackBarAmbiantG.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBarAmbiantG.Value = 10;
            // 
            // trackBarAmbiantR
            // 
            this.trackBarAmbiantR.Location = new System.Drawing.Point(270, 182);
            this.trackBarAmbiantR.Maximum = 100;
            this.trackBarAmbiantR.Name = "trackBarAmbiantR";
            this.trackBarAmbiantR.Size = new System.Drawing.Size(104, 45);
            this.trackBarAmbiantR.TabIndex = 3;
            this.trackBarAmbiantR.TickFrequency = 10;
            this.trackBarAmbiantR.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBarAmbiantR.Value = 10;
            // 
            // labelSpecular
            // 
            this.labelSpecular.Location = new System.Drawing.Point(30, 287);
            this.labelSpecular.Name = "labelSpecular";
            this.labelSpecular.Size = new System.Drawing.Size(219, 45);
            this.labelSpecular.TabIndex = 2;
            this.labelSpecular.Text = "Интенсивность бликовой составляющей:";
            this.labelSpecular.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelDiffuse
            // 
            this.labelDiffuse.Location = new System.Drawing.Point(30, 233);
            this.labelDiffuse.Name = "labelDiffuse";
            this.labelDiffuse.Size = new System.Drawing.Size(228, 45);
            this.labelDiffuse.TabIndex = 1;
            this.labelDiffuse.Text = "Интенсивность диффузной составляющей:";
            this.labelDiffuse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelAmbiant
            // 
            this.labelAmbiant.Location = new System.Drawing.Point(30, 182);
            this.labelAmbiant.Name = "labelAmbiant";
            this.labelAmbiant.Size = new System.Drawing.Size(219, 45);
            this.labelAmbiant.TabIndex = 0;
            this.labelAmbiant.Text = "Интенсивность фоновой составляющей:";
            this.labelAmbiant.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(600, 387);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(87, 28);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonOK
            // 
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Location = new System.Drawing.Point(495, 387);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(87, 28);
            this.buttonOK.TabIndex = 2;
            this.buttonOK.Text = "Применить";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // LightDialog
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(699, 429);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.groupBoxLight);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LightDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Свойства объекта \' Источник света\'";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LightDialogFormClosed);
            this.Load += new System.EventHandler(this.LightDialogLoad);
            this.groupBoxLight.ResumeLayout(false);
            this.groupBoxLight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPositionZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPositionY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPositionX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSpecularB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSpecularG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSpecularR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarDiffuseB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarDiffuseG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarDiffuseR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAmbiantB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAmbiantG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAmbiantR)).EndInit();
            this.ResumeLayout(false);

		}
		private System.Windows.Forms.Label labelFirst;
		private System.Windows.Forms.Label labelSecond;
		private System.Windows.Forms.Label labelThird;
		private System.Windows.Forms.Label labelFourth;
		private System.Windows.Forms.Label labelFifth;
		private System.Windows.Forms.Label labelSixth;
		private System.Windows.Forms.Label labelEighth;
		private System.Windows.Forms.Label labelSeventh;
		private System.Windows.Forms.Button buttonOK;
		
		private System.Windows.Forms.Label labelNumber;
		private System.Windows.Forms.Label labelPosition;
		private System.Windows.Forms.NumericUpDown numericUpDownPositionX;
		private System.Windows.Forms.NumericUpDown numericUpDownPositionY;
		private System.Windows.Forms.NumericUpDown numericUpDownPositionZ;
		private System.Windows.Forms.Label labelX;
		private System.Windows.Forms.Label labelY;
		private System.Windows.Forms.Label labelZ;
		private System.Windows.Forms.GroupBox groupBoxLight;
		private System.Windows.Forms.Label labelBRange;
		private System.Windows.Forms.Label labelGRange;
		private System.Windows.Forms.Label labelRRange;
		private System.Windows.Forms.Label labelAmbiant;
		private System.Windows.Forms.Label labelDiffuse;
		private System.Windows.Forms.Label labelSpecular;
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.TrackBar trackBarDiffuseR;
		private System.Windows.Forms.TrackBar trackBarDiffuseG;
		private System.Windows.Forms.TrackBar trackBarDiffuseB;
		private System.Windows.Forms.TrackBar trackBarAmbiantR;
		private System.Windows.Forms.TrackBar trackBarAmbiantG;
		private System.Windows.Forms.TrackBar trackBarAmbiantB;
		private System.Windows.Forms.TrackBar trackBarSpecularR;
		private System.Windows.Forms.TrackBar trackBarSpecularG;
		private System.Windows.Forms.TrackBar trackBarSpecularB;
	}
}
