using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpBasic
{
    // https://www.csharpstudy.com/WinForms/WinForms-thread.aspx
    public partial class WindowMultiThreading : Form
    {
        // 윈도우 프로그래밍에서 멀티쓰레드를 사용하기 위해서는 흔히 Thread 클래스를 이용해 새로운 쓰레드를 만들거나,
        // 쓰레드풀/Task 등을 이용하거나, 혹은 이전에 설명한 BackgroundWorker Wrapper 클래스를 사용
        // 윈도우 멀티쓰레딩에서 중요한 사항은 UI 컨트롤들을 갱신하기 위해서는 항상 해당 UI 컨트롤을 생성한 UI Thread에서 갱신하여야 한다는 것
        // 이를 어기고 다른 Worker Thread가 UI 컨트롤을 엑세스하면 다음과 에러가 발생("Cross-thread operation not valid: Control [progressBar1] accessed from a thread other than the thread it was created on.")
        public WindowMultiThreading()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread worker = new Thread(new ThreadStart(MyThreadRun));
            worker.Start();
        }

        private void MyThreadRun()
        {
            string srcDir = @"C:\Users\jjh\Desktop\img\_Src";
            string destDir = @"C:\Users\jjh\Desktop\img\_Dest";

            DirectoryInfo di = new DirectoryInfo(srcDir);
            FileInfo[] fileInfos = di.GetFiles();
            int totalFiles = fileInfos.Length;
            int counter = 0;
            int pct = 0;
            foreach(var fi in fileInfos)
            {
                string destFile = Path.Combine(destDir, fi.Name);
                File.Copy(fi.FullName, destFile);
                Thread.Sleep(1000);
                pct = ((++counter * 100) / totalFiles);
                ShowProgress(pct);
            }
        }

        delegate void ShowDelegate(int percent); // 대리자
        private void ShowProgress(int pct)
        {
            // Worker 쓰레드가 직접 progressBar1 객체를 갱신하려 했기 때문에 에러가 발생
            // progressBar1.Value = pct; //<== 에러발생!

            // 위와 같은 문제점을 해결하기 위해 쓰레드 함수에서 UI 컨트롤을 엑세스할 때,
            // 항상 Control클래스의 InvokeRequired 속성을 체크하여 현재 쓰레드로 컨트롤을 엑세스할 수 있는지를 검사해야 한다
            // InvokeRequired값이 true이면, 현재 쓰레드는 Worker Thread라는 뜻이므로, Invoke(동기 호출)나 
            // BeginInvoke(비동기 호출)를 사용하여 UI Thread로 메서드 호출을 보내야 한다
            if (InvokeRequired)
            {
                ShowDelegate del = new ShowDelegate(ShowProgress);
                // 또는 ShowDelegate del = p => ShowDelegate(p);
                Invoke(del, pct);
            }
            else
            {
                progressBar1.Value = pct;
            }
        }
    }
}
