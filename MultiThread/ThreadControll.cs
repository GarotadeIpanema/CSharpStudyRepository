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

namespace MultiThread
{
    public partial class ThreadControll : Form
    {
        public ThreadControll()
        {
            InitializeComponent();
        }

        // 1. C# 쓰레드의 생성 (Thread 클래스)
        private void button1_Click(object sender, EventArgs e)
        {
            // 새로운 쓰레드에서 Run() 실행
            Thread t1 = new Thread(new ThreadStart(Run));
            t1.Start();

            // 메인 쓰레드에서 Run() 실행
            Run();
        }
        delegate void ShowDelegate(); // 대리자

        private void Run()
        {
            Console.WriteLine($"Thread#{Thread.CurrentThread.ManagedThreadId} : Begin");
            Thread.Sleep(3000);

            Console.WriteLine($"Thread#{Thread.CurrentThread.ManagedThreadId} : End");

            // label은 쓰레드가 생성된 곳과 다르기에 접근하기 위해서 대리자를 사용
            if (InvokeRequired)
            {
                ShowDelegate del = new ShowDelegate(Run);
                // 또는 ShowDelegate del = p => ShowDelegate(p);
                Invoke(del);
            }
            else
            {
                label1.Text = $"Thread#{Thread.CurrentThread.ManagedThreadId} : Begin";

                // Do Simething
                Thread.Sleep(3000);

                label2.Text = $"Thread#{Thread.CurrentThread.ManagedThreadId} : End";
            }
        }

        // C# 쓰레스 생성의 다양한 예제
        // Thread클래스의 생성자가 받아들이는 파라미터는 ThreadStart 델리게이트와 ParameterizedThreadStart 델리게이트가 있는데,
        // 이 섹션은 파라미터를 직접 전달하지 않는 메서드들에 사용하는 ThreadStart 델리게이트 사용 예제를 보여준다
        // ThreadStart 델리게이트는 public delegate void ThreadStart();와 같이 정의되어 있는데, 리턴값과 파라미터 모두 void임을 알 수 있다
        // 따라서 파라미터와 리턴값이 없는 메서드는 델리게이트 객체로 생성될 수 있다.
        private void button2_Click(object sender, EventArgs e)
        {
            // Run 메서드를 입력받아
            // ThreadStart 델리게이트 타입 객체를 생성한 후
            // Thread 클래스 생성자에 전달
            Thread t1 = new Thread(new ThreadStart(Run2));
            t1.Start();

            // 컴파일러가 Run() 메서드의 함수 프로토 타입으로 부터
            // ThreadStart Delegate객체를 추론하여 생성
            Thread t2 = new Thread(Run2);
            t2.Start();

            // 익명메서드(Anonymous Method)를 사용하여 쓰레드 생성
            Thread t3 = new Thread(delegate ()
            {
                Run2();
            });
            t3.Start();

            // 람다식(Landa Expression)을 사용하여 쓰레드 생성
            Thread t4 = new Thread(() => Run2());
            t4.Start();

            // 간단한 표현
            new Thread(() => Run2()).Start();
        }

        private void Run2()
        {
            Console.WriteLine("Run");
            //label3.Text = "Run";
        }


        // C# Thread 클래스 파라미터 전달
        // Thread 클래스는 파라미터를 전달하지 않는 ThreadStart 델리게이트와
        // 파라미터를 직접 전달하는 ParameterizedThreadStart 델리게이트를 사용할 수 있다
        // ThreadStart 델리게이트는 public delegate void ThreadStart(); 프로토타입에서 알 수 있듯이, 파라미터를 직접 전달 받지 않는다
        // ParameterizedThreadStart 델리게이트는 public delegate void ParameterizedThreadStart(object obj);로 정의되어 있는데,
        // 하나의 object 파라미터를 전달하고 리턴 값이 없는 형식이다
        // 하나의 파라미터를 object 형식으로 전달하기 때문에, 여러 개의 파라미터를 전달하기 위해서는 클래스나 구조체를 만들어 객체를 생성해서 전달할 수 있다
        // 파라미터의 전달은 Thread.Start() 메서드를 호출할 때 파라미터를 전달
        private void button3_Click(object sender, EventArgs e)
        {
            // 파라미터 없는 ThreadStart 사용
            Thread t1 = new Thread(new ThreadStart(Run3));
            t1.Start();

            // ParameterizedThreadStart 파라미터 전달
            Thread t2 = new Thread(new ParameterizedThreadStart(Calc));
            t2.Start(10.00);

            // ThreadStart에서 파라미터 전달
            Thread t3 = new Thread(() => Sum(10, 20, 30));
            t3.Start();
        }
        private void Run3()
        {
            Console.WriteLine("Run");
        }

        // radius라는 파라미터를 object 타입으로 받아들임
        private void Calc(object radius)
        {
            double r = (double)radius;
            double area = r * r * 3.14;
            Console.WriteLine($"r = {r}, area = {area}");
        }

        private void Sum(int d1, int d2, int d3)
        {
            int sum = d1 + d2 + d3;
            Console.WriteLine(sum);
        }

        // Background 쓰레드 vs Foreground 쓰레드
        // Thread 클래스 객체를 생성한 후 Start()를 실행하기 전에 IsBackground 속성을 true/false로 지정할 수 있는데,
        // 만약 true로 지정하면 이 쓰레드는 백그라운드 쓰레드가 된다
        // 디폴트 값은 false 즉 Foreground 쓰레드이다.
        // 백그라운드와 Foreground 쓰레드의 기본적인 차이점은 Foreground 쓰레드는 메인 쓰레드가 종료되더라도 Foreground 쓰레드가 살아 있는 한,
        // 프로세스가 종료되지 않고 계속 실행되고,
        // 백그라운드 쓰레드는 메인 쓰레드가 종료되면 바로 프로세스를 종료한다는 점
        private void button4_Click(object sender, EventArgs e)
        {
            // Foreground Thread
            Thread t1 = new Thread(new ThreadStart(Run3));
            t1.Start();

            // Background Thread
            Thread t2 = new Thread(new ThreadStart(Run3));
            t2.IsBackground = true;
            t2.Start();
        }
    }
}
