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
    public partial class SlideFormControl : Form
    {
        public SlideFormControl()
        {
            InitializeComponent();
        }

        private void gradientButton1_Click(object sender, EventArgs e)
        {
            SlideForm frm = new SlideForm();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog();
        }
    }
}
