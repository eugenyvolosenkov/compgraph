using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

using Auxiliary.Graphics;
using Auxiliary.MathTools;
using Auxiliary.Raytracing;

namespace SceneEditor
{
	/// <summary> Диалоговое окно для задания свойств материала. </summary>
	public partial class MaterialDialog : Form
	{
		#region Private Fields
		
		/// <summary> Материал объекта (описывает свойства поверхности). </summary>
		private Material material = new Material();
		
		#endregion
		
		#region Constructor
		
		/// <summary> Создает диалоговое окно для задания свойств материала. </summary>
		public MaterialDialog()
		{
			InitializeComponent();
		}
		
		#endregion
		
		#region Private Methods
		
		/// <summary> Отображает настройки материала в элементах управления. </summary>
		private void OutputOptions()
		{
			// Выводим коэффициент отражения фонового света
			trackBarAmbiantR.Value = Convert.ToInt32(material.Ambiant.X * trackBarAmbiantR.Maximum);
			trackBarAmbiantG.Value = Convert.ToInt32(material.Ambiant.Y * trackBarAmbiantG.Maximum);
			trackBarAmbiantB.Value = Convert.ToInt32(material.Ambiant.Z * trackBarAmbiantB.Maximum);
			
			// Выводим коэффициент отражения диффузного света
			trackBarDiffuseR.Value = Convert.ToInt32(material.Diffuse.X * trackBarDiffuseR.Maximum);
			trackBarDiffuseG.Value = Convert.ToInt32(material.Diffuse.Y * trackBarDiffuseG.Maximum);
			trackBarDiffuseB.Value = Convert.ToInt32(material.Diffuse.Z * trackBarDiffuseB.Maximum);
			
			// Выводим коэффициент отражения зеркального блика
			trackBarSpecularR.Value = Convert.ToInt32(material.Specular.X * trackBarSpecularR.Maximum);
			trackBarSpecularG.Value = Convert.ToInt32(material.Specular.Y * trackBarSpecularG.Maximum);
			trackBarSpecularB.Value = Convert.ToInt32(material.Specular.Z * trackBarSpecularB.Maximum);
			
			// Выводим коэффициент резкости бликов
			trackBarShininess.Value = Convert.ToInt32(material.Shininess);
			
			// Выводим вклад отраженного света (описывает отражающие свойства материала)
			trackBarReflectR.Value = Convert.ToInt32(material.ReflectCoeff.X * trackBarReflectR.Maximum);
			trackBarReflectG.Value = Convert.ToInt32(material.ReflectCoeff.Y * trackBarReflectG.Maximum);
			trackBarReflectB.Value = Convert.ToInt32(material.ReflectCoeff.Z * trackBarReflectB.Maximum);
			
			// Выводим вклад преломленного света (описывает преломляющие свойства материала)
			trackBarRefractR.Value = Convert.ToInt32(material.RefractCoeff.X * trackBarRefractR.Maximum);
			trackBarRefractG.Value = Convert.ToInt32(material.RefractCoeff.Y * trackBarRefractG.Maximum);
			trackBarRefractB.Value = Convert.ToInt32(material.RefractCoeff.Z * trackBarRefractB.Maximum);						
			
			// Выводим коэффициент преломления материала
			trackBarRefrIndex.Value = Convert.ToInt32(material.RefractIndex * trackBarRefrIndex.Maximum / 10f);
			
			// Выводим собственный цвет материала
			panelColor.BackColor = Color.FromArgb(Convert.ToInt32(255f * material.Color.X),
			                                       Convert.ToInt32(255f * material.Color.Y),
			                                       Convert.ToInt32(255f * material.Color.Z));
			
			// Выводим параметры и образец текстуры
			OutputTexture();

		}
		
		/// <summary> Отображает настройки текстуры. </summary>
		private void OutputTexture()
		{
			if (material.Texture != null)
			{
				// Выводим режим наложения текстуры
				if (MapMode.Clamp == material.Texture.MapMode)
				{
					comboBoxMappingMode.SelectedIndex = 0;
				}
				else
				{
					comboBoxMappingMode.SelectedIndex = 1;
				}
					
				// Выводим коэффициенты масштабирования текстуры
				numericUpDownScaleS.Value = Convert.ToDecimal(material.Texture.Scale.X);			
				numericUpDownScaleT.Value = Convert.ToDecimal(material.Texture.Scale.Y);
				
				// Разрешаем управление режимом наложения текстуры
				comboBoxMappingMode.Enabled = true;
				
				// Разрешаем управление коэффициентами масштабирования текстуры
				numericUpDownScaleS.Enabled = true;
				numericUpDownScaleT.Enabled = true;	

				// Выводим образец текстуры
				OutputSample();
			}
			else
			{
				// Запрещаем управление режимом наложения текстуры
				comboBoxMappingMode.Enabled = false;
				
				// Запрещаем управление коэффициентами масштабирования текстуры
				numericUpDownScaleS.Enabled = false;
				numericUpDownScaleT.Enabled = false;
				
				// Убираем образец предыдущей текстуры
				panelTexture.BackgroundImage = null;	
			}
		}		
		
		/// <summary> Отображает образец текстуры. </summary>
		private void OutputSample()
		{
			if (material.Texture != null)
			{
				// Создаем точечный рисунок для отрисовки текстуры
				Raster raster = new Raster(panelTexture.Width, panelTexture.Height);
						
				for (int x = 0; x < raster.Width; x++)
				{
					for (int y = 0; y < raster.Height; y++)
					{
						// Вычисляем текстурные координаты
						Vector2D texcoord = new Vector2D(x / (float) raster.Height,
						                                 y / (float) raster.Height);
						
						// Получаем соответствующее значение цвета
						raster[x, y] = material.Texture.CalcColor(texcoord);
					}
				}
				
				// Выводим образец на экран
				panelTexture.BackgroundImage = raster.ToBitmap();
			}
		}
				
		/// <summary> Сохраняет настройки материала из элементов управления. </summary>
		private void InputOptions()
		{
			// Сохраняем коэффициент отражения фонового света
			material.Ambiant.X = trackBarAmbiantR.Value / (float)trackBarAmbiantR.Maximum;
			material.Ambiant.Y = trackBarAmbiantG.Value / (float)trackBarAmbiantG.Maximum;
			material.Ambiant.Z = trackBarAmbiantB.Value / (float)trackBarAmbiantB.Maximum;			
			
			// Сохраняем коэффициент отражения диффузного света
			material.Diffuse.X = trackBarDiffuseR.Value / (float)trackBarDiffuseR.Maximum;
			material.Diffuse.Y = trackBarDiffuseG.Value / (float)trackBarDiffuseG.Maximum;
			material.Diffuse.Z = trackBarDiffuseB.Value / (float)trackBarDiffuseB.Maximum;
			
			// Сохраняем коэффициент отражения зеркального блика
			material.Specular.X = trackBarSpecularR.Value / (float)trackBarSpecularR.Maximum;
			material.Specular.Y = trackBarSpecularG.Value / (float)trackBarSpecularG.Maximum;
			material.Specular.Z = trackBarSpecularB.Value / (float)trackBarSpecularB.Maximum;

			// Сохраняем коэффициент резкости бликов
			material.Shininess = trackBarShininess.Value;			
			
			// Сохраняем вклад отраженного света (описывает отражающие свойства материала)
			material.ReflectCoeff.X = trackBarReflectR.Value / (float)trackBarReflectR.Maximum;
			material.ReflectCoeff.Y = trackBarReflectG.Value / (float)trackBarReflectG.Maximum;
			material.ReflectCoeff.Z = trackBarReflectB.Value / (float)trackBarReflectB.Maximum;
			
			// Сохраняем вклад преломленного света (описывает преломляющие свойства материала)
			material.RefractCoeff.X = trackBarRefractR.Value / (float)trackBarRefractR.Maximum;
			material.RefractCoeff.Y = trackBarRefractG.Value / (float)trackBarRefractG.Maximum;
			material.RefractCoeff.Z = trackBarRefractB.Value / (float)trackBarRefractB.Maximum;
			
			// Сохраняем коэффициент преломления материала
			material.RefractIndex = 10f * trackBarRefrIndex.Value / (float)trackBarRefrIndex.Maximum;
			
			// Сохраняем собственный цвет материала
			material.Color.X = panelColor.BackColor.R / 255f;
			material.Color.Y = panelColor.BackColor.G / 255f;
			material.Color.Z = panelColor.BackColor.B / 255f;
		}		
		
		#endregion
		
		#region Event Handlers
		
		private void PanelColorClick(object sender, EventArgs e)
		{
			ColorDialog dialog = new ColorDialog();
			
			dialog.Color = panelColor.BackColor;
			
			if (dialog.ShowDialog() == DialogResult.OK) panelColor.BackColor = dialog.Color;
		}
		
		private void PanelTextureClick(object sender, EventArgs e)
		{
			OpenFileDialog dialog = new OpenFileDialog();
			
			dialog.Filter = "Файлы изображений (*.BMP, *.GIF, *.PNG, *.JPG, *.JPEG) |" +
				"*.BMP; *.GIF; *.PNG; *.JPG; *.JPEG | Файлы процедурных текстур (*.PRT) | *.PRT";
			
			if (dialog.ShowDialog() == DialogResult.OK)
			{
				if (1 == dialog.FilterIndex)
				{
					material.Texture = new ImageTexture(dialog.FileName);
				}
				else
				{
	        		using (FileStream fileStream = new FileStream(dialog.FileName, FileMode.Open))
					{
						IFormatter formatter = new BinaryFormatter();
						
						try
						{					
							material.Texture = (AbstractTexture) formatter.Deserialize(fileStream);
						}
						catch
						{
							MessageBox.Show("Ошибка! Не удается загрузить текстуру из файла.");
						}
						
						fileStream.Close();
					}
				}
				
				OutputTexture();
			}
		}

		private void ButtonRemoveTextureClick(object sender, EventArgs e)
		{
			material.Texture = null;
			
			OutputTexture();
		}		
		
		private void ComboBoxMappingModeSelectedIndexChanged(object sender, EventArgs e)
		{
			if (0 == comboBoxMappingMode.SelectedIndex)
			{
				material.Texture.MapMode = MapMode.Clamp;
			}
			else
			{
				material.Texture.MapMode = MapMode.Repeat;
			}
			
			OutputSample();
		}		
		
		private void NumericUpDownScaleSValueChanged(object sender, EventArgs e)
		{
			material.Texture.Scale.X = Convert.ToSingle(numericUpDownScaleS.Value);
			
			OutputSample();
		}
		
		private void NumericUpDownScaleTValueChanged(object sender, EventArgs e)
		{
			material.Texture.Scale.Y = Convert.ToSingle(numericUpDownScaleT.Value);
			
			OutputSample();			
		}		
		
		private void MaterialDialogLoad(object sender, EventArgs e)
		{
			OutputOptions();
		}
		
		private void MaterialDialogFormClosed(object sender, FormClosedEventArgs e)
		{
			if (DialogResult == DialogResult.OK) InputOptions();
		}
			
		#endregion
	
		#region Properties
		
		/// <summary> Материал объекта (описывает свойства поверхности). </summary>
		public Material Material
		{
			get
			{
				return material;
			}
			
			set
			{
				material = (Material) Replicator.Copy(value);
			}
		}
		
		#endregion
	}
}
