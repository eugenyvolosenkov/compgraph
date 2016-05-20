using System;
using System.Windows.Forms;
using Auxiliary.MathTools;

namespace SceneEditor
{
	/// <summary> Диалговое окно для настройки параметров визуализации. </summary>
	public partial class RenderDialog : Form
	{
		#region Private Fields

		/// <summary> Половинный размер видимого объема. </summary>
		private Vector3D volumeSize = new Vector3D(5.0f, 5.0f, 5.0f);
		
		#endregion
	
		#region Public Fields
		
		/// <summary> Скорость мыши. </summary>
		public float MouseSpeed = 0.005f;
		
		/// <summary> Скорость клавиатуры. </summary>
		public float KeyboardSpeed = 0.1f;
		
        /// <summary> Глубина трассировки. </summary>
        public int TraceDepth = 5;        
        
        /// <summary> Число потоков рендеринга. </summary>
        public int ThreadsCount = 2;
        
        /// <summary> Ширина изображения. </summary>
        public int ImageWidth = 512;        
        
        /// <summary> Высота изображения. </summary>
        public int ImageHeight = 512;        
		
        /// <summary> Угол раствора камеры. </summary>
        public float FieldOfView = Util.PI / 6.0f;
        
		#endregion
				
		#region Constructor
		
		/// <summary> Создает новое диалоговое окно для настройки параметров визуализации. </summary>
		public RenderDialog()
		{
			InitializeComponent();
		}
		
		#endregion
		
		#region Private Methods
		
		/// <summary> Отображает настройки визуализации в элементах управления. </summary>
		private void OutputOptions()
		{
			// Выводим скорость мыши
			trackBarMouse.Value = Convert.ToInt32(10000f * MouseSpeed);
			
			// Выводим скорость клавиатуры
			trackBarKeyboard.Value = Convert.ToInt32(100f * KeyboardSpeed);
			
			// Выводим половинный размер видимого объема
			numericUpDownSizeX.Value = Convert.ToDecimal(volumeSize.X);
			numericUpDownSizeY.Value = Convert.ToDecimal(volumeSize.Y);
			numericUpDownSizeZ.Value = Convert.ToDecimal(volumeSize.Z);
			
			// Выводим глубину трассировки
			numericUpDownTraceDepth.Value = TraceDepth;
			
			// Выводим число потоков для рассчета
			numericUpDownThreadsCount.Value = ThreadsCount;
			
			// Выводим размеры изображения
			numericUpDownWidth.Value = ImageWidth;
			numericUpDownHeight.Value = ImageHeight;
			
			// Выводим угол раствора камеры
			numericUpDownFieldOfView.Value = Convert.ToDecimal(Util.ToDegree(FieldOfView));
		}
		
		/// <summary> Сохраняет настройки визуализации из элементов управления. </summary>
		private void InputOptions()
		{
			// Сохраняем скорость мыши
			MouseSpeed = trackBarMouse.Value / 10000f;
			
			// Сохраняем скорость клавиатуры
			KeyboardSpeed = trackBarKeyboard.Value / 100f;
			
			// Сохраняем половинный размер видимого объема
			volumeSize = new Vector3D(Convert.ToSingle(numericUpDownSizeX.Value),
			                          Convert.ToSingle(numericUpDownSizeY.Value),
			                          Convert.ToSingle(numericUpDownSizeZ.Value));
			
			// Сохраняем глубину трассировки
			TraceDepth = Convert.ToInt32(numericUpDownTraceDepth.Value);
			
			// Сохраняем число потоков для рассчета
			ThreadsCount = Convert.ToInt32(numericUpDownThreadsCount.Value);
			
			// Сохраняем размеры изображения
			ImageWidth = Convert.ToInt32(numericUpDownWidth.Value);
			ImageHeight = Convert.ToInt32(numericUpDownHeight.Value);
			
			// Сохраняем угол раствора камеры
			FieldOfView = Util.ToRadian(Convert.ToSingle(numericUpDownFieldOfView.Value));
		}		
		
		#endregion
		
		#region Event Handlers
				
		private void RenderDialogLoad(object sender, EventArgs e)
		{
			OutputOptions();
		}
		
		private void RenderDialogFormClosed(object sender, FormClosedEventArgs e)
		{
			if (DialogResult == DialogResult.OK) InputOptions();
		}		
			
		#endregion
		
		#region Properties
		
		/// <summary> Половинный (!) размер видимого объема. </summary>
		public Vector3D VolumeSize
		{
			get
			{
				return volumeSize;
			}
			
			set
			{
				volumeSize = (Vector3D) Replicator.Copy(value);
			}
		}
		
		#endregion
	}
}
