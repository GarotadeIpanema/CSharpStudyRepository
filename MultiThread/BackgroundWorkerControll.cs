using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiThread
{
    public partial class BackgroundWorkerControll : Form
    {
        public BackgroundWorkerControll()
        {
            InitializeComponent();
        }

        // C# BackgroundWorker 클래스
        // BackgroundWorker 클래스는 쓰레드풀에서 작업 쓰레드(Worker Thread)를 할당 받아 작업을 실행하는 Wrapper 클래스이다
        //  BackgroundWorker는 이벤트를 기반으로 비동기 처리를 진행하는 패턴 (Event-based Asynchronous Pattern)을 구현한 클래스
        // BackgroundWorker로부터 생성된 객체는 DoWork 이벤트 핸들러를 통해 실제 작업할 내용을 지정
        // RunWorkerAsync() 메서드를 호출하여 작업을 시작
        private BackgroundWorker worker;
        private void button1_Click(object sender, EventArgs e)
        {
            Execute();
        }
        private void Execute()
        {
            // 쓰레드풀에서 작업쓰레드 시작
            worker = new BackgroundWorker();
            worker.DoWork += new DoWorkEventHandler(worker_DoWork);
            worker.RunWorkerAsync();
        }

        // 작업쓰레드가 실행할 Task 메서드
        void worker_DoWork(object sender, DoWorkEventArgs e)
        {
            // 긴 처리 가정
            Console.WriteLine("Long running task"); 
        }

        // C# BackgroundWorker 이벤트들
        // BackgroundWorker 클래스는 이벤트를 기반으로 하는 비동기 처리를 진행하는데,
        // 기본적으로 실제 작업을 진행하는 DoWork 이벤트 이외에 진척 사항을 전달 처리하는 ProgressChanged 이벤트,
        // 작업 완료후 UI 컨트롤 갱신 및 에러 처리에 사용되는 RunWorkerCompleted 이벤트가 있다
        // DoWork 이벤트 핸들러는 작업 쓰레드에서 돌고 (따라서 UI 컨트롤을 직접 엑세스할 수 없다),
        // ProgressChanged와 RunWorkerCompleted 이벤트 핸들러는 UI Thread에서 돈다.
        // (따라서 이 이벤트 핸들러에서는 UI 컨트롤을 직접 엑세스한다) 또한,
        // 작업쓰레드는 작업쓰레드 실행 코드인 DoWork() 밖에서 CancelAsync()를 호출하여 취소를 명령하게 되며,
        // DoWork() 안에서 CancellationPending 속성을 체크하여 점검하게 된다. DoWork() 안에서 실제 취소는 e.Cancel을 true 셋팅하고 return하여 작업 진행을 중지하면 된다.

        private BackgroundWorker worker2;
        private void button2_Click(object sender, EventArgs e)
        {
            // 진척보고와 취소 속성을 true
            worker2 = new BackgroundWorker();
            worker2.WorkerReportsProgress = true; // 진척 보고?
            worker2.WorkerSupportsCancellation = true; // 취소 가능?

            // 이벤트 핸들러를 지정
            worker2.DoWork += new DoWorkEventHandler(worker_DoWork2);
            worker2.ProgressChanged += new ProgressChangedEventHandler(worker_ProgressChanged);
            worker2.RunWorkerCompleted += new RunWorkerCompletedEventHandler(worker_RunWorkerCompleted);

            // 작업 쓰레드 시작
            worker2.RunWorkerAsync();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            worker2.CancelAsync(); // 취소
        }

        private void worker_DoWork2(object sender, DoWorkEventArgs e)
        {
            // 100개 업로드
            int N = 100;
            for (int i = 1; i <= N; i++)
            {
                // 외부에서 작업을 취소하였는가?
                if (worker2.CancellationPending)
                {
                    e.Cancel = true; // 작업 취소
                    return;
                }

                // 업로드 작업 진행
                string filename = $"Data_{i}.txt";
                Upload(filename);

                // 진척 사항 : i%
                worker2.ReportProgress(i, filename);
            }
            e.Result = N;
        }

        void Upload(string filename)
        {
            Debug.WriteLine($"Uploading {filename}");
            // 가정 : 업로드 1초간 처리
            Thread.Sleep(1000);
        }

        void worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            // UI 컨트롤에 직접 수정
            // Control.Invoke() 필요 없음
            textBox1.Text = $"Progress : {e.ProgressPercentage}%";
        }

        void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            // UI 컨트롤에 직접 수정
            // Control.Invoke() 필요 없음
            if (e.Cancelled)
            {
                textBox1.Text = "작업 취소됨";
            }
            else if(e.Error != null)
            {
                // 에러 발생 메시지 표시
                throw e.Error;
            }
            else
            {
                textBox1.Text = $"{e.Result} files updated";
            }
        }


    }
}
