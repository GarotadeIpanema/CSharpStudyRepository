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
    public partial class Lock_BlockControll : Form
    {
        public Lock_BlockControll()
        {
            InitializeComponent();

            dataGridView1.ColumnCount = 1;
            dataGridView1.Columns[0].HeaderText = "count";
        }

        // Thread-Unsafe
        // 멀티쓰레드는 필드의 내용을 동시에 엑세스하여 잘못된 결과를 만들거나 출력할 수 있는데,이를 Thread Unsafe 하다고 한다.
        // 아래 예제는 여러 개의 쓰레드가 Thread-Safe하지 않은 메서드를 호출하는 예를 보여주고 있다.
        // 10개의 쓰레드가 counter라는 필드를 동시에 쓰거나 읽는 샘플로서 
        // 한 쓰레드가 counter변수를 변경하고 읽기 전에 다른 쓰레드가 다시 counter변수를 변경할 수 있기 때문에 불확실한 결과를 출력하게 된다
        int counter = 1000;

        private void button1_Click(object sender, EventArgs e)
        {
            // 10개의 쓰레드가 동일 메서드 실행
            for(int i = 0; i < 10; i++)
            {
                new Thread(UnsafeCalc).Start();
            }
        }
        // Tread-Safe 하지 않은 메서드
        private void UnsafeCalc()
        {
            // 객체 필드를 모든 쓰레드가 자유롭게 변경
            counter++;

            // 가정 : 다른 복잡한 일을 한다
            for (int i = 0; i < counter; i++)
                for (int j = 0; j < counter; j++) ;

            // 필드 값 읽기
            // dataGridView1.Rows.Add(counter);
            Console.WriteLine(counter);
        }

        // lock 키워드
        // C#의 lock 키워드는 특정 블럭의 코드(Critical Section이라 부른다)를 한번에 하나의 쓰레드만 실행할 수 있도록 해준다
        // lock()의 파라미터에는 임의의 객체를 사용할 수 있는데, 주로 object 타입의 private 필드를 지정한다.
        // 즉, private object obj = new object() 와 같이 private 필드를 생성한 후, lock(obj)와 같이 지정
        // 특히, 클래스 객체를 의미하는 this를 사용하여 lock(this)와 같이 잘못 사용할 수 있는데,
        // 이는 의도치 않게 데드락을 발생시키거나 Lock Granularity를 떨어뜨리는 부작용을 야기할 수 있다.
        // 
    }
}
