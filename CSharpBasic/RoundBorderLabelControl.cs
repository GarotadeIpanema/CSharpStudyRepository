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
    public partial class RoundBorderLabelControl : Form
    {
        public RoundBorderLabelControl()
        {
            InitializeComponent();

            roundBorderLabel1.borderWidth = 2;
            roundBorderLabel1.borderColor = Color.Red;
            roundBorderLabel1.backColor = Color.LightYellow;

            roundBorderLabel2.borderColor = Color.LightGreen;
            roundBorderLabel2.backColor = Color.LightGreen;

            roundBorderLabel3.isFillLeftTop = true;
            roundBorderLabel3.isFillRightTop = true;
            roundBorderLabel3.isFillLeftBtm = true;
            roundBorderLabel3.isFillRightBtm = true;
            roundBorderLabel3.borderColor = Color.DarkBlue;
            roundBorderLabel3.backColor = Color.LightBlue;

            roundBorderLabel4.cornerRadius = 30;
            roundBorderLabel4.isFillLeftBtm = true;
            roundBorderLabel4.isFillRightBtm = true;
            roundBorderLabel4.borderWidth = 2;
            roundBorderLabel4.borderColor = Color.DarkCyan;
            roundBorderLabel4.backColor = Color.AntiqueWhite;

            roundBorderLabel5.cornerRadius = 30;
            roundBorderLabel5.isFillRightTop = true;
            roundBorderLabel5.isFillRightBtm = true;
            roundBorderLabel5.borderColor = Color.DarkKhaki;
            roundBorderLabel5.backColor = Color.LightCoral;

            roundBorderLabel6.cornerRadius = 50;

            roundBorderLabel7.cornerRadius = 30;
            roundBorderLabel7.borderColor = Color.Black;
            roundBorderLabel1.backColor = Color.Transparent;

            roundBorderLabel8.cornerRadius = 30;
            roundBorderLabel8.borderColor = Color.Transparent;
            roundBorderLabel8.backColor = Color.Transparent;
        }
    }
}
