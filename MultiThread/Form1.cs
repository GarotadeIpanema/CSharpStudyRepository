using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiThread
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            (new ThreadControll()).ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            (new ThreadPoolControll()).ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            (new AsynchronousDelegate()).ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            (new BackgroundWorkerControll()).ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            (new TaskControll()).ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            (new TaskOfTControll()).ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            (new ParallelProgramming()).ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            (new AwaitControll()).ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            (new TimerControll()).ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            (new Lock_BlockControll()).ShowDialog();
        }
    }
}
