using BookManagementProgram.Repository;
using System;
using System.Data;
using System.Linq;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookManagementProgram.XtraForm
{
    public partial class FindByPassword : Form
    {
        private int _duration = 0;
        private string _auth_code = "";
        BookUserRepository userRepository = new BookUserRepository();

        public FindByPassword()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;
        }
        // 인증번호 요청 버튼
        private void authenticationRequest_btn_Click(object sender, EventArgs e)
        {
            if(CheckTextBox())
            {
                string email = memberEmail_txt.Text;
                if(CheckEmailPattern(email))
                {
                    GmailRun(email);
                }
            }
        }

        // 인증번호 확인 버튼
        private void checkAuthentication_btn_Click(object sender, EventArgs e)
        {
            if (authenticationNumber_txt.Text.Trim().Equals(_auth_code))
            {
                MessageBox.Show("인증 되었습니다");
                ResetTimerAndCode();
                newPassword_txt.ReadOnly = false;
                newPassword_txt.Focus();
            }
            else
            {
                MessageBox.Show("다시 확인해주세요");
            }
        }

        // 비밀번호 변경 버튼
        private void changePassword_btn_Click(object sender, EventArgs e)
        {
            if(CheckTextBox())
            {
                if(newPassword_txt.Text.Length > 0)
                {
                    if(userRepository.FindByPassword(memberNumber_txt.Text, memberID_txt.Text, newPassword_txt.Text))
                    {
                        MessageBox.Show("비밀번호 변경 되었습니다");
                        this.Close();
                        return;
                    }
                    MessageBox.Show("비밀번호 변경에 실패하였습니다.");
                }
            }
        }

        // 취소
        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool CheckTextBox()
        {
            if(string.IsNullOrEmpty(memberNumber_txt.Text))
            {
                MessageBox.Show("회원의 성함을 입력해주세요.");
                memberNumber_txt.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(memberID_txt.Text))
            {
                MessageBox.Show("회원의 아이디를 입력해주세요.");
                memberID_txt.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(memberEmail_txt.Text))
            {
                MessageBox.Show("회원의 이메일을 입력해주세요.");
                memberEmail_txt.Focus();
                return false;
            }
            return true;
        }

        private bool CheckEmailPattern(string email)
        {
            string pattern = @"[a-zA-Z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-zA-Z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-zA-Z0-9](?:[a-zA-Z0-9-]*[a-zA-Z0-9])?\.)+[a-zA-Z0-9](?:[a-zA-Z0-9-]*[a-zA-Z0-9])?";
            if(Regex.IsMatch(email, pattern))
            {
                return true;
            }
            else
            {
                MessageBox.Show("이메일을 확인해주세요.");
                memberEmail_txt.Focus();
                return false;
            }
        }

        // 랜덤 코드 생성
        private string getRandomCode()
        {
            Random rand = new Random();
            string input = "abcdefghijklmnopqrstuvxyz0123456789";

            var chars = Enumerable.Range(0, 6).Select(x => input[rand.Next(0, input.Length)]);

            return new string(chars.ToArray());
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

        // 타이머 및 코드 초기화
        private void ResetTimerAndCode()
        {
            timer1.Stop();
            timer1.Dispose();
            _auth_code = "";
        }

        // gmail
        private async void GmailRun(string email)
        {
            // 타이머 초기화 및 인증번호 생성
            _duration = 60;
            _auth_code = getRandomCode();
            timer1.Stop();
            timer1 = new Timer();
            timer1.Tick += new EventHandler(CountDown);
            timer1.Interval = 1000;
            timer1.Start();

            await Task.Run(() => sendGmailAsync(email));
            //auth_btn.Enabled = true;
        }
        private void sendGmailAsync(string email)
        {
            MailMessage mailMessage = new MailMessage();

            mailMessage.From = new MailAddress(Properties.Settings.Default.GmailID);
            mailMessage.To.Add(email);
            mailMessage.Subject = "인증코드";
            mailMessage.Body = $"인증 코드 : {_auth_code}";
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
            SmtpServer.Port = 587;
            SmtpServer.EnableSsl = true;
            SmtpServer.UseDefaultCredentials = false;
            SmtpServer.DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network;
            SmtpServer.Credentials = new System.Net.NetworkCredential(Properties.Settings.Default.GmailID, Properties.Settings.Default.GmailPW);

            SmtpServer.Send(mailMessage);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            memberNumber_txt.Focus();
        }
        private void label2_Click(object sender, EventArgs e)
        {
            memberID_txt.Focus();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            memberEmail_txt.Focus();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            authenticationNumber_txt.Focus();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            newPassword_txt.Focus();
        }
    }
}
