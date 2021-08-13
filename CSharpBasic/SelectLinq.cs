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
    public partial class SelectLinq : Form
    {
        public SelectLinq()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> words = new List<string>();

            words.Add(textBox1.Text);
            words.Add(textBox2.Text);
            words.Add(textBox3.Text);
            words.Add(textBox4.Text);

            int length = Convert.ToInt32(textBox5.Text);

            string str1 = "";

            for(int i = 0; i < words.Count; i++)
            {
                if (words[i].Length >= length)
                {
                    str1 += $"{words[i]} \r\n";
                }
            }

            textBox6.Text = str1;

            str1 = "";

            words = words.Where(data => data.Length >= length).ToList();
            /*
            var query = from word in words
                        where word.Length >= length
                        select word;
            */
            foreach(string str in words)
            {
                str1 += $"{str} \r\n";
            }

            textBox7.Text = str1;
        }
    }
}
