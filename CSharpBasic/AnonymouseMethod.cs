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
    public partial class AnonymouseMethod : Form
    {
        public AnonymouseMethod()
        {
            InitializeComponent();
        }

        delegate int Transformer(int i);

        Transformer ts = delegate (int x) { return x * x; };

        private void button1_Click(object sender, EventArgs e)
        {
            int number = Convert.ToInt32(textBox1.Text);

            label1.Text = ts(number).ToString();
        }
    }
}
