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
    public partial class TabConrolDynamicPage : Form
    {
        public TabConrolDynamicPage()
        {
            InitializeComponent();
        }

        private void TabConrolDynamicPage_Load(object sender, EventArgs e)
        {
            TabPage tp = null;
            for(int idx = 1; idx <= 10; idx++)
            {
                string pageName = $"page{idx}";
                tp = new TabPage(pageName);
                tabControl1.TabPages.Add(tp);
            }
        }
    }
}
