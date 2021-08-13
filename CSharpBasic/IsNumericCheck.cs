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
    public partial class IsNumericCheck : Form
    {
        public IsNumericCheck()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var text1 = textBox1.Text;
            var text2 = textBox2.Text;
            if(!IsNumeric(text1) || !IsNumeric(text2))
            {
                MessageBox.Show("숫자를 입력해주세요!");
                textBox1.Focus();
                return;
            }
            label1.Text = $"{text1} + {text2} = {Convert.ToInt32(text1) + Convert.ToInt32(text2)}";
        }

        private bool IsNumeric(string input)
        {
            int number = 0;

            // 숫자의 문자열 표현을 해당하는 32비트 부호 있는 정수로 변환합니다. 반환 값은 작업의 성공 여부를 나타냅니다.
            return int.TryParse(input, out number);
        }
    }
}
