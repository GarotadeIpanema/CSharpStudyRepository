using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpBasic
{
    public partial class ImageViewer : Form
    {
        List<string> imgList = null;

        public ImageViewer()
        {
            InitializeComponent();

            this.uiBtn_Load.Click += LoadBtnClick;
        }

        private void LoadBtnClick(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if(fbd.ShowDialog() == DialogResult.OK)
            {
                uiTxt_Folder.Text = fbd.SelectedPath;

                uiFlp_Thumnail.Controls.Clear();

                string[] files = Directory.GetFiles(fbd.SelectedPath);
                imgList = files.Where(x => x.IndexOf(".jpg", StringComparison.OrdinalIgnoreCase) >= 0 
                                            || x.IndexOf(".png", StringComparison.OrdinalIgnoreCase) >= 0)
                                            .Select(x => x).ToList();

                for (int i = 0; i < imgList.Count; i++)
                {
                    Image img = Image.FromFile(imgList[i]);

                    Panel pPanel = new Panel();
                    pPanel.BackColor = Color.Black;
                    pPanel.Size = new Size(150, 150);
                    pPanel.Padding = new System.Windows.Forms.Padding(4);

                    PictureBox pbox = new PictureBox();
                    pbox.BackColor = Color.DimGray;
                    pbox.Dock = DockStyle.Fill;
                    pbox.SizeMode = PictureBoxSizeMode.Zoom;
                    // GetThumbnailImage, 이 Image의 축소판 그림을 반환
                    // Image.GetThumbnailImage(Int32, Int32, Image+GetThumbnailImageAbort, IntPtr) 메서드
                    // IntPtr, 포인터나 핸들을 나타내는 데 사용되는 플랫폼별 형식
                    // IntPtr.Zero, 0으로 초기화된 포인터나 핸들을 나타내는 읽기 전용 필드
                    pbox.Image = img.GetThumbnailImage(150, 150, null, IntPtr.Zero);
                    pbox.Click += PBox_Click;
                    pbox.Tag = i.ToString();
                    pPanel.Controls.Add(pbox);

                    uiFlp_Thumnail.Controls.Add(pPanel);
                }
            }
        }

        private void PBox_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < uiFlp_Thumnail.Controls.Count; i++)
            {
                if(uiFlp_Thumnail.Controls[i] is Panel)
                {
                    Panel pnl = uiFlp_Thumnail.Controls[i] as Panel;
                    pnl.BackColor = Color.Black;
                }
            }

            PictureBox pb = sender as PictureBox;
            pb.Parent.BackColor = Color.Red;

            int idx = Convert.ToInt32(pb.Tag.ToString());

            Image img = Image.FromFile(imgList[idx]);
            uiPic_Main.Image = img;
            uiPic_Main.SizeMode = PictureBoxSizeMode.StretchImage;
            uiTxt_ImgFile.Text = imgList[idx];
        }
    }
}
