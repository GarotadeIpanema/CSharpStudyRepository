
namespace BookManagementProgram.RentalControls
{
    partial class AddRentalForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddRentalForm));
            this.label1 = new System.Windows.Forms.Label();
            this.book_no_txt = new System.Windows.Forms.TextBox();
            this.book_select_btn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.book_title_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.book_writer_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.book_description_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.user_no_txt = new System.Windows.Forms.TextBox();
            this.user_select_btn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.user_name_txt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.user_id_txt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.user_grade_txt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.user_registerdate_txt = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.user_address_txt = new System.Windows.Forms.TextBox();
            this.rental_btn = new DevExpress.XtraEditors.SimpleButton();
            this.cancle_btn = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.rental_userno_txt = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.rental_bookno_txt = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.rental_date_txt = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.return_date_txt = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "도서번호";
            // 
            // book_no_txt
            // 
            this.book_no_txt.Location = new System.Drawing.Point(75, 20);
            this.book_no_txt.Name = "book_no_txt";
            this.book_no_txt.Size = new System.Drawing.Size(221, 21);
            this.book_no_txt.TabIndex = 1;
            // 
            // book_select_btn
            // 
            this.book_select_btn.Location = new System.Drawing.Point(302, 20);
            this.book_select_btn.Name = "book_select_btn";
            this.book_select_btn.Size = new System.Drawing.Size(92, 23);
            this.book_select_btn.TabIndex = 2;
            this.book_select_btn.Text = "도서조회";
            this.book_select_btn.UseVisualStyleBackColor = true;
            this.book_select_btn.Click += new System.EventHandler(this.book_select_btn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.book_select_btn);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.book_no_txt);
            this.groupBox1.Controls.Add(this.book_description_txt);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.book_writer_txt);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.book_title_txt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 426);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "도서정보";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(6, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "도서제목";
            // 
            // book_title_txt
            // 
            this.book_title_txt.Location = new System.Drawing.Point(75, 54);
            this.book_title_txt.Name = "book_title_txt";
            this.book_title_txt.ReadOnly = true;
            this.book_title_txt.Size = new System.Drawing.Size(319, 21);
            this.book_title_txt.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(6, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "도서저자";
            // 
            // book_writer_txt
            // 
            this.book_writer_txt.Location = new System.Drawing.Point(75, 83);
            this.book_writer_txt.Name = "book_writer_txt";
            this.book_writer_txt.ReadOnly = true;
            this.book_writer_txt.Size = new System.Drawing.Size(319, 21);
            this.book_writer_txt.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(6, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "도서설명";
            // 
            // book_description_txt
            // 
            this.book_description_txt.Location = new System.Drawing.Point(75, 116);
            this.book_description_txt.Multiline = true;
            this.book_description_txt.Name = "book_description_txt";
            this.book_description_txt.ReadOnly = true;
            this.book_description_txt.Size = new System.Drawing.Size(319, 115);
            this.book_description_txt.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(6, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "이미지";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(75, 246);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(319, 174);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.user_address_txt);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.user_registerdate_txt);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.user_grade_txt);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.user_id_txt);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.user_name_txt);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.user_select_btn);
            this.groupBox2.Controls.Add(this.user_no_txt);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(452, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(413, 231);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "사용자정보";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(6, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "사용자번호";
            // 
            // user_no_txt
            // 
            this.user_no_txt.Location = new System.Drawing.Point(89, 23);
            this.user_no_txt.Name = "user_no_txt";
            this.user_no_txt.Size = new System.Drawing.Size(221, 21);
            this.user_no_txt.TabIndex = 6;
            // 
            // user_select_btn
            // 
            this.user_select_btn.Location = new System.Drawing.Point(316, 23);
            this.user_select_btn.Name = "user_select_btn";
            this.user_select_btn.Size = new System.Drawing.Size(92, 23);
            this.user_select_btn.TabIndex = 7;
            this.user_select_btn.Text = "사용자조회";
            this.user_select_btn.UseVisualStyleBackColor = true;
            this.user_select_btn.Click += new System.EventHandler(this.user_select_btn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(6, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "사용자이름";
            // 
            // user_name_txt
            // 
            this.user_name_txt.Location = new System.Drawing.Point(88, 55);
            this.user_name_txt.Name = "user_name_txt";
            this.user_name_txt.ReadOnly = true;
            this.user_name_txt.Size = new System.Drawing.Size(320, 21);
            this.user_name_txt.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(6, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "아이디";
            // 
            // user_id_txt
            // 
            this.user_id_txt.Location = new System.Drawing.Point(87, 89);
            this.user_id_txt.Name = "user_id_txt";
            this.user_id_txt.ReadOnly = true;
            this.user_id_txt.Size = new System.Drawing.Size(320, 21);
            this.user_id_txt.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.Location = new System.Drawing.Point(6, 128);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "사용자등급";
            // 
            // user_grade_txt
            // 
            this.user_grade_txt.Location = new System.Drawing.Point(89, 126);
            this.user_grade_txt.Name = "user_grade_txt";
            this.user_grade_txt.ReadOnly = true;
            this.user_grade_txt.Size = new System.Drawing.Size(320, 21);
            this.user_grade_txt.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label10.Location = new System.Drawing.Point(6, 164);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "가입날짜";
            // 
            // user_registerdate_txt
            // 
            this.user_registerdate_txt.Location = new System.Drawing.Point(89, 162);
            this.user_registerdate_txt.Name = "user_registerdate_txt";
            this.user_registerdate_txt.ReadOnly = true;
            this.user_registerdate_txt.Size = new System.Drawing.Size(320, 21);
            this.user_registerdate_txt.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label11.Location = new System.Drawing.Point(6, 201);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "사용자주소";
            // 
            // user_address_txt
            // 
            this.user_address_txt.Location = new System.Drawing.Point(89, 199);
            this.user_address_txt.Name = "user_address_txt";
            this.user_address_txt.ReadOnly = true;
            this.user_address_txt.Size = new System.Drawing.Size(320, 21);
            this.user_address_txt.TabIndex = 12;
            // 
            // rental_btn
            // 
            this.rental_btn.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rental_btn.Appearance.Options.UseFont = true;
            this.rental_btn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.rental_btn.Location = new System.Drawing.Point(670, 384);
            this.rental_btn.Name = "rental_btn";
            this.rental_btn.Size = new System.Drawing.Size(92, 54);
            this.rental_btn.TabIndex = 17;
            this.rental_btn.Text = "렌탈";
            this.rental_btn.Click += new System.EventHandler(this.rental_btn_Click);
            // 
            // cancle_btn
            // 
            this.cancle_btn.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancle_btn.Appearance.Options.UseFont = true;
            this.cancle_btn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image1")));
            this.cancle_btn.Location = new System.Drawing.Point(773, 384);
            this.cancle_btn.Name = "cancle_btn";
            this.cancle_btn.Size = new System.Drawing.Size(92, 54);
            this.cancle_btn.TabIndex = 18;
            this.cancle_btn.Text = "취소";
            this.cancle_btn.Click += new System.EventHandler(this.cancle_btn_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.return_date_txt);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.rental_date_txt);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.rental_bookno_txt);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.rental_userno_txt);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Location = new System.Drawing.Point(452, 249);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(413, 129);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "렌탈정보";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label12.Location = new System.Drawing.Point(6, 17);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 13);
            this.label12.TabIndex = 20;
            this.label12.Text = "사용자번호";
            // 
            // rental_userno_txt
            // 
            this.rental_userno_txt.Location = new System.Drawing.Point(89, 15);
            this.rental_userno_txt.Name = "rental_userno_txt";
            this.rental_userno_txt.ReadOnly = true;
            this.rental_userno_txt.Size = new System.Drawing.Size(318, 21);
            this.rental_userno_txt.TabIndex = 13;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label13.Location = new System.Drawing.Point(6, 44);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 13);
            this.label13.TabIndex = 11;
            this.label13.Text = "도서번호";
            // 
            // rental_bookno_txt
            // 
            this.rental_bookno_txt.Location = new System.Drawing.Point(89, 42);
            this.rental_bookno_txt.Name = "rental_bookno_txt";
            this.rental_bookno_txt.ReadOnly = true;
            this.rental_bookno_txt.Size = new System.Drawing.Size(318, 21);
            this.rental_bookno_txt.TabIndex = 14;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label14.Location = new System.Drawing.Point(6, 70);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(49, 13);
            this.label14.TabIndex = 22;
            this.label14.Text = "렌탈일";
            // 
            // rental_date_txt
            // 
            this.rental_date_txt.Location = new System.Drawing.Point(89, 68);
            this.rental_date_txt.Name = "rental_date_txt";
            this.rental_date_txt.ReadOnly = true;
            this.rental_date_txt.Size = new System.Drawing.Size(318, 21);
            this.rental_date_txt.TabIndex = 15;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label15.Location = new System.Drawing.Point(6, 98);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(49, 13);
            this.label15.TabIndex = 24;
            this.label15.Text = "반납일";
            // 
            // return_date_txt
            // 
            this.return_date_txt.Location = new System.Drawing.Point(89, 96);
            this.return_date_txt.Name = "return_date_txt";
            this.return_date_txt.ReadOnly = true;
            this.return_date_txt.Size = new System.Drawing.Size(318, 21);
            this.return_date_txt.TabIndex = 16;
            // 
            // AddRentalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.cancle_btn);
            this.Controls.Add(this.rental_btn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddRentalForm";
            this.Text = "AddRentalForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox book_no_txt;
        private System.Windows.Forms.Button book_select_btn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox book_description_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox book_writer_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox book_title_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox user_address_txt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox user_registerdate_txt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox user_grade_txt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox user_id_txt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox user_name_txt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button user_select_btn;
        private System.Windows.Forms.TextBox user_no_txt;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.SimpleButton rental_btn;
        private DevExpress.XtraEditors.SimpleButton cancle_btn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox return_date_txt;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox rental_date_txt;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox rental_bookno_txt;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox rental_userno_txt;
        private System.Windows.Forms.Label label12;
    }
}