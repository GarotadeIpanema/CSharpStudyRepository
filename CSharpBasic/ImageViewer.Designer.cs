
namespace CSharpBasic
{
    partial class ImageViewer
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
            this.uiTlp_Main = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.uiLab_Folder = new System.Windows.Forms.Label();
            this.uiTxt_Folder = new System.Windows.Forms.TextBox();
            this.uiBtn_Load = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.uiLab_ImgFile = new System.Windows.Forms.Label();
            this.uiTxt_ImgFile = new System.Windows.Forms.TextBox();
            this.uiTlp_Sub = new System.Windows.Forms.TableLayoutPanel();
            this.uiFlp_Thumnail = new System.Windows.Forms.FlowLayoutPanel();
            this.uiPic_Main = new System.Windows.Forms.PictureBox();
            this.uiTlp_Main.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.uiTlp_Sub.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiPic_Main)).BeginInit();
            this.SuspendLayout();
            // 
            // uiTlp_Main
            // 
            this.uiTlp_Main.ColumnCount = 1;
            this.uiTlp_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.uiTlp_Main.Controls.Add(this.panel1, 0, 0);
            this.uiTlp_Main.Controls.Add(this.panel2, 0, 1);
            this.uiTlp_Main.Controls.Add(this.uiTlp_Sub, 0, 2);
            this.uiTlp_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiTlp_Main.Location = new System.Drawing.Point(0, 0);
            this.uiTlp_Main.Name = "uiTlp_Main";
            this.uiTlp_Main.RowCount = 3;
            this.uiTlp_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.uiTlp_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.uiTlp_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.uiTlp_Main.Size = new System.Drawing.Size(800, 450);
            this.uiTlp_Main.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.uiBtn_Load);
            this.panel1.Controls.Add(this.uiTxt_Folder);
            this.panel1.Controls.Add(this.uiLab_Folder);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(794, 61);
            this.panel1.TabIndex = 0;
            // 
            // uiLab_Folder
            // 
            this.uiLab_Folder.AutoSize = true;
            this.uiLab_Folder.Location = new System.Drawing.Point(20, 24);
            this.uiLab_Folder.Name = "uiLab_Folder";
            this.uiLab_Folder.Size = new System.Drawing.Size(40, 12);
            this.uiLab_Folder.TabIndex = 0;
            this.uiLab_Folder.Text = "Folder";
            // 
            // uiTxt_Folder
            // 
            this.uiTxt_Folder.Location = new System.Drawing.Point(98, 21);
            this.uiTxt_Folder.Name = "uiTxt_Folder";
            this.uiTxt_Folder.Size = new System.Drawing.Size(606, 21);
            this.uiTxt_Folder.TabIndex = 1;
            // 
            // uiBtn_Load
            // 
            this.uiBtn_Load.Location = new System.Drawing.Point(710, 19);
            this.uiBtn_Load.Name = "uiBtn_Load";
            this.uiBtn_Load.Size = new System.Drawing.Size(75, 23);
            this.uiBtn_Load.TabIndex = 2;
            this.uiBtn_Load.Text = "button1";
            this.uiBtn_Load.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.uiTxt_ImgFile);
            this.panel2.Controls.Add(this.uiLab_ImgFile);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 70);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(794, 61);
            this.panel2.TabIndex = 1;
            // 
            // uiLab_ImgFile
            // 
            this.uiLab_ImgFile.AutoSize = true;
            this.uiLab_ImgFile.Location = new System.Drawing.Point(22, 23);
            this.uiLab_ImgFile.Name = "uiLab_ImgFile";
            this.uiLab_ImgFile.Size = new System.Drawing.Size(63, 12);
            this.uiLab_ImgFile.TabIndex = 0;
            this.uiLab_ImgFile.Text = "File Name";
            // 
            // uiTxt_ImgFile
            // 
            this.uiTxt_ImgFile.Location = new System.Drawing.Point(98, 20);
            this.uiTxt_ImgFile.Name = "uiTxt_ImgFile";
            this.uiTxt_ImgFile.Size = new System.Drawing.Size(687, 21);
            this.uiTxt_ImgFile.TabIndex = 2;
            // 
            // uiTlp_Sub
            // 
            this.uiTlp_Sub.ColumnCount = 2;
            this.uiTlp_Sub.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.uiTlp_Sub.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.uiTlp_Sub.Controls.Add(this.uiFlp_Thumnail, 0, 0);
            this.uiTlp_Sub.Controls.Add(this.uiPic_Main, 1, 0);
            this.uiTlp_Sub.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiTlp_Sub.Location = new System.Drawing.Point(3, 137);
            this.uiTlp_Sub.Name = "uiTlp_Sub";
            this.uiTlp_Sub.RowCount = 1;
            this.uiTlp_Sub.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.uiTlp_Sub.Size = new System.Drawing.Size(794, 310);
            this.uiTlp_Sub.TabIndex = 2;
            // 
            // uiFlp_Thumnail
            // 
            this.uiFlp_Thumnail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiFlp_Thumnail.Location = new System.Drawing.Point(3, 3);
            this.uiFlp_Thumnail.Name = "uiFlp_Thumnail";
            this.uiFlp_Thumnail.Size = new System.Drawing.Size(152, 304);
            this.uiFlp_Thumnail.TabIndex = 0;
            // 
            // uiPic_Main
            // 
            this.uiPic_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPic_Main.Location = new System.Drawing.Point(161, 3);
            this.uiPic_Main.Name = "uiPic_Main";
            this.uiPic_Main.Size = new System.Drawing.Size(630, 304);
            this.uiPic_Main.TabIndex = 1;
            this.uiPic_Main.TabStop = false;
            // 
            // ImageViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.uiTlp_Main);
            this.Name = "ImageViewer";
            this.Text = "ImageViewer";
            this.uiTlp_Main.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.uiTlp_Sub.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uiPic_Main)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel uiTlp_Main;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button uiBtn_Load;
        private System.Windows.Forms.TextBox uiTxt_Folder;
        private System.Windows.Forms.Label uiLab_Folder;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox uiTxt_ImgFile;
        private System.Windows.Forms.Label uiLab_ImgFile;
        private System.Windows.Forms.TableLayoutPanel uiTlp_Sub;
        private System.Windows.Forms.FlowLayoutPanel uiFlp_Thumnail;
        private System.Windows.Forms.PictureBox uiPic_Main;
    }
}