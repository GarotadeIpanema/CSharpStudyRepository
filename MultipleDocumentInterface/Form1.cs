using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultipleDocumentInterface
{
    public partial class Form1 : Form
    {
        // 자식 폼 객체
        private ChildForm1 _childForm1 = null;
        private ChildForm2 _childForm2 = null;

        public Form1()
        {
            InitializeComponent();

            // MenuStrip Click Event 선언
            this.폼1ToolStripMenuItem.Click += Form1ToolStripMenuClick;
            this.폼2ToolStripMenuItem.Click += Form2ToolStripMenuClick;
            this.창닫기ToolStripMenuItem.Click += ExitToolStripMenuClick;
        }

        private Form ShowActivateForm(Form form, Type t)
        {
            if(form == null)
            {
                form = (Form)Activator.CreateInstance(t);
                form.MdiParent = this;
                form.WindowState = FormWindowState.Maximized;
                form.Show();
            }
            else
            {
                if (form.IsDisposed)
                {
                    form = (Form)Activator.CreateInstance(t);
                    form.MdiParent = this;
                    form.WindowState = FormWindowState.Maximized;
                    form.Show();
                }
                else
                {
                    form.Activate();
                }
            }
            return form;
        }

        public void Form1ToolStripMenuClick(object sender, EventArgs e)
        {
            if(ActiveMdiChild != null)  // 자식폼이 열려 있으면
            {
                if(this.ActiveMdiChild != _childForm1) // 열려 있는 form이 form1이 아니면
                {
                    ActiveMdiChild.Close(); // 현재 활성화된 창을 닫아라
                }
                _childForm1 = ShowActivateForm(_childForm1, typeof(ChildForm1)) as ChildForm1;
            }
            else
            {
                _childForm1 = ShowActivateForm(_childForm1, typeof(ChildForm1)) as ChildForm1;
            }
        }

        public void Form2ToolStripMenuClick(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)  // 자식폼이 열려 있으면
            {
                if (this.ActiveMdiChild != _childForm2) // 열려 있는 form이 form1이 아니면
                {
                    ActiveMdiChild.Close(); // 현재 활성화된 창을 닫아라
                }
                _childForm2 = ShowActivateForm(_childForm2, typeof(ChildForm2)) as ChildForm2;
            }
            else
            {
                _childForm2 = ShowActivateForm(_childForm2, typeof(ChildForm2)) as ChildForm2;
            }
        }

        public void ExitToolStripMenuClick(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
