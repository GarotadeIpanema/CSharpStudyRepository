using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using System.Configuration;
using System.Net;

namespace popup
{
    public partial class FindByPWMS : Form
    {
        private int _duration = 0;
        private string _auth_code = "";

        public FindByPWMS()
        {
            InitializeComponent();
        }

        // 창 닫기 이벤트
        private void cancle_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // sendgrid
        private void send_grid_btn_Click(object sender, EventArgs e)
        {
            SendGridRun();
        }
        private async void SendGridRun()
        {
            string email = sendgrid_txt.Text;

            if (EmailValdate(email))
            {
                // 타이머 초기화 및 인증번호 생성
                _duration = 60;
                _auth_code = GetRandomCode();
                timer1.Stop();
                timer1 = new Timer();
                timer1.Tick += new EventHandler(CountDown);
                timer1.Interval = 1000;
                timer1.Start();

                await Task.Run(() => SpendToMailSendGrid(email));
            }
            else
            {
                MessageBox.Show("이메일을 제대로 확인해주세요.");
            }
        }

        private void SpendToMailSendGrid(string email)
        {
            // sendgrid
            // var apiKey = Environment.GetEnvironmentVariable("Variable");
            var apiKey = ConfigurationManager.AppSettings["SendGridKey"];
            var client = new SendGridClient(apiKey);
            var from = new EmailAddress(ConfigurationManager.AppSettings["SendGridHost"], "HOST");
            var to = new EmailAddress(email, "USER");
            var subject = "Sending with SendGrid is Fun";
            var plainTextContent = $"인증 코드 : {_auth_code}";
            var htmlContent = "";
            //var htmlContent = "<strong>and easy to do anywhere, even with C#</strong>";
            var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);
            var response = client.SendEmailAsync(msg);
        }

        // twilo
        private void button1_Click(object sender, EventArgs e)
        {
            TwiloRun();
        }

        private async void TwiloRun()
        {
            string phone = phone_txt.Text;

            if (PhoneValidate(phone))
            {
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
            else
            {
                MessageBox.Show("휴대폰 번호를 제대로 확인해주세요.(- 없이 숫자만)");
            }
        }

        private void SpendSMSTwilo(string phone)
        {
            // twilo
            try
            {
                string accountSid = ConfigurationManager.AppSettings["TwiloSID"];
                string authToken = ConfigurationManager.AppSettings["TwiloToken"];

                TwilioClient.Init(accountSid, authToken);

                var message = MessageResource.Create(
                    body: $"인증번호 : {_auth_code}",
                    from: new Twilio.Types.PhoneNumber(ConfigurationManager.AppSettings["TwiloHost"]),
                    to: new Twilio.Types.PhoneNumber($"+82{phone}")
                );
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        // gmail
        private void auth_btn_Click(object sender, EventArgs e)
        {
            GmailRun();
        }

        private async void GmailRun()
        {
            string email = email_txt.Text;

            if (EmailValdate(email))
            {
                // 타이머 초기화 및 인증번호 생성
                _duration = 60;
                _auth_code = GetRandomCode();
                timer1.Stop();
                timer1 = new Timer();
                timer1.Tick += new EventHandler(CountDown);
                timer1.Interval = 1000;
                timer1.Start();

                await Task.Run(() => sendGmailAsync(email));
                auth_btn.Enabled = true;
            }
            else
            {
                MessageBox.Show("이메일을 제대로 확인해주세요.");
            }
        }
        private void sendGmailAsync(string email)
        {
            // smtp 초기화 및 설정
            MailMessage mailMessage = new MailMessage();

            // 보내는 사람 이메일
            // mailMessage.From = new MailAddress("전송하는 계정 주소", "표시 이름", System.Text.Encoding.UTF8);
            //mailMessage.From = new MailAddress(_email, "인증번호", System.Text.Encoding.UTF8);
            mailMessage.From = new MailAddress(ConfigurationManager.AppSettings["GmailID"]);
            // 받는 사람 이메일
            mailMessage.To.Add(email);
            // 비공개 참조 메일 주소
            // mailMessage.Bcc.Add("aaa@naver.com");
            // 제목
            mailMessage.Subject = "인증코드";
            // 메일 제목 인코딩
            // mailMessage.SubjectEncoding = System.Text.Encoding.UTF8;
            // 본문
            mailMessage.Body = $"인증 코드 : {_auth_code}";
            // 본문의 포맷에 따라 선택
            // mailMessage.IsBodyHtml = false;
            // 본문 인코딩 타입
            // mailMessage.BodyEncoding = System.Text.Encoding.UTF8;
            // 파일 첨부
            // mailMessage.Attachments.Add(new Attachment(new FileStream(@"D:\test.zip", FileMode.Open, FileAccess.Read), "test.zip"));
            // smtp 서버 주소
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
            // STML 포트
            SmtpServer.Port = 587;
            // SSL 사용 여부
            SmtpServer.EnableSsl = true;
            SmtpServer.UseDefaultCredentials = false;
            SmtpServer.DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network;
            // 보낼 이메일 아이디랑 비밀번호 입력
            // SmtpServer.Credentials = new System.Net.NetworkCredential("아이디", "비밀번호");
            SmtpServer.Credentials = new System.Net.NetworkCredential(ConfigurationManager.AppSettings["GmailID"], ConfigurationManager.AppSettings["GmailPW"]);

            SmtpServer.Send(mailMessage);
        }

        // 이메일 검증
        public bool EmailValdate(string email)
        {
            string pattern = @"[a-zA-Z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-zA-Z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-zA-Z0-9](?:[a-zA-Z0-9-]*[a-zA-Z0-9])?\.)+[a-zA-Z0-9](?:[a-zA-Z0-9-]*[a-zA-Z0-9])?";
            return Regex.IsMatch(email, pattern);
        }

        // 휴대폰 번호 검증
        private bool PhoneValidate(string phone)
        {
            string pattern = @"01[0-4]{1}[0-9]{3,4}[0-9]{4}";

            return Regex.IsMatch(phone, pattern);
        }
        // 인증번호 확인 버튼 클릭 이벤트
        private void auth_check_btn_Click(object sender, EventArgs e)
        {
            if(auth_txt.Text.Trim().Equals(_auth_code))
            {
                MessageBox.Show("인증 되었습니다");
                ResetTimerAndCode();
                new_password_txt.ReadOnly = false;
                new_password_txt.Focus();
            }
            else
            {
                MessageBox.Show("다시 확인해주세요");
            }
        }

        // 비밀번호 변경 버튼
        private void change_password_btn_Click(object sender, EventArgs e)
        {
            if (id_txt.Text.Trim() == "")
            {
                MessageBox.Show("아이디를 입력해주세요");
                id_txt.Focus();
                return;
            }
            if (email_txt.Text.Trim() == "")
            {
                MessageBox.Show("이메일을 입력해주세요");
                email_txt.Focus();
                return;
            }
            if (new_password_txt.Text.Trim() == "")
            {
                MessageBox.Show("비밀번호를 입력해주세요");
                new_password_txt.Focus();
                return;
            }
            MessageBox.Show("변경 완료");
        }

        // 타이머 카운트 다운
        private void CountDown(object sender, EventArgs e)
        {
            if(_duration == 0 || _duration < 0)
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

        private void naverbtn_Click(object sender, EventArgs e)
        {
            NaverRun();
        }

        private async void NaverRun()
        {
            string email = navertxt.Text;

            if (EmailValdate(email))
            {
                _duration = 60;
                _auth_code = GetRandomCode();
                timer1.Stop();
                timer1 = new Timer();
                timer1.Tick += new EventHandler(CountDown);
                timer1.Interval = 1000;
                timer1.Start();

                await Task.Run(() => sendNaverAsync(email));
                auth_btn.Enabled = true;
            }
            else
            {
                MessageBox.Show("이메일을 제대로 확인해주세요.");
            }
        }
        private void sendNaverAsync(string email)
        {
            MailMessage mailMessage = new MailMessage();
            mailMessage.From = new MailAddress(ConfigurationManager.AppSettings["NaverFrom"], "mms"); // 보내는 사람
            mailMessage.To.Add(email);
            mailMessage.Subject = "인증코드";
            mailMessage.SubjectEncoding = System.Text.Encoding.UTF8;
            mailMessage.Body = $"인증 코드 : {_auth_code}";
            mailMessage.BodyEncoding = System.Text.Encoding.UTF8;
            
            SmtpClient SmtpServer = new SmtpClient("smtp.naver.com");
            SmtpServer.Port = 587;
            SmtpServer.EnableSsl = true;
            SmtpServer.UseDefaultCredentials = false;
            SmtpServer.DeliveryMethod = SmtpDeliveryMethod.Network;
            SmtpServer.Credentials = new NetworkCredential(ConfigurationManager.AppSettings["NaverID"], ConfigurationManager.AppSettings["NaverPW"]);
            SmtpServer.Send(mailMessage);
        }
    }
}
