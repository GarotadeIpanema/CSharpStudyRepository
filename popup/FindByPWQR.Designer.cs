
namespace popup
{
    partial class Form4
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.id_lbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.password_txt = new System.Windows.Forms.TextBox();
            this.auth_txt = new System.Windows.Forms.TextBox();
            this.id_txt = new System.Windows.Forms.TextBox();
            this.spend_auth_btn = new System.Windows.Forms.Button();
            this.change_password_btn = new System.Windows.Forms.Button();
            this.close_btn = new System.Windows.Forms.Button();
            this.check_auth_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(412, 100);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // id_lbl
            // 
            this.id_lbl.AutoSize = true;
            this.id_lbl.Location = new System.Drawing.Point(12, 35);
            this.id_lbl.Name = "id_lbl";
            this.id_lbl.Size = new System.Drawing.Size(41, 12);
            this.id_lbl.TabIndex = 1;
            this.id_lbl.Text = "아이디";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "인증번호";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "변경할 비밀번호";
            // 
            // password_txt
            // 
            this.password_txt.Location = new System.Drawing.Point(134, 100);
            this.password_txt.Name = "password_txt";
            this.password_txt.ReadOnly = true;
            this.password_txt.Size = new System.Drawing.Size(254, 21);
            this.password_txt.TabIndex = 4;
            // 
            // auth_txt
            // 
            this.auth_txt.Location = new System.Drawing.Point(134, 63);
            this.auth_txt.Name = "auth_txt";
            this.auth_txt.Size = new System.Drawing.Size(254, 21);
            this.auth_txt.TabIndex = 2;
            // 
            // id_txt
            // 
            this.id_txt.Location = new System.Drawing.Point(134, 26);
            this.id_txt.Name = "id_txt";
            this.id_txt.Size = new System.Drawing.Size(254, 21);
            this.id_txt.TabIndex = 0;
            // 
            // spend_auth_btn
            // 
            this.spend_auth_btn.Location = new System.Drawing.Point(416, 26);
            this.spend_auth_btn.Name = "spend_auth_btn";
            this.spend_auth_btn.Size = new System.Drawing.Size(96, 23);
            this.spend_auth_btn.TabIndex = 1;
            this.spend_auth_btn.Text = "인증번호 전송";
            this.spend_auth_btn.UseVisualStyleBackColor = true;
            this.spend_auth_btn.Click += new System.EventHandler(this.spend_auth_btn_Click);
            // 
            // change_password_btn
            // 
            this.change_password_btn.Location = new System.Drawing.Point(134, 163);
            this.change_password_btn.Name = "change_password_btn";
            this.change_password_btn.Size = new System.Drawing.Size(110, 23);
            this.change_password_btn.TabIndex = 5;
            this.change_password_btn.Text = "비밀번호 변경";
            this.change_password_btn.UseVisualStyleBackColor = true;
            this.change_password_btn.Click += new System.EventHandler(this.change_password_btn_Click);
            // 
            // close_btn
            // 
            this.close_btn.Location = new System.Drawing.Point(313, 163);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(75, 23);
            this.close_btn.TabIndex = 6;
            this.close_btn.Text = "닫기";
            this.close_btn.UseVisualStyleBackColor = true;
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // check_auth_btn
            // 
            this.check_auth_btn.Location = new System.Drawing.Point(416, 61);
            this.check_auth_btn.Name = "check_auth_btn";
            this.check_auth_btn.Size = new System.Drawing.Size(96, 23);
            this.check_auth_btn.TabIndex = 3;
            this.check_auth_btn.Text = "인증번호 확인";
            this.check_auth_btn.UseVisualStyleBackColor = true;
            this.check_auth_btn.Click += new System.EventHandler(this.check_auth_btn_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 225);
            this.Controls.Add(this.check_auth_btn);
            this.Controls.Add(this.close_btn);
            this.Controls.Add(this.change_password_btn);
            this.Controls.Add(this.spend_auth_btn);
            this.Controls.Add(this.id_txt);
            this.Controls.Add(this.auth_txt);
            this.Controls.Add(this.password_txt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.id_lbl);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form4";
            this.Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label id_lbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox password_txt;
        private System.Windows.Forms.TextBox auth_txt;
        private System.Windows.Forms.TextBox id_txt;
        private System.Windows.Forms.Button spend_auth_btn;
        private System.Windows.Forms.Button change_password_btn;
        private System.Windows.Forms.Button close_btn;
        private System.Windows.Forms.Button check_auth_btn;
    }
}