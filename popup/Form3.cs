using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SendGrid;
using SendGrid.Helpers.Mail;

namespace popup
{
    public partial class Form3 : Form
    {
        private string _code = "";
        private BindingList<object> objectList = new BindingList<object>();

        public Form3()
        {
            InitializeComponent();

            objectList.Add(new { Text = "A회사", Value = "0000000001" });
            objectList.Add(new { Text = "B회사", Value = "0000000002" });
            objectList.Add(new { Text = "C회사", Value = "0000000003" });
            objectList.Add(new { Text = "A쇼핑몰", Value = "0000000004" });
            objectList.Add(new { Text = "B쇼핑몰", Value = "0000000005" }); 
            objectList.Add(new { Text = "C쇼핑몰", Value = "0000000006" });

            comboBox1.DataSource = objectList;
            comboBox1.DisplayMember = "Text";
            comboBox1.ValueMember = "Value";

        }

        // 랜덤 코드 생성
        private string GetRandomCode()
        {
            Random rand = new Random();
            string input = "abcdefghijklmnopqrstuvxyz0123456789";

            var chars = Enumerable.Range(0, 6).Select(x => input[rand.Next(0, input.Length)]);

            return new string(chars.ToArray());
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            _code = comboBox.SelectedIndex.ToString();
            MessageBox.Show(_code);
        }
    }
}
