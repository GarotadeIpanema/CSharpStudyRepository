
namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.password_visible_chk = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.id_save_chk = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pw_custom_txt = new WindowsFormsApp1.CustomPlaceholderBorderBottomTextBox();
            this.id_custom_txt = new WindowsFormsApp1.CustomPlaceholderBorderBottomTextBox();
            this.customRoundButton1 = new WindowsFormsApp1.CustomRoundButton();
            this.com_code_txt = new WindowsFormsApp1.CustomPlaceholderBorderBottomTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // password_visible_chk
            // 
            this.password_visible_chk.AutoSize = true;
            this.password_visible_chk.Font = new System.Drawing.Font("Tahoma", 12F);
            this.password_visible_chk.ForeColor = System.Drawing.Color.White;
            this.password_visible_chk.Location = new System.Drawing.Point(246, 286);
            this.password_visible_chk.Name = "password_visible_chk";
            this.password_visible_chk.Size = new System.Drawing.Size(117, 23);
            this.password_visible_chk.TabIndex = 7;
            this.password_visible_chk.Text = "비밀번호 확인";
            this.password_visible_chk.UseVisualStyleBackColor = true;
            this.password_visible_chk.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(57)))), ((int)(((byte)(53)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 450);
            this.panel1.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 30F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(62, 356);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(286, 40);
            this.label3.TabIndex = 10;
            this.label3.Text = "XXXX Program";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 30F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(62, 286);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(288, 40);
            this.label2.TabIndex = 9;
            this.label2.Text = "Welcom to the";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(101, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(206, 192);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(73)))));
            this.panel2.Controls.Add(this.com_code_txt);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.id_save_chk);
            this.panel2.Controls.Add(this.pw_custom_txt);
            this.panel2.Controls.Add(this.id_custom_txt);
            this.panel2.Controls.Add(this.customRoundButton1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.password_visible_chk);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(400, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(400, 450);
            this.panel2.TabIndex = 9;
            // 
            // id_save_chk
            // 
            this.id_save_chk.AutoSize = true;
            this.id_save_chk.Font = new System.Drawing.Font("Tahoma", 12F);
            this.id_save_chk.ForeColor = System.Drawing.Color.White;
            this.id_save_chk.Location = new System.Drawing.Point(114, 286);
            this.id_save_chk.Name = "id_save_chk";
            this.id_save_chk.Size = new System.Drawing.Size(103, 23);
            this.id_save_chk.TabIndex = 17;
            this.id_save_chk.Text = "아이디 저장";
            this.id_save_chk.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 30F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(47, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 40);
            this.label1.TabIndex = 8;
            this.label1.Text = "Login to Access";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Font = new System.Drawing.Font("굴림", 12F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(124, 333);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "아이디 찾기";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5.Font = new System.Drawing.Font("굴림", 12F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(254, 333);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 16);
            this.label5.TabIndex = 18;
            this.label5.Text = "비밀번호 찾기";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // pw_custom_txt
            // 
            this.pw_custom_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(73)))));
            this.pw_custom_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pw_custom_txt.BottomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(57)))), ((int)(((byte)(53)))));
            this.pw_custom_txt.BottomBorderOnFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(57)))), ((int)(((byte)(53)))));
            this.pw_custom_txt.Font = new System.Drawing.Font("굴림", 13F);
            this.pw_custom_txt.ForeColor = System.Drawing.Color.DarkGray;
            this.pw_custom_txt.Location = new System.Drawing.Point(49, 240);
            this.pw_custom_txt.Name = "pw_custom_txt";
            this.pw_custom_txt.Placeholder = "비밀번호를 입력해주세요.";
            this.pw_custom_txt.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.pw_custom_txt.Size = new System.Drawing.Size(303, 21);
            this.pw_custom_txt.TabIndex = 16;
            this.pw_custom_txt.Text = "비밀번호를 입력해주세요.";
            this.pw_custom_txt.WriteColor = System.Drawing.Color.White;
            // 
            // id_custom_txt
            // 
            this.id_custom_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(73)))));
            this.id_custom_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.id_custom_txt.BottomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(57)))), ((int)(((byte)(53)))));
            this.id_custom_txt.BottomBorderOnFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(57)))), ((int)(((byte)(53)))));
            this.id_custom_txt.Font = new System.Drawing.Font("굴림", 13F);
            this.id_custom_txt.ForeColor = System.Drawing.Color.DarkGray;
            this.id_custom_txt.Location = new System.Drawing.Point(49, 191);
            this.id_custom_txt.MaxLength = 20;
            this.id_custom_txt.Name = "id_custom_txt";
            this.id_custom_txt.Placeholder = "아이디를 입력해주세요.";
            this.id_custom_txt.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.id_custom_txt.Size = new System.Drawing.Size(303, 21);
            this.id_custom_txt.TabIndex = 15;
            this.id_custom_txt.Text = "아이디를 입력해주세요.";
            this.id_custom_txt.WriteColor = System.Drawing.Color.White;
            // 
            // customRoundButton1
            // 
            this.customRoundButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(57)))), ((int)(((byte)(53)))));
            this.customRoundButton1.CornerRadius = 40;
            this.customRoundButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.customRoundButton1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(57)))), ((int)(((byte)(53)))));
            this.customRoundButton1.FlatAppearance.BorderSize = 0;
            this.customRoundButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customRoundButton1.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customRoundButton1.ForeColor = System.Drawing.Color.White;
            this.customRoundButton1.Location = new System.Drawing.Point(0, 370);
            this.customRoundButton1.Name = "customRoundButton1";
            this.customRoundButton1.Size = new System.Drawing.Size(260, 40);
            this.customRoundButton1.TabIndex = 12;
            this.customRoundButton1.Text = "로그인";
            this.customRoundButton1.UseVisualStyleBackColor = false;
            this.customRoundButton1.Click += new System.EventHandler(this.customRoundButton1_Click);
            // 
            // com_code_txt
            // 
            this.com_code_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(73)))));
            this.com_code_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.com_code_txt.BottomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(57)))), ((int)(((byte)(53)))));
            this.com_code_txt.BottomBorderOnFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(57)))), ((int)(((byte)(53)))));
            this.com_code_txt.Font = new System.Drawing.Font("굴림", 13F);
            this.com_code_txt.ForeColor = System.Drawing.Color.DarkGray;
            this.com_code_txt.Location = new System.Drawing.Point(49, 138);
            this.com_code_txt.MaxLength = 20;
            this.com_code_txt.Name = "com_code_txt";
            this.com_code_txt.Placeholder = "회사코드를 입력해주세요.";
            this.com_code_txt.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.com_code_txt.Size = new System.Drawing.Size(303, 21);
            this.com_code_txt.TabIndex = 19;
            this.com_code_txt.Text = "회사코드를 입력해주세요.";
            this.com_code_txt.WriteColor = System.Drawing.Color.White;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.CheckBox password_visible_chk;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private CustomRoundButton customRoundButton1;
        private CustomPlaceholderBorderBottomTextBox id_custom_txt;
        private CustomPlaceholderBorderBottomTextBox pw_custom_txt;
        private System.Windows.Forms.CheckBox id_save_chk;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private CustomPlaceholderBorderBottomTextBox com_code_txt;
    }
}

