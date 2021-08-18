using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookManagementProgram.LOGIN
{
    public partial class FindById : Form
    {
        public FindById()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void find_btn_Click(object sender, EventArgs e)
        {
            string memberNo = memberNumber_txt.Text;
            string memberName = memberName_txt.Text;

            if(string.IsNullOrEmpty(memberNo))
            {
                MessageBox.Show("회원 번호를 입력해주세요.");
                memberNumber_txt.Focus();
                return;
            }
            if(string.IsNullOrEmpty(memberName))
            {
                MessageBox.Show("회원 성명를 입력해주세요.");
                memberName_txt.Focus();
                return;
            }


        }

        private void label1_Click(object sender, EventArgs e)
        {
            memberNumber_txt.Focus();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            memberName_txt.Focus();
        }
    }
}
