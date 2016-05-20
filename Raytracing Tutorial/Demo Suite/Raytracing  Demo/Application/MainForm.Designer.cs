namespace SceneEditor
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemOpenScene = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemOpenPrimitive = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemOpenLight = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemSave = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemSaveScene = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemSavePrimitive = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemSaveLight = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemSaveImage = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSeparatorExit = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.режимToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemEditor = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemRender = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.panelLightSources = new System.Windows.Forms.Panel();
            this.listViewLights = new System.Windows.Forms.ListView();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.toolStripLights = new System.Windows.Forms.ToolStrip();
            this.labelLights = new System.Windows.Forms.ToolStripLabel();
            this.buttonRemoveAllLights = new System.Windows.Forms.ToolStripButton();
            this.separatorLightsRight = new System.Windows.Forms.ToolStripSeparator();
            this.buttonLightProperties = new System.Windows.Forms.ToolStripButton();
            this.buttonRemoveLight = new System.Windows.Forms.ToolStripButton();
            this.buttonAddLight = new System.Windows.Forms.ToolStripButton();
            this.separatorLightsLeft = new System.Windows.Forms.ToolStripSeparator();
            this.buttonSaveLight = new System.Windows.Forms.ToolStripButton();
            this.buttonOpenLight = new System.Windows.Forms.ToolStripButton();
            this.panelPrimitives = new System.Windows.Forms.Panel();
            this.listViewPrimitives = new System.Windows.Forms.ListView();
            this.toolStripPrimitives = new System.Windows.Forms.ToolStrip();
            this.labelPrimitives = new System.Windows.Forms.ToolStripLabel();
            this.buttonRemovePrimitives = new System.Windows.Forms.ToolStripButton();
            this.separatorPrimitivesRight = new System.Windows.Forms.ToolStripSeparator();
            this.buttonPrimitiveProperties = new System.Windows.Forms.ToolStripButton();
            this.buttonRemovePrimitive = new System.Windows.Forms.ToolStripButton();
            this.buttonAddPrimitive = new System.Windows.Forms.ToolStripSplitButton();
            this.menuItemBasePrimitives = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemAddSphere = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemAddSquare = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemAddBox = new System.Windows.Forms.ToolStripMenuItem();
            this.separatorPrimitivesLeft = new System.Windows.Forms.ToolStripSeparator();
            this.buttonSavePrimitive = new System.Windows.Forms.ToolStripButton();
            this.buttonOpenPrimitive = new System.Windows.Forms.ToolStripButton();
            this.panelView = new System.Windows.Forms.Panel();
            this.panelOpenGL = new Tao.Platform.Windows.SimpleOpenGlControl();
            this.toolStripViewport = new System.Windows.Forms.ToolStrip();
            this.labelViewport = new System.Windows.Forms.ToolStripLabel();
            this.buttonSceneProperties = new System.Windows.Forms.ToolStripButton();
            this.buttonCamera = new System.Windows.Forms.ToolStripButton();
            this.buttonVolume = new System.Windows.Forms.ToolStripButton();
            this.buttonAxes = new System.Windows.Forms.ToolStripButton();
            this.labelMouseActive = new System.Windows.Forms.ToolStripLabel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.panelStatus = new System.Windows.Forms.Panel();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.labelOrientation = new System.Windows.Forms.Label();
            this.labelPosition = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.menuStrip.SuspendLayout();
            this.panelLightSources.SuspendLayout();
            this.toolStripLights.SuspendLayout();
            this.panelPrimitives.SuspendLayout();
            this.toolStripPrimitives.SuspendLayout();
            this.panelView.SuspendLayout();
            this.toolStripViewport.SuspendLayout();
            this.panelStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.режимToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip.Size = new System.Drawing.Size(832, 24);
            this.menuStrip.TabIndex = 3;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemOpen,
            this.menuItemSave,
            this.toolStripMenuItem1,
            this.menuItemSaveImage,
            this.menuSeparatorExit,
            this.menuItemExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.fileToolStripMenuItem.Text = "Файл";
            // 
            // menuItemOpen
            // 
            this.menuItemOpen.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemOpenScene,
            this.menuItemOpenPrimitive,
            this.menuItemOpenLight});
            this.menuItemOpen.Name = "menuItemOpen";
            this.menuItemOpen.Size = new System.Drawing.Size(209, 22);
            this.menuItemOpen.Text = "Открыть";
            // 
            // menuItemOpenScene
            // 
            this.menuItemOpenScene.Name = "menuItemOpenScene";
            this.menuItemOpenScene.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.menuItemOpenScene.Size = new System.Drawing.Size(160, 22);
            this.menuItemOpenScene.Text = "Сцену";
            this.menuItemOpenScene.Click += new System.EventHandler(this.MenuItemOpenSceneClick);
            // 
            // menuItemOpenPrimitive
            // 
            this.menuItemOpenPrimitive.Name = "menuItemOpenPrimitive";
            this.menuItemOpenPrimitive.Size = new System.Drawing.Size(160, 22);
            this.menuItemOpenPrimitive.Text = "Объект";
            this.menuItemOpenPrimitive.Click += new System.EventHandler(this.MenuItemOpenPrimitiveClick);
            // 
            // menuItemOpenLight
            // 
            this.menuItemOpenLight.Name = "menuItemOpenLight";
            this.menuItemOpenLight.Size = new System.Drawing.Size(160, 22);
            this.menuItemOpenLight.Text = "Источник света";
            this.menuItemOpenLight.Click += new System.EventHandler(this.MenuItemOpenLightClick);
            // 
            // menuItemSave
            // 
            this.menuItemSave.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemSaveScene,
            this.menuItemSavePrimitive,
            this.menuItemSaveLight});
            this.menuItemSave.Name = "menuItemSave";
            this.menuItemSave.Size = new System.Drawing.Size(209, 22);
            this.menuItemSave.Text = "Сохранить";
            // 
            // menuItemSaveScene
            // 
            this.menuItemSaveScene.Name = "menuItemSaveScene";
            this.menuItemSaveScene.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.menuItemSaveScene.Size = new System.Drawing.Size(160, 22);
            this.menuItemSaveScene.Text = "Сцену";
            this.menuItemSaveScene.Click += new System.EventHandler(this.MenuItemSaveSceneClick);
            // 
            // menuItemSavePrimitive
            // 
            this.menuItemSavePrimitive.Name = "menuItemSavePrimitive";
            this.menuItemSavePrimitive.Size = new System.Drawing.Size(160, 22);
            this.menuItemSavePrimitive.Text = "Объект";
            this.menuItemSavePrimitive.Click += new System.EventHandler(this.MenuItemSavePrimitiveClick);
            // 
            // menuItemSaveLight
            // 
            this.menuItemSaveLight.Name = "menuItemSaveLight";
            this.menuItemSaveLight.Size = new System.Drawing.Size(160, 22);
            this.menuItemSaveLight.Text = "Источник света";
            this.menuItemSaveLight.Click += new System.EventHandler(this.MenuItemSaveLightClick);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(206, 6);
            // 
            // menuItemSaveImage
            // 
            this.menuItemSaveImage.Name = "menuItemSaveImage";
            this.menuItemSaveImage.Size = new System.Drawing.Size(209, 22);
            this.menuItemSaveImage.Text = "Сохранить изображение";
            this.menuItemSaveImage.Click += new System.EventHandler(this.MenuItemSaveImageClick);
            // 
            // menuSeparatorExit
            // 
            this.menuSeparatorExit.Name = "menuSeparatorExit";
            this.menuSeparatorExit.Size = new System.Drawing.Size(206, 6);
            // 
            // menuItemExit
            // 
            this.menuItemExit.Name = "menuItemExit";
            this.menuItemExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.menuItemExit.Size = new System.Drawing.Size(209, 22);
            this.menuItemExit.Text = "Выход";
            this.menuItemExit.Click += new System.EventHandler(this.MenuItemExitClick);
            // 
            // режимToolStripMenuItem
            // 
            this.режимToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemEditor,
            this.menuItemRender});
            this.режимToolStripMenuItem.Name = "режимToolStripMenuItem";
            this.режимToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.режимToolStripMenuItem.Text = "Режим";
            // 
            // menuItemEditor
            // 
            this.menuItemEditor.Name = "menuItemEditor";
            this.menuItemEditor.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.menuItemEditor.Size = new System.Drawing.Size(152, 22);
            this.menuItemEditor.Text = "Редактор";
            this.menuItemEditor.Click += new System.EventHandler(this.MenuItemEditorClick);
            // 
            // menuItemRender
            // 
            this.menuItemRender.Name = "menuItemRender";
            this.menuItemRender.ShortcutKeys = System.Windows.Forms.Keys.F6;
            this.menuItemRender.Size = new System.Drawing.Size(152, 22);
            this.menuItemRender.Text = "Рендеринг";
            this.menuItemRender.Click += new System.EventHandler(this.MenuItemRenderClick);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemAbout});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // menuItemAbout
            // 
            this.menuItemAbout.Name = "menuItemAbout";
            this.menuItemAbout.Size = new System.Drawing.Size(149, 22);
            this.menuItemAbout.Text = "О программе";
            this.menuItemAbout.Click += new System.EventHandler(this.MenuItemAboutClick);
            // 
            // panelLightSources
            // 
            this.panelLightSources.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panelLightSources.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelLightSources.Controls.Add(this.listViewLights);
            this.panelLightSources.Controls.Add(this.toolStripLights);
            this.panelLightSources.Location = new System.Drawing.Point(537, 320);
            this.panelLightSources.Name = "panelLightSources";
            this.panelLightSources.Size = new System.Drawing.Size(287, 256);
            this.panelLightSources.TabIndex = 12;
            // 
            // listViewLights
            // 
            this.listViewLights.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewLights.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewLights.LabelWrap = false;
            this.listViewLights.LargeImageList = this.imageList;
            this.listViewLights.Location = new System.Drawing.Point(0, 25);
            this.listViewLights.MultiSelect = false;
            this.listViewLights.Name = "listViewLights";
            this.listViewLights.Size = new System.Drawing.Size(283, 227);
            this.listViewLights.TabIndex = 10;
            this.listViewLights.UseCompatibleStateImageBehavior = false;
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.White;
            this.imageList.Images.SetKeyName(0, "shere.bmp");
            this.imageList.Images.SetKeyName(1, "rect.bmp");
            this.imageList.Images.SetKeyName(2, "box.bmp");
            this.imageList.Images.SetKeyName(3, "surface.bmp");
            this.imageList.Images.SetKeyName(4, "light.bmp");
            // 
            // toolStripLights
            // 
            this.toolStripLights.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripLights.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripLights.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelLights,
            this.buttonRemoveAllLights,
            this.separatorLightsRight,
            this.buttonLightProperties,
            this.buttonRemoveLight,
            this.buttonAddLight,
            this.separatorLightsLeft,
            this.buttonSaveLight,
            this.buttonOpenLight});
            this.toolStripLights.Location = new System.Drawing.Point(0, 0);
            this.toolStripLights.Name = "toolStripLights";
            this.toolStripLights.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStripLights.Size = new System.Drawing.Size(283, 25);
            this.toolStripLights.TabIndex = 4;
            // 
            // labelLights
            // 
            this.labelLights.Name = "labelLights";
            this.labelLights.Size = new System.Drawing.Size(100, 22);
            this.labelLights.Text = "Источники света";
            // 
            // buttonRemoveAllLights
            // 
            this.buttonRemoveAllLights.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.buttonRemoveAllLights.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonRemoveAllLights.Image = ((System.Drawing.Image)(resources.GetObject("buttonRemoveAllLights.Image")));
            this.buttonRemoveAllLights.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.buttonRemoveAllLights.ImageTransparentColor = System.Drawing.Color.Red;
            this.buttonRemoveAllLights.Name = "buttonRemoveAllLights";
            this.buttonRemoveAllLights.Size = new System.Drawing.Size(23, 22);
            this.buttonRemoveAllLights.ToolTipText = "Удалить все источники света";
            this.buttonRemoveAllLights.Click += new System.EventHandler(this.ButtonRemoveAllLightsClick);
            // 
            // separatorLightsRight
            // 
            this.separatorLightsRight.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.separatorLightsRight.Name = "separatorLightsRight";
            this.separatorLightsRight.Size = new System.Drawing.Size(6, 25);
            // 
            // buttonLightProperties
            // 
            this.buttonLightProperties.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.buttonLightProperties.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonLightProperties.Image = ((System.Drawing.Image)(resources.GetObject("buttonLightProperties.Image")));
            this.buttonLightProperties.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.buttonLightProperties.ImageTransparentColor = System.Drawing.Color.Red;
            this.buttonLightProperties.Name = "buttonLightProperties";
            this.buttonLightProperties.Size = new System.Drawing.Size(23, 22);
            this.buttonLightProperties.ToolTipText = "Параметры источника света";
            this.buttonLightProperties.Click += new System.EventHandler(this.ButtonLightPropertiesClick);
            // 
            // buttonRemoveLight
            // 
            this.buttonRemoveLight.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.buttonRemoveLight.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonRemoveLight.Image = ((System.Drawing.Image)(resources.GetObject("buttonRemoveLight.Image")));
            this.buttonRemoveLight.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.buttonRemoveLight.ImageTransparentColor = System.Drawing.Color.Red;
            this.buttonRemoveLight.Name = "buttonRemoveLight";
            this.buttonRemoveLight.Size = new System.Drawing.Size(23, 22);
            this.buttonRemoveLight.ToolTipText = "Удалить источник света";
            this.buttonRemoveLight.Click += new System.EventHandler(this.ButtonRemoveLightClick);
            // 
            // buttonAddLight
            // 
            this.buttonAddLight.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.buttonAddLight.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonAddLight.Image = ((System.Drawing.Image)(resources.GetObject("buttonAddLight.Image")));
            this.buttonAddLight.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.buttonAddLight.ImageTransparentColor = System.Drawing.Color.Red;
            this.buttonAddLight.Name = "buttonAddLight";
            this.buttonAddLight.Size = new System.Drawing.Size(23, 22);
            this.buttonAddLight.ToolTipText = "Добавить источник света";
            this.buttonAddLight.Click += new System.EventHandler(this.ButtonAddLightClick);
            // 
            // separatorLightsLeft
            // 
            this.separatorLightsLeft.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.separatorLightsLeft.Name = "separatorLightsLeft";
            this.separatorLightsLeft.Size = new System.Drawing.Size(6, 25);
            // 
            // buttonSaveLight
            // 
            this.buttonSaveLight.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.buttonSaveLight.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonSaveLight.Image = ((System.Drawing.Image)(resources.GetObject("buttonSaveLight.Image")));
            this.buttonSaveLight.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.buttonSaveLight.ImageTransparentColor = System.Drawing.Color.Red;
            this.buttonSaveLight.Name = "buttonSaveLight";
            this.buttonSaveLight.Size = new System.Drawing.Size(23, 22);
            this.buttonSaveLight.ToolTipText = "Сохранить источник света";
            this.buttonSaveLight.Click += new System.EventHandler(this.ButtonSaveLightClick);
            // 
            // buttonOpenLight
            // 
            this.buttonOpenLight.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.buttonOpenLight.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonOpenLight.Image = ((System.Drawing.Image)(resources.GetObject("buttonOpenLight.Image")));
            this.buttonOpenLight.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.buttonOpenLight.ImageTransparentColor = System.Drawing.Color.Red;
            this.buttonOpenLight.Name = "buttonOpenLight";
            this.buttonOpenLight.Size = new System.Drawing.Size(23, 22);
            this.buttonOpenLight.ToolTipText = "Открыть источник света";
            this.buttonOpenLight.Click += new System.EventHandler(this.ButtonOpenLightClick);
            // 
            // panelPrimitives
            // 
            this.panelPrimitives.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panelPrimitives.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelPrimitives.Controls.Add(this.listViewPrimitives);
            this.panelPrimitives.Controls.Add(this.toolStripPrimitives);
            this.panelPrimitives.Location = new System.Drawing.Point(537, 35);
            this.panelPrimitives.Name = "panelPrimitives";
            this.panelPrimitives.Size = new System.Drawing.Size(287, 270);
            this.panelPrimitives.TabIndex = 11;
            // 
            // listViewPrimitives
            // 
            this.listViewPrimitives.BackColor = System.Drawing.SystemColors.Window;
            this.listViewPrimitives.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewPrimitives.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewPrimitives.LabelWrap = false;
            this.listViewPrimitives.LargeImageList = this.imageList;
            this.listViewPrimitives.Location = new System.Drawing.Point(0, 25);
            this.listViewPrimitives.MultiSelect = false;
            this.listViewPrimitives.Name = "listViewPrimitives";
            this.listViewPrimitives.Size = new System.Drawing.Size(283, 241);
            this.listViewPrimitives.TabIndex = 9;
            this.listViewPrimitives.UseCompatibleStateImageBehavior = false;
            this.listViewPrimitives.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.ListViewPrimitivesItemChecked);
            // 
            // toolStripPrimitives
            // 
            this.toolStripPrimitives.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripPrimitives.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripPrimitives.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelPrimitives,
            this.buttonRemovePrimitives,
            this.separatorPrimitivesRight,
            this.buttonPrimitiveProperties,
            this.buttonRemovePrimitive,
            this.buttonAddPrimitive,
            this.separatorPrimitivesLeft,
            this.buttonSavePrimitive,
            this.buttonOpenPrimitive});
            this.toolStripPrimitives.Location = new System.Drawing.Point(0, 0);
            this.toolStripPrimitives.Name = "toolStripPrimitives";
            this.toolStripPrimitives.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStripPrimitives.Size = new System.Drawing.Size(283, 25);
            this.toolStripPrimitives.TabIndex = 4;
            // 
            // labelPrimitives
            // 
            this.labelPrimitives.Name = "labelPrimitives";
            this.labelPrimitives.Size = new System.Drawing.Size(94, 22);
            this.labelPrimitives.Text = "Объекты сцены";
            // 
            // buttonRemovePrimitives
            // 
            this.buttonRemovePrimitives.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.buttonRemovePrimitives.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonRemovePrimitives.Image = ((System.Drawing.Image)(resources.GetObject("buttonRemovePrimitives.Image")));
            this.buttonRemovePrimitives.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.buttonRemovePrimitives.ImageTransparentColor = System.Drawing.Color.Red;
            this.buttonRemovePrimitives.Name = "buttonRemovePrimitives";
            this.buttonRemovePrimitives.Size = new System.Drawing.Size(23, 22);
            this.buttonRemovePrimitives.ToolTipText = "Удалить все объекты";
            this.buttonRemovePrimitives.Click += new System.EventHandler(this.ButtonRemoveAllPrimitivesClick);
            // 
            // separatorPrimitivesRight
            // 
            this.separatorPrimitivesRight.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.separatorPrimitivesRight.Name = "separatorPrimitivesRight";
            this.separatorPrimitivesRight.Size = new System.Drawing.Size(6, 25);
            // 
            // buttonPrimitiveProperties
            // 
            this.buttonPrimitiveProperties.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.buttonPrimitiveProperties.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonPrimitiveProperties.Image = ((System.Drawing.Image)(resources.GetObject("buttonPrimitiveProperties.Image")));
            this.buttonPrimitiveProperties.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.buttonPrimitiveProperties.ImageTransparentColor = System.Drawing.Color.Red;
            this.buttonPrimitiveProperties.Name = "buttonPrimitiveProperties";
            this.buttonPrimitiveProperties.Size = new System.Drawing.Size(23, 22);
            this.buttonPrimitiveProperties.ToolTipText = "Параметры объекта";
            this.buttonPrimitiveProperties.Click += new System.EventHandler(this.ButtonPrimitivePropertiesClick);
            // 
            // buttonRemovePrimitive
            // 
            this.buttonRemovePrimitive.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.buttonRemovePrimitive.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonRemovePrimitive.Image = ((System.Drawing.Image)(resources.GetObject("buttonRemovePrimitive.Image")));
            this.buttonRemovePrimitive.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.buttonRemovePrimitive.ImageTransparentColor = System.Drawing.Color.Red;
            this.buttonRemovePrimitive.Name = "buttonRemovePrimitive";
            this.buttonRemovePrimitive.Size = new System.Drawing.Size(23, 22);
            this.buttonRemovePrimitive.ToolTipText = "Удалить объект";
            this.buttonRemovePrimitive.Click += new System.EventHandler(this.ButtonRemovePrimitiveClick);
            // 
            // buttonAddPrimitive
            // 
            this.buttonAddPrimitive.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.buttonAddPrimitive.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonAddPrimitive.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemBasePrimitives,
            this.menuItemAddSphere,
            this.menuItemAddSquare,
            this.menuItemAddBox});
            this.buttonAddPrimitive.Image = ((System.Drawing.Image)(resources.GetObject("buttonAddPrimitive.Image")));
            this.buttonAddPrimitive.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.buttonAddPrimitive.ImageTransparentColor = System.Drawing.Color.Red;
            this.buttonAddPrimitive.Name = "buttonAddPrimitive";
            this.buttonAddPrimitive.Size = new System.Drawing.Size(33, 22);
            this.buttonAddPrimitive.ToolTipText = "Добавить объект";
            this.buttonAddPrimitive.ButtonClick += new System.EventHandler(this.buttonAddPrimitive_ButtonClick);
            // 
            // menuItemBasePrimitives
            // 
            this.menuItemBasePrimitives.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.menuItemBasePrimitives.Font = new System.Drawing.Font("Tahoma", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuItemBasePrimitives.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.menuItemBasePrimitives.Name = "menuItemBasePrimitives";
            this.menuItemBasePrimitives.Size = new System.Drawing.Size(213, 22);
            this.menuItemBasePrimitives.Text = "Стандартные объекты";
            // 
            // menuItemAddSphere
            // 
            this.menuItemAddSphere.Name = "menuItemAddSphere";
            this.menuItemAddSphere.Size = new System.Drawing.Size(213, 22);
            this.menuItemAddSphere.Text = "Сфера";
            this.menuItemAddSphere.Click += new System.EventHandler(this.MenuItemAddSphereClick);
            // 
            // menuItemAddSquare
            // 
            this.menuItemAddSquare.Name = "menuItemAddSquare";
            this.menuItemAddSquare.Size = new System.Drawing.Size(213, 22);
            this.menuItemAddSquare.Text = "Прямоугольник";
            this.menuItemAddSquare.Click += new System.EventHandler(this.MenuItemAddSquareClick);
            // 
            // menuItemAddBox
            // 
            this.menuItemAddBox.Name = "menuItemAddBox";
            this.menuItemAddBox.Size = new System.Drawing.Size(213, 22);
            this.menuItemAddBox.Text = "Параллелипипед";
            this.menuItemAddBox.Click += new System.EventHandler(this.MenuItemAddBoxClick);
            // 
            // separatorPrimitivesLeft
            // 
            this.separatorPrimitivesLeft.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.separatorPrimitivesLeft.Name = "separatorPrimitivesLeft";
            this.separatorPrimitivesLeft.Size = new System.Drawing.Size(6, 25);
            // 
            // buttonSavePrimitive
            // 
            this.buttonSavePrimitive.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.buttonSavePrimitive.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonSavePrimitive.Image = ((System.Drawing.Image)(resources.GetObject("buttonSavePrimitive.Image")));
            this.buttonSavePrimitive.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.buttonSavePrimitive.ImageTransparentColor = System.Drawing.Color.Red;
            this.buttonSavePrimitive.Name = "buttonSavePrimitive";
            this.buttonSavePrimitive.Size = new System.Drawing.Size(23, 22);
            this.buttonSavePrimitive.ToolTipText = "Сохранить объект";
            this.buttonSavePrimitive.Click += new System.EventHandler(this.ButtonSavePrimitiveClick);
            // 
            // buttonOpenPrimitive
            // 
            this.buttonOpenPrimitive.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.buttonOpenPrimitive.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonOpenPrimitive.Image = ((System.Drawing.Image)(resources.GetObject("buttonOpenPrimitive.Image")));
            this.buttonOpenPrimitive.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.buttonOpenPrimitive.ImageTransparentColor = System.Drawing.Color.Red;
            this.buttonOpenPrimitive.Name = "buttonOpenPrimitive";
            this.buttonOpenPrimitive.Size = new System.Drawing.Size(23, 22);
            this.buttonOpenPrimitive.ToolTipText = "Открыть объект";
            this.buttonOpenPrimitive.Click += new System.EventHandler(this.ButtonOpenPrimitiveClick);
            // 
            // panelView
            // 
            this.panelView.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panelView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelView.Controls.Add(this.panelOpenGL);
            this.panelView.Controls.Add(this.toolStripViewport);
            this.panelView.Location = new System.Drawing.Point(9, 35);
            this.panelView.Name = "panelView";
            this.panelView.Size = new System.Drawing.Size(516, 541);
            this.panelView.TabIndex = 12;
            // 
            // panelOpenGL
            // 
            this.panelOpenGL.AccumBits = ((byte)(0));
            this.panelOpenGL.AutoCheckErrors = false;
            this.panelOpenGL.AutoFinish = false;
            this.panelOpenGL.AutoMakeCurrent = true;
            this.panelOpenGL.AutoSwapBuffers = true;
            this.panelOpenGL.BackColor = System.Drawing.Color.Black;
            this.panelOpenGL.ColorBits = ((byte)(32));
            this.panelOpenGL.DepthBits = ((byte)(16));
            this.panelOpenGL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOpenGL.Location = new System.Drawing.Point(0, 25);
            this.panelOpenGL.Name = "panelOpenGL";
            this.panelOpenGL.Size = new System.Drawing.Size(512, 512);
            this.panelOpenGL.StencilBits = ((byte)(0));
            this.panelOpenGL.TabIndex = 8;
            this.panelOpenGL.Load += new System.EventHandler(this.panelOpenGL_Load);
            this.panelOpenGL.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelOpenGLPaint);
            this.panelOpenGL.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PanelOpenGLKeyDown);
            this.panelOpenGL.KeyUp += new System.Windows.Forms.KeyEventHandler(this.PanelOpenGLKeyUp);
            this.panelOpenGL.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelOpenGLMouseDown);
            this.panelOpenGL.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelOpenGLMouseMove);
            // 
            // toolStripViewport
            // 
            this.toolStripViewport.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripViewport.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripViewport.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelViewport,
            this.buttonSceneProperties,
            this.buttonCamera,
            this.buttonVolume,
            this.buttonAxes,
            this.labelMouseActive});
            this.toolStripViewport.Location = new System.Drawing.Point(0, 0);
            this.toolStripViewport.Name = "toolStripViewport";
            this.toolStripViewport.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStripViewport.Size = new System.Drawing.Size(512, 25);
            this.toolStripViewport.TabIndex = 4;
            // 
            // labelViewport
            // 
            this.labelViewport.Name = "labelViewport";
            this.labelViewport.Size = new System.Drawing.Size(100, 22);
            this.labelViewport.Text = "Окно просмотра";
            // 
            // buttonSceneProperties
            // 
            this.buttonSceneProperties.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.buttonSceneProperties.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonSceneProperties.Image = ((System.Drawing.Image)(resources.GetObject("buttonSceneProperties.Image")));
            this.buttonSceneProperties.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.buttonSceneProperties.ImageTransparentColor = System.Drawing.Color.Red;
            this.buttonSceneProperties.Name = "buttonSceneProperties";
            this.buttonSceneProperties.Size = new System.Drawing.Size(23, 22);
            this.buttonSceneProperties.ToolTipText = "Параметры визуализации";
            this.buttonSceneProperties.Click += new System.EventHandler(this.ButtonScenePropertiesClick);
            // 
            // buttonCamera
            // 
            this.buttonCamera.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.buttonCamera.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonCamera.Image = ((System.Drawing.Image)(resources.GetObject("buttonCamera.Image")));
            this.buttonCamera.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.buttonCamera.ImageTransparentColor = System.Drawing.Color.Red;
            this.buttonCamera.Name = "buttonCamera";
            this.buttonCamera.Size = new System.Drawing.Size(23, 22);
            this.buttonCamera.ToolTipText = "Камера по умолчанию";
            this.buttonCamera.Click += new System.EventHandler(this.ButtonCameraClick);
            // 
            // buttonVolume
            // 
            this.buttonVolume.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.buttonVolume.Checked = true;
            this.buttonVolume.CheckOnClick = true;
            this.buttonVolume.CheckState = System.Windows.Forms.CheckState.Checked;
            this.buttonVolume.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonVolume.Image = ((System.Drawing.Image)(resources.GetObject("buttonVolume.Image")));
            this.buttonVolume.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.buttonVolume.ImageTransparentColor = System.Drawing.Color.Red;
            this.buttonVolume.Name = "buttonVolume";
            this.buttonVolume.Size = new System.Drawing.Size(23, 22);
            this.buttonVolume.ToolTipText = "Отобразить / скрыть ограничивающий объем";
            this.buttonVolume.CheckedChanged += new System.EventHandler(this.ButtonVolumeCheckedChanged);
            // 
            // buttonAxes
            // 
            this.buttonAxes.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.buttonAxes.Checked = true;
            this.buttonAxes.CheckOnClick = true;
            this.buttonAxes.CheckState = System.Windows.Forms.CheckState.Checked;
            this.buttonAxes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonAxes.Image = ((System.Drawing.Image)(resources.GetObject("buttonAxes.Image")));
            this.buttonAxes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.buttonAxes.ImageTransparentColor = System.Drawing.Color.Red;
            this.buttonAxes.Name = "buttonAxes";
            this.buttonAxes.Size = new System.Drawing.Size(23, 22);
            this.buttonAxes.ToolTipText = "Отобразить / скрыть оси";
            this.buttonAxes.CheckedChanged += new System.EventHandler(this.ButtonAxesCheckedChanged);
            // 
            // labelMouseActive
            // 
            this.labelMouseActive.Font = new System.Drawing.Font("Wingdings", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.labelMouseActive.ForeColor = System.Drawing.Color.Brown;
            this.labelMouseActive.Name = "labelMouseActive";
            this.labelMouseActive.Size = new System.Drawing.Size(23, 22);
            this.labelMouseActive.Text = "8";
            this.labelMouseActive.Visible = false;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 20;
            this.timer.Tick += new System.EventHandler(this.TimerTick);
            // 
            // panelStatus
            // 
            this.panelStatus.Controls.Add(this.progressBar);
            this.panelStatus.Controls.Add(this.labelOrientation);
            this.panelStatus.Controls.Add(this.labelPosition);
            this.panelStatus.Controls.Add(this.labelTime);
            this.panelStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelStatus.Location = new System.Drawing.Point(0, 587);
            this.panelStatus.Name = "panelStatus";
            this.panelStatus.Size = new System.Drawing.Size(832, 21);
            this.panelStatus.TabIndex = 13;
            // 
            // progressBar
            // 
            this.progressBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressBar.Location = new System.Drawing.Point(360, 0);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(372, 21);
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar.TabIndex = 5;
            // 
            // labelOrientation
            // 
            this.labelOrientation.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelOrientation.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelOrientation.Location = new System.Drawing.Point(180, 0);
            this.labelOrientation.Name = "labelOrientation";
            this.labelOrientation.Size = new System.Drawing.Size(180, 21);
            this.labelOrientation.TabIndex = 4;
            this.labelOrientation.Text = "---";
            this.labelOrientation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPosition
            // 
            this.labelPosition.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelPosition.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelPosition.Location = new System.Drawing.Point(0, 0);
            this.labelPosition.Name = "labelPosition";
            this.labelPosition.Size = new System.Drawing.Size(180, 21);
            this.labelPosition.TabIndex = 3;
            this.labelPosition.Text = "---";
            this.labelPosition.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTime
            // 
            this.labelTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelTime.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelTime.Location = new System.Drawing.Point(732, 0);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(100, 21);
            this.labelTime.TabIndex = 1;
            this.labelTime.Text = "---";
            this.labelTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.WorkerReportsProgress = true;
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorkerDoWork);
            this.backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BackgroundWorkerProgressChanged);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundWorkerRunWorkerCompleted);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(832, 608);
            this.Controls.Add(this.panelStatus);
            this.Controls.Add(this.panelView);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.panelLightSources);
            this.Controls.Add(this.panelPrimitives);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Raytracing Tutorial";
            this.Load += new System.EventHandler(this.MainFormLoad);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.panelLightSources.ResumeLayout(false);
            this.panelLightSources.PerformLayout();
            this.toolStripLights.ResumeLayout(false);
            this.toolStripLights.PerformLayout();
            this.panelPrimitives.ResumeLayout(false);
            this.panelPrimitives.PerformLayout();
            this.toolStripPrimitives.ResumeLayout(false);
            this.toolStripPrimitives.PerformLayout();
            this.panelView.ResumeLayout(false);
            this.panelView.PerformLayout();
            this.toolStripViewport.ResumeLayout(false);
            this.toolStripViewport.PerformLayout();
            this.panelStatus.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.ToolStripMenuItem menuItemSaveImage;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.Label labelOrientation;
        private System.Windows.Forms.Label labelPosition;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Panel panelStatus;
        private System.Windows.Forms.ToolStripMenuItem menuItemEditor;
        private System.Windows.Forms.ToolStripMenuItem режимToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuItemRender;
        private System.Windows.Forms.ToolStripSeparator menuSeparatorExit;
        private System.Windows.Forms.Panel panelView;
        private System.Windows.Forms.ToolStripLabel labelMouseActive;
        private System.Windows.Forms.ListView listViewLights;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.ToolStripButton buttonRemoveAllLights;
        private System.Windows.Forms.ToolStripSeparator separatorLightsLeft;
        private System.Windows.Forms.ToolStripSeparator separatorLightsRight;
        private System.Windows.Forms.ToolStripButton buttonRemovePrimitive;
        private System.Windows.Forms.ToolStripSeparator separatorPrimitivesLeft;
        private System.Windows.Forms.ToolStripSeparator separatorPrimitivesRight;
        private System.Windows.Forms.ToolStripButton buttonRemovePrimitives;
        private System.Windows.Forms.ToolStripButton buttonSaveLight;
        private System.Windows.Forms.ToolStripButton buttonOpenLight;
        private System.Windows.Forms.ToolStripMenuItem menuItemSaveLight;
        private System.Windows.Forms.ToolStripMenuItem menuItemSavePrimitive;
        private System.Windows.Forms.ToolStripMenuItem menuItemSaveScene;
        private System.Windows.Forms.ToolStripMenuItem menuItemOpenLight;
        private System.Windows.Forms.ToolStripMenuItem menuItemOpenPrimitive;
        private System.Windows.Forms.ToolStripMenuItem menuItemOpenScene;
        private System.Windows.Forms.ToolStripButton buttonSavePrimitive;
        private System.Windows.Forms.ToolStripButton buttonOpenPrimitive;
        private System.Windows.Forms.ToolStripButton buttonCamera;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ToolStripButton buttonVolume;
        private System.Windows.Forms.ToolStripButton buttonSceneProperties;
        private System.Windows.Forms.ToolStripButton buttonAxes;
        private System.Windows.Forms.ToolStripLabel labelLights;
        private System.Windows.Forms.ToolStripLabel labelViewport;
        private System.Windows.Forms.ToolStrip toolStripViewport;
        private System.Windows.Forms.ToolStrip toolStripLights;
        private System.Windows.Forms.ToolStripMenuItem menuItemAbout;
        private Tao.Platform.Windows.SimpleOpenGlControl panelOpenGL;
        private System.Windows.Forms.ToolStripMenuItem menuItemExit;
        private System.Windows.Forms.ToolStripMenuItem menuItemSave;
        private System.Windows.Forms.ToolStripMenuItem menuItemOpen;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuItemAddBox;
        private System.Windows.Forms.ToolStripMenuItem menuItemAddSquare;
        private System.Windows.Forms.ToolStripMenuItem menuItemAddSphere;
        private System.Windows.Forms.ToolStripMenuItem menuItemBasePrimitives;
        private System.Windows.Forms.ToolStripButton buttonRemoveLight;
        private System.Windows.Forms.ToolStripButton buttonLightProperties;
        private System.Windows.Forms.ToolStripButton buttonAddLight;
        private System.Windows.Forms.MenuStrip menuStrip;

        #endregion

        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.Panel panelLightSources;
        private System.Windows.Forms.Panel panelPrimitives;
        private System.Windows.Forms.ListView listViewPrimitives;
        private System.Windows.Forms.ToolStrip toolStripPrimitives;
        private System.Windows.Forms.ToolStripLabel labelPrimitives;
        private System.Windows.Forms.ToolStripButton buttonPrimitiveProperties;
        private System.Windows.Forms.ToolStripSplitButton buttonAddPrimitive;
        private System.ComponentModel.BackgroundWorker backgroundWorker;


    }
}

