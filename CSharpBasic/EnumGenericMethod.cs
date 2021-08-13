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
    public partial class EnumGenericMethod : Form
    {
        public enum FRUIT { APPLE, MELON, WATERMELON, BANANA, PEACH };
        public enum COLOR { RED, BLACK, BLUE, GREEN, YELLOW };

        public EnumGenericMethod()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = "";
            foreach(FRUIT item in Enum.GetValues(typeof(FRUIT)))
            {
                str += $"{item} \r\n";
            }
            textBox1.Text = str;

            textBox6.Text = SetEnumData<FRUIT>();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string str = "";
            foreach (COLOR item in Enum.GetValues(typeof(COLOR)))
            {
                str += $"{item} \r\n";
            }
            textBox2.Text = str;

            textBox12.Text = SetEnumData<COLOR>();
        }

        public string SetEnumData<TEnum>()
        {
            string str = "";

            //Enum 타입 받아온다
            Type enumType = typeof(TEnum);

            // enum 반목문으로 출력
            foreach(Enum item in Enum.GetValues(enumType))
            {
                str += $"{item} \r\n";
            }
            return str;
        }
    }
}
