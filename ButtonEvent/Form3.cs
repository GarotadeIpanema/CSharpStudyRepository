using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ButtonEvent
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            openFileDialog1.InitialDirectory = "C:\\";
            openFileDialog1.Filter = "텍스트 파일(*.*)|*.*";
            openFileDialog1.Multiselect = true;
            openFileDialog1.ShowDialog();

            foreach(var item in openFileDialog1.FileNames)
            {
                textBox1.Text = textBox1.Text + item;
                textBox1.Text = textBox1.Text +  Environment.NewLine;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog() == DialogResult.OK)
            {
                BackColor = colorDialog1.Color;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                button3.BackColor = colorDialog1.Color;
            }
        }
    }
}
