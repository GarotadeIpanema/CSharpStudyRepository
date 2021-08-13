using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpBasic
{
    public partial class GenericMethod : Form
    {
        public GenericMethod()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            object txt1 = textBox1.Text;
            object txt2 = textBox2.Text;

            Swap<object>(ref txt1, ref txt2);
            textBox3.Text = txt1.ToString();
            textBox4.Text = txt2.ToString();
        }

        // ref 키워드는 값이 참조로 전달됨을 나타냅니다. 다음 네 가지 컨텍스트에서 사용됩니다.
        // 메서드 시그니처 및 메서드 호출에서 인수를 메서드에 참조로 전달합니다.
        // 메서드 시그니처에서 값을 호출자에게 참조로 반환합니다. 
        // 멤버 본문에서 참조 반환 값이 호출자가 수정하려는 참조로 로컬에 저장됨을 나타냅니다. 또는 지역 변수가 참조로 다른 값에 액세스함을 나타냅니다. 
        // struct 선언에서 ref struct 또는 readonly ref struct를 선언합니다. 

        // IntegerType Swap Method
        public void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        // StringType Swap Method
        public void Swap(ref string a, ref string b)
        {
            string temp = a;
            a = b;
            b = temp;
        }

        // GenericType T Swap Method
        public void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
    }
}
