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
    public partial class ThreadPoolControll : Form
    {
        public ThreadPoolControll()
        {
            InitializeComponent();
        }

        // C# ThreadPool 사용 - https://www.csharpstudy.com/Threads/threadpool.aspx
        // .NET의 Thread 클래스를 이용하여 쓰레드를 하나씩 만들어 사용하는 것이 아니라,
        // 이미 존재하는 쓰레드풀에서 사용가능한 작업 쓰레드를 할당 받아 사용하는 방식이 있는데,
        // 이는 다수의 쓰레드를 계속 만들어 사용하는 것보다 효율적이다
        // 이렇게 시스템에 존재하는 쓰레드풀에 있는 쓰레드를 사용하기 위해서는 
        // (1) ThreadPool 클래스, (2) 비동기 델리게이트(Asynchronous delegate), (3) .NET 4 Task 클래스, (4) .NET 4 Task<T> 클래스, (5) BackgroundWorker 클래스
        // 등을 사용할 수 있다
        // 이 중 ThreadPool 클래스의 경우, ThreadPool.QueueUserWorkItem() 를 사용하여 실행하고자 하는 메서드 델리게이트를 지정하면 시스템풀에서 쓰레드를 할당하여 실행하게 된다
        // 이 방식은 실행되는 메서드로부터 리턴 값을 돌려받을 필요가 없는 곳에 주로 사용
        // 리턴값이 필요한 경우는 비동기 델리게이트(Asynchronous delegate)를 사용

        // ThreadPool에서의 쓰레드 생성 과정
        // .NET의 쓰레드풀은 기본적으로(by default) CPU 코어당 최소 1개의 쓰레드에서 최대 N 개의 작업쓰레드를 생성하여 운영하게 된다
        // 여기서 최대 N 개는 .NET의 버전에 따라 다른데,
        // NET 2.0 까지는 CPU 코어 당 25개, .NET 3.5(CLR 2.0 SP1+)에서는 CPU 코어 당 250개, .NET 4.0의 32bit에서 1023개, .NET 4.0의 64bit 환경에서는 32768개 등
        // 다양한 값을 가질 수 있
        // 예를 들어, 만약 해당 컴퓨터가 4개의 CPU 코어를 가지고 있고 .NET 3.5를 사용하고 있다면, ThreadPool은 최소 4개의 쓰레드와 최대 1000개의 작업 쓰레드를 가질 수 있게된다.
        // 쓰레드 생성시 요청되는 쓰레드수가 해당 컴퓨터의 CPU수보다 많아지면, CLR 시스템은 쓰레드를 즉시 생성하지 않고 초당 2개의 쓰레드를 새로 생성되도록 지연하게 된다 (Thread Throttling).
        private void button1_Click(object sender, EventArgs e)
        {
            // ThreadPool에 있는 쓰레드를 이용하여 Calc() 메서드 실행
            // 리턴값이 없을 경우 사용
            ThreadPool.QueueUserWorkItem(Calc); // radius = null
            ThreadPool.QueueUserWorkItem(Calc, 10.0); // radius = 10.0
            ThreadPool.QueueUserWorkItem(Calc, 20.0); // radius = 20.0

            Console.WriteLine();
        }

        private void Calc(object radius)
        {
            if (radius == null) return;

            double r = (double)radius;
            double area = r * r * 3.14;
            Console.WriteLine($"r = {r}, area = {area}");
        }
    }
}
