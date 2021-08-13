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
    public partial class DragAndDrop : Form
    {
        public DragAndDrop()
        {
            InitializeComponent();
        }

        // drop source에서 해야될 작업
        // 사용자가 마우스로 데이타를 끄는 행동
        // 원폼의 기본 Base 클래스인 COntrol 클래스는 DoDragDrop()이라는 메서드를 가지고 있따
        // Drop Source 컨트롤에서 이 DoDragDrop 메서드를 호출하면 드래그 앤 드롭을 시작하게 된다
        // 흔히 Drop Source 컨트롤의 MouseDown 이벤트 핸들러에서 실행하게 되지만,
        // ListView나  TreeView 등 일부 컨트롤에서는 특별한 ItemDrag라는 이벤트를 사용하기에 ItemDrag 이벤트 랜들러 안에서 실행 된다
        // 예시 텍스트박스
        private void textBox1_MouseDown(object sender, MouseEventArgs e)
        {
            // DoDragDrop() 첫번째 파라미터를 타겟에 전달할 데이타를 가리키고,
            // 두번째 파라미터는 타겟에 Drop하는 방식을 가리킨다, 즉 두번째 파라미터는 소스에서 전달하는 데이타를 타겟에 그대로 복사(Copy)할지
            // 타겟에 복사하지만 소스에서 지우는 이동(Move)을 할지, 혹은 타겟에 링크(Link)만 할 지 등을 정한다
            DoDragDrop(textBox1.Text, DragDropEffects.Copy);
            // textBox1.Text = ""; // 만약 Move이면 소스를 이렇게 지움
        }

        // Drop Target에서 해주어야될 작업
        // Drop Source에서는 한 가지 일만 해주면 되지만, Drop Target에서는 최소한 3가지 작업을 해줘야 한다
        // 1. Drop Target 컨트롤에서 AllowDrop 속성을 true로 설정한다, 이는 해당 컨트롤에 Drop 하는 것을 허용하는 일이다
        // 2.Drop Target 컨트롤에서 DragEnter 이벤트 핸들러를 구현하여, e.Effect 속성을 지정한다
        //    DragEnter 이벤트는 마우스가 타겟 컨트롤 내로 들어 올 때 발생하는 이벤트로 이 이벤트가 그래그앤드랍 데이타를 받을지 결정하게 된다
        //     DragEnter 대신 다음에 발생하는 DragOver 이벤트에서 Effect 속성을 지정할 수도 있다
        // 3. Drop Target 컨트롤에서 DragDrop 이벤트 핸들러 구현한다, DragDrop은 마우스를 Release하여
        //     실제 Drop이 이루어질 때 발생하는 이벤트로서 이 이벤트 핸들러에서는 Drop된 데이타를 타겟에 복사하거나 이동하는 등의 일을 한다
        private void textBox2_DragEnter(object sender, DragEventArgs e)
        {
            // 데이터가 문자열 타입이면 복사하고, 아니면 Drop을 무효처리
            if (e.Data.GetDataPresent(typeof(string)))
            {
                // Drop하여 복사함
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                // Drop 할 수 없음
                e.Effect = DragDropEffects.None;
            }
        }

        private void textBox2_DragDrop(object sender, DragEventArgs e)
        {
            // e.Data.GetData()메서드는 드래그앤드랍에서 전달된 데이타를 가져온다
            // 타겟 컨트롤(textBox2)에 드랍 데이타 지정
            textBox2.Text = (string)e.Data.GetData(DataFormats.StringFormat);
        }
    }
}
