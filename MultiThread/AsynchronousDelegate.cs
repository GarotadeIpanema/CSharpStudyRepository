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
    public partial class AsynchronousDelegate : Form
    {
        public AsynchronousDelegate()
        {
            InitializeComponent();
        }

        // C# 비동기 델리게이트 (Asynchronous Delegate)
        // .NET의 비동기 델리게이트(Asynchronous delegate)는 쓰레드풀의 쓰레드를 사용하는 한 방식으로,
        // 메서드 델리게이트(Delegate, 대리자)의 BeginInvoke()를 사용하여 쓰레드에게 작업을 시작하게 하고,
        // EndInvoke()를 사용하여 해당 작업이 끝날 때까지 기다려서 리턴 값을 넘겨 받게 된다.
        // BeginInvoke()는 쓰레드를 구동시킨 후 IAsyncResult 객체를 리턴하고 즉시 메인쓰레드의 다음 문장을 실행하게 된다.
        // IAsyncResult 객체는 차후 EndInvoke() 등과 같은 메서드를 실행할 때 파라미터로 전달되는 것으로서 어떤 쓰레드를 가리키는 지를 알 수 있게 한다
        private void button1_Click(object sender, EventArgs e)
        {
            // GetArea() 메서드를 사용하여 .NET의 Func 델리게이트 인스턴스를 생성
            // Func의 처음 2개 int는 입력, 마지막 int는 출력타임
            Func<int, int, int> work = GetArea;

            // 델리게이트객체로부터 BeginInvoke() 실행
            // 두 개의 입력 파라미터 10, 20 지정
            IAsyncResult asyncResult = work.BeginInvoke(10, 20, null, null);

            Console.WriteLine("Do Something in Main Thead");

            // 델리게이트개체로부터 EndInvoke(IAsyncResult) 실행
            // EndInvoke는 쓰레드가 완료되길 기다린다
            // 완료 후 리턴 값을 돌려 받는다
            int result = work.EndInvoke(asyncResult);

            Console.WriteLine($"Result : {result}");
        }

        private int GetArea(int height, int width)
        {
            return height + width;
        }
    }
}
