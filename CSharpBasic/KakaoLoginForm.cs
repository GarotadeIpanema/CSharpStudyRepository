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
using System.Security;
using Microsoft.Win32;
using System.IO;
using ExamKakaoTalk;

namespace CSharpBasic
{
    public partial class KakaoLoginForm : Form
    {
        public KakaoLoginForm()
        {
            InitializeComponent();

            webBrowserKakaoLogin.Navigate(KakaoDefine.LOGIN_URL);
        }

        private void webBrowserKakaoLogin_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            string code = getCode();
            if (code != "")
            {
                KakaoDefine.USER_CODE = code;
                KakaoDefine.ACCESS_TOKEN = getToken();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        //인가 코드 요청하기
        public string getCode()
        {
            string url = webBrowserKakaoLogin.Url.ToString();
            string token = url.Substring(url.IndexOf("=") + 1);

            //사용자가 '동의하고 계속하기' 선택, 로그인 진행 시 응답 형태:
            //{REDIRECT_URI}?code={AUTHORIZE_CODE}
            if (url.CompareTo(KakaoDefine.REDIRECT_URL + "?code=" + token) == 0)
            {
                return token;
            }
            else
            {
                return "";
            }
        }

        //토큰 요청하기
        public string getToken()
        {
            var client = new RestClient(KakaoDefine.HOST_OAUTH_URL);

            var request = new RestRequest("/oauth/token", Method.POST);
            request.AddParameter("grant_type", "authorization_code");
            request.AddParameter("client_id", KakaoDefine.API_KEY);
            request.AddParameter("redirect_uri", KakaoDefine.REDIRECT_URL);
            request.AddParameter("code", KakaoDefine.USER_CODE);

            var result = client.Execute(request);
            var json = JObject.Parse(result.Content);

            return json["access_token"].ToString();
        }
    }
}
