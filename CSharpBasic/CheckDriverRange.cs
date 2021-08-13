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
    public partial class CheckDriverRange : Form
    {
        public CheckDriverRange()
        {
            InitializeComponent();

            this.Load += Test_Load;
        }

        private void Test_Load(object sender, EventArgs e)
        {
            GetDriverSize();
        }

        private void GetDriverSize()
        {
            DriveInfo[] drives = DriveInfo.GetDrives();

            foreach(DriveInfo drive in drives)
            {
                if(drive.DriveType == DriveType.Fixed)
                {
                    if (drive.Name.Contains("C"))
                    {
                        SetDriveSize(drive, progressBar1, label1, label2);
                    }
                    else
                    {
                        SetDriveSize(drive, progressBar2, label3, label4);
                    }
                }
            }
        }

        private void SetDriveSize(DriveInfo drive, ProgressBar progressBar1, Label label1, Label label2)
        {
            string driveName = string.Empty;
            string totalSize = string.Empty;
            string freeSize = string.Empty;
            string usage = string.Empty;

            try
            {
                driveName = drive.Name.Substring(0, 1).ToString();
                totalSize = Convert.ToInt32(drive.TotalSize / 1024 / 1024 / 1024).ToString(); // 전체사이즈
                freeSize = Convert.ToInt32(drive.AvailableFreeSpace / 1024 / 1024 / 1024).ToString();
                usage = (Convert.ToInt32(totalSize) - Convert.ToInt32(freeSize)).ToString();

                progressBar1.Maximum = Convert.ToInt32(totalSize);
                progressBar1.Value = Convert.ToInt32(usage);

                label1.Text = $"Disk {driveName}";
                label1.AutoSize = true;

                label2.Text = $"{totalSize}GB of {freeSize}GB avaliable.";
                label2.AutoSize = true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
