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
    public partial class iTextSharpBarcode : Form
    {
        public iTextSharpBarcode()
        {
            InitializeComponent();
        }

        private void CreateBarcode(string code)
        {
            Barcode39 barcode39 = new Barcode39(); // Barcode39 인스턴스 생성
            barcode39.Code = code; // Code 프로퍼티에 바코드에 출력될 스트링을 대입
            barcode39.BarHeight = 50f; // 바코드의 높이 지정
            barcode39.CreateDrawingImage(Color.Black, Color.White).Save(@"C:\Users\jjh\Desktop\mms\_Src\barcode.png"); // 바코드 이미지 저장
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string code = textBox1.Text;
            CreateBarcode(code);
        }
    }
}
