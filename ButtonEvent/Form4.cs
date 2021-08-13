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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void MenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            textBox1.Text += item.Text + Environment.NewLine;
        }

        private void 종료XToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 프로그램정보AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBOx aboutBOx = new AboutBOx();
            aboutBOx.ShowDialog();
        }

        private void textBox_Click(object sender, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;
            if (me.Button == MouseButtons.Right )
            {
                MessageBox.Show("1");
                contextMenuStrip1.Show(me.Location);
            }
        }
    }
}
