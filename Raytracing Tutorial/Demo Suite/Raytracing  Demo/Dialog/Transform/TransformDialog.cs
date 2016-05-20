using System;
using System.Windows.Forms;
using Auxiliary.MathTools;
using Auxiliary.Raytracing;

namespace SceneEditor
{
	/// <summary> Диалоговое окно для задания преобразования объекта. </summary>
	public partial class TransformDialog : Form
	{
		#region Private Fields
		
		/// <summary> Преобразование объекта. </summary>
		private Transform transform;
		
		#endregion
		
		#region Constructor
		
		/// <summary> Создает диалоговое окно для задания преобразования объекта. </summary>
		public TransformDialog()
		{
			InitializeComponent();
		}
		
		#endregion
		
		#region Private Methods
		
		/// <summary> Отображает настройки трансформации объекта в элементах управления. </summary>
		private void OutputOptions()
		{
			// Выводим положение объекта
			numericUpDownPositionX.Value = Convert.ToDecimal(transform.Position.X);
			numericUpDownPositionY.Value = Convert.ToDecimal(transform.Position.Y);
			numericUpDownPositionZ.Value = Convert.ToDecimal(transform.Position.Z);		
			
			// Выводим ориентацию объекта
			numericUpDownAngleX.Value = Convert.ToDecimal(180f * transform.Orientation.X / Math.PI);
			numericUpDownAngleY.Value = Convert.ToDecimal(180f * transform.Orientation.Y / Math.PI);
			numericUpDownAngleZ.Value = Convert.ToDecimal(180f * transform.Orientation.Z / Math.PI);
			
			// Выводим масштабирование объекта
			numericUpDownScalingX.Value = Convert.ToDecimal(transform.Scale.X);
			numericUpDownScalingY.Value = Convert.ToDecimal(transform.Scale.Y);
			numericUpDownScalingZ.Value = Convert.ToDecimal(transform.Scale.Z);
		}
		
		/// <summary> Сохраняет настройки трансформации объекта из элементов управления. </summary>
		private void InputOptions()
		{
			// Сохраняем положение объекта
			transform.Position = new Vector3D(Convert.ToSingle(numericUpDownPositionX.Value),
			                                  Convert.ToSingle(numericUpDownPositionY.Value),
			                                  Convert.ToSingle(numericUpDownPositionZ.Value));
			
			// Сохраняем ориентацию объекта
			transform.Orientation = new Vector3D(Util.PI * Convert.ToSingle(numericUpDownAngleX.Value) / 180f,
			                                     Util.PI * Convert.ToSingle(numericUpDownAngleY.Value) / 180f,
			                                     Util.PI * Convert.ToSingle(numericUpDownAngleZ.Value) / 180f);
			
			// Сохраняем масштабирование объекта
			transform.Scale = new Vector3D(Convert.ToSingle(numericUpDownScalingX.Value),
			                               Convert.ToSingle(numericUpDownScalingY.Value),
			                               Convert.ToSingle(numericUpDownScalingZ.Value));
		}		
		
		#endregion
		
		#region Event Handlers
				
		private void TransformDialogLoad(object sender, EventArgs e)
		{
			OutputOptions();
		}
		
		private void TransformDialogFormClosed(object sender, FormClosedEventArgs e)
		{
			if (DialogResult == DialogResult.OK) InputOptions();
		}		
			
		#endregion		
	
		#region Properties
		
		/// <summary> Преобразоване объекта. </summary>
		public Transform Transform
		{
			get
			{
				return transform;
			}
			
			set
			{
				transform = (Transform) Replicator.Copy(value);
			}			
		}
	
		#endregion
	}
}
