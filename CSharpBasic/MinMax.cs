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
    public partial class MinMax : Form
    {
        private List<int> numbers = new List<int>();
        public MinMax()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            numbers.Add(Convert.ToInt32(textBox1.Text));
            numbers.Add(Convert.ToInt32(textBox2.Text));
            numbers.Add(Convert.ToInt32(textBox3.Text));
            numbers.Add(Convert.ToInt32(textBox4.Text));
            numbers.Add(Convert.ToInt32(textBox5.Text));
            numbers.Add(Convert.ToInt32(textBox6.Text));
            numbers.Add(Convert.ToInt32(textBox7.Text));

            int min = numbers[0];
            //int min = Int32.MaxValue;
            int max = numbers[0];
            //int max = Int32.MinValue;

            for(int i = 0; i < numbers.Count; i++)
            {
                // Min Logic
                min = (min > numbers[i]) ? numbers[i] : min;

                // Max Logic
                max = (max < numbers[i]) ? numbers[i] : max;
            }

            textBox8.Text = min.ToString();
            textBox9.Text = max.ToString();

            min = Int32.MaxValue;
            max = Int32.MinValue;
            min = numbers.Min();
            max = numbers.Max();

            textBox10.Text = min.ToString();
            textBox11.Text = max.ToString();

        }
    }
}
