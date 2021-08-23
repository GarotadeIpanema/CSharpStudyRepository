
namespace BookManagementProgram.UserControls
{
    partial class UserSearchForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserSearchForm));
            this.label1 = new System.Windows.Forms.Label();
            this.user_no_txt = new System.Windows.Forms.TextBox();
            this.user_select_btn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.user_grade_cmb = new System.Windows.Forms.ComboBox();
            this.user_auth_cmb = new System.Windows.Forms.ComboBox();
            this.user_deregisterdate_txt = new System.Windows.Forms.TextBox();
            this.user_registerdate_txt = new System.Windows.Forms.TextBox();
            this.user_id_txt = new System.Windows.Forms.TextBox();
            this.user_birth_txt = new System.Windows.Forms.TextBox();
            this.user_address_txt = new System.Windows.Forms.TextBox();
            this.user_name_txt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.user_update_btn = new DevExpress.XtraEditors.SimpleButton();
            this.user_delete_btn = new DevExpress.XtraEditors.SimpleButton();
            this.cancel_btn = new DevExpress.XtraEditors.SimpleButton();
            this.reset_btn = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "사용자번호";
            // 
            // user_no_txt
            // 
            this.user_no_txt.Font = new System.Drawing.Font("굴림", 10F);
            this.user_no_txt.Location = new System.Drawing.Point(95, 16);
            this.user_no_txt.Name = "user_no_txt";
            this.user_no_txt.Size = new System.Drawing.Size(279, 23);
            this.user_no_txt.TabIndex = 1;
            // 
            // user_select_btn
            // 
            this.user_select_btn.Location = new System.Drawing.Point(380, 16);
            this.user_select_btn.Name = "user_select_btn";
            this.user_select_btn.Size = new System.Drawing.Size(88, 23);
            this.user_select_btn.TabIndex = 2;
            this.user_select_btn.Text = "조회";
            this.user_select_btn.UseVisualStyleBackColor = true;
            this.user_select_btn.Click += new System.EventHandler(this.user_select_btn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.user_grade_cmb);
            this.groupBox1.Controls.Add(this.user_auth_cmb);
            this.groupBox1.Controls.Add(this.user_deregisterdate_txt);
            this.groupBox1.Controls.Add(this.user_registerdate_txt);
            this.groupBox1.Controls.Add(this.user_id_txt);
            this.groupBox1.Controls.Add(this.user_birth_txt);
            this.groupBox1.Controls.Add(this.user_address_txt);
            this.groupBox1.Controls.Add(this.user_name_txt);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(456, 341);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "사용자 정보";
            // 
            // user_grade_cmb
            // 
            this.user_grade_cmb.Font = new System.Drawing.Font("굴림", 10F);
            this.user_grade_cmb.FormattingEnabled = true;
            this.user_grade_cmb.Location = new System.Drawing.Point(89, 303);
            this.user_grade_cmb.Name = "user_grade_cmb";
            this.user_grade_cmb.Size = new System.Drawing.Size(361, 21);
            this.user_grade_cmb.TabIndex = 21;
            // 
            // user_auth_cmb
            // 
            this.user_auth_cmb.Font = new System.Drawing.Font("굴림", 10F);
            this.user_auth_cmb.FormattingEnabled = true;
            this.user_auth_cmb.Location = new System.Drawing.Point(89, 269);
            this.user_auth_cmb.Name = "user_auth_cmb";
            this.user_auth_cmb.Size = new System.Drawing.Size(361, 21);
            this.user_auth_cmb.TabIndex = 20;
            // 
            // user_deregisterdate_txt
            // 
            this.user_deregisterdate_txt.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.user_deregisterdate_txt.Location = new System.Drawing.Point(89, 226);
            this.user_deregisterdate_txt.Name = "user_deregisterdate_txt";
            this.user_deregisterdate_txt.ReadOnly = true;
            this.user_deregisterdate_txt.Size = new System.Drawing.Size(361, 22);
            this.user_deregisterdate_txt.TabIndex = 19;
            // 
            // user_registerdate_txt
            // 
            this.user_registerdate_txt.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.user_registerdate_txt.Location = new System.Drawing.Point(89, 187);
            this.user_registerdate_txt.Name = "user_registerdate_txt";
            this.user_registerdate_txt.ReadOnly = true;
            this.user_registerdate_txt.Size = new System.Drawing.Size(361, 22);
            this.user_registerdate_txt.TabIndex = 18;
            // 
            // user_id_txt
            // 
            this.user_id_txt.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.user_id_txt.Location = new System.Drawing.Point(89, 148);
            this.user_id_txt.Name = "user_id_txt";
            this.user_id_txt.Size = new System.Drawing.Size(361, 22);
            this.user_id_txt.TabIndex = 16;
            // 
            // user_birth_txt
            // 
            this.user_birth_txt.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.user_birth_txt.Location = new System.Drawing.Point(89, 107);
            this.user_birth_txt.Name = "user_birth_txt";
            this.user_birth_txt.Size = new System.Drawing.Size(361, 22);
            this.user_birth_txt.TabIndex = 15;
            // 
            // user_address_txt
            // 
            this.user_address_txt.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.user_address_txt.Location = new System.Drawing.Point(89, 69);
            this.user_address_txt.Name = "user_address_txt";
            this.user_address_txt.Size = new System.Drawing.Size(361, 22);
            this.user_address_txt.TabIndex = 14;
            // 
            // user_name_txt
            // 
            this.user_name_txt.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.user_name_txt.Location = new System.Drawing.Point(89, 34);
            this.user_name_txt.Name = "user_name_txt";
            this.user_name_txt.Size = new System.Drawing.Size(361, 22);
            this.user_name_txt.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label10.Location = new System.Drawing.Point(6, 306);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "등급";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.Location = new System.Drawing.Point(6, 272);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "권한";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(6, 229);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "탈퇴일";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(6, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "가입일";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(6, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "아이디";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(6, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "생년월일";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(6, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "사용자주소";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(6, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "사용자이름";
            // 
            // user_update_btn
            // 
            this.user_update_btn.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_update_btn.Appearance.Options.UseFont = true;
            this.user_update_btn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("user_update_btn.ImageOptions.Image")));
            this.user_update_btn.Location = new System.Drawing.Point(12, 393);
            this.user_update_btn.Name = "user_update_btn";
            this.user_update_btn.Size = new System.Drawing.Size(110, 46);
            this.user_update_btn.TabIndex = 4;
            this.user_update_btn.Text = "수정";
            this.user_update_btn.Click += new System.EventHandler(this.user_update_btn_Click);
            // 
            // user_delete_btn
            // 
            this.user_delete_btn.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_delete_btn.Appearance.Options.UseFont = true;
            this.user_delete_btn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("user_delete_btn.ImageOptions.Image")));
            this.user_delete_btn.Location = new System.Drawing.Point(128, 393);
            this.user_delete_btn.Name = "user_delete_btn";
            this.user_delete_btn.Size = new System.Drawing.Size(110, 46);
            this.user_delete_btn.TabIndex = 5;
            this.user_delete_btn.Text = "삭제";
            this.user_delete_btn.Click += new System.EventHandler(this.user_delete_btn_Click);
            // 
            // cancel_btn
            // 
            this.cancel_btn.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel_btn.Appearance.Options.UseFont = true;
            this.cancel_btn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cancel_btn.ImageOptions.Image")));
            this.cancel_btn.Location = new System.Drawing.Point(358, 393);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(110, 46);
            this.cancel_btn.TabIndex = 6;
            this.cancel_btn.Text = "취소";
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // reset_btn
            // 
            this.reset_btn.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reset_btn.Appearance.Options.UseFont = true;
            this.reset_btn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("reset_btn.ImageOptions.Image")));
            this.reset_btn.Location = new System.Drawing.Point(242, 393);
            this.reset_btn.Name = "reset_btn";
            this.reset_btn.Size = new System.Drawing.Size(110, 46);
            this.reset_btn.TabIndex = 7;
            this.reset_btn.Text = "초기화";
            this.reset_btn.Click += new System.EventHandler(this.reset_btn_Click);
            // 
            // UserSearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 450);
            this.Controls.Add(this.reset_btn);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.user_delete_btn);
            this.Controls.Add(this.user_update_btn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.user_select_btn);
            this.Controls.Add(this.user_no_txt);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "UserSearchForm";
            this.Text = "UserSearchForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox user_no_txt;
        private System.Windows.Forms.Button user_select_btn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SimpleButton user_update_btn;
        private System.Windows.Forms.ComboBox user_grade_cmb;
        private System.Windows.Forms.ComboBox user_auth_cmb;
        private System.Windows.Forms.TextBox user_deregisterdate_txt;
        private System.Windows.Forms.TextBox user_registerdate_txt;
        private System.Windows.Forms.TextBox user_id_txt;
        private System.Windows.Forms.TextBox user_birth_txt;
        private System.Windows.Forms.TextBox user_address_txt;
        private System.Windows.Forms.TextBox user_name_txt;
        private DevExpress.XtraEditors.SimpleButton user_delete_btn;
        private DevExpress.XtraEditors.SimpleButton cancel_btn;
        private DevExpress.XtraEditors.SimpleButton reset_btn;
    }
}