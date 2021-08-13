using DevExpress.XtraSplashScreen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpBasic
{
    public partial class Loading_SpliashScreenManager_ : UserControl
    {
        public Loading_SpliashScreenManager_()
        {
            InitializeComponent();

            //if (!splashScreenManager1.IsSplashFormVisible) // Wait Form이 이미 실행중인지 확인
            //    splashScreenManager1.ShowWaitForm(); // Wait Form 열기
            //else if (splashScreenManager1.IsSplashFormVisible) // Wait Form이 이미 실행중인지 확인
            //    splashScreenManager1.CloseWaitForm();

            // SplashScreenManager.ShowForm(null, typeof(WaitForm1), true, true, true);
            splashScreenManager1.ShowWaitForm(); // Wait Form 열기
            Thread.Sleep(5000);
            //SplashScreenManager.CloseForm();
            splashScreenManager1.CloseWaitForm();
        }
    }
}
