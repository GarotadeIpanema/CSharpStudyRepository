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

namespace CSharpBasic
{
    public partial class ThreadWithParameter : Form
    {
        public ThreadWithParameter()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string number = textBox1.Text;

            // ParameterizedThreadStart에 파라미터 전달
            // _thread.Start()의 파라미터로 number 변수 값 전달
            Thread _thread = new Thread(new ParameterizedThreadStart(Sum));
            _thread.Start(number);
        }

        public void Sum(object num)
        {
            int number = Convert.ToInt32(num);
            // cross Thread Error 발생대비
            // 사용할려는 콘트롤러의 주권이 없는 쓰레드에서 콘트롤러를 제어할려고 할 때 발생
            // 먼저 현재 쓰레드가 권한이 있는지 확인
            if(textBox2.InvokeRequired)
            {
                // 권한이 없으면 대리자인 delegate를 사용한다
                // BeginInvoke는 컨트롤러의 내부 핸들이 작성된 스레드에서 대리자를 비동기식으로 실행한다
                // MethodInvoker는 관리 코드에서 void로 선언되고 매개 변수를 사용하지 않는 모든 메서드를 실행할 수 있는 대리자를 나타냅니다.
                textBox2.BeginInvoke(new MethodInvoker(delegate ()
                {
                    textBox2.Text = (number + number).ToString();
                }));
            }
            else
            {
                textBox2.Text = (number + number).ToString();
            }
        }
    }
}
