using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Diagnostics;

namespace CSharpBasic
{
    public partial class RegexControll : Form
    {
        public RegexControll()
        {
            InitializeComponent();
        }

        //  ^          :    시작
        //  $          :    끝
        //  \w      :    문자(영숫자) [a-zA-Z0-9ㄱ-ㅎ가-힣]
        //  \s       :    공백
        //  \d       :    숫자
        //  *          :    ZERO TO OVER
        //  +          :    OVER ONE
        //  ?          :    ZERO OR ONE
        //  .           :    ONE (EXCEPT newline)
        //  [ ]        :    CONTAINS WORD
        //  [^ ]      :    EXCEPT WORD
        //  [ - ]     :    CONTAINS WORD RANGE
        //  {n, m}  :    min Length, Max Length
        //  ()         :    Group
        // |          :     OR

        // Match     : 표현식에 합당한 단일 일치 항목의 문자열 리턴
        // Matches  : 표현식에 합당한 모든 일치 항목의 문자열 리턴
        // isMatch   : 표현식에 합당한지 bool 값 리턴
        // Split       : 표현식에 합당한 문자열을 기준으로 분리
        // Replace  : 표현식에 합당한 문자열을 다른 문자열로 치환

        // Match
        private void button1_Click(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"a");
            label2.Text = regex.Match(textBox1.Text).Value;
        }

        // Matches
        private void button2_Click(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"a");
            MatchCollection matchs = regex.Matches(textBox2.Text);
            string str = "";
            foreach(Match m in matchs)
            {
                str += $"{m} ";
            }
            label3.Text = str;
        }

        // isMatch
        private void button3_Click(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"a");
            label5.Text = regex.IsMatch(textBox3.Text).ToString();
        }

        // Split
        private void button4_Click(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"a");
            var strarr = regex.Split(textBox4.Text);
            label7.Text = string.Join(" ", strarr);
        }

        //Group1
        // 괄호안에 있는 문자열들을 찾아내어 Match 클래스 객체의 Match.Groups 속성에 결과를 넣게 된다
        // Match.Groups 속성은 GroupCollection 클래스 객체로서 복수의 Group 클래스 객체를 갖는다.
        private void button5_Click(object sender, EventArgs e)
        {
            // 강남빌라 역삼아파트 서초APT
            Regex regex = new Regex(@"(아파트|APT)");
            MatchCollection matchs = regex.Matches(textBox5.Text);
            string str = "";
            foreach(Match m in matchs)
            {
                // (Captured) Group은 1부터
                Group g = m.Groups[1];
                str += $"{g.Index} : {g.Value}";
            }
            label9.Text = str;
        }

        //Group2
        private void button6_Click(object sender, EventArgs e)
        {
            // <ul><li>홈페이지</li><li>주문메뉴</li></ul>
            string str = "";
            Regex regex = new Regex(@"<li>(\w+)</li>");
            MatchCollection mc = regex.Matches(textBox6.Text);
            foreach(Match m in mc)
            {
                Group g = m.Groups[1];
                str += $"{g.Index} : {g.Value} ";
            }
            label11.Text = str;
        }

        // Group3
        private void button7_Click(object sender, EventArgs e)
        {
            // 02-632-5432; 032-645-7361
            Regex regex = new Regex(@"(\d+)-(\d+-\d+)");
            MatchCollection matchs = regex.Matches(textBox7.Text);
            string str = "";
            foreach(Match m in matchs)
            {
                Group g = m.Groups[1];
                str += $"{g.Index} : {g.Value} ";
            }
            label13.Text = str;
        }

        // Named Group1
        // 복수의 그룹들은 인덱스를 통해서만 접근할 수 있었다. 그런데, Regular Expression에서는 그룹에 이름을 붙여서 사용하는 것(Named Group)이 가능
        // 각 그룹별로 이름을 붙이면, 여러 그룹들을 사용할 경우 차후에 이름을 통해 그룹 객체를 엑세스할 수 있게되어, 코드를 쓰거나 읽는 것이 쉬워진다
        private void button8_Click(object sender, EventArgs e)
        {
            // 02-632-5432; 032-645-7361
            Regex regex = new Regex(@"(?<areaNo>\d+)-(?<phoneNo>\d+-\d+)");
            MatchCollection mc = regex.Matches(textBox8.Text);
            string str = "";
            foreach (Match m in mc)
            {
                string area = m.Groups["areaNo"].Value;
                string phone = m.Groups["phoneNo"].Value;
                str += $"{area} - {phone} ";
            }
            label15.Text = str;
        }
        // Named Group2
        private void button9_Click(object sender, EventArgs e)
        {
            // <div><a href='www.sqlmgmt.com'>SQL Tools</a></div>
            string pattern = @"<a[^>]*href\s*=\s*[""']?(?<href>[^""'>]+)[""']?";
            Match m = Regex.Match(textBox9.Text, pattern);
            Group g = m.Groups["href"];
            label17.Text = g.Value;
        }

        // Regex을 이용한 문자열 치환1
        //  특정 패턴을 찾아내는 Match() / Matches()
        // 특정 패턴을 기준으로 문자열을 분리하는 Split()
        // 찾아낸 문자열을 다른 문자열로 치환하는 Replace()
        private void button10_Click(object sender, EventArgs e)
        {
            //    서울시 강남구 역삼동 강남아파트 1  
            string pattern = @"^\s+|\s+$";
            label19.Text = Regex.Replace(textBox10.Text, pattern, "");
        }

        // Regex을 이용한 문자열 치환2
        private void button11_Click(object sender, EventArgs e)
        {
            // 02-632-5432; 032-645-7361
            string pattern = @"(?<areaNo>\d+)-(?<phoneNo>\d+-\d+)";
            label21.Text = Regex.Replace(textBox11.Text, pattern, @"(${areaNo}) ${phoneNo}");
        }



    }
}
