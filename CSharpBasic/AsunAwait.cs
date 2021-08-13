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

namespace CSharpBasic
{
    // https://www.csharpstudy.com/CSharp/CSharp-async-await.aspx
    // async는 컴파일러에게 해당 메서드가 await를 가지고 있음을 알려주는 역할을 한다
    // async라고 표기된 메서드는 await를 1개 이상 가질수 있는데, 하나도 없는 경우라도 컴파일은 가능하지만 Waring 메시지가 표기
    // aync를 표기한다고 하여 자동으로 비동기 방식으로 프로그램을 수행하는것이 아닌 await를 보조하는 컴파일러 지시어라고 볼 수 있다
    // async 메서드의 리턴 타입은 대부분의 경우 Task<TResult>(리턴값이 있는 경우) 혹은 Task(리턴값이 없는 경우) 인데,
    // 예로 리턴 값이 string일 경우 async Task<string> methid()와 같이 정의하고 return "문자열"과 같이 문자열만 리턴
    // C# 컴파일러는 return문을 자동으로 Task<string>로 변환해 준다
    // 또 다른 aync 메서드의 리턴 타입으로 void 타입이 있는데, 특히 이벤트 핸들러를 위해 void리턴을 허용하고 있다

    // 실제 핵심키워드는 await인데, 이 await는 일반적으로 Task 혹은 Task<T> 객체와 함께 사용 된다
    // Task 이외의 클래스도 사용가능한데, awaitable 클래스, 즉 GetAwaiter()라는 메서드를 갖는 클래스이면 함께 사용 가능
    // UI프로그램에서 await는 Task와 같은 awaitable 클래스의 객체가 완료되기를 기다리는데, 
    // 여기서 중요한 점은 'UI 쓰레드가 정지되지 않고 메시지 루프를 계속 돌 수 있도록' 필요한 코드 컴파일러가 await 키워드를 만나면 자동으로 추가한다는 점
    // 메시지 루프가 계속 돌게 만든다는 것은 마우스 클릭이나 키보드 입력 등과 같은 윈도우 메시지들을 계속 처리할 수 있다는 것을 의미
    // await는 해당 Task가 끝날 때까지 기다렸다가 완료 후, await 바로 다음 실행문부터 실행을 계속한다
    // await가 기다리는 Task 혹은 실행 메서드는 별도의 Worker Thread에서 돌 수도 있고, 또는 UI Thread에서 돌 수도 있다.
    public partial class AsunAwait : Form
    {
        public AsunAwait()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Run();
        }

        private async void Run()
        {
            // 비동기로 Worker Thread에서 도는 task1
            // Task.Run() : .NET Framework 4.5+
            var task1 = Task.Run(() => LongCalcAsync(10));

            // task1이 끝나길 기다렸다가 끝나면 결과치를 sum에 할당
            int sum = await task1;

            // 위의 문장을 합친 문장
            //int sum = await Task.Run(() => LongCalcAsync(10));

            // UI Thread에서 실행
            // Control.Invok 혹은 Control.BeginInvok 필요 없음
            label1.Text = $"Sum = {sum}";
            button1.Enabled = true;
        }

        private int LongCalcAsync(int times)
        {
            int result = 0;
            for(int i = 0; i < times; i++)
            {
                result += i;
                Thread.Sleep(1000);
            }
            return result;
        }


        // await : UI 쓰레드에서 도는 Task
        // await가 기다리는 Task는 대부분의 경우 Background Worker Thread에서 실행된다. 
        // 하지만 await를 썼다고 해서 자동으로 그 Task(혹은 메서드)가 Worker Thread에서 도는 것은 아니다
       // 아래 코드는 await를 사용했지만, 해당 Task(LongCalc2)는 (별도로 Worker Thread를 생성하지 않고) UI쓰레드에서 실행된다
       // 만약 Worker Thread를 생성하려면, Task.Rum() 등과 메서드를 사용하여 비동기 작업을 지정

        private void button2_Click(object sender, EventArgs e)
        {
            Rum2();
        }

        private async void Rum2()
        {
            int sum = await LongCalc2(10);
            label2.Text = $"Sum : {sum}";
            button2.Enabled = true;
        }

        private async Task<int> LongCalc2(int times)
        {
            // UI Thread에서 실행
            Debug.WriteLine(Thread.CurrentThread.ManagedThreadId);
            int result = 0;
            for(int i = 0; i < times; i++)
            {
                result += i;
                await Task.Delay(1000);
            }
            return result;
        }

        // await : Task.ContinueWith()
        // await는 해당 Task가 끝난 후 await 문장이 있었던 곳으로부터 계속 다음 문장들을 실행하도록 되어있다
        // 이러한 기능은 .NET 4.0에서 소개 되었던 Task클래스의 ContinueWith()를 써서 아래와 같이 구현될 수 있다
        // await가 ContinueWith() 방식을 사용하는것은 아니지만, 개념적으로 동일한 방식이라 볼 수 잇다
        private void button3_Click(object sender, EventArgs e)
        {
            Run3();    
        }
        private void Run3()
        {
            var task1 = Task<int>.Run(() => LongCalc2(10));

            // await task1과 동일한 효과
            task1.ContinueWith(x =>
            {
                label3.Text = $"Sum = {task1.Result}";
                button3.Enabled = true;
            }, TaskScheduler.FromCurrentSynchronizationContext());
        }

        // 콘솔프로그램에서의 await
        // 윈폼이나 WPF 같은 UI 프로그램은 await가 실행되기 전에 당시 실행되고 있는 쓰레드를 캡쳐해서 SynchronizationContext 에 가지고 있으며,
        // await가 끝난 후에 이 컨텍스트로부터 원래 쓰레드 맥락에서 다음 문장들을 실행하게 한다
        // 하지만, 콘솔 프로그램이나 윈도우즈 서비스 프로그램의 경우에는 SynchronizationContext가 디폴트로 null 이 되어,
        // await 이후의 문장들을 실행할 때 Thread Pool에서 작업 쓰레드를 가져와 실행하게 된다.
        /*
        static void Main(string[] args)
        {
            Console.WriteLine($"Main : {Thread.CurrentThread.ManagedThreadId}");
            Run4();
            Console.ReadLine();
        }

        private static  async void Run4()
        {
            // 비동기로 Worker Thread에서 도는 task1
            var task = Task.Run(() => LongCalcAsync2(10));

            // 콘솔 프로그램인 경우 SynchronizationContext가 null
            Console.WriteLine(SynchronizationContext.Current);

            // task1이 끝나길 기다렸다가 끝나면 결과치를 sum에 할당
            int sum = await task;

            // Worker Thread에서 실행
            Console.WriteLine(sum);
            Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
        }

        private static int LongCalcAsync2(int times)
        {
            int result = 0;
            for(int i = 0; i < times; i ++)
            {
                result += 0;
                Thread.Sleep(1000);
            }

            return result;
        }
        */
    }
}
