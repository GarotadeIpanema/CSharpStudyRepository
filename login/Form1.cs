using DH.Connect;
using DH.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DH_WMS
{
	public partial class FrmLogin : FrmInherit
	{

		public FrmLogin()
		{
			InitializeComponent();
		}

		private void simpleButton1_Click(object sender, EventArgs e)
		{
			string emp_id = emp_id_txt.Text; // 입력받은 아이디
			string emp_pw = Encryption(emp_pw_txt.Text);  // 입력받은 비밀번호

			Excute excute = new Excute();
			excute.Query("SP_LOGIN_S1", emp_id, emp_pw);
			excute.Exec();  //실행			

			if (excute.Return_Result)
			{
				Global.User.Id = excute.dt.Rows[0]["EMP_ID"].ToString();
				Global.User.Ip = GetExternalIPAddress();
				Log(LogType.Login);

				FrmMain main = new FrmMain();
				main.Show();
				main.BringToFront();
				this.Hide();
			}
			else
			{
				Excute.Msg(Excute.Message_Type.Sql_Error);
			}
		}

		// 체크박스 비밀번호 캐릭터 설정 이벤트
		private void emp_pw_chk_CheckedChanged(object sender, EventArgs e)
		{
			if (emp_pw_chk.Checked)
				emp_pw_txt.PasswordChar = default(char);
			else
				emp_pw_txt.PasswordChar = '*';
		}

		// 암호화(단방향) 메서드
		public string Encryption(string data)
		{
			SHA256 sha = new SHA256Managed();
			byte[] hash = sha.ComputeHash(Encoding.ASCII.GetBytes(data));
			StringBuilder stringBuilder = new StringBuilder();
			foreach (byte b in hash)
			{
				stringBuilder.AppendFormat("{0:x2}", b);
			}
			return stringBuilder.ToString();
		}

		// 외부 IP 갖고오기
		public static string GetExternalIPAddress()
		{
			string externalip = new WebClient().DownloadString("http://ipinfo.io/ip").Trim();

			if (String.IsNullOrWhiteSpace(externalip)) // 외부 ip가 없을 경우(null일 경우) 내부 IP 갖고 오기
			{
				externalip = GetInternalIPAddress();
			}

			return externalip;
		}
		// 내부 ip(0(IPv6), 1(IPv4))
		public static string GetInternalIPAddress(int i = 1)
		{
			String strHostName = string.Empty;
			IPHostEntry ipEntry = Dns.GetHostEntry(Dns.GetHostName());
			IPAddress[] addr = ipEntry.AddressList;

			return addr[i].ToString();
		}

	}
}