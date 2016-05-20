namespace SceneEditor
{
	partial class MaterialDialog
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MaterialDialog));
			this.groupBoxMaterial = new System.Windows.Forms.GroupBox();
			this.comboBoxMappingMode = new System.Windows.Forms.ComboBox();
			this.labelMappingAndScale = new System.Windows.Forms.Label();
			this.labelT = new System.Windows.Forms.Label();
			this.panelTexture = new System.Windows.Forms.Panel();
			this.buttonRemoveTexture = new System.Windows.Forms.Button();
			this.imageList = new System.Windows.Forms.ImageList(this.components);
			this.labelS = new System.Windows.Forms.Label();
			this.panelColor = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.numericUpDownScaleS = new System.Windows.Forms.NumericUpDown();
			this.labelColorAndTexture = new System.Windows.Forms.Label();
			this.numericUpDownScaleT = new System.Windows.Forms.NumericUpDown();
			this.labelRefrIndexRange = new System.Windows.Forms.Label();
			this.labelRefrIndex = new System.Windows.Forms.Label();
			this.trackBarRefrIndex = new System.Windows.Forms.TrackBar();
			this.labelRefract = new System.Windows.Forms.Label();
			this.trackBarRefractB = new System.Windows.Forms.TrackBar();
			this.trackBarRefractG = new System.Windows.Forms.TrackBar();
			this.trackBarRefractR = new System.Windows.Forms.TrackBar();
			this.trackBarReflectB = new System.Windows.Forms.TrackBar();
			this.trackBarReflectG = new System.Windows.Forms.TrackBar();
			this.trackBarReflectR = new System.Windows.Forms.TrackBar();
			this.labelReflect = new System.Windows.Forms.Label();
			this.labelShininessRange = new System.Windows.Forms.Label();
			this.labelShininess = new System.Windows.Forms.Label();
			this.trackBarShininess = new System.Windows.Forms.TrackBar();
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
			this.buttonOk = new System.Windows.Forms.Button();
			this.groupBoxMaterial.SuspendLayout();
			this.panelTexture.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownScaleS)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownScaleT)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBarRefrIndex)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBarRefractB)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBarRefractG)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBarRefractR)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBarReflectB)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBarReflectG)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBarReflectR)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBarShininess)).BeginInit();
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
			// groupBoxMaterial
			// 
			this.groupBoxMaterial.Controls.Add(this.comboBoxMappingMode);
			this.groupBoxMaterial.Controls.Add(this.labelMappingAndScale);
			this.groupBoxMaterial.Controls.Add(this.labelT);
			this.groupBoxMaterial.Controls.Add(this.panelTexture);
			this.groupBoxMaterial.Controls.Add(this.labelS);
			this.groupBoxMaterial.Controls.Add(this.panelColor);
			this.groupBoxMaterial.Controls.Add(this.label1);
			this.groupBoxMaterial.Controls.Add(this.numericUpDownScaleS);
			this.groupBoxMaterial.Controls.Add(this.labelColorAndTexture);
			this.groupBoxMaterial.Controls.Add(this.numericUpDownScaleT);
			this.groupBoxMaterial.Controls.Add(this.labelRefrIndexRange);
			this.groupBoxMaterial.Controls.Add(this.labelRefrIndex);
			this.groupBoxMaterial.Controls.Add(this.trackBarRefrIndex);
			this.groupBoxMaterial.Controls.Add(this.labelRefract);
			this.groupBoxMaterial.Controls.Add(this.trackBarRefractB);
			this.groupBoxMaterial.Controls.Add(this.trackBarRefractG);
			this.groupBoxMaterial.Controls.Add(this.trackBarRefractR);
			this.groupBoxMaterial.Controls.Add(this.trackBarReflectB);
			this.groupBoxMaterial.Controls.Add(this.trackBarReflectG);
			this.groupBoxMaterial.Controls.Add(this.trackBarReflectR);
			this.groupBoxMaterial.Controls.Add(this.labelReflect);
			this.groupBoxMaterial.Controls.Add(this.labelShininessRange);
			this.groupBoxMaterial.Controls.Add(this.labelShininess);
			this.groupBoxMaterial.Controls.Add(this.trackBarShininess);
			this.groupBoxMaterial.Controls.Add(this.labelBRange);
			this.groupBoxMaterial.Controls.Add(this.labelGRange);
			this.groupBoxMaterial.Controls.Add(this.labelRRange);
			this.groupBoxMaterial.Controls.Add(this.trackBarSpecularB);
			this.groupBoxMaterial.Controls.Add(this.trackBarSpecularG);
			this.groupBoxMaterial.Controls.Add(this.trackBarSpecularR);
			this.groupBoxMaterial.Controls.Add(this.trackBarDiffuseB);
			this.groupBoxMaterial.Controls.Add(this.trackBarDiffuseG);
			this.groupBoxMaterial.Controls.Add(this.trackBarDiffuseR);
			this.groupBoxMaterial.Controls.Add(this.trackBarAmbiantB);
			this.groupBoxMaterial.Controls.Add(this.trackBarAmbiantG);
			this.groupBoxMaterial.Controls.Add(this.trackBarAmbiantR);
			this.groupBoxMaterial.Controls.Add(this.labelSpecular);
			this.groupBoxMaterial.Controls.Add(this.labelDiffuse);
			this.groupBoxMaterial.Controls.Add(this.labelAmbiant);
			this.groupBoxMaterial.Location = new System.Drawing.Point(12, 12);
			this.groupBoxMaterial.Name = "groupBoxMaterial";
			this.groupBoxMaterial.Size = new System.Drawing.Size(614, 650);
			this.groupBoxMaterial.TabIndex = 0;
			this.groupBoxMaterial.TabStop = false;
			this.groupBoxMaterial.Text = "Свойства материала (модель Уиттеда)";
			// 
			// comboBoxMapping
			// 
			this.comboBoxMappingMode.FormattingEnabled = true;
			this.comboBoxMappingMode.Items.AddRange(new object[] {
									"Clamp",
									"Repeat"});
			this.comboBoxMappingMode.Location = new System.Drawing.Point(236, 589);
			this.comboBoxMappingMode.Name = "comboBoxMapping";
			this.comboBoxMappingMode.Size = new System.Drawing.Size(96, 21);
			this.comboBoxMappingMode.TabIndex = 47;
			this.comboBoxMappingMode.SelectedIndexChanged += new System.EventHandler(this.ComboBoxMappingModeSelectedIndexChanged);
			// 
			// labelMappingAndScale
			// 
			this.labelMappingAndScale.AutoSize = true;
			this.labelMappingAndScale.Location = new System.Drawing.Point(36, 592);
			this.labelMappingAndScale.Name = "labelMappingAndScale";
			this.labelMappingAndScale.Size = new System.Drawing.Size(175, 13);
			this.labelMappingAndScale.TabIndex = 46;
			this.labelMappingAndScale.Text = "Наложение и масштаб текстуры:";
			this.labelMappingAndScale.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// labelT
			// 
			this.labelT.AutoSize = true;
			this.labelT.ForeColor = System.Drawing.Color.Green;
			this.labelT.Location = new System.Drawing.Point(471, 570);
			this.labelT.Name = "labelT";
			this.labelT.Size = new System.Drawing.Size(98, 13);
			this.labelT.TabIndex = 44;
			this.labelT.Text = "0 - - - - <T> - - - - +∞";
			this.labelT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panelTexture
			// 
			this.panelTexture.BackColor = System.Drawing.SystemColors.Control;
			this.panelTexture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panelTexture.Controls.Add(this.buttonRemoveTexture);
			this.panelTexture.Location = new System.Drawing.Point(289, 460);
			this.panelTexture.Name = "panelTexture";
			this.panelTexture.Size = new System.Drawing.Size(280, 82);
			this.panelTexture.TabIndex = 45;
			this.panelTexture.Click += new System.EventHandler(this.PanelTextureClick);
			// 
			// buttonRemoveTexture
			// 
			this.buttonRemoveTexture.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.buttonRemoveTexture.ImageKey = "9.bmp";
			this.buttonRemoveTexture.ImageList = this.imageList;
			this.buttonRemoveTexture.Location = new System.Drawing.Point(248, 50);
			this.buttonRemoveTexture.Name = "buttonRemoveTexture";
			this.buttonRemoveTexture.Size = new System.Drawing.Size(28, 28);
			this.buttonRemoveTexture.TabIndex = 1;
			this.buttonRemoveTexture.UseVisualStyleBackColor = true;
			this.buttonRemoveTexture.Click += new System.EventHandler(this.ButtonRemoveTextureClick);
			// 
			// imageList
			// 
			this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
			this.imageList.TransparentColor = System.Drawing.Color.Red;
			this.imageList.Images.SetKeyName(0, "9.bmp");
			// 
			// labelS
			// 
			this.labelS.AutoSize = true;
			this.labelS.ForeColor = System.Drawing.Color.Red;
			this.labelS.Location = new System.Drawing.Point(352, 570);
			this.labelS.Name = "labelS";
			this.labelS.Size = new System.Drawing.Size(98, 13);
			this.labelS.TabIndex = 43;
			this.labelS.Text = "0 - - - - <S> - - - - +∞";
			this.labelS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panelColor
			// 
			this.panelColor.BackColor = System.Drawing.SystemColors.Control;
			this.panelColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panelColor.Location = new System.Drawing.Point(236, 460);
			this.panelColor.Name = "panelColor";
			this.panelColor.Size = new System.Drawing.Size(47, 82);
			this.panelColor.TabIndex = 44;
			this.panelColor.Click += new System.EventHandler(this.PanelColorClick);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(236, 564);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(0, 13);
			this.label1.TabIndex = 42;
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// numericUpDownScaleS
			// 
			this.numericUpDownScaleS.DecimalPlaces = 2;
			this.numericUpDownScaleS.Increment = new decimal(new int[] {
									1,
									0,
									0,
									131072});
			this.numericUpDownScaleS.Location = new System.Drawing.Point(354, 590);
			this.numericUpDownScaleS.Maximum = new decimal(new int[] {
									1000,
									0,
									0,
									0});
			this.numericUpDownScaleS.Minimum = new decimal(new int[] {
									1,
									0,
									0,
									196608});
			this.numericUpDownScaleS.Name = "numericUpDownScaleS";
			this.numericUpDownScaleS.Size = new System.Drawing.Size(96, 20);
			this.numericUpDownScaleS.TabIndex = 41;
			this.numericUpDownScaleS.Value = new decimal(new int[] {
									1,
									0,
									0,
									0});
			this.numericUpDownScaleS.ValueChanged += new System.EventHandler(this.NumericUpDownScaleSValueChanged);
			// 
			// labelColorAndTexture
			// 
			this.labelColorAndTexture.Location = new System.Drawing.Point(36, 460);
			this.labelColorAndTexture.Name = "labelColorAndTexture";
			this.labelColorAndTexture.Size = new System.Drawing.Size(173, 82);
			this.labelColorAndTexture.TabIndex = 32;
			this.labelColorAndTexture.Text = "Цвет и текстура материала:";
			this.labelColorAndTexture.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// numericUpDownScaleT
			// 
			this.numericUpDownScaleT.DecimalPlaces = 2;
			this.numericUpDownScaleT.Increment = new decimal(new int[] {
									1,
									0,
									0,
									131072});
			this.numericUpDownScaleT.Location = new System.Drawing.Point(473, 590);
			this.numericUpDownScaleT.Maximum = new decimal(new int[] {
									1000,
									0,
									0,
									0});
			this.numericUpDownScaleT.Minimum = new decimal(new int[] {
									1,
									0,
									0,
									196608});
			this.numericUpDownScaleT.Name = "numericUpDownScaleT";
			this.numericUpDownScaleT.Size = new System.Drawing.Size(96, 20);
			this.numericUpDownScaleT.TabIndex = 40;
			this.numericUpDownScaleT.Value = new decimal(new int[] {
									1,
									0,
									0,
									0});
			this.numericUpDownScaleT.ValueChanged += new System.EventHandler(this.NumericUpDownScaleTValueChanged);
			// 
			// labelRefrIndexRange
			// 
			this.labelRefrIndexRange.Location = new System.Drawing.Point(230, 381);
			this.labelRefrIndexRange.Name = "labelRefrIndexRange";
			this.labelRefrIndexRange.Size = new System.Drawing.Size(347, 14);
			this.labelRefrIndexRange.TabIndex = 31;
			this.labelRefrIndexRange.Text = "1 - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -" +
			" - - - - - - - - - - - - - - 5";
			this.labelRefrIndexRange.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// labelRefrIndex
			// 
			this.labelRefrIndex.Location = new System.Drawing.Point(36, 395);
			this.labelRefrIndex.Name = "labelRefrIndex";
			this.labelRefrIndex.Size = new System.Drawing.Size(186, 45);
			this.labelRefrIndex.TabIndex = 30;
			this.labelRefrIndex.Text = "Показатель преломления:";
			this.labelRefrIndex.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// trackBarRefrIndex
			// 
			this.trackBarRefrIndex.Location = new System.Drawing.Point(228, 398);
			this.trackBarRefrIndex.Maximum = 1000;
			this.trackBarRefrIndex.Minimum = 100;
			this.trackBarRefrIndex.Name = "trackBarRefrIndex";
			this.trackBarRefrIndex.Size = new System.Drawing.Size(350, 42);
			this.trackBarRefrIndex.TabIndex = 29;
			this.trackBarRefrIndex.TickFrequency = 35;
			this.trackBarRefrIndex.TickStyle = System.Windows.Forms.TickStyle.Both;
			this.trackBarRefrIndex.Value = 100;
			// 
			// labelRefract
			// 
			this.labelRefract.Location = new System.Drawing.Point(36, 255);
			this.labelRefract.Name = "labelRefract";
			this.labelRefract.Size = new System.Drawing.Size(186, 42);
			this.labelRefract.TabIndex = 28;
			this.labelRefract.Text = "Вклад преломленных лучей:";
			this.labelRefract.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// trackBarRefractB
			// 
			this.trackBarRefractB.Location = new System.Drawing.Point(474, 255);
			this.trackBarRefractB.Maximum = 100;
			this.trackBarRefractB.Name = "trackBarRefractB";
			this.trackBarRefractB.Size = new System.Drawing.Size(104, 42);
			this.trackBarRefractB.TabIndex = 27;
			this.trackBarRefractB.TickFrequency = 10;
			this.trackBarRefractB.TickStyle = System.Windows.Forms.TickStyle.Both;
			this.trackBarRefractB.Value = 10;
			// 
			// trackBarRefractG
			// 
			this.trackBarRefractG.Location = new System.Drawing.Point(351, 255);
			this.trackBarRefractG.Maximum = 100;
			this.trackBarRefractG.Name = "trackBarRefractG";
			this.trackBarRefractG.Size = new System.Drawing.Size(104, 42);
			this.trackBarRefractG.TabIndex = 26;
			this.trackBarRefractG.TickFrequency = 10;
			this.trackBarRefractG.TickStyle = System.Windows.Forms.TickStyle.Both;
			this.trackBarRefractG.Value = 10;
			// 
			// trackBarRefractR
			// 
			this.trackBarRefractR.Location = new System.Drawing.Point(228, 255);
			this.trackBarRefractR.Maximum = 100;
			this.trackBarRefractR.Name = "trackBarRefractR";
			this.trackBarRefractR.Size = new System.Drawing.Size(104, 42);
			this.trackBarRefractR.TabIndex = 25;
			this.trackBarRefractR.TickFrequency = 10;
			this.trackBarRefractR.TickStyle = System.Windows.Forms.TickStyle.Both;
			this.trackBarRefractR.Value = 10;
			// 
			// trackBarReflectB
			// 
			this.trackBarReflectB.Location = new System.Drawing.Point(474, 204);
			this.trackBarReflectB.Maximum = 100;
			this.trackBarReflectB.Name = "trackBarReflectB";
			this.trackBarReflectB.Size = new System.Drawing.Size(104, 42);
			this.trackBarReflectB.TabIndex = 24;
			this.trackBarReflectB.TickFrequency = 10;
			this.trackBarReflectB.TickStyle = System.Windows.Forms.TickStyle.Both;
			this.trackBarReflectB.Value = 10;
			// 
			// trackBarReflectG
			// 
			this.trackBarReflectG.Location = new System.Drawing.Point(351, 204);
			this.trackBarReflectG.Maximum = 100;
			this.trackBarReflectG.Name = "trackBarReflectG";
			this.trackBarReflectG.Size = new System.Drawing.Size(104, 42);
			this.trackBarReflectG.TabIndex = 23;
			this.trackBarReflectG.TickFrequency = 10;
			this.trackBarReflectG.TickStyle = System.Windows.Forms.TickStyle.Both;
			this.trackBarReflectG.Value = 10;
			// 
			// trackBarReflectR
			// 
			this.trackBarReflectR.Location = new System.Drawing.Point(228, 204);
			this.trackBarReflectR.Maximum = 100;
			this.trackBarReflectR.Name = "trackBarReflectR";
			this.trackBarReflectR.Size = new System.Drawing.Size(104, 42);
			this.trackBarReflectR.TabIndex = 22;
			this.trackBarReflectR.TickFrequency = 10;
			this.trackBarReflectR.TickStyle = System.Windows.Forms.TickStyle.Both;
			this.trackBarReflectR.Value = 10;
			// 
			// labelReflect
			// 
			this.labelReflect.Location = new System.Drawing.Point(36, 204);
			this.labelReflect.Name = "labelReflect";
			this.labelReflect.Size = new System.Drawing.Size(186, 42);
			this.labelReflect.TabIndex = 21;
			this.labelReflect.Text = "Вклад отраженных лучей:";
			this.labelReflect.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// labelShininessRange
			// 
			this.labelShininessRange.Location = new System.Drawing.Point(230, 311);
			this.labelShininessRange.Name = "labelShininessRange";
			this.labelShininessRange.Size = new System.Drawing.Size(347, 14);
			this.labelShininessRange.TabIndex = 20;
			this.labelShininessRange.Text = "1 - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -" +
			" - - - - - - - - - - - - 500";
			this.labelShininessRange.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// labelShininess
			// 
			this.labelShininess.Location = new System.Drawing.Point(36, 325);
			this.labelShininess.Name = "labelShininess";
			this.labelShininess.Size = new System.Drawing.Size(186, 45);
			this.labelShininess.TabIndex = 19;
			this.labelShininess.Text = "Коэффициент резкости бликов:";
			this.labelShininess.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// trackBarShininess
			// 
			this.trackBarShininess.Location = new System.Drawing.Point(228, 328);
			this.trackBarShininess.Maximum = 500;
			this.trackBarShininess.Minimum = 1;
			this.trackBarShininess.Name = "trackBarShininess";
			this.trackBarShininess.Size = new System.Drawing.Size(350, 42);
			this.trackBarShininess.TabIndex = 18;
			this.trackBarShininess.TickFrequency = 20;
			this.trackBarShininess.TickStyle = System.Windows.Forms.TickStyle.Both;
			this.trackBarShininess.Value = 10;
			// 
			// labelBRange
			// 
			this.labelBRange.ForeColor = System.Drawing.Color.Blue;
			this.labelBRange.Location = new System.Drawing.Point(474, 33);
			this.labelBRange.Name = "labelBRange";
			this.labelBRange.Size = new System.Drawing.Size(104, 15);
			this.labelBRange.TabIndex = 17;
			this.labelBRange.Text = "0 - - - - <B> - - - - 1";
			this.labelBRange.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// labelGRange
			// 
			this.labelGRange.ForeColor = System.Drawing.Color.Green;
			this.labelGRange.Location = new System.Drawing.Point(351, 33);
			this.labelGRange.Name = "labelGRange";
			this.labelGRange.Size = new System.Drawing.Size(104, 15);
			this.labelGRange.TabIndex = 16;
			this.labelGRange.Text = "0 - - - - <G> - - - - 1";
			this.labelGRange.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// labelRRange
			// 
			this.labelRRange.ForeColor = System.Drawing.Color.Red;
			this.labelRRange.Location = new System.Drawing.Point(228, 33);
			this.labelRRange.Name = "labelRRange";
			this.labelRRange.Size = new System.Drawing.Size(104, 15);
			this.labelRRange.TabIndex = 15;
			this.labelRRange.Text = "0 - - - - <R> - - - - 1";
			this.labelRRange.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// trackBarSpecularB
			// 
			this.trackBarSpecularB.Location = new System.Drawing.Point(474, 153);
			this.trackBarSpecularB.Maximum = 100;
			this.trackBarSpecularB.Name = "trackBarSpecularB";
			this.trackBarSpecularB.Size = new System.Drawing.Size(104, 42);
			this.trackBarSpecularB.TabIndex = 11;
			this.trackBarSpecularB.TickFrequency = 10;
			this.trackBarSpecularB.TickStyle = System.Windows.Forms.TickStyle.Both;
			this.trackBarSpecularB.Value = 10;
			// 
			// trackBarSpecularG
			// 
			this.trackBarSpecularG.Location = new System.Drawing.Point(351, 153);
			this.trackBarSpecularG.Maximum = 100;
			this.trackBarSpecularG.Name = "trackBarSpecularG";
			this.trackBarSpecularG.Size = new System.Drawing.Size(104, 42);
			this.trackBarSpecularG.TabIndex = 10;
			this.trackBarSpecularG.TickFrequency = 10;
			this.trackBarSpecularG.TickStyle = System.Windows.Forms.TickStyle.Both;
			this.trackBarSpecularG.Value = 10;
			// 
			// trackBarSpecularR
			// 
			this.trackBarSpecularR.Location = new System.Drawing.Point(228, 153);
			this.trackBarSpecularR.Maximum = 100;
			this.trackBarSpecularR.Name = "trackBarSpecularR";
			this.trackBarSpecularR.Size = new System.Drawing.Size(104, 42);
			this.trackBarSpecularR.TabIndex = 9;
			this.trackBarSpecularR.TickFrequency = 10;
			this.trackBarSpecularR.TickStyle = System.Windows.Forms.TickStyle.Both;
			this.trackBarSpecularR.Value = 10;
			// 
			// trackBarDiffuseB
			// 
			this.trackBarDiffuseB.Location = new System.Drawing.Point(474, 102);
			this.trackBarDiffuseB.Maximum = 100;
			this.trackBarDiffuseB.Name = "trackBarDiffuseB";
			this.trackBarDiffuseB.Size = new System.Drawing.Size(104, 42);
			this.trackBarDiffuseB.TabIndex = 8;
			this.trackBarDiffuseB.TickFrequency = 10;
			this.trackBarDiffuseB.TickStyle = System.Windows.Forms.TickStyle.Both;
			this.trackBarDiffuseB.Value = 10;
			// 
			// trackBarDiffuseG
			// 
			this.trackBarDiffuseG.Location = new System.Drawing.Point(351, 102);
			this.trackBarDiffuseG.Maximum = 100;
			this.trackBarDiffuseG.Name = "trackBarDiffuseG";
			this.trackBarDiffuseG.Size = new System.Drawing.Size(104, 42);
			this.trackBarDiffuseG.TabIndex = 7;
			this.trackBarDiffuseG.TickFrequency = 10;
			this.trackBarDiffuseG.TickStyle = System.Windows.Forms.TickStyle.Both;
			this.trackBarDiffuseG.Value = 10;
			// 
			// trackBarDiffuseR
			// 
			this.trackBarDiffuseR.Location = new System.Drawing.Point(228, 102);
			this.trackBarDiffuseR.Maximum = 100;
			this.trackBarDiffuseR.Name = "trackBarDiffuseR";
			this.trackBarDiffuseR.Size = new System.Drawing.Size(104, 42);
			this.trackBarDiffuseR.TabIndex = 6;
			this.trackBarDiffuseR.TickFrequency = 10;
			this.trackBarDiffuseR.TickStyle = System.Windows.Forms.TickStyle.Both;
			this.trackBarDiffuseR.Value = 10;
			// 
			// trackBarAmbiantB
			// 
			this.trackBarAmbiantB.Location = new System.Drawing.Point(474, 51);
			this.trackBarAmbiantB.Maximum = 100;
			this.trackBarAmbiantB.Name = "trackBarAmbiantB";
			this.trackBarAmbiantB.Size = new System.Drawing.Size(104, 42);
			this.trackBarAmbiantB.TabIndex = 5;
			this.trackBarAmbiantB.TickFrequency = 10;
			this.trackBarAmbiantB.TickStyle = System.Windows.Forms.TickStyle.Both;
			this.trackBarAmbiantB.Value = 10;
			// 
			// trackBarAmbiantG
			// 
			this.trackBarAmbiantG.Location = new System.Drawing.Point(351, 51);
			this.trackBarAmbiantG.Maximum = 100;
			this.trackBarAmbiantG.Name = "trackBarAmbiantG";
			this.trackBarAmbiantG.Size = new System.Drawing.Size(104, 42);
			this.trackBarAmbiantG.TabIndex = 4;
			this.trackBarAmbiantG.TickFrequency = 10;
			this.trackBarAmbiantG.TickStyle = System.Windows.Forms.TickStyle.Both;
			this.trackBarAmbiantG.Value = 10;
			// 
			// trackBarAmbiantR
			// 
			this.trackBarAmbiantR.Location = new System.Drawing.Point(228, 51);
			this.trackBarAmbiantR.Maximum = 100;
			this.trackBarAmbiantR.Name = "trackBarAmbiantR";
			this.trackBarAmbiantR.Size = new System.Drawing.Size(104, 42);
			this.trackBarAmbiantR.TabIndex = 3;
			this.trackBarAmbiantR.TickFrequency = 10;
			this.trackBarAmbiantR.TickStyle = System.Windows.Forms.TickStyle.Both;
			this.trackBarAmbiantR.Value = 10;
			// 
			// labelSpecular
			// 
			this.labelSpecular.Location = new System.Drawing.Point(36, 153);
			this.labelSpecular.Name = "labelSpecular";
			this.labelSpecular.Size = new System.Drawing.Size(186, 42);
			this.labelSpecular.TabIndex = 2;
			this.labelSpecular.Text = "Вклад бликовой составляющей:";
			this.labelSpecular.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// labelDiffuse
			// 
			this.labelDiffuse.Location = new System.Drawing.Point(36, 102);
			this.labelDiffuse.Name = "labelDiffuse";
			this.labelDiffuse.Size = new System.Drawing.Size(186, 42);
			this.labelDiffuse.TabIndex = 1;
			this.labelDiffuse.Text = "Вклад диффузной составляющей:";
			this.labelDiffuse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// labelAmbiant
			// 
			this.labelAmbiant.Location = new System.Drawing.Point(36, 51);
			this.labelAmbiant.Name = "labelAmbiant";
			this.labelAmbiant.Size = new System.Drawing.Size(186, 42);
			this.labelAmbiant.TabIndex = 0;
			this.labelAmbiant.Text = "Вклад фоновой составляющей:";
			this.labelAmbiant.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// buttonCancel
			// 
			this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.Location = new System.Drawing.Point(539, 675);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(87, 28);
			this.buttonCancel.TabIndex = 1;
			this.buttonCancel.Text = "Отмена";
			this.buttonCancel.UseVisualStyleBackColor = true;
			// 
			// buttonOk
			// 
			this.buttonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.buttonOk.Location = new System.Drawing.Point(432, 675);
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.Size = new System.Drawing.Size(87, 28);
			this.buttonOk.TabIndex = 2;
			this.buttonOk.Text = "Применить";
			this.buttonOk.UseVisualStyleBackColor = true;
			// 
			// MaterialDialog
			// 
			this.AcceptButton = this.buttonOk;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.buttonCancel;
			this.ClientSize = new System.Drawing.Size(639, 716);
			this.Controls.Add(this.buttonOk);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.groupBoxMaterial);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MaterialDialog";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Свойства Материала";
			this.Load += new System.EventHandler(this.MaterialDialogLoad);
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MaterialDialogFormClosed);
			this.groupBoxMaterial.ResumeLayout(false);
			this.groupBoxMaterial.PerformLayout();
			this.panelTexture.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownScaleS)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownScaleT)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBarRefrIndex)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBarRefractB)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBarRefractG)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBarRefractR)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBarReflectB)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBarReflectG)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBarReflectR)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBarShininess)).EndInit();
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
		private System.Windows.Forms.Button buttonRemoveTexture;
		private System.Windows.Forms.ImageList imageList;
		private System.Windows.Forms.Label labelMappingAndScale;
		private System.Windows.Forms.ComboBox comboBoxMappingMode;
		private System.Windows.Forms.Label labelColorAndTexture;
		private System.Windows.Forms.Panel panelTexture;
		private System.Windows.Forms.Panel panelColor;
		private System.Windows.Forms.NumericUpDown numericUpDownScaleS;
		private System.Windows.Forms.NumericUpDown numericUpDownScaleT;
		private System.Windows.Forms.Label labelT;
		private System.Windows.Forms.Label labelS;
		private System.Windows.Forms.Label label1;
		
		private System.Windows.Forms.GroupBox groupBoxMaterial;
		private System.Windows.Forms.Label labelBRange;
		private System.Windows.Forms.Label labelGRange;
		private System.Windows.Forms.Label labelRRange;
		private System.Windows.Forms.Label labelAmbiant;
		private System.Windows.Forms.Label labelDiffuse;
		private System.Windows.Forms.Label labelSpecular;
		private System.Windows.Forms.Label labelReflect;
		private System.Windows.Forms.Label labelRefract;
		private System.Windows.Forms.TrackBar trackBarShininess;
		private System.Windows.Forms.Label labelShininessRange;
		private System.Windows.Forms.Label labelShininess;
		private System.Windows.Forms.Label labelRefrIndexRange;
		private System.Windows.Forms.Label labelRefrIndex;
		private System.Windows.Forms.TrackBar trackBarRefrIndex;
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.Button buttonOk;
		private System.Windows.Forms.TrackBar trackBarRefractR;
		private System.Windows.Forms.TrackBar trackBarRefractG;
		private System.Windows.Forms.TrackBar trackBarRefractB;
		private System.Windows.Forms.TrackBar trackBarReflectR;
		private System.Windows.Forms.TrackBar trackBarReflectG;
		private System.Windows.Forms.TrackBar trackBarReflectB;
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