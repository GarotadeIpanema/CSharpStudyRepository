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
    public partial class ChildToParentPassedData : Form
    {
        // 대리자 선언
        public delegate void ChildFormSendDataHandler(string message);

        // 이벤트 선언
        public event ChildFormSendDataHandler ChildFormEvent;

        public ChildToParentPassedData()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = textBox1.Text;

            // 델리게이트 이벤트를통해 부모폼으로 데이터 전송
            this.ChildFormEvent(str);

            this.Close();
        }
    }
}
