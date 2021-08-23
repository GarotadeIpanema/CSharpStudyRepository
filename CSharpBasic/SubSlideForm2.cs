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
    public partial class SubSlideForm2 : UserControl
    {
        public SubSlideForm2()
        {
            InitializeComponent();

            this.Load += Load_Evnet;
        }

        private void Load_Evnet(object sender, EventArgs e)
        {
            GetCharData();
        }

        private void GetCharData()
        {
            chart1.Series["Series1"].Points.Clear();
            chart1.Series["Series1"].Points.Add(100);
            chart1.Series["Series1"].Points.Add(200);
            chart1.Series["Series1"].Points.Add(300);
            chart1.Series["Series1"].Points.Add(400);
        }
    }
}
