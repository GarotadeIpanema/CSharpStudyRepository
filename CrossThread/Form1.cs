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

namespace CrossThread
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Thread thread_A = new Thread(new ThreadStart(A));
            Thread thread_B = new Thread(new ThreadStart(B));
            Thread thread_C = new Thread(new ThreadStart(C));

            thread_A.Start();
            thread_B.Start();
            thread_C.Start();
        }

        public void A()
        {
            for(int i = 0; i < 100; i++)
            {
                CrossThread(textBox1, "A");
            }
        }

        public void B()
        {
            for (int i = 0; i < 100; i++)
            {
                CrossThread(textBox1, "B");
            }
        }

        public void C()
        {
            for (int i = 0; i < 100; i++)
            {
                CrossThread(textBox1, "C");
            }
        }

        public static void CrossThread(Control item, string text)
        {
            // InvokeRequired, 호출자가 컨트롤이 만들어진 스레드와 다른 스레드에 있기 때문에 메서드를 통해 컨트롤을 호출하는 경우 해당 호출자가 호출 메서드를 호출해야 하는지를 나타내는 값을 가져옵니다.
            // InvokeRequired, 컨트롤의Handle이 호출 스레드와 다른 스레드에서 만들어져 호출 메서드를 통해 해당 컨트롤을 호출해야 하는 경우  true이고, 그렇지 않으면 false입니다.
            if (item.InvokeRequired)
            {
                // BeginInvoke, 컨트롤의 내부 핸들이 작성된 스레드에서 대리자를 비동기식으로 실행합니다
                // MethodInvoker, 관리 코드에서 void로 선언되고 매개 변수를 사용하지 않는 모든 메서드를 실행할 수 있는 대리자를 나타냅니다.
                item.BeginInvoke(new MethodInvoker(delegate ()
                {
                    item.Text += text;
                })); 
            }
        }
    }
}
