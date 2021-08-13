using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpBasic
{
    public partial class BackWorker : Form
    {
        // BackgroundWorker클래스는 별도의 쓰레드에게 어떤 일을 시키기 위해 사용하는 클래스
        // 흔히 백그라운 쓰레드 혹은 워커 쓰레스라 불리우는 별도의 쓰레드에서는 UI Thread와 별도로 어떤 작업을 수행하는데 사용
        // BackgroundWorker로부터 생성된 객체는 DoWork이벤트 핸들러를 통해 실제 작업할 내용을 지정하고,
        // ProgressChanged이벤트를 통해 진척 사항을 전달하며, RunWorkerCompleted 이벤트를 통해 완료 후 실행될 작업을 지정
        // DoWork 이벤트 핸들러는 Worker Thread에서 돌고, ProgressChanged와 RunWorkerCompleted 이벤트 핸들러는 UI Thread에서 돈다
        // BackgroundWorker클래스 객체는 Thread클래스와 같이 쓰레드를 직접 생성하는 것이 아니라, Thread Pool로부터 가져온 쓰레드를 사용

        private BackgroundWorker worker;
        public BackWorker()
        {
            InitializeComponent();

            /*
            //Thread객체 생성
            BackgroundWorker worker = new BackgroundWorker();

            // 이벤트 핸들러 지정
            worker.DoWork += new DoWorkEventHandler(worker_DoWork);
            worker.ProgressChanged += new ProgressChangedEventHandler(worker_ProgressChanged);
            worker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(worker_RunWorkerCompleted);

            // 실행
            worker.RunWorkerAsync();
            */

            // Woker Intance 생성 및 초기화
            worker = new BackgroundWorker();
            worker.WorkerReportsProgress = true;
            worker.WorkerSupportsCancellation = true;
            worker.DoWork += new DoWorkEventHandler(worker_DoWork);
            worker.ProgressChanged += new ProgressChangedEventHandler(worker_ProgressChanged);
            worker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(worker_RunWorkerCompleted);
        }

        // Worker Thread가 실제 하는일
        private void worker_DoWork(object sender, DoWorkEventArgs e)
        {
            string srcDir = @"C:\Users\jjh\Desktop\img\_Src";
            string destDir = @"C:\Users\jjh\Desktop\img\_Dest";

            DirectoryInfo di = new DirectoryInfo(srcDir);
            FileInfo[] fileInfos = di.GetFiles();
            int totalFIles = fileInfos.Length;
            int counter = 0;
            int pct = 0;
            foreach(var fi in fileInfos)
            {
                string destFile = Path.Combine(destDir, fi.Name);
                File.Copy(fi.FullName, destFile);

                pct = ((++counter * 100) / totalFIles);
                worker.ReportProgress(pct);
            }
        }

        // Progress 리포트 - UI Thread
        private void worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        // 작업 완료 - UI Thread
        private void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if(e.Error != null)
            {
                label1.Text = e.Error.Message;
                MessageBox.Show(e.Error.Message, "Error");
                return;
            }
            label1.Text = "성공적으로 완료되었습니다.";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 비동기로 실행
            worker.RunWorkerAsync();
        }
    }
}
