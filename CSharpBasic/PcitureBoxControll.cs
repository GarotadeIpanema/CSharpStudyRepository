using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpBasic
{
    public partial class PcitureBoxControll : Form
    {
        public PcitureBoxControll()
        {
            InitializeComponent();

            //  이미지Clip
            // 이미지 소수 갖고 오기
            var src = (Bitmap)Bitmap.FromFile(@"C:\Users\jjh\Downloads\문민승.jpg");

            // 소스 이미지 크기와 동일한 타겟 이미지 생성
            Bitmap tgt = new Bitmap(src.Width, src.Height);

            // 타겟 이미지의 Graphics 객체 얻기
            using (Graphics g = Graphics.FromImage(tgt))
            {
                // 배경색 설정
                var rect = new Rectangle(0, 0, tgt.Width, tgt.Height);
                using (Brush br = new SolidBrush(SystemColors.Control))
                {
                    g.FillRectangle(br, 0, 0, tgt.Width, tgt.Height);
                }

                // 원모양으로 Clip
                GraphicsPath path = new GraphicsPath();
                path.AddEllipse(0, 0, tgt.Width, tgt.Height);
                g.SetClip(path);

                // 소스 이미지를 원모양으로 잘라 타겟 이미지에 출력
                g.DrawImage(src, 0, 0);    
            }
            pictureBox2.Image = tgt;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Bitmap.FromFile(@"C:\Users\jjh\Desktop\img\key.png");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if(pictureBox1.SizeMode == PictureBoxSizeMode.Zoom)
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // 예제(A) : 이미지 파일 저장
            Bitmap bmp = (Bitmap)pictureBox1.Image;
            bmp.Save(@"C:\Users\jjh\Desktop\img\output.png", ImageFormat.Png);

            // 파일이 아니라 외부로 송신하거나 데이타베이스 등에 저장한다면, 이미지를 바이트 배열로 변환할 필요가 있다
            ImageConverter converter = new ImageConverter();
            byte[] imageBytes = (byte[])converter.ConvertTo(pictureBox1.Image, typeof(byte[]));
            MessageBox.Show(imageBytes.Length.ToString());
        }
    }
}
