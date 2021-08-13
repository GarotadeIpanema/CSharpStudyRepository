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
    public partial class DictionaryEqualKeyError : Form
    {
        private Dictionary<string, string> dic;
        public DictionaryEqualKeyError()
        {
            InitializeComponent();
            dic = new Dictionary<string, string>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string key = textBox1.Text;
            string value = textBox2.Text;
            if (dic.ContainsKey(key))
            {
                MessageBox.Show("이미 존재하는 키 입니다");
                textBox1.Focus();
                return;
            }
            MessageBox.Show("입력되었습니다!");
            textBox1.Text = "";
            textBox2.Text = "";
            textBox1.Focus();
            dic.Add(key, value);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string key = textBox3.Text;
            if(!dic.ContainsKey(key))
            {
                label1.Text = "없는 키 입니다";
                return;
            }
            label1.Text = dic[key];
        }
    }
}