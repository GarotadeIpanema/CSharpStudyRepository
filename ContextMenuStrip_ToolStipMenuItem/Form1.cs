using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContextMenuStrip_ToolStipMenuItem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.button1.Left = (this.ClientSize.Width - button1.Width) / 2;
            this.button1.Top = (this.ClientSize.Height - button1.Height) / 2;

            this.button1.Click += button_Menu_Click;
        }

        private void button_Menu_Click(object sender, EventArgs e)
        {
            ContextMenuStrip menu = new ContextMenuStrip();

            ToolStripMenuItem item01 = new ToolStripMenuItem("파일");
            item01.Click += item01_Click;
            ToolStripMenuItem item02 = new ToolStripMenuItem("이미지");
            item02.Click += item02_Click;

            menu.Items.Add(item01);
            menu.Items.Add(item02);

            menu.Show(MousePosition);
        }

        private void item01_Click(object sender, EventArgs e)
        {
            MessageBox.Show("파일 메뉴 클릭");
        }

        private void item02_Click(object sender, EventArgs e)
        {
            MessageBox.Show("이미지 메뉴 클릭");
        }
    }
}
