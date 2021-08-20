using DevExpress.XtraEditors;
using DevExpress.XtraTabbedMdi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpBasic
{
    public partial class Xtra : XtraForm
    {
        XtraTabbedMdiManager mdiManager;

        public Xtra()
        {
            InitializeComponent();
        }

        private void ChildFormAdd()
        {
            mdiManager = new XtraTabbedMdiManager();
            mdiManager.MdiParent = this;
            mdiManager.HeaderButtons = DevExpress.XtraTab.TabButtons.Close;
            mdiManager.HeaderLocation = DevExpress.XtraTab.TabHeaderLocation.Top;
            mdiManager.PageAdded += MdiManager_ChildFormAdd;
            //mdiManager.SelectedPageChanged += MdiManager_SelectedPageChanged;
            mdiManager.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InActiveTabPageAndTabControlHeader;
        }
        private void Main_Load(object sender, EventArgs e)
        {
            ChildFormAdd();

            //SplashScreenManager.ShowForm(null, typeof(COMMON.WaitForm1), true, true, true);

            //Thread.Sleep(500);

            Home();
            //SplashScreenManager.CloseForm();
        }

        private void MdiManager_ChildFormAdd(object sender, MdiTabPageEventArgs e)
        {
            XtraMdiTabPage page = e.Page;
        }

        //private void MdiManager_SelectedPageChanged(object sender, EventArgs e)
        //{
        //    if (mdiManager.SelectedPage != null)
        //        ButtonAuthority(mdiManager.SelectedPage.Text);
        //    else
        //    {
        //        ButtonAuthority("null");
        //    }
        //}

        private void Home()
        {
            //ButtonAuthority("null");

            foreach (Form item in this.MdiChildren)
            {
                if (item.Name == "HOME")  //Notice
                {
                    item.Focus();
                    return;
                }
            }

            Assembly asm = Assembly.GetExecutingAssembly();

            Form frm = (Form)asm.CreateInstance(string.Format("{0}.{1}", "CSharpBasic", "GradientButtonCOntrol"));

            if (frm != null)
            {
                frm.Text = "메인화면";
                frm.MdiParent = this;
                frm.Dock = DockStyle.Fill;
                frm.Show();

            }
        }
    }
}
