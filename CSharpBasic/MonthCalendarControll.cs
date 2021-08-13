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
    public partial class MonthCalendarControll : Form
    {
        public MonthCalendarControll()
        {
            InitializeComponent();

            // 초기 선택 범위 지정
            monthCalendar1.SelectionStart = DateTime.Now;
            monthCalendar1.SelectionEnd = DateTime.Now.AddDays(3);

            // MaxSelectionCOunt, defulat value = 7
            monthCalendar1.MaxSelectionCount = 31;
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            // 사용자 캘린더 날짜 변경하면 텍스트 박스 내용 변경
            textBox1.Text = monthCalendar1.SelectionStart.ToShortDateString();
            textBox2.Text = monthCalendar1.SelectionEnd.ToShortDateString();
        }
    }
}
