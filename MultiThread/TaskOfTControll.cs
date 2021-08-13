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
    public partial class TaskOfTControll : Form
    {
        public TaskOfTControll()
        {
            InitializeComponent();
        }

        // C# Task<T> 클래스
        // Non-Generic 타입인 Task 클래스는 ThreadPool.QueueUserWorkItem()과 같이 리턴값을 쉽게 돌려 받지 못한다.
        // 비동기 델리게이트(Asynchronous Delegate)와 같이 리턴값을 돌려 받기 위해서는 Task<T> 클래스를 사용한다.
        // Task<T> 클래스의 T는 리턴 타입을 가리키는 것으로 리턴값은 Task객체 생성 후 Result 속성을 참조해서 얻게 된다.
        // Result 속성을 참조할 때 만약 작업 쓰레드가 계속 실행 중이면, 결과가 나올 때까지 해당 쓰레드를 기다리게 된다.
        private void button1_Click(object sender, EventArgs e)
        {
            // Task<T>를 이용하여 쓰레드 생성과 시작
            Task<int> task = Task.Factory.StartNew<int>(() => CalcSize("Hello World"));

            // 메인쓰레드에서 다른 작업 실행
            Thread.Sleep(1000);

            // 쓰레드 결과 리턴, 쓰레드가 계속 실행중이면
            // 이곳에서 끝날 때까지 대기함
            int result = task.Result;

            Console.WriteLine($"Result = {result}");
        }
        private int CalcSize(string data)
        {
            string s = data ?? "";
            return s.Length;
        }

        // Task 작업 취소
        // 비동기 작업을 취소하기 위해서는 Cancellation Token을 사용하는데, 작업 취소와 관련된 타입은 CancellationTokenSource 클래스와 CancellationToken 구조체이다.
        // CancellationTokenSource 클래스는 Cancellation Token을 생성하고 Cancel 요청을 Cancellation Token들에게 보내는 일을 담당하고,
        // CancellationToken은 현재 Cancel 상태를 모니터링하는 여러 Listener들에 의해 사용되는 구조체이다.
        // 작업을 취소하는 일반적인 절차는
        // (1) 먼저 CancellationTokenSource 필드를 선언하고, (2) CancellationTokenSource 객체를 생성하며,
        // (3) 비동기 작업 메서드 안에서 작업이 취소되었는지를 체크하는 코드를 넣으며, (4) 취소 버튼이 눌러지면 CancellationTokenSource의 Cancel() 메서드를 호출해 작업 취소를 요청한다.
        // (1) CancellationTokenSource 필드
        private CancellationTokenSource cancellationTokenSource;

        private void button2_Click(object sender, EventArgs e)
        {
            Run();
        }
        private async void Run()
        {
            //  (2) CancellationTokenSource 객체 생성
            cancellationTokenSource = new CancellationTokenSource();
            CancellationToken token = cancellationTokenSource.Token;

            // (Optional)여기서의 StartNew 메서드는 StartNew(Func, CancellationToken)를 호출함.
            // 여기서 Token이 Cancel 상태(토큰이 false)이면
            // LongCalcAsync() 메서드 자체가 실행되지 않는다는 의미
            var task1 = Task.Factory.StartNew<object>(LongCalcAsync, token);

            dynamic res = await task1;
            if(res != null)
            {
                label1.Text = $"Sum : {res.Sum}";
            }
            else
            {
                label1.Text = "Cancelled ";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // (4) 작업 취소
            cancellationTokenSource.Cancel();
        }

        private object LongCalcAsync()
        {
            int sum = 0;
            for(int i = 0; i < 100; i++)
            {
                //(3) 작업 취소인지 체크
                if (cancellationTokenSource.Token.IsCancellationRequested)
                {
                    return null;
                }
                sum += i;
                Thread.Sleep(1000);
            }
            return new { Sum = sum };
        }


        // CancellationToken을 필드와 같이 Global Scope에 두지 않고, 직접 Task 메서드의 파라미터로 전달하는 방법도 있다.
        // 이는 Task.Factory.StartNew()의 오버로드들 중 상태 객체를 전달할 수 있는 메서드 오버로드를 사용하면 되는데,
        // 아래 예제는 StartNew()의 2번째 파라미터에 상태(state) 객체를 전달하고, 3번째 파라미터에 CancellationToken 을 전달하고 있다.
        // 여기서 2번째 파라미터는 람다식의 state 입력파라미터로 전달되어, 다시 람다 메서드 내에서 token = (CancellationToken)state 와 같이 CancellationToken으로 변환된어 사용된다.
        // 3번째 파라미터는 람다식이 호출되지 이전에 작업이 Cancel되었는지를 체크하여 Cancel 되었으면 아예 람다식을 실행하지 않는 역활을 한다.
        private void button4_Click(object sender, EventArgs e)
        {
            /*
            var task1 = Task.Factory.StartNew<object>((state) => LongCalcWithStateAsync(state) {

                CancellationToken token = (CancellationToken)state;
                // 생략

                /// 작업 취소인지 체크
                if (token.IsCancellationRequested)
                {
                    return null;
                }

                // 생략
            }
        , token,    // 상태 param. state 로 전달됨
        , token);   // CancellationToken param
            */
        }
    }
}
