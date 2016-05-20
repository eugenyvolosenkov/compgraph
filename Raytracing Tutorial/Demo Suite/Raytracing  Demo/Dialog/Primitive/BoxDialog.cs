using System;
using System.Windows.Forms;
using Auxiliary.MathTools;
using Auxiliary.Raytracing;

namespace SceneEditor
{
	/// <summary> Диалоговое окно для задания параметров параллелипипеда. </summary>
	public partial class BoxDialog : Form
	{
		#region Private Fields
		
		/// <summary> Объект 'Параллелипипед'. </summary>
		private Box box = new Box(new Vector3D(1.0f, 1.0f, 1.0f));
		
		#endregion
		
		#region Constructor
		
		/// <summary> Создает диалоговое окно для задания параметров параллелипипеда. </summary>
		public BoxDialog()
		{
			InitializeComponent();
		}
		
		#endregion
		
		#region Private Methods
		
		/// <summary> Отображает свойства параллелипипеда в элементах управления. </summary>
		private void OutputOptions()
		{
			// Выводим имя объекта
			textBoxName.Text = box.Name;
			
			// Выводим размеры параллелипипеда
			numericUpDownSizeX.Value = Convert.ToDecimal(box.Size.X);
			numericUpDownSizeY.Value = Convert.ToDecimal(box.Size.Y);
			numericUpDownSizeZ.Value = Convert.ToDecimal(box.Size.Z);
		}
		
		/// <summary> Сохраняет свойства параллелипипеда из элементов управления. </summary>
		private void InputOptions()
		{
			// Сохраняем имя объекта
			box.Name = textBoxName.Text;
			
			// Сохраняем размеры параллелипипеда
			box.Size = new Vector3D(Convert.ToSingle(numericUpDownSizeX.Value),
			                        Convert.ToSingle(numericUpDownSizeY.Value),
			                        Convert.ToSingle(numericUpDownSizeZ.Value));
		}
		
		#endregion
		
		#region Event Handlers
		
		private void ButtonTransformClick(object sender, EventArgs e)
		{
			TransformDialog dialog = new TransformDialog();
			
			dialog.Transform = box.Transform;
			
			if (dialog.ShowDialog() == DialogResult.OK)
				box.Transform = dialog.Transform;
		}
		
		private void ButtonMaterialClick(object sender, EventArgs e)
		{
			MaterialDialog dialog = new MaterialDialog();
			
			dialog.Material = box.Material;

			if (dialog.ShowDialog() == DialogResult.OK)
				box.Material = dialog.Material;			
		}		

		private void SquareDialogLoad(object sender, EventArgs e)
		{
			OutputOptions();
		}
		
		private void SquareDialogFormClosed(object sender, FormClosedEventArgs e)
		{
			if (DialogResult == DialogResult.OK) InputOptions();
		}		
		
		#endregion
	
		#region Properties
		
		/// <summary> Объект 'Параллелипипед'. </summary>
		public Box Box
		{
			get
			{
				return box;
			}
			
			set
			{
				box = (Box) Replicator.Copy(value);
			}
		}
		
		#endregion
	}
}
