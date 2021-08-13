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
    public partial class ParentToChildPassedData : Form
    {
        public ParentToChildPassedData()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChildToParentPassedData form = new ChildToParentPassedData();
            form.ChildFormEvent += EventMethod;
            form.ShowDialog();
        }

        public void EventMethod(string str)
        {
            // 자식폼에서 델리게이트로 이벤트 발생 시키면 현재 함수 EventMethod 호출
            textBox1.Text = str;
        }
    }
}
