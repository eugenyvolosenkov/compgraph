using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LightTracing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            trackBar1.Value = 10;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            progressBar1.Maximum = 100;
            
            var step = (float)Convert.ToDouble(textBox1.Text);
            var lightCoeff = 0.1f * Convert.ToInt32(trackBar1.Value);

            var renderer = new Renderer();
            renderer.OnPercentChange += RendererOnOnPercentChange;
            renderer.Render(step, lightCoeff, ref pictureBox1);
        }

        private void RendererOnOnPercentChange(object sender, EventArgs eventArgs)
        {
            var renderer = sender as Renderer;
            progressBar1.Value = Convert.ToInt32(renderer.Percent);
        }
    }
}
