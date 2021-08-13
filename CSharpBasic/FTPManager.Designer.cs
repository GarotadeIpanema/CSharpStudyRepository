
namespace CSharpBasic
{
    partial class FTPManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FTPManager));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.saveFtpInfo = new System.Windows.Forms.CheckBox();
            this.ConnectionBtn = new System.Windows.Forms.Button();
            this.FTPUserPwTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.FTPUserIdTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.FTPPortTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.FTPIpAddrTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.saveDirPath = new System.Windows.Forms.TextBox();
            this.DownloadBtn = new System.Windows.Forms.Button();
            this.saveFilePath = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.uploadFolderTxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.UploadBtn = new System.Windows.Forms.Button();
            this.openFileTxt = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            this.panel3 = new System.Windows.Forms.Panel();
            this.closeBtn = new DevExpress.XtraEditors.SimpleButton();
            this.resetBtn = new DevExpress.XtraEditors.SimpleButton();
            this.label9 = new System.Windows.Forms.Label();
            this.deleteFilePath = new System.Windows.Forms.TextBox();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.saveFtpInfo);
            this.panel1.Controls.Add(this.ConnectionBtn);
            this.panel1.Controls.Add(this.FTPUserPwTxt);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.FTPUserIdTxt);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.FTPPortTxt);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.FTPIpAddrTxt);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(794, 75);
            this.panel1.TabIndex = 0;
            // 
            // saveFtpInfo
            // 
            this.saveFtpInfo.AutoSize = true;
            this.saveFtpInfo.Location = new System.Drawing.Point(654, 48);
            this.saveFtpInfo.Name = "saveFtpInfo";
            this.saveFtpInfo.Size = new System.Drawing.Size(131, 16);
            this.saveFtpInfo.TabIndex = 9;
            this.saveFtpInfo.Text = "FTP 접속 정보 저장";
            this.saveFtpInfo.UseVisualStyleBackColor = true;
            // 
            // ConnectionBtn
            // 
            this.ConnectionBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ConnectionBtn.Location = new System.Drawing.Point(672, 14);
            this.ConnectionBtn.Name = "ConnectionBtn";
            this.ConnectionBtn.Size = new System.Drawing.Size(113, 23);
            this.ConnectionBtn.TabIndex = 8;
            this.ConnectionBtn.Text = "FTPConnection";
            this.ConnectionBtn.UseVisualStyleBackColor = true;
            this.ConnectionBtn.Click += new System.EventHandler(this.ConnectionBtn_Click);
            // 
            // FTPUserPwTxt
            // 
            this.FTPUserPwTxt.Location = new System.Drawing.Point(545, 16);
            this.FTPUserPwTxt.Name = "FTPUserPwTxt";
            this.FTPUserPwTxt.Size = new System.Drawing.Size(100, 21);
            this.FTPUserPwTxt.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(490, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "UserPW";
            // 
            // FTPUserIdTxt
            // 
            this.FTPUserIdTxt.Location = new System.Drawing.Point(363, 16);
            this.FTPUserIdTxt.Name = "FTPUserIdTxt";
            this.FTPUserIdTxt.Size = new System.Drawing.Size(100, 21);
            this.FTPUserIdTxt.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(315, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "UserID";
            // 
            // FTPPortTxt
            // 
            this.FTPPortTxt.Location = new System.Drawing.Point(196, 16);
            this.FTPPortTxt.Name = "FTPPortTxt";
            this.FTPPortTxt.Size = new System.Drawing.Size(100, 21);
            this.FTPPortTxt.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(152, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "PORT";
            // 
            // FTPIpAddrTxt
            // 
            this.FTPIpAddrTxt.Location = new System.Drawing.Point(32, 16);
            this.FTPIpAddrTxt.Name = "FTPIpAddrTxt";
            this.FTPIpAddrTxt.Size = new System.Drawing.Size(100, 21);
            this.FTPIpAddrTxt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel2.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.groupBox3, 0, 0);
            this.tableLayoutPanel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 84);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(794, 363);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.groupBox4);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(161, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(630, 357);
            this.panel2.TabIndex = 1;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.DeleteBtn);
            this.groupBox4.Controls.Add(this.deleteFilePath);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox4.Location = new System.Drawing.Point(0, 200);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(630, 70);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "groupBox4";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.saveDirPath);
            this.groupBox2.Controls.Add(this.DownloadBtn);
            this.groupBox2.Controls.Add(this.saveFilePath);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 100);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(630, 100);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "FTP 다운로드";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 12);
            this.label6.TabIndex = 6;
            this.label6.Text = "FTP 다운로드 폴더 경로";
            // 
            // saveDirPath
            // 
            this.saveDirPath.Location = new System.Drawing.Point(148, 29);
            this.saveDirPath.Name = "saveDirPath";
            this.saveDirPath.ReadOnly = true;
            this.saveDirPath.Size = new System.Drawing.Size(476, 21);
            this.saveDirPath.TabIndex = 1;
            // 
            // DownloadBtn
            // 
            this.DownloadBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DownloadBtn.Location = new System.Drawing.Point(511, 62);
            this.DownloadBtn.Name = "DownloadBtn";
            this.DownloadBtn.Size = new System.Drawing.Size(113, 21);
            this.DownloadBtn.TabIndex = 0;
            this.DownloadBtn.Text = "Download";
            this.DownloadBtn.UseVisualStyleBackColor = true;
            this.DownloadBtn.Click += new System.EventHandler(this.DownloadBtn_Click);
            // 
            // saveFilePath
            // 
            this.saveFilePath.Location = new System.Drawing.Point(148, 63);
            this.saveFilePath.Name = "saveFilePath";
            this.saveFilePath.ReadOnly = true;
            this.saveFilePath.Size = new System.Drawing.Size(357, 21);
            this.saveFilePath.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 12);
            this.label7.TabIndex = 7;
            this.label7.Text = "FTP 다운로드 파일 경로";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.uploadFolderTxt);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.UploadBtn);
            this.groupBox1.Controls.Add(this.openFileTxt);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(630, 100);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "FTP 업로드";
            // 
            // uploadFolderTxt
            // 
            this.uploadFolderTxt.Location = new System.Drawing.Point(132, 27);
            this.uploadFolderTxt.Name = "uploadFolderTxt";
            this.uploadFolderTxt.Size = new System.Drawing.Size(492, 21);
            this.uploadFolderTxt.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 12);
            this.label8.TabIndex = 8;
            this.label8.Text = "FTP 업로드 경로";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 12);
            this.label5.TabIndex = 5;
            this.label5.Text = "사용자 업로드 파일";
            // 
            // UploadBtn
            // 
            this.UploadBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UploadBtn.Location = new System.Drawing.Point(511, 60);
            this.UploadBtn.Name = "UploadBtn";
            this.UploadBtn.Size = new System.Drawing.Size(113, 21);
            this.UploadBtn.TabIndex = 4;
            this.UploadBtn.Text = "Upload";
            this.UploadBtn.UseVisualStyleBackColor = true;
            this.UploadBtn.Click += new System.EventHandler(this.UploadBtn_Click);
            // 
            // openFileTxt
            // 
            this.openFileTxt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.openFileTxt.Location = new System.Drawing.Point(132, 60);
            this.openFileTxt.Name = "openFileTxt";
            this.openFileTxt.ReadOnly = true;
            this.openFileTxt.Size = new System.Drawing.Size(373, 21);
            this.openFileTxt.TabIndex = 3;
            this.openFileTxt.Text = "Click choise File";
            this.openFileTxt.Click += new System.EventHandler(this.openFileTxt_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.navBarControl1);
            this.groupBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(152, 357);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "FTP FILE LIST";
            // 
            // navBarControl1
            // 
            this.navBarControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navBarControl1.Location = new System.Drawing.Point(3, 17);
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.OptionsNavPane.ExpandedWidth = 146;
            this.navBarControl1.Size = new System.Drawing.Size(146, 337);
            this.navBarControl1.TabIndex = 0;
            this.navBarControl1.Text = "navBarControl1";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.closeBtn);
            this.panel3.Controls.Add(this.resetBtn);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 270);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(630, 87);
            this.panel3.TabIndex = 15;
            // 
            // closeBtn
            // 
            this.closeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("closeBtn.ImageOptions.Image")));
            this.closeBtn.Location = new System.Drawing.Point(528, 31);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(93, 34);
            this.closeBtn.TabIndex = 18;
            this.closeBtn.Text = "종료";
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // resetBtn
            // 
            this.resetBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.resetBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resetBtn.ImageOptions.Image")));
            this.resetBtn.Location = new System.Drawing.Point(429, 31);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(93, 34);
            this.resetBtn.TabIndex = 17;
            this.resetBtn.Text = "새로고침";
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 12);
            this.label9.TabIndex = 8;
            this.label9.Text = "FTP 삭제할 파일 경로";
            // 
            // deleteFilePath
            // 
            this.deleteFilePath.Location = new System.Drawing.Point(148, 20);
            this.deleteFilePath.Name = "deleteFilePath";
            this.deleteFilePath.ReadOnly = true;
            this.deleteFilePath.Size = new System.Drawing.Size(357, 21);
            this.deleteFilePath.TabIndex = 8;
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteBtn.Location = new System.Drawing.Point(511, 19);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(113, 21);
            this.DeleteBtn.TabIndex = 8;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // FTPManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FTPManager";
            this.Text = "FTPManager";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ConnectionBtn;
        private System.Windows.Forms.TextBox FTPUserPwTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox FTPUserIdTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox FTPPortTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox FTPIpAddrTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button DownloadBtn;
        private System.Windows.Forms.TextBox saveFilePath;
        private System.Windows.Forms.TextBox saveDirPath;
        private System.Windows.Forms.Button UploadBtn;
        private System.Windows.Forms.TextBox openFileTxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox uploadFolderTxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private DevExpress.XtraNavBar.NavBarControl navBarControl1;
        private System.Windows.Forms.CheckBox saveFtpInfo;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraEditors.SimpleButton closeBtn;
        private DevExpress.XtraEditors.SimpleButton resetBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.TextBox deleteFilePath;
        private System.Windows.Forms.Label label9;
    }
}