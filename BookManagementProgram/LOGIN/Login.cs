using BookManagementProgram.Repository;
using System;
using System.Linq;
using System.Windows.Forms;

namespace BookManagementProgram.LOGIN
{
    public partial class Login : Form
    {
        BookUserRepository userRepository = new BookUserRepository();
        public Login()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            if(Properties.Settings.Default.isLoginIdSave)
            {
                id_txt.Text = Properties.Settings.Default.LoginId;
                idSaveCheck_chk.Checked = Properties.Settings.Default.isLoginIdSave;
            }
        }

        // TextBox Focussing
        private void label1_Click(object sender, EventArgs e)
        {
            id_txt.Focus();
        }
        private void label2_Click(object sender, EventArgs e)
        {
            pw_txt.Focus();
        }

        // 비밀번호 보이기 체크박스
        private void showPassword_chk_CheckedChanged(object sender, EventArgs e)
        {
            if (showPassword_chk.Checked)
                pw_txt.PasswordChar = default(char);
            else
                pw_txt.PasswordChar = '*';
        }

        // 아이디 저장 체크박스
        private static void NotSaveID()
        {
            Properties.Settings.Default.isLoginIdSave = false;
            Properties.Settings.Default.Save();
        }
        private void SaveID()
        {
            Properties.Settings.Default.LoginId = id_txt.Text;
            Properties.Settings.Default.isLoginIdSave = true;
            Properties.Settings.Default.Save();
        }

        // 아이디 찾기 라벨
        private void findId_lbl_Click(object sender, EventArgs e)
        {
            (new FindById()).ShowDialog();
        }
        // 비밀번호 찾기 라벨
        private void findPassword_lbl_Click(object sender, EventArgs e)
        {
            (new FindByPassword()).ShowDialog();
        }

        // 로그인 버튼
        private void login_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(id_txt.Text))
            {
                MessageBox.Show("아이디를 입력해주세요.");
                id_txt.Focus();
                return;
            }
            if (string.IsNullOrEmpty(pw_txt.Text))
            {
                MessageBox.Show("비밀번호를 입력해주세요.");
                pw_txt.Focus();
                return;
            }
            
            string result = userRepository.Login(id_txt.Text, pw_txt.Text);
            if (!result.All(char.IsDigit))
            {
                MessageBox.Show(result);
                return;
            }

            if (idSaveCheck_chk.Checked)
            {
                SaveID();
            }
            else
            {
                NotSaveID();
            }

            Main main = new Main();
            main.Show();
            main.BringToFront();

            this.Hide();
        }
    }
}
