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
    public partial class ListBoxControll : Form
    {
        private enum MemberType
        {
            VIP = 0
            , Regular
            , Associate
            , DayPass
        }
        private MemberType memberType;

        public ListBoxControll()
        {
            InitializeComponent();

            listBox1.Items.Clear();
            listBox1.Items.Add("VIP 회원");
            listBox1.Items.Add("정회원");
            listBox1.Items.Add("준회원");
            listBox1.Items.Add("일일 회원");

            listBox1.SelectedIndex = 1;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            memberType = (MemberType)listBox1.SelectedIndex;

            MessageBox.Show(memberType.ToString());
        }
    }
}
