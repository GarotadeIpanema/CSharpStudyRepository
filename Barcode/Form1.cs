using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text.pdf;

namespace Barcode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            (new iTextSharpBarcode()).ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            (new ZXingQRCode()).ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            (new ZenBarcodeQRCode()).ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            (new ZXingBarCode()).ShowDialog();
        }
    }
}
