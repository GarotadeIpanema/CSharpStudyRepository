using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ButtonEvent
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "결과 표시";
            label2.Text = "좋아하는 과일을 선택하세요";
            label3.Text = string.Empty;
        }

        // button
        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = FlatStyle.Flat.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = FlatStyle.Popup.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = FlatStyle.Standard.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = FlatStyle.System.ToString();
        }

        


        // checkbox
        private void UpdateLabel()
        {
            string strchk1 = "";
            string strchk2 = "";
            string strchk3 = "";
            string strchk4 = "";

            if(checkBox1.Checked) strchk1 = checkBox1.Text;
            if(checkBox2.Checked) strchk2 = checkBox2.Text;
            if(checkBox3.Checked) strchk3 = checkBox3.Text;
            if(checkBox4.Checked) strchk4 = checkBox4.Text;

            label2.Text = strchk1 + " " + strchk2 + " " + strchk3 + " " + strchk4;
        }
        private void CheckedChanged(object sender, EventArgs e)
        {
            UpdateLabel();
        }

        // radiobox
        private void CheckedRadio(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            label3.Text = rb.Text;
        }

        // rinklabel
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(linkLabel1.Text); // 링크를 클릭하면 링크 사이트로 이동
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox2.Text = $"some Text : ${textBox1.Text} \r\nclick the button";

            if (textBox1.Text.ToUpper() == "ADMIN") MessageBox.Show("관리자 로그인");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3();
            form.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form4 form = new Form4();
            form.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            (new Form5()).ShowDialog();
        }
    }
}
