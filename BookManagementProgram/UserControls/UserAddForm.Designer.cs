
namespace BookManagementProgram.UserControls
{
    partial class UserAddForm
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
            this.user_name_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.user_address_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.user_birth_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.user_id_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.user_password_txt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.user_auth_cmb = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.user_grade_cmb = new System.Windows.Forms.ComboBox();
            this.auth_btn = new System.Windows.Forms.Button();
            this.auth_check_btn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.user_phone_txt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.auth_number_txt = new System.Windows.Forms.TextBox();
            this.add_user_btn = new System.Windows.Forms.Button();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.timer_lbl = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(22, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "성함";
            // 
            // user_name_txt
            // 
            this.user_name_txt.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.user_name_txt.Location = new System.Drawing.Point(91, 15);
            this.user_name_txt.MaxLength = 20;
            this.user_name_txt.Name = "user_name_txt";
            this.user_name_txt.Size = new System.Drawing.Size(329, 22);
            this.user_name_txt.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(22, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "주소";
            // 
            // user_address_txt
            // 
            this.user_address_txt.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.user_address_txt.Location = new System.Drawing.Point(91, 57);
            this.user_address_txt.MaxLength = 20;
            this.user_address_txt.Name = "user_address_txt";
            this.user_address_txt.Size = new System.Drawing.Size(329, 22);
            this.user_address_txt.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(22, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "생년월일";
            // 
            // user_birth_txt
            // 
            this.user_birth_txt.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.user_birth_txt.Location = new System.Drawing.Point(91, 96);
            this.user_birth_txt.MaxLength = 20;
            this.user_birth_txt.Name = "user_birth_txt";
            this.user_birth_txt.Size = new System.Drawing.Size(329, 22);
            this.user_birth_txt.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(22, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "아이디";
            // 
            // user_id_txt
            // 
            this.user_id_txt.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.user_id_txt.Location = new System.Drawing.Point(91, 141);
            this.user_id_txt.MaxLength = 20;
            this.user_id_txt.Name = "user_id_txt";
            this.user_id_txt.Size = new System.Drawing.Size(329, 22);
            this.user_id_txt.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(22, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "비밀번호";
            // 
            // user_password_txt
            // 
            this.user_password_txt.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.user_password_txt.Location = new System.Drawing.Point(91, 186);
            this.user_password_txt.MaxLength = 20;
            this.user_password_txt.Name = "user_password_txt";
            this.user_password_txt.Size = new System.Drawing.Size(329, 22);
            this.user_password_txt.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(22, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "권한";
            // 
            // user_auth_cmb
            // 
            this.user_auth_cmb.FormattingEnabled = true;
            this.user_auth_cmb.Location = new System.Drawing.Point(91, 228);
            this.user_auth_cmb.Name = "user_auth_cmb";
            this.user_auth_cmb.Size = new System.Drawing.Size(329, 20);
            this.user_auth_cmb.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(22, 276);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "등급";
            // 
            // user_grade_cmb
            // 
            this.user_grade_cmb.FormattingEnabled = true;
            this.user_grade_cmb.Location = new System.Drawing.Point(91, 274);
            this.user_grade_cmb.Name = "user_grade_cmb";
            this.user_grade_cmb.Size = new System.Drawing.Size(329, 20);
            this.user_grade_cmb.TabIndex = 13;
            // 
            // auth_btn
            // 
            this.auth_btn.Location = new System.Drawing.Point(333, 312);
            this.auth_btn.Name = "auth_btn";
            this.auth_btn.Size = new System.Drawing.Size(87, 23);
            this.auth_btn.TabIndex = 15;
            this.auth_btn.Text = "인증번호";
            this.auth_btn.UseVisualStyleBackColor = true;
            this.auth_btn.Click += new System.EventHandler(this.auth_btn_Click);
            // 
            // auth_check_btn
            // 
            this.auth_check_btn.Location = new System.Drawing.Point(333, 356);
            this.auth_check_btn.Name = "auth_check_btn";
            this.auth_check_btn.Size = new System.Drawing.Size(87, 22);
            this.auth_check_btn.TabIndex = 17;
            this.auth_check_btn.Text = "확인";
            this.auth_check_btn.UseVisualStyleBackColor = true;
            this.auth_check_btn.Click += new System.EventHandler(this.auth_check_btn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(22, 315);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "휴대폰";
            // 
            // user_phone_txt
            // 
            this.user_phone_txt.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.user_phone_txt.Location = new System.Drawing.Point(91, 312);
            this.user_phone_txt.MaxLength = 20;
            this.user_phone_txt.Name = "user_phone_txt";
            this.user_phone_txt.Size = new System.Drawing.Size(236, 22);
            this.user_phone_txt.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.Location = new System.Drawing.Point(22, 359);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "인증번호";
            // 
            // auth_number_txt
            // 
            this.auth_number_txt.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.auth_number_txt.Location = new System.Drawing.Point(91, 356);
            this.auth_number_txt.MaxLength = 20;
            this.auth_number_txt.Name = "auth_number_txt";
            this.auth_number_txt.Size = new System.Drawing.Size(236, 22);
            this.auth_number_txt.TabIndex = 16;
            // 
            // add_user_btn
            // 
            this.add_user_btn.Enabled = false;
            this.add_user_btn.Location = new System.Drawing.Point(25, 399);
            this.add_user_btn.Name = "add_user_btn";
            this.add_user_btn.Size = new System.Drawing.Size(161, 38);
            this.add_user_btn.TabIndex = 18;
            this.add_user_btn.Text = "회원등록";
            this.add_user_btn.UseVisualStyleBackColor = true;
            this.add_user_btn.Click += new System.EventHandler(this.add_user_btn_Click);
            // 
            // cancel_btn
            // 
            this.cancel_btn.Location = new System.Drawing.Point(192, 399);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(161, 38);
            this.cancel_btn.TabIndex = 19;
            this.cancel_btn.Text = "취소";
            this.cancel_btn.UseVisualStyleBackColor = true;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // timer_lbl
            // 
            this.timer_lbl.AutoSize = true;
            this.timer_lbl.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.timer_lbl.Location = new System.Drawing.Point(374, 406);
            this.timer_lbl.Name = "timer_lbl";
            this.timer_lbl.Size = new System.Drawing.Size(31, 19);
            this.timer_lbl.TabIndex = 22;
            this.timer_lbl.Text = "60";
            // 
            // UserAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 455);
            this.Controls.Add(this.timer_lbl);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.add_user_btn);
            this.Controls.Add(this.auth_number_txt);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.user_phone_txt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.auth_check_btn);
            this.Controls.Add(this.auth_btn);
            this.Controls.Add(this.user_grade_cmb);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.user_auth_cmb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.user_password_txt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.user_id_txt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.user_birth_txt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.user_address_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.user_name_txt);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "UserAddForm";
            this.Text = "UserAddForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox user_name_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox user_address_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox user_birth_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox user_id_txt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox user_password_txt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox user_auth_cmb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox user_grade_cmb;
        private System.Windows.Forms.Button auth_btn;
        private System.Windows.Forms.Button auth_check_btn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox user_phone_txt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox auth_number_txt;
        private System.Windows.Forms.Button add_user_btn;
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.Label timer_lbl;
        private System.Windows.Forms.Timer timer1;
    }
}