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
    public partial class ImageSaveForm : Form
    {
        public ImageSaveForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "이미지 불러오기";
            openFileDialog.FileName = "";
            openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            textBox1.Text = string.Empty;
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = openFileDialog.FileName;
                pictureBox1.Image = new Bitmap(openFileDialog.FileName);
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string dir = @"C:\Users\jjh\Desktop\mms\BookManagerForm\BookImages";
            Image image = Image.FromFile(textBox1.Text);
            bool bExist = true;
            int fileCount = 0;
            string dirMapPath = string.Empty;
            if (image != null)
            {
                string fileName = textBox1.Text.Split('\\').Last();
                string strName = fileName.Substring(0, fileName.LastIndexOf("."));
                string strExt = fileName.Substring(fileName.LastIndexOf("."));
                while(bExist)
                {
                    dirMapPath = dir;
                    string pathCombine = System.IO.Path.Combine(dirMapPath, fileName);
                    if(System.IO.File.Exists(pathCombine))
                    {
                        fileCount++;
                        fileName = $"{strName}({fileCount}){strExt}";
                    }
                    else
                    {
                        bExist = false;
                    }
                }
                image.Save($@"{dir}\{fileName}");
                MessageBox.Show("이미지 저장이 되었습니다");
            }
        }
    }
}
