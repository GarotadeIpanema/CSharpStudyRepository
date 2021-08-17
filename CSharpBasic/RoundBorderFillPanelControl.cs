using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpBasic
{
    public partial class RoundBorderFillPanelControl : Form
    {
        public RoundBorderFillPanelControl()
        {
            InitializeComponent();

            roundBorderFillPanel1.isBorder = true;
            roundBorderFillPanel1.isFill = true;
            roundBorderFillPanel1.radius = 5;
            roundBorderFillPanel1.borderWidth = 5;
            roundBorderFillPanel1.borderColor = Color.Red;
            roundBorderFillPanel1.fillColor = Color.Yellow;

            roundBorderFillPanel2.isBorder = true;
            roundBorderFillPanel2.isFill = false;
            roundBorderFillPanel2.radius = 10;
            roundBorderFillPanel2.borderWidth = 10;
            roundBorderFillPanel2.borderColor = Color.Green;

            roundBorderFillPanel3.isBorder = false;
            roundBorderFillPanel3.isFill = true;
            roundBorderFillPanel3.radius = 30;
            roundBorderFillPanel3.fillColor = Color.LightCoral;

            roundBorderFillPanel4.isBorder = true;
            roundBorderFillPanel4.isFill = true;
            roundBorderFillPanel4.radius = roundBorderFillPanel4.Width / 2;
            roundBorderFillPanel4.borderWidth = 5;
            roundBorderFillPanel4.borderColor = Color.DarkBlue;
            roundBorderFillPanel4.fillColor = Color.LightBlue;
        }
    }
}
