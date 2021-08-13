using System;
using System.Timers;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Timers.Timer;
using FTimer = System.Windows.Forms.Timer;
using System.Net;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace MultiThread
{
    // 멀티쓰레딩 Timer 클래스
    // .NET의 타이머는 크게 멀티쓰레딩을 지원하는 System.Threading.Timer클래스,
    // System.Timers.Timer 클래스와 싱글쓰레드만을 지원하는 System.Windows.Forms.Timer클래스,
    // System.Windows.Threading.DispatcherTimer 클래스가 있다.
    // 멀티쓰레딩을 지원하는 Timer클래스들은 특정 간격으로 실행되는 이벤트 핸들러를 쓰레드풀에서 할당된 작업쓰레드를 이용하여 실행하게 되고,
    // 항상 같은 작업쓰레드가 이벤트 핸들러를 실행한다는 보장이 없다.
    // 또한 만약 이벤트 핸들러가 다음 Interval 보다 오래 실행된다면, 다른 작업쓰레드가 핸들러를 실행하게 되기 때문에,Thread Safe하게 작성해야 한다.
    public partial class TimerControll : Form
    {
        public TimerControll()
        {
            InitializeComponent();
        }

        // 1시간마다 특정 웹페이지를 읽어와서 파일로 저장하는 예
        private void button1_Click(object sender, EventArgs e)
        {
            // 타이머 생성 및 시작
            Timer timer = new System.Timers.Timer();
            // 밀리초
            timer.Interval = 60 * 1000; // 1분
            timer.Elapsed += new ElapsedEventHandler(timer_Elapsed);
            timer.Start();
        }

        // 쓰레드 풀의 작업 쓰레드가 지정된 시간 간격으로 아래 이벤트 핸들러 실행
        private void timer_Elapsed(object sender, ElapsedEventArgs ar)
        {
            // 웹페이지 html문을 다운로드
            WebClient web = new WebClient();
            string webpage = web.DownloadString("http://mssql.tools");

            // 다운로드 내용을 파일에 저장
            string time = DateTime.Now.ToString("yyyyMMdd_hhmmss");
            string outputFile = string.Format($"page_{time}.html");
            File.WriteAllText(outputFile, webpage);
        }

        // 싱글쓰레드 Timer 클래스
        // Timer를 UI 프로그램에서 보다 편리한 사용을 위해, 윈폼 (WinForms)에는 System.Windows.Forms.Timer라는 클래스가 있으며,
        // WPF (Windows Presentation Foundation)에는 System.Windows.Threading.DispatcherTimer 클래스가 있다.
        // 이들 타이머 클래스들은 Tick 이벤트 핸들러를 실행하기 위해 별도의 작업쓰레드를 생성하지 않고
        // UI 쓰레드에서 실행하기 때문에, UI 컨트롤이나 UI Element들을 직접 이벤트 핸들러 안에서 마샬링 없이 엑세스할 수 있다.
        // 타이머가 UI 쓰레드를 이용하기 때문에 만약 이벤트 핸들러가 긴 작업을 수행할 경우 UI Hang과 같은 현상이 있을 수 있다.
        private void button2_Click(object sender, EventArgs e)
        {
            FTimer timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000; // 1초
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            // UI 쓰레드에서 실행
            // UI 컨트롤 직접 엑세스 가능
            label1.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
