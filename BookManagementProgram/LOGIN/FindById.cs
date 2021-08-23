using BookManagementProgram.Repository;
using System;
using System.Windows.Forms;

namespace BookManagementProgram.XtraForm
{
    public partial class FindById : Form
    {
        BookUserRepository userRepository = new BookUserRepository();
        public FindById()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;
        }
        // 취소 버튼
        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // 아이디 찾기 버튼
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

            MessageBox.Show(userRepository.FindById(memberNo, memberName));
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
