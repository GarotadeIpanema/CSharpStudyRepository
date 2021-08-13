using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Excel
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            (new CreateExcelFile()).ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            (new ReadExcelFile()).ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            (new AutomationExcelFile()).ShowDialog();
        }

    }
}
