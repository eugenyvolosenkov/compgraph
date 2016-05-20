using System;
using System.Windows.Forms;
using Auxiliary.Raytracing;

namespace SceneEditor
{
	/// <summary> Диалоговое окно для задания параметров сферы. </summary>
	public partial class SphereDialog : Form
	{
		#region Private Fields

		/// <summary> Объект 'Сфера'. </summary>
		private Sphere sphere = new Sphere(1.0f);
		
		#endregion
		
		#region Constructor
		
		/// <summary> Создает диалогове окно для задания параметров сферы. </summary>
		public SphereDialog()
		{
			InitializeComponent();
		}
		
		#endregion
		
		#region Private Methods
		
		/// <summary> Отображает свойства сферы в элементах управления. </summary>
		private void OutputOptions()
		{
			// Выводим имя объекта
			textBoxName.Text = sphere.Name;
			
			// Выводим радиус сферы
			numericUpDownRadius.Value = Convert.ToDecimal(sphere.Radius);
		}
		
		/// <summary> Сохраняет свойства сферы из элементов управления. </summary>
		private void InputOptions()
		{
			// Сохраняем имя объекта
			sphere.Name = textBoxName.Text;
			
			// Сохраняем радиус сферы
			sphere.Radius = Convert.ToSingle(numericUpDownRadius.Value);
		}
		
		#endregion		
		
		#region Event Handlers
		
		private void ButtonTransformClick(object sender, EventArgs e)
		{
			TransformDialog dialog = new TransformDialog();
			
			dialog.Transform = sphere.Transform;
			
			if (dialog.ShowDialog() == DialogResult.OK)
				sphere.Transform = dialog.Transform;
		}
		
		private void ButtonMaterialClick(object sender, EventArgs e)
		{
			MaterialDialog dialog = new MaterialDialog();
			
			dialog.Material = sphere.Material;
			
			if (dialog.ShowDialog() == DialogResult.OK)
				sphere.Material = dialog.Material;
		}

		private void SphereDialogLoad(object sender, EventArgs e)
		{
			OutputOptions();
		}
		
		private void SphereDialogFormClosed(object sender, FormClosedEventArgs e)
		{
			if (DialogResult == DialogResult.OK) InputOptions();
		}
		
		#endregion
		
		#region Properties
		
		/// <summary> Объект 'Сфера'. </summary>
		public Sphere Sphere
		{
			get
			{
				return sphere;
			}
			
			set
			{
				sphere = (Sphere) Replicator.Copy(value);
			}
		}
		
		#endregion
	}
}
