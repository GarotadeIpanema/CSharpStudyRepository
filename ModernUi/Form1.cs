using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModernUi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.gradient_pnl.Paint += Panel_Gradient;
        }

        // Panel
        private void Panel_Gradient(object sender, PaintEventArgs e)
        {
            Color startColor = System.Drawing.ColorTranslator.FromHtml("#FFB75E");
            Color middleColor = System.Drawing.ColorTranslator.FromHtml("#ED8F03");
            Color endColor = Color.FromArgb(0, 0, 0);

            LinearGradientBrush linearGradientBrush
                = new LinearGradientBrush(this.ClientRectangle, System.Drawing.Color.Black, System.Drawing.Color.Black, 0, false);

            ColorBlend colorBlend = new ColorBlend();
            colorBlend.Positions = new[] { 0, 1 / 2f, 1 };
            colorBlend.Colors = new[] { startColor, middleColor, endColor };

            linearGradientBrush.InterpolationColors = colorBlend;
            linearGradientBrush.RotateTransform(45);
            e.Graphics.FillRectangle(linearGradientBrush, this.ClientRectangle);

        }

        // button
        private void Buttonl_Gradient(object sender, PaintEventArgs e)
        {
            Color startColor = System.Drawing.ColorTranslator.FromHtml("#FFB75E");
            Color middleColor = System.Drawing.ColorTranslator.FromHtml("#ED8F03");
            Color endColor = Color.FromArgb(0, 0, 0);

            LinearGradientBrush linearGradientBrush
                = new LinearGradientBrush(this.ClientRectangle, System.Drawing.Color.Black, System.Drawing.Color.Black, 0, false);

            ColorBlend colorBlend = new ColorBlend();
            colorBlend.Positions = new[] { 0, 1 / 2f, 1 };
            colorBlend.Colors = new[] { startColor, middleColor, endColor };

            linearGradientBrush.InterpolationColors = colorBlend;
            linearGradientBrush.RotateTransform(45);
            e.Graphics.FillRectangle(linearGradientBrush, this.ClientRectangle);
        }

        private void gradient_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("hi");
        }
    }
}
