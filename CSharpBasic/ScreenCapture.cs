using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpBasic
{
    public partial class ScreenCapture : Form
    {
        public ScreenCapture()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Thread.Sleep(500);

            SendKeys.Send("{PRTSC}");
            Image img = Clipboard.GetImage();

            pictureBox1.Image = img;

            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Jpeg Image | *.jpg | Bitmap Image | *.bmp";
            saveFileDialog.Title = "Save Image";
            saveFileDialog.ShowDialog();

            if(saveFileDialog.FileName != null) {
                System.IO.FileStream fs = (System.IO.FileStream)saveFileDialog.OpenFile();

                switch(saveFileDialog.FilterIndex)
                {
                    case 1:
                        pictureBox1.Image.Save(fs, System.Drawing.Imaging.ImageFormat.Jpeg);
                        break;
                    case 2:
                        pictureBox1.Image.Save(fs, System.Drawing.Imaging.ImageFormat.Bmp);
                        break;
                }

                fs.Close();
            }
        }
    }
}
