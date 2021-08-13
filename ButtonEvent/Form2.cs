using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ButtonEvent
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if( textBox1.Text.Trim() != "")
            {
                listBox1.Items.Add(textBox1.Text);
                comboBox1.Items.Add(textBox1.Text);
            }
            textBox1.Text = "";
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex > -1)
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string strTemp = "";
            foreach(var item in checkedListBox1.CheckedItems)
            {
                strTemp += item.ToString() + " ";
            }
            MessageBox.Show($"당신의 취미는 {strTemp}입니다.", "확인", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if(e.NewValue == CheckState.Checked && checkedListBox1.CheckedItems.Count >= 3)
            {
                e.NewValue = CheckState.Unchecked;
                MessageBox.Show("최대 선택 개수는 3개 입니다");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
