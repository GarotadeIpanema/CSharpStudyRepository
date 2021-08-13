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
    // C# 5.0 await
    // C# 5.0부터 비동기 프로그래밍을 보다 손쉽게 지원하기 위하여 async와 await라는 C# 키워드가 추가
    // async는 컴파일러에게 해당 메서드가 await를 가지고 있음을 알려주는 역활을 하고,
    // await는 awaitable 클래스(즉 GetAwaiter() 라는 메서드를 갖는 클래스)이면 함께 사용되어awaitable 객체가 완료되기를 기다리는 역활을 한다.
    // 여기서 중요한 점은 await는 UI 쓰레드가 정지되지 않고 메시지 루프를 계속 돌 수 있도록 필요한 코드를 컴파일러가 자동으로 추가한다는 점
    // 메시지 루프가 계속 돌게 만든다는 것은 마우스 클릭이나 키보트 입력, 화면 페인팅 등을 계속 처리할 수 있다는 것을 의미
    // await는 해당 Task가 끝날 때까지 기다렸다가 완료 후, 바로 다음 실행문부터 실행을 계속하는데,
    // 이 때의 쓰레드는 디폴트로 await를 호출하기 이전의 실행 쓰레드가 된다.
    // 즉 UI Thread에서 await를 호출하였다면 await 다음 문장들은 UI 쓰레드에서 실행
    // 만약 task.ConfigureAwait(false)를 실행하면 쓰레드풀의 쓰레드로 실행
    public partial class AwaitControll : Form
    {
        public AwaitControll()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RunIt();
        }

        private async void RunIt()
        {
            // 긴 계산을 하는 메서드 비동기로 호출
            Task<double> task = Task<double>.Factory.StartNew(() => LongCalc(10));

            // Task가 끝나기를 기다림, 하지만 UI Thread는 Block되지 않는다
            await task;

            // Task가 끝난 다음 아래 UI 컨트롤의 값 갱신
            // 이 문장은 UI 쓰레드가 실행하므로 Invoke()가 필요 없다
            textBox1.Text = task.Result.ToString();
        }

        private double LongCalc(double r)
        {
            Thread.Sleep(1000);
            return 3.14 * r * r;
        }
    }
}
