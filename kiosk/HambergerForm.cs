using kiosk.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kiosk
{
    public partial class HambergerForm : UserControl
    {
        private KioskRepository repository = new KioskRepository();
        private TextBox textbox;
        private Label label1;
        private Label label2;

        public HambergerForm(TextBox textBox, Label labe1, Label label2)
        {
            InitializeComponent();

            this.textbox = textBox;
            this.label1 = labe1;
            this.label2 = label2;

            bulgogi.CheckedChanged += CheckItem;
            doublebulgogi.CheckedChanged += CheckItem;
            cheese.CheckedChanged += CheckItem;
            doublecheese.CheckedChanged += CheckItem;
        }

        

        private void CheckItem(object sender, EventArgs e)
        {
            RadioButton rd = (RadioButton)sender;
            bool flag = rd.Checked;
            if(flag)
            {
                string str = "";
                textbox.Text = "";
                repository.AddMenu(rd.Text, 5000);
                repository.SelectOrders().ForEach(menu => {
                    str += $"{menu.ToString()}\r\n";
                });
                textbox.Text = str;
                label1.Text = $"가격 : {repository.Billing()}";
                label2.Text = $"수량 : {repository.CountingMenu()}";
            }
            
        }
    }
}
