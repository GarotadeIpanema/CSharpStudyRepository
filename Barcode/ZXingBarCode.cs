using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;
using ZXing.Common;

namespace Barcode
{
    public partial class ZXingBarCode : Form
    {
        public ZXingBarCode()
        {
            InitializeComponent();
        }

        // Read
        private void button1_Click(object sender, EventArgs e)
        {
            // create a barcode reader instance
            var barcodeReader = new BarcodeReader();

            // create an in memory bitmap
            var barcodeBitmap = (Bitmap)Bitmap.FromFile(@"C:\Users\jjh\Desktop\img\barimage.bmp");

            // decode the barcode from the in memory bitmap
            var barcodeResult = barcodeReader.Decode(barcodeBitmap);

            // output result
            pictureBox1.Image = barcodeBitmap;
            textBox1.Text = $"Decoded barcode text : {barcodeResult?.Text}";
            textBox1.Text = $"Barcode format : {barcodeResult?.BarcodeFormat}";
        }

        // write
        private void button2_Click(object sender, EventArgs e)
        {
            // instantiate a write object
            var barcodeWriter = new BarcodeWriter
            {
                Format = BarcodeFormat.CODE_39,
                Options = new EncodingOptions
                {
                    Height = 200,
                    Width = 600,
                    PureBarcode = true
                }
            };

            // set the barcode format
            // barcodeWriter.Format = BarcodeFormat.CODE_39;

            // write text and  generate a 2-D barcode as a bitmap
            // save로 저장하지 않으면 bitmap형식으로 반환
            barcodeWriter
                .Write("https://www.daum.net")
                .Save(@"C:\Users\jjh\Desktop\img\barimage.bmp");
        }
    }
}
