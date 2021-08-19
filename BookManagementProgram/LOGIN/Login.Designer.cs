
namespace BookManagementProgram.LOGIN
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.gradientPanel1 = new CSharpBasic.GradientPanel();
            this.login_btn = new WindowsFormsApp1.CustomRoundButton();
            this.findPassword_lbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.findId_lbl = new System.Windows.Forms.Label();
            this.showPassword_chk = new System.Windows.Forms.CheckBox();
            this.idSaveCheck_chk = new System.Windows.Forms.CheckBox();
            this.pw_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.id_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.Controls.Add(this.login_btn);
            this.gradientPanel1.Controls.Add(this.findPassword_lbl);
            this.gradientPanel1.Controls.Add(this.label3);
            this.gradientPanel1.Controls.Add(this.findId_lbl);
            this.gradientPanel1.Controls.Add(this.showPassword_chk);
            this.gradientPanel1.Controls.Add(this.idSaveCheck_chk);
            this.gradientPanel1.Controls.Add(this.pw_txt);
            this.gradientPanel1.Controls.Add(this.label2);
            this.gradientPanel1.Controls.Add(this.id_txt);
            this.gradientPanel1.Controls.Add(this.label1);
            this.gradientPanel1.Controls.Add(this.pictureBox1);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanel1.GraColorA = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.gradientPanel1.GraColorB = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.gradientPanel1.GradientFilStyle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.gradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(584, 391);
            this.gradientPanel1.TabIndex = 0;
            this.gradientPanel1.Text = "GradientPanel";
            // 
            // login_btn
            // 
            this.login_btn.BackColor = System.Drawing.Color.White;
            this.login_btn.CornerRadius = 40;
            this.login_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.login_btn.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.login_btn.Location = new System.Drawing.Point(201, 327);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(180, 40);
            this.login_btn.TabIndex = 10;
            this.login_btn.Text = "로그인";
            this.login_btn.UseVisualStyleBackColor = false;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // findPassword_lbl
            // 
            this.findPassword_lbl.AutoSize = true;
            this.findPassword_lbl.BackColor = System.Drawing.Color.Transparent;
            this.findPassword_lbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.findPassword_lbl.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.findPassword_lbl.ForeColor = System.Drawing.Color.White;
            this.findPassword_lbl.Location = new System.Drawing.Point(394, 277);
            this.findPassword_lbl.Name = "findPassword_lbl";
            this.findPassword_lbl.Size = new System.Drawing.Size(96, 13);
            this.findPassword_lbl.TabIndex = 9;
            this.findPassword_lbl.Text = "비밀번호 찾기";
            this.findPassword_lbl.Click += new System.EventHandler(this.findPassword_lbl_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(373, 277);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "|";
            // 
            // findId_lbl
            // 
            this.findId_lbl.AutoSize = true;
            this.findId_lbl.BackColor = System.Drawing.Color.Transparent;
            this.findId_lbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.findId_lbl.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.findId_lbl.ForeColor = System.Drawing.Color.White;
            this.findId_lbl.Location = new System.Drawing.Point(285, 277);
            this.findId_lbl.Name = "findId_lbl";
            this.findId_lbl.Size = new System.Drawing.Size(82, 13);
            this.findId_lbl.TabIndex = 7;
            this.findId_lbl.Text = "아이디 찾기";
            this.findId_lbl.Click += new System.EventHandler(this.findId_lbl_Click);
            // 
            // showPassword_chk
            // 
            this.showPassword_chk.AutoSize = true;
            this.showPassword_chk.BackColor = System.Drawing.Color.Transparent;
            this.showPassword_chk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showPassword_chk.ForeColor = System.Drawing.Color.White;
            this.showPassword_chk.Location = new System.Drawing.Point(179, 277);
            this.showPassword_chk.Name = "showPassword_chk";
            this.showPassword_chk.Size = new System.Drawing.Size(100, 16);
            this.showPassword_chk.TabIndex = 6;
            this.showPassword_chk.Text = "비밀번호 확인";
            this.showPassword_chk.UseVisualStyleBackColor = false;
            this.showPassword_chk.CheckedChanged += new System.EventHandler(this.showPassword_chk_CheckedChanged);
            // 
            // idSaveCheck_chk
            // 
            this.idSaveCheck_chk.AutoSize = true;
            this.idSaveCheck_chk.BackColor = System.Drawing.Color.Transparent;
            this.idSaveCheck_chk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.idSaveCheck_chk.ForeColor = System.Drawing.Color.White;
            this.idSaveCheck_chk.Location = new System.Drawing.Point(85, 277);
            this.idSaveCheck_chk.Name = "idSaveCheck_chk";
            this.idSaveCheck_chk.Size = new System.Drawing.Size(88, 16);
            this.idSaveCheck_chk.TabIndex = 5;
            this.idSaveCheck_chk.Text = "아이디 저장";
            this.idSaveCheck_chk.UseVisualStyleBackColor = false;
            // 
            // pw_txt
            // 
            this.pw_txt.BackColor = System.Drawing.Color.White;
            this.pw_txt.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.pw_txt.Location = new System.Drawing.Point(193, 225);
            this.pw_txt.MaxLength = 20;
            this.pw_txt.Name = "pw_txt";
            this.pw_txt.PasswordChar = '*';
            this.pw_txt.Size = new System.Drawing.Size(297, 26);
            this.pw_txt.TabIndex = 4;
            this.pw_txt.KeyUp += new System.Windows.Forms.KeyEventHandler(this.pw_txt_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(81, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "비밀번호";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // id_txt
            // 
            this.id_txt.BackColor = System.Drawing.Color.White;
            this.id_txt.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.id_txt.Location = new System.Drawing.Point(193, 186);
            this.id_txt.MaxLength = 20;
            this.id_txt.Name = "id_txt";
            this.id_txt.Size = new System.Drawing.Size(297, 26);
            this.id_txt.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(81, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "아이디";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(203, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(178, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(584, 391);
            this.Controls.Add(this.gradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Login";
            this.Text = "로그인";
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CSharpBasic.GradientPanel gradientPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox pw_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox id_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox showPassword_chk;
        private System.Windows.Forms.CheckBox idSaveCheck_chk;
        private System.Windows.Forms.Label findPassword_lbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label findId_lbl;
        private WindowsFormsApp1.CustomRoundButton login_btn;
    }
}