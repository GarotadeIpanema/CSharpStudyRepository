using DevExpress.XtraNavBar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpBasic
{
    public partial class FTPManager : Form
    {
        private bool result = false;

        private FTPClass fTP = null;

        public FTPManager()
        {
            InitializeComponent();
            fTP = new FTPClass();
            FTPIpAddrTxt.Focus();

            if(Properties.Settings.Default.FtpSaveInfo)
            {
                FTPIpAddrTxt.Text = Properties.Settings.Default.FtpIpAddress;
                FTPPortTxt.Text = Properties.Settings.Default.FtpPort;
                FTPUserIdTxt.Text = Properties.Settings.Default.FtpUserId;
                FTPUserPwTxt.Text = Properties.Settings.Default.FtpUserPw;
                saveFtpInfo.Checked = Properties.Settings.Default.FtpSaveInfo;
            }
        }

        // FTP 연결 버튼 및 메뉴 생성
        private void ConnectionBtn_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(FTPIpAddrTxt.Text))
            {
                MessageBox.Show("IP를 입력해주세요.");
                FTPIpAddrTxt.Focus();
                return;
            }
            if (string.IsNullOrEmpty(FTPPortTxt.Text))
            {
                MessageBox.Show("PORT를 입력해주세요.");
                FTPPortTxt.Focus();
                return;
            }
            if (string.IsNullOrEmpty(FTPUserIdTxt.Text))
            {
                MessageBox.Show("아이디를 입력해주세요.");
                FTPUserIdTxt.Focus();
                return;
            }
            if (string.IsNullOrEmpty(FTPUserPwTxt.Text))
            {
                MessageBox.Show("비밀번호를 입력해주세요.");
                FTPUserPwTxt.Focus();
                return;
            }
            if(saveFtpInfo.Checked)
            {
                Properties.Settings.Default.FtpIpAddress = FTPIpAddrTxt.Text;
                Properties.Settings.Default.FtpPort = FTPPortTxt.Text;
                Properties.Settings.Default.FtpUserId = FTPUserIdTxt.Text;
                Properties.Settings.Default.FtpUserPw = FTPUserPwTxt.Text;
                Properties.Settings.Default.FtpSaveInfo = true;
            }
            else
            {
                Properties.Settings.Default.FtpSaveInfo = false;
            }
            Properties.Settings.Default.Save();

            result = fTP.ConnectToServer(FTPIpAddrTxt.Text, FTPPortTxt.Text, FTPUserIdTxt.Text, FTPUserPwTxt.Text);

            if (!result)
            {
                MessageBox.Show("FTP 접속 실패하였습니다, 정보를 확인해주세요.");
                return;
            }
                
            MessageBox.Show("FTP 접속 성공");
            ResetMenuBar();
        }

        // menu item선택 이벤트
        private void NavBarItem_CLick(object sender, NavBarLinkEventArgs e)
        {
            NavBarItem item = (NavBarItem)sender;

            string Folder = item.Hint.Substring(0, item.Hint.Length-1);
            string File = (string.IsNullOrEmpty(item.Caption) || item.Caption.Equals("EMPTY")) ? "" : $"/{item.Caption}";

            saveDirPath.Text = Folder;
            saveFilePath.Text = File.Replace("/","");

            deleteFilePath.Text = $"{Folder}{File}";
        }

        // download 버튼
        // https://afsdzvcx123.tistory.com/entry/C-FTP-C-FTP-%EC%A0%91%EC%86%8D-%EB%B0%8F-%ED%8C%8C%EC%9D%BC-%EB%8B%A4%EC%9A%B4%EB%A1%9C%EB%93%9C?category=784688
        private void DownloadBtn_Click(object sender, EventArgs e)
        {
            if(!result)
            {
                MessageBox.Show("FTP 접속부터 진행해주세요.");
                return;
            }
            if(string.IsNullOrEmpty(saveDirPath.Text) || string.IsNullOrEmpty(saveFilePath.Text))
            {
                MessageBox.Show("내려받을 파일을 메뉴에서 선택해주세요.");
                return;
            }

            SaveFileDialog save = new SaveFileDialog();
            save.FileName = saveFilePath.Text;

            if(save.ShowDialog() == DialogResult.OK)
            {
                string serverPath = $@"{saveDirPath.Text}{saveFilePath.Text}";
                // string localPath = @"C:\Users\jjh\Desktop\img\_Dest\test.txt";
                string localPath = save.FileName;
                if (fTP.DownLoad(localPath, serverPath))
                {
                    MessageBox.Show("다운로드 성공");
                }
                else
                {
                    MessageBox.Show("다운로드 실패, 파일명을 입력하셨나요?");
                }
            }

        }

        private void openFileTxt_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if(open.ShowDialog() == DialogResult.OK)
            {
                openFileTxt.Text = open.FileName;
            }
        }

        // 업로드 버튼
        private void UploadBtn_Click(object sender, EventArgs e)
        {
            if(!result)
            {
                MessageBox.Show("FTP 연결을 먼저 진행해주세요.");
                return;
            }
            if(openFileTxt.Text.Equals("Click choise File") || string.IsNullOrEmpty(openFileTxt.Text))
            {
                MessageBox.Show("업로드할 파일을 선택해주세요.");
                return;
            }
            if (string.IsNullOrEmpty(uploadFolderTxt.Text) || !Regex.IsMatch(uploadFolderTxt.Text, @"(\/|\\){1}[a-zA-Z0-9ㄱ-ㅎ가-힣]+$")) 
            {
                MessageBox.Show("업로드할 위치를 입력해주세요.\n(/폴더, /폴더/폴더 형식으로 입력해주세요.)");
                return;
            }
            string fileName = openFileTxt.Text;
            string path = uploadFolderTxt.Text.Replace('\\','/'); // 업로드할 파일 저장할 FTP 경로 지정

            if (fTP.UpLoad(path, fileName) == false) // 파일 업로드
            {
                MessageBox.Show("FTP Upload 실패");
            }
            else
            {
                MessageBox.Show("FTP Upload시작");
                MessageBox.Show("FTP Upload완료");
                ResetMenuBar();
            }
            /*
            // 기준 경로의 모든 파일을 업로드 할 때 사용
            string localPath = @"C:\Users\jjh\Desktop\"; // 바탕화면 경로를 기준으로 둔다
            DirectoryInfo dirinfo = new DirectoryInfo(localPath);
            FileInfo[] infos = dirinfo.GetFiles();
            foreach (FileInfo info in infos)
            {
                if (Path.GetExtension(info.FullName) == ".txt") // txt 확장자 파일만 FTP 서버에 Upload
                {
                    if (fTP.UpLoad(path, info.FullName) == false) // 파일 업로드
                    {
                        MessageBox.Show("FTP Upload 실패");
                    }
                    else
                    {
                        MessageBox.Show("FTP Upload시작");
                        MessageBox.Show("FTP Upload완료");
                    }

                }
            }
            */
        }

        // navBar Menu 새로고침
        private void ResetMenuBar()
        {
            if (!result)
            {
                MessageBox.Show("FTP 연결부터 해주세요");
                return;
            }

            navBarControl1.Groups.Clear();

            List<DirectoryPath> directoryPaths = fTP.GetFTPList("/").OrderBy(item => item.Folder).ToList();

            NavBarGroup navBarGroup = null;
            NavBarItem navBarItem = null;

            foreach (DirectoryPath directory in directoryPaths)
            {
                if (navBarControl1.Groups.Any(item => item.Caption == directory.Folder))
                {
                    navBarItem = new NavBarItem();
                    navBarItem.Caption = directory.File;
                    navBarControl1.Groups[navBarControl1.Groups.Count - 1].ItemLinks.Add(navBarItem);
                }
                else
                {
                    navBarGroup = new NavBarGroup();
                    navBarGroup.Caption = directory.Folder;
                    navBarItem = new NavBarItem();
                    navBarItem.Caption = directory.File;
                    navBarGroup.ItemLinks.Add(navBarItem);
                    navBarControl1.Groups.Add(navBarGroup);
                }
                navBarItem.Hint = directory.Folder;
                navBarItem.LinkClicked += NavBarItem_CLick;
                // MessageBox.Show($"폴더 : {directory.Folder}, 파일 : {directory.File}");
            }
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            ResetMenuBar();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // FTP 파일 삭제
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(deleteFilePath.Text))
            {
                MessageBox.Show("삭제할 파일을 선택해주세요.");
                return;
            }
            string msg  = fTP.DeleteFTPFile(deleteFilePath.Text) ? "삭제 되었습니다." : "삭제 실패하였습니다.";
            ResetMenuBar();
            MessageBox.Show(msg);
        }
    }
}
