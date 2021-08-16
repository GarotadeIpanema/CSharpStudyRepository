using ExamKakaoTalk;
using Newtonsoft.Json.Linq;
using RestSharp;
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
    public partial class KakaoLogin : Form
    {
        public KakaoLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "로그인")
            {
                KakaoLoginForm form = new KakaoLoginForm();
                if (form.ShowDialog() == DialogResult.OK)
                {
                    button1.Text = "로그아웃";
                }
            }
            else
            {
                var client = new RestClient(KakaoDefine.HOST_API_URL);

                var request = new RestRequest("/v1/user/unlink", Method.POST);
                request.AddHeader("Authorization", "bearer " + KakaoDefine.ACCESS_TOKEN);

                if (client.Execute(request).IsSuccessful)
                {
                    button1.Text = "로그인";
                }
            }
        }

        private void sendBtn_Click(object sender, EventArgs e)
        {
            if(customMsgRdo.Checked)
            {
                sendMessageToMySelf(msgTxt.Text);
                msgTxt.Text = "";
            }
            else
            {
                sendTemplateMessageToMySelf();
            }
        }

        private void sendMessageToMySelf(string message)
        {
            // JSON 구성
            JObject send = new JObject();
            JObject link = new JObject();
            send.Add("object_type", "text");
            send.Add("text", message);
            link.Add("web_url", "https://developers.kakao.com");
            link.Add("mobile_web_url", "https://developers.kakao.com");
            send.Add("link", link);
            send.Add("button_title", "링크 이동");

            // 요청
            var client = new RestClient(KakaoDefine.HOST_API_URL);
            var requst = new RestRequest("/v2/api/talk/memo/default/send", Method.POST);
            requst.AddHeader("Authorization", "bearer" + KakaoDefine.ACCESS_TOKEN);
            requst.AddParameter("template_object", send);

            if (client.Execute(requst).IsSuccessful)
                MessageBox.Show("메시지 전송 성공!");
            else
                MessageBox.Show("메시지 전송 실패!");
        }

        private void sendTemplateMessageToMySelf()
        {
            var client = new RestClient(KakaoDefine.HOST_API_URL);

            var request = new RestRequest("/v2/api/talk/memo/send", Method.POST);
            request.AddHeader("Authorization", "bearer" + KakaoDefine.ACCESS_TOKEN);
            request.AddParameter("template_id", KakaoDefine.TEMPLATE_ID);

            if(client.Execute(request).IsSuccessful)
                MessageBox.Show("메시지 전송 성공!");
            else
                MessageBox.Show("메시지 전송 실패!");
        }
    }
}
