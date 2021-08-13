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
    public partial class MaskedTextBoxControll : Form
    {
        public MaskedTextBoxControll()
        {
            InitializeComponent();

            // 0, 반드시 숫자 입력
            // 9, 숫자나 공란, 선택
            // #, 숫자 나 공백 그리고 +, -, 선택, 위치가 비어있으면 속성에 공백으로 렌더링 된다
            // L, 문자, 필수. ASCII 문자 a-z 및 a-z로 입력을 제한, [a-zA-Z]와 동일
            // https://docs.microsoft.com/ko-kr/dotnet/api/system.windows.forms.maskedtextbox.mask?view=net-5.0
            maskedTextBox1.Mask = "0000.00.00";
            maskedTextBox2.Mask = "(999)000-0000";
            maskedTextBox3.Mask = "(000)0000-0000";
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            toolTip1.Show("숫자만 입력 가능", this);
        }
        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (e.Position < 5) /// (999)인 경우
            {
                toolTip1.Show("숫자나 공란만 입력 가능", this);
            }
            else // 000 - 0000
            {
                toolTip1.Show("숫자만 입력 가능", this);
            }
        }

        private void maskedTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            toolTip1.Show("숫자만 입력 가능", this);
        }
    }
}
