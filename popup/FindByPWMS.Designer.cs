
namespace popup
{
    partial class FindByPWMS
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.id_txt = new System.Windows.Forms.TextBox();
            this.email_txt = new System.Windows.Forms.TextBox();
            this.auth_txt = new System.Windows.Forms.TextBox();
            this.new_password_txt = new System.Windows.Forms.TextBox();
            this.auth_btn = new System.Windows.Forms.Button();
            this.auth_check_btn = new System.Windows.Forms.Button();
            this.change_password_btn = new System.Windows.Forms.Button();
            this.cancle_btn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer_lbl = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.phone_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.send_grid_btn = new System.Windows.Forms.Button();
            this.sendgrid_txt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.naverbtn = new System.Windows.Forms.Button();
            this.navertxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "아이디";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "Gmail";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "인증번호";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "변경 할 비밀번호";
            // 
            // id_txt
            // 
            this.id_txt.Location = new System.Drawing.Point(114, 10);
            this.id_txt.Name = "id_txt";
            this.id_txt.Size = new System.Drawing.Size(223, 21);
            this.id_txt.TabIndex = 0;
            // 
            // email_txt
            // 
            this.email_txt.Location = new System.Drawing.Point(114, 51);
            this.email_txt.Name = "email_txt";
            this.email_txt.Size = new System.Drawing.Size(223, 21);
            this.email_txt.TabIndex = 1;
            // 
            // auth_txt
            // 
            this.auth_txt.Location = new System.Drawing.Point(114, 202);
            this.auth_txt.Name = "auth_txt";
            this.auth_txt.Size = new System.Drawing.Size(223, 21);
            this.auth_txt.TabIndex = 3;
            // 
            // new_password_txt
            // 
            this.new_password_txt.Location = new System.Drawing.Point(114, 238);
            this.new_password_txt.Name = "new_password_txt";
            this.new_password_txt.ReadOnly = true;
            this.new_password_txt.Size = new System.Drawing.Size(223, 21);
            this.new_password_txt.TabIndex = 5;
            // 
            // auth_btn
            // 
            this.auth_btn.Location = new System.Drawing.Point(343, 49);
            this.auth_btn.Name = "auth_btn";
            this.auth_btn.Size = new System.Drawing.Size(99, 23);
            this.auth_btn.TabIndex = 2;
            this.auth_btn.Text = "인증번호 전송";
            this.auth_btn.UseVisualStyleBackColor = true;
            this.auth_btn.Click += new System.EventHandler(this.auth_btn_Click);
            // 
            // auth_check_btn
            // 
            this.auth_check_btn.Location = new System.Drawing.Point(343, 200);
            this.auth_check_btn.Name = "auth_check_btn";
            this.auth_check_btn.Size = new System.Drawing.Size(99, 23);
            this.auth_check_btn.TabIndex = 4;
            this.auth_check_btn.Text = "인증번호 확인";
            this.auth_check_btn.UseVisualStyleBackColor = true;
            this.auth_check_btn.Click += new System.EventHandler(this.auth_check_btn_Click);
            // 
            // change_password_btn
            // 
            this.change_password_btn.Location = new System.Drawing.Point(114, 274);
            this.change_password_btn.Name = "change_password_btn";
            this.change_password_btn.Size = new System.Drawing.Size(109, 23);
            this.change_password_btn.TabIndex = 6;
            this.change_password_btn.Text = "비밀번호 변경";
            this.change_password_btn.UseVisualStyleBackColor = true;
            this.change_password_btn.Click += new System.EventHandler(this.change_password_btn_Click);
            // 
            // cancle_btn
            // 
            this.cancle_btn.Location = new System.Drawing.Point(262, 274);
            this.cancle_btn.Name = "cancle_btn";
            this.cancle_btn.Size = new System.Drawing.Size(75, 23);
            this.cancle_btn.TabIndex = 7;
            this.cancle_btn.Text = "닫기";
            this.cancle_btn.UseVisualStyleBackColor = true;
            this.cancle_btn.Click += new System.EventHandler(this.cancle_btn_Click);
            // 
            // timer_lbl
            // 
            this.timer_lbl.AutoSize = true;
            this.timer_lbl.Location = new System.Drawing.Point(343, 241);
            this.timer_lbl.Name = "timer_lbl";
            this.timer_lbl.Size = new System.Drawing.Size(0, 12);
            this.timer_lbl.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(343, 106);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "인증번호 전송";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // phone_txt
            // 
            this.phone_txt.Location = new System.Drawing.Point(114, 108);
            this.phone_txt.Name = "phone_txt";
            this.phone_txt.Size = new System.Drawing.Size(223, 21);
            this.phone_txt.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "twilo";
            // 
            // send_grid_btn
            // 
            this.send_grid_btn.Location = new System.Drawing.Point(343, 151);
            this.send_grid_btn.Name = "send_grid_btn";
            this.send_grid_btn.Size = new System.Drawing.Size(99, 23);
            this.send_grid_btn.TabIndex = 14;
            this.send_grid_btn.Text = "인증번호 전송";
            this.send_grid_btn.UseVisualStyleBackColor = true;
            this.send_grid_btn.Click += new System.EventHandler(this.send_grid_btn_Click);
            // 
            // sendgrid_txt
            // 
            this.sendgrid_txt.Location = new System.Drawing.Point(114, 153);
            this.sendgrid_txt.Name = "sendgrid_txt";
            this.sendgrid_txt.Size = new System.Drawing.Size(223, 21);
            this.sendgrid_txt.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 12);
            this.label6.TabIndex = 13;
            this.label6.Text = "sendgrid";
            // 
            // naverbtn
            // 
            this.naverbtn.Location = new System.Drawing.Point(343, 76);
            this.naverbtn.Name = "naverbtn";
            this.naverbtn.Size = new System.Drawing.Size(99, 23);
            this.naverbtn.TabIndex = 17;
            this.naverbtn.Text = "인증번호 전송";
            this.naverbtn.UseVisualStyleBackColor = true;
            this.naverbtn.Click += new System.EventHandler(this.naverbtn_Click);
            // 
            // navertxt
            // 
            this.navertxt.Location = new System.Drawing.Point(114, 78);
            this.navertxt.Name = "navertxt";
            this.navertxt.Size = new System.Drawing.Size(223, 21);
            this.navertxt.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 12);
            this.label7.TabIndex = 16;
            this.label7.Text = "Naver";
            // 
            // FindByPWMS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 379);
            this.Controls.Add(this.naverbtn);
            this.Controls.Add(this.navertxt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.send_grid_btn);
            this.Controls.Add(this.sendgrid_txt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.phone_txt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.timer_lbl);
            this.Controls.Add(this.cancle_btn);
            this.Controls.Add(this.change_password_btn);
            this.Controls.Add(this.auth_check_btn);
            this.Controls.Add(this.auth_btn);
            this.Controls.Add(this.new_password_txt);
            this.Controls.Add(this.auth_txt);
            this.Controls.Add(this.email_txt);
            this.Controls.Add(this.id_txt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FindByPWMS";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox id_txt;
        private System.Windows.Forms.TextBox email_txt;
        private System.Windows.Forms.TextBox auth_txt;
        private System.Windows.Forms.TextBox new_password_txt;
        private System.Windows.Forms.Button auth_btn;
        private System.Windows.Forms.Button auth_check_btn;
        private System.Windows.Forms.Button change_password_btn;
        private System.Windows.Forms.Button cancle_btn;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label timer_lbl;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox phone_txt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button send_grid_btn;
        private System.Windows.Forms.TextBox sendgrid_txt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button naverbtn;
        private System.Windows.Forms.TextBox navertxt;
        private System.Windows.Forms.Label label7;
    }
}