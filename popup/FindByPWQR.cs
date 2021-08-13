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

namespace popup
{
    public partial class Form4 : Form
    {
        private string _auth = null;

        public Form4()
        {
            InitializeComponent();
        }

        private void spend_auth_btn_Click(object sender, EventArgs e)
        {
            _auth = GetRandomCode();

            // instance a writer object
            var barcodeWrite = new BarcodeWriter
            {
                Format = BarcodeFormat.QR_CODE,
                Options =
                {
                    Width = 100,
                    Height = 100,
                    PureBarcode = true
                }
            };
            
            // write text and generate a 2-D barcode as a bitmap
            var bitmap = barcodeWrite
                .Write(_auth);
            pictureBox1.Image = bitmap;
        }

        private void check_auth_btn_Click(object sender, EventArgs e)
        {
            if (auth_txt.Text.Equals(_auth))
            {
                MessageBox.Show("성공");
                password_txt.ReadOnly = false;
                password_txt.Focus();
                return;
            }
            MessageBox.Show("다시확인해보세요");
        }

        private void change_password_btn_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(id_txt.Text) && !string.IsNullOrEmpty(password_txt.Text))
            {
                MessageBox.Show("성공");
                return;
            }
            MessageBox.Show("아이디와 비밀번호를 제대로 작성해주십시오");
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // 랜덤 코드 생성
        private string GetRandomCode()
        {
            Random rand = new Random();
            string input = "abcdefghijklmnopqrstuvxyz0123456789";

            var chars = Enumerable.Range(0, 6).Select(x => input[rand.Next(0, input.Length)]);

            return new string(chars.ToArray());
        }
    }
}
