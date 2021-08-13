using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zen.Barcode;

namespace Barcode
{
    public partial class ZenBarcodeQRCode : Form
    {
        public ZenBarcodeQRCode()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CodeQrBarcodeDraw qrcode = BarcodeDrawFactory.CodeQr; // 바코드 : Code128WithChecksum, QR : CodeQr
            var qrimage = qrcode.Draw("https://www.naver.com", 50);
            qrimage.Save(@"C:\Users\jjh\Desktop\img\a.jpg");
        }
    }
}
