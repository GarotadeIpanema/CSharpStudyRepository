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
    public partial class CMD : Form
    {
        public CMD()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 프로세스를 시작할 때 사용되는 값 집합을 지정합니다.
            System.Diagnostics.ProcessStartInfo pri = new System.Diagnostics.ProcessStartInfo();
            // 로컬 및 원격 프로세스에 대한 액세스를 제공하고 로컬 시스템 프로세스를 시작하고 중지할 수 있습니다.
            System.Diagnostics.Process pro = new System.Diagnostics.Process();

            // 실행할 팡일 명 입력하기
            pri.FileName = "cmd.exe";
            // cmd창 띄우기
            pri.CreateNoWindow = false; // false가 띄우가, true가 안 띄우기
            pri.UseShellExecute = false;

            pri.RedirectStandardInput = true;
            pri.RedirectStandardOutput = true;
            pri.RedirectStandardError = true;

            pro.StartInfo = pri;
            pro.Start();

            // CMD 명령어 실행
            pro.StandardInput.Write(@"ipconfig" + Environment.NewLine);
            pro.StandardInput.Close();
            string resultValue = pro.StandardOutput.ReadToEnd();
            pro.WaitForExit();
            pro.Close();

            textBox1.Text = resultValue;

        }
    }
}
