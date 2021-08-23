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
    public partial class SlideForm : Form
    {
        List<Control> ctlList = null;

        Timer slideTimer = new Timer();
        int idx = 0;
        public SlideForm()
        {
            InitializeComponent();

            this.Shown += SlideForm_Shown;
        }

        private void SlideForm_Shown(object sender, EventArgs e)
        {
            AddControl();

            SlideTimer_Start();
        }

        private void SlideTimer_Start()
        {
            slideTimer.Interval = 3 * 1000;
            slideTimer.Tick += SlideTimer_Tick;

            this.Controls.Clear();
            ctlList[idx].Dock = DockStyle.Fill;
            this.Controls.Add(ctlList[idx++]);

            slideTimer.Start();
        }

        private void SlideTimer_Tick(object sender, EventArgs e)
        {
            this.Controls.Clear();
            ctlList[idx].Dock = DockStyle.Fill;
            this.Controls.Add(ctlList[idx]);
            SetTitle(ctlList[idx++]);

            if (idx >= ctlList.Count) idx = 0;
        }

        private void SetTitle(Control control)
        {
            if (control is SubSlideForm1)
                this.Text = "SlideForm - [Data Sheet]";
            else if (control is SubSlideForm2)
                this.Text = "SlideFOrm - [Chart]";
        }

        private void AddControl()
        {
            SubSlideForm1 sub1 = new SubSlideForm1();
            SubSlideForm2 sub2 = new SubSlideForm2();

            ctlList = new List<Control>();

            ctlList.Add(sub1);
            ctlList.Add(sub2);
        }
    }
}
