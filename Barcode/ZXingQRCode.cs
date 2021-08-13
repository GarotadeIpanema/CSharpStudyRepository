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
using ZXing.QrCode.Internal;
using ZXing.Rendering;

namespace Barcode
{
    public partial class ZXingQRCode : Form
    {
        public ZXingQRCode()
        {
            InitializeComponent();
        }

        // qr 생성
        private void button1_Click(object sender, EventArgs e)
        {
            string str = textBox1.Text;
            // instance a writer object
            var barcodeWrite = new BarcodeWriter();
            // set the barcode format
            barcodeWrite.Format = BarcodeFormat.QR_CODE;
            // write text and generate a 2-D barcode as a bitmap
            barcodeWrite
                .Write(str)
                .Save(@"C:\Users\jjh\Desktop\img\generated.bmp");
            /*
            BarcodeWriter barcodeWriter = new BarcodeWriter();

            EncodingOptions encodingOptions = new EncodingOptions() { Width = 300, Height = 300, Margin = 0, PureBarcode = false };

            encodingOptions.Hints.Add(EncodeHintType.ERROR_CORRECTION, ErrorCorrectionLevel.H);

            barcodeWriter.Renderer = new BitmapRenderer();

            barcodeWriter.Options = encodingOptions;

            barcodeWriter.Format = BarcodeFormat.QR_CODE;

            Bitmap bitmap = barcodeWriter.Write(textBox1.Text);

            //Bitmap logo = new Bitmap($"{Application.StartupPath}/");

            Graphics g = Graphics.FromImage(bitmap);

            pictureBox1.Image = bitmap;
            */
        }

        // qr 해석
        private void button2_Click(object sender, EventArgs e)
        {
            //crate a barcode reader instance
            var barcodeReader = new BarcodeReader();
            // create an in memory bitmap
            var barcodeBitmap = (Bitmap)Bitmap.FromFile(@"C:\Users\jjh\Desktop\img\generated.bmp");
            // decode the barcode from the in memory bitmap
            var barcodeResult = barcodeReader.Decode(barcodeBitmap);
            // output result to textbox
            pictureBox1.Image = barcodeBitmap;
            textBox2.Text = $"Decode barcode text : {barcodeResult?.Text}";
            textBox3.Text = $"Barcode format : {barcodeResult?.BarcodeFormat}";
            /*
            BarcodeReader barcodeReader = new BarcodeReader();

            var result = barcodeReader.Decode(new Bitmap(pictureBox1.Image));

            if(result != null)
            {
                textBox2.Text = result.Text;
            }
            */
        }
    }
}
