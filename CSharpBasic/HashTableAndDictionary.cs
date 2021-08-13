using System;
using System.Collections;
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
    public partial class HashTableAndDictionary : Form
    // HashTable는 특정 자료형 뿐만 아니라 여러 자료형을 담을 수 있다.
    // 하지만 Dictionary는 선언한 자료형에 맞춰서 데이타를 삽입해야 한다. 
    // ArrayList가 쓰기 편할만큼 데이타를 가져오거나 넣을때 그만큼 느리다. 
    {
        Hashtable hashtable;
        Dictionary<object, object> dictionary;
        public HashTableAndDictionary()
        {
            InitializeComponent();

            hashtable = new Hashtable();
            dictionary = new Dictionary<object, object>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string key = textBox1.Text;
            string value = textBox2.Text;

            if(hashtable.ContainsKey(key))
            {
                MessageBox.Show("이미 존재하는 키 입니다");
                textBox1.Focus();
                return;
            }
            if (String.IsNullOrEmpty(value))
            {
                MessageBox.Show("데이터를 입력해주세요.");
                textBox2.Focus();
                return;
            }
            hashtable.Add(key, value);

            string str = "";
            foreach(var item in hashtable.Keys)
            {
                str += $"{item} : {hashtable[item]} \r\n";
            }
            textBox3.Text = str;

            textBox1.Text = "";
            textBox1.Focus();
            textBox2.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string key = textBox4.Text;
            string value = textBox5.Text;

            if(dictionary.ContainsKey(key))
            {
                MessageBox.Show("이미 존재하는 키 입니다");
                textBox4.Focus();
                return;
            }
            if(String.IsNullOrEmpty(value))
            {
                MessageBox.Show("데이터를 입력해주세요.");
                textBox5.Focus();
                return;
            }
            dictionary.Add(key, value);

            string str = "";
            foreach(var item in dictionary.Keys)
            {
                str += $"{item} : {dictionary[item]} \r\n";
            }
            textBox6.Text = str;

            textBox4.Text = "";
            textBox4.Focus();
            textBox5.Text = "";
        }
    }
}
