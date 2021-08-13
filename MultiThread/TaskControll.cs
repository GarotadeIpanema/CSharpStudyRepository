using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiThread
{
    public partial class TaskControll : Form
    {
        public TaskControll()
        {
            InitializeComponent();
        }

        // C# Task 클래스
        // Task 클래스와 이의 Generic형태인 Task<T>클래스는 .NET 4.0에 도입된 새로운 클래스들로서 쓰레드풀로부터 쓰레드를 가져와 비동기 작업을 실행한다.
        // Task 관련 클래스들과 Parallel 클래스들을 합쳐 Task Parallel Library(TPL)이라 부르는데,
        // 이들은 기본적으로 다중 CPU 병렬 처리를 염두에 두고 만들었다.
        // Task 클래스는 .NET 4.0 이전 버전의 ThreadPool.QueueUserWorkItem()와 같은 기능을 제공하지만,보다 빠르고 유연한 기능을 갖추고 있다.
        // Task클래스 사용을 위해 흔히 사용되는 방법은 Task.Factory.StartNew()를 사용하여 실행하고자 하는 메서드에 대한 델리케이트를 지정하는 것이다.
        // 이 StartNew()는 쓰레드를 생성과 동시에 실행하는 방식이고, 만약 시작을 하지 않고 Task 객체를 만들기 위해서는 Task() 생성자를 사용하여 메서드 델리게이트를 지정한다.
        private void button1_Click(object sender, EventArgs e)
        {
            // Task.Factory를 이용하여 쓰레드 생성과 시작
            Task.Factory.StartNew(new Action<object>(Run), null);
            Task.Factory.StartNew(new Action<object>(Run), "1st");
            Task.Factory.StartNew(Run, "2nd");

            Console.Read();
        }

        private void Run(object data)
        {
            Console.WriteLine(data ?? "Null" );
        }

        // 위의 Task.Factory.StartNew()는 쓰레드를 생성과 동시에 시작하는 방식이고,
        // 만약 시작을 하지 않고 Task 객체만을 먼저 만들기 위해서는 Task 클래스 생성자를 사용하여 메서드 델리게이트를 지정, Task 객체만을 생성한다.
        // 생성된 Task 객체로부터 실제 쓰레드를 시작하기 위해서는 Start() 메서드를 호출하고,
        // 종료때까지 기다리기 위해선 Wait() 메서드를 호출
        private void button2_Click(object sender, EventArgs e)
        {
            // Task 생성자에 Rum2을 지정 Task 객체 생성
            Task t1 = new Task(new Action(Run2));

            // 람다식을 이용 Task 객체 생성
            Task t2 = new Task(() =>
            {
                Console.WriteLine("Long query");
            });

            // Task 쓰레드 시작
            t1.Start();
            t2.Start();

            // Task가 끝날때까지 대기
            t1.Wait();
            t2.Wait();

        }

        private void Run2()
        {
            Console.WriteLine("Long running method");
        }
    }
}
