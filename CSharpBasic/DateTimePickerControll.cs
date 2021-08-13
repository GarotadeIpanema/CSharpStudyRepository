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
    public partial class DateTimePickerControll : Form
    {
        public DateTimePickerControll()
        {
            InitializeComponent();
        }

        private void dateTimePicker4_ValueChanged(object sender, EventArgs e)
        {
            DateTime dt = dateTimePicker4.Value;

            string str = $"{dt.Month}월 {dt.Day}일 {dt.Hour}시 {dt.Minute}분에 보자";

            MessageBox.Show(str);
        }
    }
}
