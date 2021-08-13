using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ChartControll
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            (new BasicChart()).ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            (new ChartArea()).ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            (new ChartEssential()).ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            (new ChartDateBinding()).ShowDialog();
        }
    }
}
