using BookManagementProgram.Model;
using BookManagementProgram.Repository;
using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace BookManagementProgram.UserControls
{
    public partial class UserSearchForm : Form
    {
        BookUserRepository userRepository = null;

        public UserSearchForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;
            userRepository = new BookUserRepository();

            user_auth_cmb.DataSource = new BindingSource(userRepository.GetAuthList(), null);
            user_auth_cmb.DisplayMember = "Key";
            user_auth_cmb.ValueMember = "Value";

            user_grade_cmb.DataSource = new BindingSource(userRepository.GetGradeList(), null);
            user_grade_cmb.DisplayMember = "Key";
            user_grade_cmb.ValueMember = "Value";
        }

        // 취소버튼
        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        // 유저 조회 버튼
        private void user_select_btn_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(user_no_txt.Text))
            {
                MessageBox.Show("사용자 번호를 입력해주세요.");
                user_no_txt.Focus();
                return;
            }

            User user = userRepository.GetUserByNumber(user_no_txt.Text);

            if(user == null)
            {
                MessageBox.Show("사용자 번호를 확인해주세요!");
                user_no_txt.Focus();
                return;
            }

            user_no_txt.ReadOnly = true;

            user_name_txt.Text = user.userName;
            user_address_txt.Text = user.userAddress;
            user_birth_txt.Text = user.userBirth;
            user_id_txt.Text = user.userId;
            user_registerdate_txt.Text = user.registerDate;
            user_deregisterdate_txt.Text = user.deregisterDate;
            user_auth_cmb.SelectedValue = user.authorityNo;
            user_grade_cmb.SelectedValue = user.gradeNo;
        }

        // 초기화 버튼
        private void reset_btn_Click(object sender, EventArgs e)
        {
            user_no_txt.ReadOnly = false;

            user_name_txt.Text = string.Empty;
            user_address_txt.Text = string.Empty;
            user_birth_txt.Text = string.Empty;
            user_id_txt.Text = string.Empty;
            user_registerdate_txt.Text = string.Empty;
            user_deregisterdate_txt.Text = string.Empty;
            user_auth_cmb.SelectedIndex = 0;
            user_grade_cmb.SelectedIndex = 0;
        }

        // 유저 삭제 버튼
        private void user_delete_btn_Click(object sender, EventArgs e)
        {
            if (!user_no_txt.ReadOnly)
            {
                MessageBox.Show("사용자 조회를 하고 삭제해주세요.");
                return;
            }
            if (MessageBox.Show($"{user_no_txt.Text}번의 사용자를 정말 삭제하시겠습니까?", null, MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if(userRepository.DeleteUserByNumber(user_no_txt.Text))
                {
                    MessageBox.Show("정상적으로 삭제 되었습니다.");
                    this.Close();
                    return;
                }
                MessageBox.Show("없는 사용자 이거나 번호를 확인해주세요.");
                return;
            }
            MessageBox.Show("취소 하셨습니다.");
        }

        // 유저 수정 버튼
        private void user_update_btn_Click(object sender, EventArgs e)
        {
            if(!user_no_txt.ReadOnly)
            {
                MessageBox.Show("사용자 조회를 하고 수정해주세요.");
                return;
            }

            if(string.IsNullOrEmpty(user_no_txt.Text))
            {
                MessageBox.Show("사용자 번호를 입력해주세요.");
                user_no_txt.Focus();
                return;
            }
            if (string.IsNullOrEmpty(user_name_txt.Text))
            {
                MessageBox.Show("사용자 이름을 입력해주세요.");
                user_name_txt.Focus();
                return;
            }
            if (string.IsNullOrEmpty(user_address_txt.Text))
            {
                MessageBox.Show("사용자 주소를 입력해주세요.");
                user_address_txt.Focus();
                return;
            }
            if (string.IsNullOrEmpty(user_birth_txt.Text) || CheckBirthPattern(user_birth_txt.Text))
            {
                MessageBox.Show("생년월일을 입력해주세요.");
                user_birth_txt.Focus();
                return;
            }
            if (string.IsNullOrEmpty(user_id_txt.Text))
            {
                MessageBox.Show("아이디를 입력해주세요.");
                user_id_txt.Focus();
                return;
            }

            if (MessageBox.Show($"{user_no_txt.Text}번의 사용자를 수정하시겠습니까?", null, MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                User user = new User();
                user.userNo = user_no_txt.Text;
                user.userName = user_name_txt.Text;
                user.userAddress = user_address_txt.Text;
                user.userBirth = user_birth_txt.Text;
                user.userId = user_id_txt.Text;
                user.authorityNo = (int)user_auth_cmb.SelectedValue;
                user.gradeNo = (int)user_grade_cmb.SelectedValue;

                if (userRepository.UpdateUserInfo(user))
                {
                    MessageBox.Show("정상적으로 수정 되었습니다.");
                    this.Close();
                    return;
                }
                MessageBox.Show("없는 사용자 이거나 번호를 확인해주세요.");
                return;
            }
            MessageBox.Show("취소 하셨습니다.");
        }

        // 생년월일 확인 정규식
        private bool CheckBirthPattern(string birth)
        {
            string pattern = @"^(19[0-9][0-9]|20\d{2})\.(0[0-9]|1[0-2])\.(0[1-9]|[1-2][0-9]|3[0-1])$";
            if (!Regex.IsMatch(birth, pattern))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
