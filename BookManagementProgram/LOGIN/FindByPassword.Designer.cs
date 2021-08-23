
namespace BookManagementProgram.XtraForm
{
    partial class FindByPassword
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
            this.memberNumber_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.memberID_txt = new System.Windows.Forms.TextBox();
            this.authenticationRequest_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.memberEmail_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.authenticationNumber_txt = new System.Windows.Forms.TextBox();
            this.checkAuthentication_btn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.newPassword_txt = new System.Windows.Forms.TextBox();
            this.changePassword_btn = new System.Windows.Forms.Button();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.timer_lbl = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "회원번호";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // memberNumber_txt
            // 
            this.memberNumber_txt.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.memberNumber_txt.Location = new System.Drawing.Point(163, 20);
            this.memberNumber_txt.Name = "memberNumber_txt";
            this.memberNumber_txt.Size = new System.Drawing.Size(360, 26);
            this.memberNumber_txt.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "아이디";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // memberID_txt
            // 
            this.memberID_txt.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.memberID_txt.Location = new System.Drawing.Point(163, 54);
            this.memberID_txt.Name = "memberID_txt";
            this.memberID_txt.Size = new System.Drawing.Size(360, 26);
            this.memberID_txt.TabIndex = 2;
            // 
            // authenticationRequest_btn
            // 
            this.authenticationRequest_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.authenticationRequest_btn.Location = new System.Drawing.Point(448, 86);
            this.authenticationRequest_btn.Name = "authenticationRequest_btn";
            this.authenticationRequest_btn.Size = new System.Drawing.Size(75, 26);
            this.authenticationRequest_btn.TabIndex = 4;
            this.authenticationRequest_btn.Text = "인증번호";
            this.authenticationRequest_btn.UseVisualStyleBackColor = true;
            this.authenticationRequest_btn.Click += new System.EventHandler(this.authenticationRequest_btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(12, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "이메일";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // memberEmail_txt
            // 
            this.memberEmail_txt.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.memberEmail_txt.Location = new System.Drawing.Point(163, 86);
            this.memberEmail_txt.Name = "memberEmail_txt";
            this.memberEmail_txt.Size = new System.Drawing.Size(279, 26);
            this.memberEmail_txt.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(12, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "인증번호";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // authenticationNumber_txt
            // 
            this.authenticationNumber_txt.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.authenticationNumber_txt.Location = new System.Drawing.Point(163, 118);
            this.authenticationNumber_txt.Name = "authenticationNumber_txt";
            this.authenticationNumber_txt.Size = new System.Drawing.Size(279, 26);
            this.authenticationNumber_txt.TabIndex = 5;
            // 
            // checkAuthentication_btn
            // 
            this.checkAuthentication_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkAuthentication_btn.Location = new System.Drawing.Point(448, 120);
            this.checkAuthentication_btn.Name = "checkAuthentication_btn";
            this.checkAuthentication_btn.Size = new System.Drawing.Size(75, 26);
            this.checkAuthentication_btn.TabIndex = 6;
            this.checkAuthentication_btn.Text = "번호확인";
            this.checkAuthentication_btn.UseVisualStyleBackColor = true;
            this.checkAuthentication_btn.Click += new System.EventHandler(this.checkAuthentication_btn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(12, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "변경할 비밀번호 :";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // newPassword_txt
            // 
            this.newPassword_txt.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.newPassword_txt.Location = new System.Drawing.Point(163, 155);
            this.newPassword_txt.Name = "newPassword_txt";
            this.newPassword_txt.ReadOnly = true;
            this.newPassword_txt.Size = new System.Drawing.Size(360, 26);
            this.newPassword_txt.TabIndex = 7;
            // 
            // changePassword_btn
            // 
            this.changePassword_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.changePassword_btn.Location = new System.Drawing.Point(15, 193);
            this.changePassword_btn.Name = "changePassword_btn";
            this.changePassword_btn.Size = new System.Drawing.Size(227, 26);
            this.changePassword_btn.TabIndex = 8;
            this.changePassword_btn.Text = "비밀번호 변경";
            this.changePassword_btn.UseVisualStyleBackColor = true;
            this.changePassword_btn.Click += new System.EventHandler(this.changePassword_btn_Click);
            // 
            // cancel_btn
            // 
            this.cancel_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancel_btn.Location = new System.Drawing.Point(248, 193);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(228, 26);
            this.cancel_btn.TabIndex = 9;
            this.cancel_btn.Text = "취소";
            this.cancel_btn.UseVisualStyleBackColor = true;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // timer_lbl
            // 
            this.timer_lbl.AutoSize = true;
            this.timer_lbl.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.timer_lbl.Location = new System.Drawing.Point(482, 196);
            this.timer_lbl.Name = "timer_lbl";
            this.timer_lbl.Size = new System.Drawing.Size(26, 16);
            this.timer_lbl.TabIndex = 14;
            this.timer_lbl.Text = "60";
            // 
            // FindByPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 233);
            this.Controls.Add(this.timer_lbl);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.changePassword_btn);
            this.Controls.Add(this.newPassword_txt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.checkAuthentication_btn);
            this.Controls.Add(this.authenticationNumber_txt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.memberEmail_txt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.authenticationRequest_btn);
            this.Controls.Add(this.memberID_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.memberNumber_txt);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FindByPassword";
            this.Text = "FindByPassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox memberNumber_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox memberID_txt;
        private System.Windows.Forms.Button authenticationRequest_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox memberEmail_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox authenticationNumber_txt;
        private System.Windows.Forms.Button checkAuthentication_btn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox newPassword_txt;
        private System.Windows.Forms.Button changePassword_btn;
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.Label timer_lbl;
        private System.Windows.Forms.Timer timer1;
    }
}