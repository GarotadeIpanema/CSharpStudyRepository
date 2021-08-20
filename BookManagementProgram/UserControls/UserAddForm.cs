using BookManagementProgram.Model;
using BookManagementProgram.Repository;
using System;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Twilio;
using Twilio.Rest.Api.V2010.Account;

namespace BookManagementProgram.UserControls
{
    public partial class UserAddForm : Form
    {
        BookUserRepository userRepository = null;
        private int _duration = 0;  // 타이머 라벨에 표시할 숫자 변수
        private string _auth_code = "";  // 인증번호

        public UserAddForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;
            userRepository = new BookUserRepository();

            // 권한 콤보 박스 초기화
            user_auth_cmb.DataSource = new BindingSource(userRepository.GetAuthList(), null);
            user_auth_cmb.DisplayMember = "Key";
            user_auth_cmb.ValueMember = "Value";

            // 등급 콤보박스 초기화
            user_grade_cmb.DataSource = new BindingSource(userRepository.GetGradeList(), null);
            user_grade_cmb.DisplayMember = "Key";
            user_grade_cmb.ValueMember = "Value";
        }

        // 취소버튼
        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // 인증번호 전송 버튼
        private void auth_btn_Click(object sender, EventArgs e)
        {
            if (CheckInput())
            {
                TwiloRun();
            }
        }

        // 인증번호 확인
        private void auth_check_btn_Click(object sender, EventArgs e)
        {
            if(auth_number_txt.Text == _auth_code)
            {
                ResetTimerAndCode();
                MessageBox.Show("인증에 성공하였습니다.");
                add_user_btn.Enabled = true;
                return;
            }
            MessageBox.Show("다시 확인해주세요.");
            auth_number_txt.Focus();
        }

        // 사용자 등록
        private void add_user_btn_Click(object sender, EventArgs e)
        {
            if(userRepository.AddUser(CreateUserInstance()))
            {
                MessageBox.Show("사용자 등록에 성공하였습니다.");
                this.Close();
                return;
            }
            MessageBox.Show("사용자 등록에 실패했습니다.");
        }

        private User CreateUserInstance()
        {
            User user = new User();
            user.userName = user_name_txt.Text;
            user.userAddress = user_address_txt.Text;
            user.userBirth = user_birth_txt.Text;
            user.userId = user_id_txt.Text;
            user.userPw = user_password_txt.Text;
            user.authorityNo = (int)user_auth_cmb.SelectedValue;
            user.gradeNo = (int)user_grade_cmb.SelectedValue;
            return user;
        }

        // 텍스트박스 입력 확인
        private bool CheckInput()
        {
            bool check = false;

            if (string.IsNullOrEmpty(user_name_txt.Text))
            {
                MessageBox.Show("성함을 입력해주세요.");
                user_name_txt.Focus();
            }
            else if (string.IsNullOrEmpty(user_address_txt.Text))
            {
                MessageBox.Show("주소를 입력해주세요.");
                user_address_txt.Focus();
            }
            else if (string.IsNullOrEmpty(user_birth_txt.Text) || CheckBirthPattern(user_birth_txt.Text))
            {
                MessageBox.Show("생년월일을 입력해주세요.(2021.01.01)");
                user_birth_txt.Focus();
            }
            else if (string.IsNullOrEmpty(user_id_txt.Text))
            {
                MessageBox.Show("아아디를 입력해주세요.");
                user_id_txt.Focus();
            }
            else if (string.IsNullOrEmpty(user_password_txt.Text))
            {
                MessageBox.Show("비밀번호를 입력해주세요.");
                user_password_txt.Focus();
            }
            else if (string.IsNullOrEmpty(user_phone_txt.Text) || CheckPhonePattern(user_phone_txt.Text))
            {
                MessageBox.Show("휴대폰번호를 입력해주세요.(01012341234)");
                user_address_txt.Focus();
            }
            else
            {
                check = true;
            }

            return check;
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

        // 휴대폰번호 정규식
        private bool CheckPhonePattern(string phone)
        {
            string pattern = @"^\d{3}\d{3,4}\d{4}$";
            if (!Regex.IsMatch(phone, pattern))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Twiolog
        private async void TwiloRun()
        {
            string phone = user_phone_txt.Text;
            // 타이머 초기화 및 인증번호 생성
            _duration = 60;
            _auth_code = GetRandomCode();
            timer1.Stop();
            timer1 = new Timer();
            timer1.Tick += new EventHandler(CountDown);
            timer1.Interval = 1000;
            timer1.Start();

            await Task.Run(() => SpendSMSTwilo(phone));
        }

        private void SpendSMSTwilo(string phone)
        {
            // twilo
            try
            {
                string accountSid = Properties.Settings.Default.TwiloSID;
                string authToken = Properties.Settings.Default.TwiloToken;

                TwilioClient.Init(accountSid, authToken);

                var message = MessageResource.Create(
                    body: $"인증번호 : {_auth_code}",
                    from: new Twilio.Types.PhoneNumber(Properties.Settings.Default.TwiloHost),
                    to: new Twilio.Types.PhoneNumber($"+82{phone}")
                );
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        // 타이머 카운트 다운
        private void CountDown(object sender, EventArgs e)
        {
            if (_duration == 0 || _duration < 0)
            {
                ResetTimerAndCode();
                MessageBox.Show("인증 시간이 초과되었습니다.");
                return;
            }
            _duration--;
            timer_lbl.Text = _duration.ToString();
        }

        // 랜덤 코드 생성
        private string GetRandomCode()
        {
            Random rand = new Random();
            string input = "abcdefghijklmnopqrstuvxyz0123456789";

            var chars = Enumerable.Range(0, 6).Select(x => input[rand.Next(0, input.Length)]);

            return new string(chars.ToArray());
        }

        // 타이머 및 코드 초기화
        private void ResetTimerAndCode()
        {
            timer1.Stop();
            timer1.Dispose();
            _auth_code = "";
        }
    }
}
