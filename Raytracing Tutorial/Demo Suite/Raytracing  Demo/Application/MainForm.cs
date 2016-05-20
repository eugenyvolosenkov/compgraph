using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

using Auxiliary.Graphics;
using Auxiliary.MathTools;
using Auxiliary.Raytracing;
using Tao.OpenGl;

namespace SceneEditor
{
	/// <summary> Главное окно приложения. </summary>
    public partial class MainForm : Form
    {
        #region Private Fields
        
        /// <summary> Управляет камерой при помощи мыши. </summary>
        private Mouse mouse = new Mouse();
		
		/// <summary> Управляет камерой при помощи клавиатуры. </summary>
		private Keyboard keyboard = new Keyboard();
		
		/// <summary> Сцена с объектами и источниками света. </summary>
		private Scene scene = new Scene();
		
		/// <summary> Точечный рисунок для сохранения изображения. </summary>
		private Raster raster = null;
		
		/// <summary> Режим работы окна просмотра. </summary>
    	private ViewMode mode = ViewMode.Editor;
		
        #endregion
        
        #region Constructor
        
        /// <summary> Создает главное окно приложения. </summary>
        public MainForm()
        {
            InitializeComponent();
        }        
        
        #endregion
        
        #region Private Methods
        
        #region Редактирование сцены
        
        /// <summary> Добавляет на сцену объект 'Сфера'. </summary>
        private void AddSphere()
        {
        	SphereDialog dialog = new SphereDialog();
        	
        	{
	        	int count = 1;
	        	
	        	foreach (Primitive primitive in scene.Primitives)
	        		if (primitive is Sphere) count++;
	        	
	        	dialog.Sphere.Name = "Sphere [" + count + "]";
        	}
        	
        	if (DialogResult.OK == dialog.ShowDialog())
        	{
        		scene.Primitives.Add(dialog.Sphere);
        		
        		OutputPrimitives();       		
        	}       	
        }
        
        /// <summary> Добавляет на сцену объект 'Прямоугольник'. </summary>
        private void AddSquare()
        {
        	SquareDialog dialog = new SquareDialog();
        	
        	{
	        	int count = 1;
	        	
	        	foreach (Primitive primitive in scene.Primitives)
	        		if (primitive is Square) count++;
	        	
	        	dialog.Square.Name = "Square [" + count + "]";
        	}
        	
        	if (DialogResult.OK == dialog.ShowDialog())
        	{
        		scene.Primitives.Add(dialog.Square);
        		
        		OutputPrimitives();      		
        	}       	
        }
        
        /// <summary> Добавляет на сцену объект 'Параллелипипед'. </summary>
        private void AddBox()
        {
        	BoxDialog dialog = new BoxDialog();
        	
        	{
	        	int count = 1;
	        	
	        	foreach (Primitive primitive in scene.Primitives)
	        		if (primitive is Box) count++;
	        	
	        	dialog.Box.Name = "Box [" + count + "]";
        	}
        	
        	if (DialogResult.OK == dialog.ShowDialog())
        	{
        		scene.Primitives.Add(dialog.Box);
        		
        		OutputPrimitives();      		
        	}        	
        }         
        
        /// <summary> Изменяет параметры выделенного объекта. </summary>
        private void EditPrimitive()
        {
        	if (listViewPrimitives.SelectedIndices.Count != 0)
        	{        		
        		if (scene.Primitives[listViewPrimitives.SelectedIndices[0]] is Sphere)
        		{
        			SphereDialog dialog = new SphereDialog();
        			
        			dialog.Sphere = (Sphere) scene.Primitives[listViewPrimitives.SelectedIndices[0]];
        			
        			if (DialogResult.OK == dialog.ShowDialog())
        				scene.Primitives[listViewPrimitives.SelectedIndices[0]] = dialog.Sphere;
        		}
        		else
        		{
	         		if (scene.Primitives[listViewPrimitives.SelectedIndices[0]] is Square)
	        		{
	        			SquareDialog dialog = new SquareDialog();
	        			
	        			dialog.Square = (Square) scene.Primitives[listViewPrimitives.SelectedIndices[0]];
	        			
	        			if (DialogResult.OK == dialog.ShowDialog())
	        				scene.Primitives[listViewPrimitives.SelectedIndices[0]] = dialog.Square;
	         		}
	         		else
	         		{
		         		if (scene.Primitives[listViewPrimitives.SelectedIndices[0]] is Box)
		        		{
		        			BoxDialog dialog = new BoxDialog();
		        			
		        			dialog.Box = (Box) scene.Primitives[listViewPrimitives.SelectedIndices[0]];
		        			
		        			if (DialogResult.OK == dialog.ShowDialog())
		        				scene.Primitives[listViewPrimitives.SelectedIndices[0]] = dialog.Box;
		         		}
	         		}
        		}
        		
        		OutputPrimitives();
        	}
        	else
        	{
        		MessageBox.Show("Ошибка! Не выбран объект для редактирования.");
        	}        
        }        

        /// <summary> Удаляет со сцены выделенный объект. </summary>
        private void RemovePrimitive()
        {
        	if (listViewPrimitives.SelectedIndices.Count != 0)
        	{
        		scene.Primitives.RemoveAt(listViewPrimitives.SelectedIndices[0]);
        		
        		OutputPrimitives();
        	}
        	else
        	{
        		MessageBox.Show("Ошибка! Не выбран объект для удаления.");
        	}
        }
        
        /// <summary> Удаляет со сцены все объекты. </summary>
        private void RemoveAllPrimitives()
        {
        	scene.Primitives.Clear();
        	
        	OutputPrimitives();
        }                
        
         /// <summary> Выводит список объектов в элементы графического интерфейса. </summary>
        private void OutputPrimitives()
        {
        	listViewPrimitives.Items.Clear();
        	
        	foreach (Primitive primitive in scene.Primitives)
        	{
        		ListViewItem item = new ListViewItem(primitive.Name);
        		
        		if (primitive is Sphere)
        			item.ImageIndex = 0;
        		else
        			if (primitive is Square)
	         			item.ImageIndex = 1;
	         		else
	         			if (primitive is Box)
		         			item.ImageIndex = 2;
        		
        		listViewPrimitives.Items.Add(item);
        	}
        }       
        
        /// <summary> Добавляет на сцену источник света. </summary>
        private void AddLight()
        {
        	if (scene.Lights.Count < 8)
        	{
        		LightDialog dialog = new LightDialog();
        		
	        	dialog.Light.Number = scene.Lights.Count;
	        	
	        	if (DialogResult.OK == dialog.ShowDialog())
	        	{
	        		scene.Lights.Add(dialog.Light);
	        		
	        		OutputLights();
	        	}        		
        	}
        	else
        	{
        		MessageBox.Show("Ошибка! В текущей версии вы не можете добавить более 8 источников света.");
        	}
        }               
        
        /// <summary> Изменяет параметры выделенного источника света. </summary>
        private void EditLight()
        {
        	if (listViewLights.SelectedIndices.Count != 0)
        	{
        		LightDialog dialog = new LightDialog();
	        	
        		dialog.Light = scene.Lights[listViewLights.SelectedIndices[0]];
	        	
	        	if (DialogResult.OK == dialog.ShowDialog())
	        		scene.Lights[listViewLights.SelectedIndices[0]] = dialog.Light;
        	}
        	else
        	{
        		MessageBox.Show("Ошибка! Не выбран источник света для редактирования.");
        	}
        }
        
        /// <summary> Удаляет со сцены выделенный источник света. </summary>
        private void RemoveLight()
        {
        	if (listViewLights.SelectedIndices.Count != 0)
        	{
        		Gl.glDisable(Gl.GL_LIGHT0 + scene.Lights.Count - 1);        		
        		
        		scene.Lights.RemoveAt(listViewLights.SelectedIndices[0]);
        		
        		for (int i = 0; i < scene.Lights.Count; i++)
        			scene.Lights[i].Number = i;
        		
        		OutputLights();
        	}
        	else
        	{
        		MessageBox.Show("Ошибка! Не выбран источник света для удаления.");
        	}
        }
        
        /// <summary> Удаляет со сцены все источники света. </summary>
        private void RemoveAllLights()
        {
        	for (int i = 0; i < scene.Lights.Count; i++)
        		Gl.glDisable(Gl.GL_LIGHT0 + i);
        	
        	scene.Lights.Clear();
        	
        	OutputLights();
        }
        
        /// <summary> Выводит список источников света в элементы графического интерфейса. </summary>
        private void OutputLights()
        {
        	listViewLights.Items.Clear();
        	
        	foreach (Light light in scene.Lights)
        	{
        		ListViewItem item = new ListViewItem("Light [" + (light.Number + 1) + "]");
        		
        		item.ImageIndex = 4;
        		
        		listViewLights.Items.Add(item);
        	}
        }        
        
        #endregion
        
        #region Сохранение и загрузка сцены и отдельных объектов
        
        /// <summary> Загружает сцену из файла. </summary>
        private void OpenScene()
        {
        	OpenFileDialog dialog = new OpenFileDialog();
        	
        	dialog.Filter = "Файлы сцен (*.scn) | *.scn";
        	
        	if (DialogResult.OK == dialog.ShowDialog())
        	{
        		using (FileStream fileStream = new FileStream(dialog.FileName, FileMode.Open))
				{
					IFormatter formatter = new BinaryFormatter();
					
					try
					{					
						scene = (Scene) formatter.Deserialize(fileStream);
					}
					catch
					{
						MessageBox.Show("Ошибка! Не удается загрузить сцену из файла.");
					}
					
					fileStream.Close();
				}
	        	
	        	OutputPrimitives();
	        	
	        	OutputLights();
        	}
        }
        
        /// <summary> Сохраняет сцену в файл. </summary>
        private void SaveScene()
        {
        	SaveFileDialog dialog = new SaveFileDialog();
        	
        	dialog.Filter = "Файлы сцен (*.scn) | *.scn";
        	
        	if (DialogResult.OK == dialog.ShowDialog())
        	{        	
	        	using (FileStream fileStream = new FileStream(dialog.FileName, FileMode.Create))
				{
					IFormatter formatter = new BinaryFormatter();
					
					try
					{
						formatter.Serialize(fileStream, scene);
					}
					catch
					{
						MessageBox.Show("Ошибка! Не удается сохранить сцену в файл.");
					}
					
					fileStream.Close();
	        	}
        	}        	
        }
        
        /// <summary> Загружает объект из файла. </summary>
        private void OpenPrimitive()
        {
        	OpenFileDialog dialog = new OpenFileDialog();
        	
        	dialog.Filter = "Файлы объектов (*.prim) | *.prim";
        	
        	if (DialogResult.OK == dialog.ShowDialog())
        	{
        		using (FileStream fileStream = new FileStream(dialog.FileName, FileMode.Open))
				{
					IFormatter formatter = new BinaryFormatter();
					
					try
					{					
						Primitive primitive = (Primitive) formatter.Deserialize(fileStream);
						
						scene.Primitives.Add(primitive);
						
						OutputPrimitives();
					}
					catch
					{
						MessageBox.Show("Ошибка! Не удается загрузить объект из файла.");
					}
					
					fileStream.Close();
        		}
        	}
        }
        
        /// <summary> Сохраняет объект в файл. </summary>
        private void SavePrimitive()
        {
        	if (listViewPrimitives.SelectedIndices.Count != 0)
        	{
	        	SaveFileDialog dialog = new SaveFileDialog();
	        	
	        	dialog.Filter = "Файлы объектов (*.prim) | *.prim";
	        	
	        	if (DialogResult.OK == dialog.ShowDialog())
	        	{        	
		        	using (FileStream fileStream = new FileStream(dialog.FileName, FileMode.Create))
					{
						IFormatter formatter = new BinaryFormatter();
						
						try
						{
							formatter.Serialize(fileStream,
							                    scene.Primitives[listViewPrimitives.SelectedIndices[0]]);
						}
						catch
						{
							MessageBox.Show("Ошибка! Не удается сохранить объект в файл.");
						}
						
						fileStream.Close();
		        	}
	        	}
        	}
        	else
        	{
        		MessageBox.Show("Ошибка! Не выбран объект для сохранения.");
        	}
        }
        
        /// <summary> Загружает источник света из файла. </summary>
        private void OpenLight()
        {
        	if (scene.Lights.Count < 8)
        	{
	        	OpenFileDialog dialog = new OpenFileDialog();
	        	
	        	dialog.Filter = "Файлы источников света (*.light) | *.light";
	        	
	        	if (DialogResult.OK == dialog.ShowDialog())
	        	{
	        		using (FileStream fileStream = new FileStream(dialog.FileName, FileMode.Open))
					{
						IFormatter formatter = new BinaryFormatter();
						
						try
						{					
							Light light = (Light) formatter.Deserialize(fileStream);
							
							light.Number = scene.Lights.Count;
							
							scene.Lights.Add(light);
							
							OutputLights();
						}
						catch
						{
							MessageBox.Show("Ошибка! Не удается загрузить источник света из файла.");
						}
						
						fileStream.Close();
					}
	        	}       		
        	}
        	else
        	{
        		MessageBox.Show("Ошибка! В текущей версии вы не можете добавить более 8 источников света.");
        	}
        }
        
        /// <summary> Сохраняет источник света в файл. </summary>
        private void SaveLight()
        {
        	if (listViewLights.SelectedIndices.Count != 0)
        	{
	        	SaveFileDialog dialog = new SaveFileDialog();
	        	
	        	dialog.Filter = "Файлы источников света (*.light) | *.light";
	        	
	        	if (DialogResult.OK == dialog.ShowDialog())
	        	{        	
		        	using (FileStream fileStream = new FileStream(dialog.FileName, FileMode.Create))
					{
						IFormatter formatter = new BinaryFormatter();
						
						try
						{
							formatter.Serialize(fileStream,
							                    scene.Lights[listViewLights.SelectedIndices[0]]);
						}
						catch
						{
							MessageBox.Show("Ошибка! Не удается сохранить источник света в файл.");
						}
						
						fileStream.Close();
		        	}
	        	}
        	}
        	else
        	{
        		MessageBox.Show("Ошибка! Не выбран источник света для сохранения.");
        	}
        }             
        
        /// <summary> Сохраняет сгенерированное изображение в файл. </summary>
        private void SaveImage()
        {
        	if (null != raster)
        	{
	        	SaveFileDialog dialog = new SaveFileDialog();
	        	
	        	dialog.Filter = "Точечный рисунок (*.bmp) | *.bmp";
	        	
	        	if (DialogResult.OK == dialog.ShowDialog())
	        	{        	
	        		raster.ToBitmap().Save(dialog.FileName);
	        	}
        	}
        	else
        	{
        		MessageBox.Show("Ошибка! Изображение недоступно.");
        	}
        }
        
        #endregion
        
        #region Настройка визуализации
                
        /// <summary> Настраивает параметры состояния API OpenGL. </summary>
        private void InitOpenGL()
        {
        	Gl.glShadeModel(Gl.GL_SMOOTH);
        	
        	Gl.glEnable(Gl.GL_POINT_SMOOTH);
    
        	Gl.glPointSize(5.0f);
        }           

        /// <summary> Устанавлиает положение и ориентацию камеры по умолчанию. </summary>
        private void InitCamera()
        {
        	scene.Camera.Position = new Vector3D(29.0f, 11.0f, 11.0f);
        	
        	scene.Camera.Orientation = new Vector3D(0.0f, 0.36f, -0.38f);       	
        }
        
        /// <summary> Перключает режимы 'редактирование сцены / просмотр результата'. </summary>
        private void SwitchMode(ViewMode mode)
        {
        	this.mode = mode;
        	
        	if (ViewMode.Editor == mode)
        	{        		
        		// Инициализируем параметры состояния API OpenGL
        		{
        			Gl.glEnable(Gl.GL_LIGHTING);
        			
        			Gl.glEnable(Gl.GL_DEPTH_TEST);
        			
        			Gl.glDisable(Gl.GL_TEXTURE_2D);
        		}
        		
        		// Устанавливаем размеры окна вывода
        		Gl.glViewport(0, 0, panelOpenGL.Width, panelOpenGL.Height);
        	}
        	else
        	{
        		// Инициализируем параметры состояния API OpenGL
        		{
        			Gl.glDisable(Gl.GL_LIGHTING);
	        		
	        		Gl.glDisable(Gl.GL_DEPTH_TEST);
	        		
	        		Gl.glEnable(Gl.GL_TEXTURE_2D);
        		}
        		
        		// Устанавливаем размеры окна вывода
        		Gl.glViewport(0, 0, panelOpenGL.Width, panelOpenGL.Height);
        		
        		// Устанавливаем матрицу проекции
        		{
        			Gl.glMatrixMode(Gl.GL_PROJECTION);
        			            
		            Gl.glLoadIdentity();              
		            
		            Gl.glOrtho(-1.0f, 1.0f, -1.0f, 1.0f, -1.0f, 1.0f);
		            
		            Gl.glMatrixMode(Gl.GL_MODELVIEW);
		            
		            Gl.glLoadIdentity();
        		}        		
        	}
        }
        
        #endregion
        
        #region Визуализация сцены
        
        /// <summary> Отрисовывает сцену в выбранном режиме. </summary>
        private void DrawScene()
        {        	
        	if (ViewMode.Editor == mode)
        	{
	        	Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT);
	        	
	        	mouse.Apply(scene.Camera);
	        	
	        	keyboard.Apply(scene.Camera);        	            
	        	            
	        	scene.Camera.Setup();
	        	
	        	scene.Draw();
	        	
	        	labelPosition.Text = "Положение: " + scene.Camera.Position.ToString();
	        	
	        	labelOrientation.Text = "Ориентация: " + scene.Camera.Orientation.ToString();
        	}
        	else
        	{
        		Gl.glClear(Gl.GL_COLOR_BUFFER_BIT);
			
        		Gl.glColor3f(1.0f, 1.0f, 1.0f);
				
        		Gl.glBegin(Gl.GL_QUADS);
				{
					Gl.glTexCoord2f(0.0f, 0.0f);
					Gl.glVertex2f(-1.0f, -1.0f);
					
					Gl.glTexCoord2f(0.0f, 1.0f);
					Gl.glVertex2f(-1.0f, 1.0f);
					
					Gl.glTexCoord2f(1.0f, 1.0f);
					Gl.glVertex2f(1.0f, 1.0f);
					
					Gl.glTexCoord2f(1.0f, 0.0f);
					Gl.glVertex2f(1.0f, -1.0f);
				}
				Gl.glEnd();      		
        	}
        } 
 
        #endregion
        
        #endregion
        
        #region Event Handlers
        
        #region Общие операции
        
        private void MainFormLoad(object sender, EventArgs e)
        {
        	panelOpenGL.InitializeContexts();
        	
        	InitOpenGL();
        	
        	InitCamera();
        	
        	SwitchMode(ViewMode.Editor);
        }

        private void MenuItemAboutClick(object sender, EventArgs e)
        {
        	(new AboutDialog()).ShowDialog();
        }
        
        private void MenuItemExitClick(object sender, EventArgs e)
        {
        	Close();
        }
        
        #endregion
        
        #region Настройка визуализации
        
        private void ButtonAxesCheckedChanged(object sender, EventArgs e)
        {
        	scene.Axes.Visible = buttonAxes.Checked;
        }
        
        private void ButtonVolumeCheckedChanged(object sender, EventArgs e)
        {
        	scene.Volume.Visible = buttonVolume.Checked;
        }        
        
        private void ButtonCameraClick(object sender, EventArgs e)
        {
        	InitCamera();
        } 
        
        private void ButtonScenePropertiesClick(object sender, EventArgs e)
        {
        	RenderDialog dialog = new RenderDialog();
        	
        	dialog.MouseSpeed = mouse.Speed;        	
        	dialog.KeyboardSpeed = keyboard.Speed;
        	
        	dialog.VolumeSize = scene.Volume.Size;
        	
        	dialog.TraceDepth = Engine.TraceDepth;        	
        	dialog.ThreadsCount = Engine.ThreadsCount;
        	
        	dialog.ImageWidth = scene.Camera.Viewport.Width;
        	dialog.ImageHeight = scene.Camera.Viewport.Height;        	
        	dialog.FieldOfView = scene.Camera.Viewport.FieldOfView;
        	
        	if (DialogResult.OK == dialog.ShowDialog())
        	{
        		mouse.Speed = dialog.MouseSpeed;        		
        		keyboard.Speed = dialog.KeyboardSpeed;
        		
        		scene.Volume.Size = dialog.VolumeSize;
        		
        		Engine.TraceDepth = dialog.TraceDepth;        	
        		Engine.ThreadsCount = dialog.ThreadsCount;
        		
        		scene.Camera.Viewport.Width = dialog.ImageWidth;
        		scene.Camera.Viewport.Height = dialog.ImageHeight;        	
        		scene.Camera.Viewport.FieldOfView = dialog.FieldOfView;        		
        	}
        }
        
        #endregion
        
        #region Визуализация сцены
        
        private void PanelOpenGLPaint(object sender, PaintEventArgs e)
        {
        	DrawScene();
        }
        
        private void PanelOpenGLKeyDown(object sender, KeyEventArgs e)
        {
        	keyboard.OnKeyDown(e);
        }
        
        private void PanelOpenGLKeyUp(object sender, KeyEventArgs e)
        {
        	keyboard.OnKeyUp(e);
        }
        
        private void PanelOpenGLMouseDown(object sender, MouseEventArgs e)
        {
        	mouse.OnMouseDown(e);
        	
        	labelMouseActive.Visible = mouse.Active;
        }
        
        private void PanelOpenGLMouseMove(object sender, MouseEventArgs e)
        {
        	mouse.OnMouseMove(e);
        }

        private void MenuItemEditorClick(object sender, EventArgs e)
        {
        	SwitchMode(ViewMode.Editor);
        }        
        
        private void MenuItemRenderClick(object sender, EventArgs e)
        {
        	backgroundWorker.RunWorkerAsync();	        	
        }        

        private void BackgroundWorkerDoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
        	raster = new Raster(scene.Camera.Viewport.Width, scene.Camera.Viewport.Height);
        			
        	Engine.Render(scene, raster, backgroundWorker);        			     	
        }
        
        private void BackgroundWorkerProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
        	progressBar.Value = e.ProgressPercentage;
        	
        	labelTime.Text = e.UserState.ToString();
        }        

        private void BackgroundWorkerRunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
        	Texture2D texture = raster.ToTexture();
        			
        	Gl.glBindTexture(Gl.GL_TEXTURE_2D, texture.Handle);
        	
        	SwitchMode(ViewMode.Result);
        }
        
        private void TimerTick(object sender, EventArgs e)
        {
        	panelOpenGL.Invalidate();
        }
        
        #endregion
        
        #region Редактирование сцены
    
        private void MenuItemAddSphereClick(object sender, EventArgs e)
        {
        	AddSphere();
        }
        
        private void MenuItemAddSquareClick(object sender, EventArgs e)
        {
        	AddSquare();
        }
        
        private void MenuItemAddBoxClick(object sender, EventArgs e)
        {
        	AddBox();
        }      
        
        private void ListViewPrimitivesItemChecked(object sender, ItemCheckedEventArgs e)
        {
        	scene.Primitives[e.Item.Index].Visible = e.Item.Checked;
        }
        
        private void ButtonPrimitivePropertiesClick(object sender, EventArgs e)
        {
        	EditPrimitive();
        }       

        private void ButtonRemovePrimitiveClick(object sender, EventArgs e)
        {
        	RemovePrimitive();
        }
        
        private void ButtonRemoveAllPrimitivesClick(object sender, EventArgs e)
        {
        	RemoveAllPrimitives();
        }
        
        private void ButtonAddLightClick(object sender, EventArgs e)
        {
        	AddLight();
        }
        
        private void ButtonLightPropertiesClick(object sender, EventArgs e)
        {
        	EditLight();
        }        

        private void ButtonRemoveLightClick(object sender, EventArgs e)
        {
        	RemoveLight();
        }        
        
        private void ButtonRemoveAllLightsClick(object sender, EventArgs e)
        {
        	RemoveAllLights();
        }      
        
        #endregion
        
        #region Сохранение и загрузка сцены и отдельных объектов
        
        private void ButtonOpenPrimitiveClick(object sender, EventArgs e)
        {
        	OpenPrimitive();
        }
        
        private void ButtonOpenLightClick(object sender, EventArgs e)
        {
        	OpenLight();
        }
        
        private void ButtonSavePrimitiveClick(object sender, EventArgs e)
        {
        	SavePrimitive();
        }
        
        private void ButtonSaveLightClick(object sender, EventArgs e)
        {
        	SaveLight();
        }
        
        private void MenuItemOpenSceneClick(object sender, EventArgs e)
        {
        	OpenScene();
        }
        
        private void MenuItemOpenPrimitiveClick(object sender, EventArgs e)
        {
        	OpenPrimitive();
        }
        
        private void MenuItemOpenLightClick(object sender, EventArgs e)
        {
        	OpenLight();
        }
        
        private void MenuItemSaveSceneClick(object sender, EventArgs e)
        {
        	SaveScene();
        }
        
        private void MenuItemSavePrimitiveClick(object sender, EventArgs e)
        {
        	SavePrimitive();
        }
        
        private void MenuItemSaveLightClick(object sender, EventArgs e)
        {
        	SaveLight();
        }
        
        private void MenuItemSaveImageClick(object sender, EventArgs e)
        {
        	SaveImage();
        }        
        
        #endregion

        private void buttonAddPrimitive_ButtonClick(object sender, EventArgs e)
        {

        }
        
        #endregion       

        private void panelOpenGL_Load(object sender, EventArgs e)
        {

        }
    }
    
    /// <summary> Режим работы окна просмотра. </summary>
    public enum ViewMode
    {
    	/// <summary> Режим редактирования сцены. </summary>
    	Editor,
    	
    	/// <summary> Режим просмотра результата рендеринга. </summary>
    	Result
    }
}
 