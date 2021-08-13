using kiosk.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kiosk
{
    public partial class Form1 : Form
    {
        private Control control = null;
        private KioskRepository repository = new KioskRepository();
        public Form1()
        {
            InitializeComponent();

            today.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            timer1.Tick += TodayDate;
            timer1.Start();
        }

        private void TodayDate(object sender, EventArgs e)
        {
            today.Text = DateTime.Now.ToString("yyyy년MM월dd일 HH시mm분ss초");
            // DateTime.ParseExact, DB에서 입력받은 문자열이나 특정 날짜 문자열을 DateTime으로 형변환하는 방법
            // CultureInfo, 특정 문화권(비관리 코드 개발의 경우 로캘 이라고 함)에 대한 정보를 제공합니다. 이 정보에는 문화권 이름, 쓰기 시스템, 사용된 달력, 문자열의 정렬 순서, 날짜 및 숫자 형식이 포함되어 있습니다.
            // CultureInfo.InvariantCulture, 문화권 독립(고정)적인 CultureInfo 개체를 가져옵니다.
            DateTime dt = new DateTime();
            dt = DateTime.ParseExact("2021-08-06", "yyyy-MM-dd", CultureInfo.InvariantCulture);
            string strDate = dt.ToString("yyyy-MM-dd일");
        }

        private void hanburger_Click(object sender, EventArgs e)
        {
            if (control != null) panel1.Controls.Remove(control);
            control = new HambergerForm(added, price, counter);
            panel1.Controls.Add(control);
        }

        private void side_Click(object sender, EventArgs e)
        {
            if (control != null) panel1.Controls.Remove(control);
            control = new SideForm(added, price, counter);
            panel1.Controls.Add(control);
        }

        private void drinks_Click(object sender, EventArgs e)
        {
            if (control != null) panel1.Controls.Remove(control);
            control = new DrinksForm(added, price, counter);
            panel1.Controls.Add(control);
        }

        private void bill_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"총 결제 금액은 {price.Text.Replace("가격 : ", "")}원 입니다");

            String str1 = $"str1 : ko[{getString("str1")}], en[{getString("en", "str1")}]";
            String str2 = $"str2 : ko[{getString("str2")}], en[{getString("en", "str2")}]";
            String msg = str1 + "\n\n" + str2;
            MessageBox.Show(msg);
        }

        private void reset_Click(object sender, EventArgs e)
        {
            repository.Reset();
            string str = "";
            added.Text = "";
            repository.SelectOrders().ForEach(menu => {
                str += $"{menu.ToString()}\r\n";
            });
            added.Text = str;
            price.Text = $"가격 : {repository.Billing()}";
            counter.Text = $"수량 : {repository.CountingMenu()}";
        }

        // 언어 지역화
        // 기본값은 한국어로 하며, 설정파일(ini) 등에서 값을 가져와 저장하여 사용
        // https://srctree.tistory.com/33
        public static string sLanguage = "ko";
        public static string getString(string name)
        {
            return getString(sLanguage, name);
        }
        public static string getString(string code, string name)
        {
            if(code.Equals("en"))
            {
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-US");
                return Properties.StringLib.ResourceManager.GetString(name);
            }
            else
            {
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("ko-KR");
                return Properties.StringLib.ResourceManager.GetString(name);
            }
        }
    }
}
