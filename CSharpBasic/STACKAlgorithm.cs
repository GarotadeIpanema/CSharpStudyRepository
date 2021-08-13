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
    public partial class STACKAlgorithm : Form
    {
        public STACKAlgorithm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StackAlgorithm stack = new StackAlgorithm(5);

            stack.PushValue(textBox1.Text);
            stack.PushValue(TextBox2.Text);
            stack.PushValue(TextBox3.Text);
            stack.PushValue(TextBox4.Text);
            stack.PushValue(TextBox5.Text);

            string str = "";

            for(int i = 0; i < 10; i++)
            {
                str += $"{stack.POPValue()} \r\n";
            }
            textBox6.Text = str;
        }

        class StackAlgorithm
        {
            private object[] list = null;
            private int length;
            private int maxLeingth;
            
            public StackAlgorithm(int max)
            {
                list = new object[max];
                length = 0;
                maxLeingth = max;
            }

            public void PushValue(object obj)
            {
                if(length >= maxLeingth)
                {
                    MessageBox.Show("이 이상 값을 추가할 수 없습니다.");
                    return;
                }
                list[length++] = obj;
            }

            public object POPValue()
            {
                return (length <= 0) ? "더 이상 값이 없습니다" : list[--length];
            }

            /*
            private List<object> list = new List<object>();

            public void PushValue(object obj)
            {
                list.Add(obj);
            }

            public object POPValue()
            {
                object obj = null;
                if (list.Count > 0) {
                    obj = list[list.Count - 1];
                    list.RemoveAt(list.Count - 1);
                }else
                {
                    obj = "더이상 값이 없습니다"; 
                }
                
                return obj ;
            }
            */
        }

    }
}

