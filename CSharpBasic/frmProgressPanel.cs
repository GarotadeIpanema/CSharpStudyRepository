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
    public partial class frmProgressPanel : Form
    {
        Timer timer = new Timer();
        int time = 5;
        public frmProgressPanel()
        {
            InitializeComponent();

            this.Shown += WaitFOrm_Shown;
            this.FormClosed += FormClosed_Event;
        }

        // 폼 Shown 이벤트 핸들러
        private void WaitFOrm_Shown(object sender, EventArgs e)
        {
            InitProgressPanel(time);
            timer.Tick += new EventHandler(Timer_Tick);
            timer.Start();
            timer.Interval = 1000;
        }

        private void InitProgressPanel(int time)
        {
            this.progressPanel1.AutoHeight = true;
            this.progressPanel1.Caption = "잠시 로딩중..";
            this.progressPanel1.ShowCaption = true;
            this.progressPanel1.Description = $"로딩 시간 : {time} 초";
            this.progressPanel1.ShowDescription = true;
            this.progressPanel1.ToolTip = "My tooltip";
            this.progressPanel1.ShowToolTips = true;
            this.progressPanel1.WaitAnimationType = DevExpress.Utils.Animation.WaitingAnimatorType.Ring;
            this.progressPanel1.CaptionToDescriptionDistance = 5;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if(this.progressPanel1 != null)
            {
                InitProgressPanel(time--);
            }
            if(time < 0)
            {
                this.Close();
                this.progressPanel1 = null;
            }
        }

        private void FormClosed_Event(object sender, FormClosedEventArgs e)
        {
            if (this.progressPanel1 != null)
                this.progressPanel1 = null;
        }
    }
}
