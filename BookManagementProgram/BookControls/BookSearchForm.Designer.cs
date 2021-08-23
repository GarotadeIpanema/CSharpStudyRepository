
namespace BookManagementProgram.BookControls
{
    partial class BookSearchForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookSearchForm));
            this.label1 = new System.Windows.Forms.Label();
            this.book_no_txt = new System.Windows.Forms.TextBox();
            this.search_btn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.book_date_txt = new System.Windows.Forms.TextBox();
            this.book_pages_txt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.book_company_txt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.book_price_txt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.book_description_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.book_category_cmb = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.book_writer_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.book_title_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.image_btn = new System.Windows.Forms.Button();
            this.book_image_txt = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.book_state_cmb = new System.Windows.Forms.ComboBox();
            this.book_location_cmb = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cancel_btn = new DevExpress.XtraEditors.SimpleButton();
            this.reset_btn = new DevExpress.XtraEditors.SimpleButton();
            this.delete_btn = new DevExpress.XtraEditors.SimpleButton();
            this.add_btn = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "도서 번호";
            // 
            // book_no_txt
            // 
            this.book_no_txt.Font = new System.Drawing.Font("굴림", 10F);
            this.book_no_txt.Location = new System.Drawing.Point(86, 11);
            this.book_no_txt.Name = "book_no_txt";
            this.book_no_txt.Size = new System.Drawing.Size(621, 23);
            this.book_no_txt.TabIndex = 1;
            // 
            // search_btn
            // 
            this.search_btn.Font = new System.Drawing.Font("굴림", 10F);
            this.search_btn.Location = new System.Drawing.Point(713, 9);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(75, 23);
            this.search_btn.TabIndex = 2;
            this.search_btn.Text = "조회";
            this.search_btn.UseVisualStyleBackColor = true;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.book_date_txt);
            this.groupBox1.Controls.Add(this.book_pages_txt);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.book_company_txt);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.book_price_txt);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.book_description_txt);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.book_category_cmb);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.book_writer_txt);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.book_title_txt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(15, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(425, 400);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "도서정보";
            // 
            // book_date_txt
            // 
            this.book_date_txt.Font = new System.Drawing.Font("굴림", 10F);
            this.book_date_txt.Location = new System.Drawing.Point(75, 335);
            this.book_date_txt.Name = "book_date_txt";
            this.book_date_txt.Size = new System.Drawing.Size(344, 23);
            this.book_date_txt.TabIndex = 16;
            // 
            // book_pages_txt
            // 
            this.book_pages_txt.Font = new System.Drawing.Font("굴림", 10F);
            this.book_pages_txt.Location = new System.Drawing.Point(75, 369);
            this.book_pages_txt.Name = "book_pages_txt";
            this.book_pages_txt.Size = new System.Drawing.Size(344, 23);
            this.book_pages_txt.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(6, 338);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "출판날짜";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.Location = new System.Drawing.Point(6, 372);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "페이지수";
            // 
            // book_company_txt
            // 
            this.book_company_txt.Font = new System.Drawing.Font("굴림", 10F);
            this.book_company_txt.Location = new System.Drawing.Point(75, 302);
            this.book_company_txt.Name = "book_company_txt";
            this.book_company_txt.Size = new System.Drawing.Size(344, 23);
            this.book_company_txt.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(6, 305);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "출판회사";
            // 
            // book_price_txt
            // 
            this.book_price_txt.Font = new System.Drawing.Font("굴림", 10F);
            this.book_price_txt.Location = new System.Drawing.Point(75, 267);
            this.book_price_txt.Name = "book_price_txt";
            this.book_price_txt.Size = new System.Drawing.Size(344, 23);
            this.book_price_txt.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(6, 270);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "도서가격";
            // 
            // book_description_txt
            // 
            this.book_description_txt.Font = new System.Drawing.Font("굴림", 10F);
            this.book_description_txt.Location = new System.Drawing.Point(75, 124);
            this.book_description_txt.Multiline = true;
            this.book_description_txt.Name = "book_description_txt";
            this.book_description_txt.Size = new System.Drawing.Size(344, 137);
            this.book_description_txt.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(6, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "도서설명";
            // 
            // book_category_cmb
            // 
            this.book_category_cmb.Font = new System.Drawing.Font("굴림", 10F);
            this.book_category_cmb.FormattingEnabled = true;
            this.book_category_cmb.Location = new System.Drawing.Point(75, 94);
            this.book_category_cmb.Name = "book_category_cmb";
            this.book_category_cmb.Size = new System.Drawing.Size(344, 21);
            this.book_category_cmb.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(6, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "카테고리";
            // 
            // book_writer_txt
            // 
            this.book_writer_txt.Font = new System.Drawing.Font("굴림", 10F);
            this.book_writer_txt.Location = new System.Drawing.Point(75, 58);
            this.book_writer_txt.Name = "book_writer_txt";
            this.book_writer_txt.Size = new System.Drawing.Size(344, 23);
            this.book_writer_txt.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(6, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "도서저자";
            // 
            // book_title_txt
            // 
            this.book_title_txt.Font = new System.Drawing.Font("굴림", 10F);
            this.book_title_txt.Location = new System.Drawing.Point(75, 25);
            this.book_title_txt.Name = "book_title_txt";
            this.book_title_txt.Size = new System.Drawing.Size(344, 23);
            this.book_title_txt.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(6, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "도서제목";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.image_btn);
            this.groupBox2.Controls.Add(this.book_image_txt);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Location = new System.Drawing.Point(446, 49);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(342, 311);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "도서 이미지";
            // 
            // image_btn
            // 
            this.image_btn.Font = new System.Drawing.Font("굴림", 10F);
            this.image_btn.Location = new System.Drawing.Point(258, 23);
            this.image_btn.Name = "image_btn";
            this.image_btn.Size = new System.Drawing.Size(75, 23);
            this.image_btn.TabIndex = 10;
            this.image_btn.Text = "불러오기";
            this.image_btn.UseVisualStyleBackColor = true;
            // 
            // book_image_txt
            // 
            this.book_image_txt.Font = new System.Drawing.Font("굴림", 10F);
            this.book_image_txt.Location = new System.Drawing.Point(61, 25);
            this.book_image_txt.Name = "book_image_txt";
            this.book_image_txt.Size = new System.Drawing.Size(191, 23);
            this.book_image_txt.TabIndex = 18;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label12.Location = new System.Drawing.Point(6, 28);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 13);
            this.label12.TabIndex = 18;
            this.label12.Text = "이미지";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(6, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(327, 247);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.book_state_cmb);
            this.groupBox3.Controls.Add(this.book_location_cmb);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Location = new System.Drawing.Point(447, 366);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(342, 83);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "도서 상태";
            // 
            // book_state_cmb
            // 
            this.book_state_cmb.Font = new System.Drawing.Font("굴림", 10F);
            this.book_state_cmb.FormattingEnabled = true;
            this.book_state_cmb.Location = new System.Drawing.Point(75, 48);
            this.book_state_cmb.Name = "book_state_cmb";
            this.book_state_cmb.Size = new System.Drawing.Size(261, 21);
            this.book_state_cmb.TabIndex = 19;
            // 
            // book_location_cmb
            // 
            this.book_location_cmb.Font = new System.Drawing.Font("굴림", 10F);
            this.book_location_cmb.FormattingEnabled = true;
            this.book_location_cmb.Location = new System.Drawing.Point(75, 18);
            this.book_location_cmb.Name = "book_location_cmb";
            this.book_location_cmb.Size = new System.Drawing.Size(261, 21);
            this.book_location_cmb.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label11.Location = new System.Drawing.Point(6, 51);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "도서상태";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label10.Location = new System.Drawing.Point(6, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "도서위치";
            // 
            // cancel_btn
            // 
            this.cancel_btn.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel_btn.Appearance.Options.UseFont = true;
            this.cancel_btn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cancel_btn.ImageOptions.Image")));
            this.cancel_btn.Location = new System.Drawing.Point(677, 459);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(109, 43);
            this.cancel_btn.TabIndex = 6;
            this.cancel_btn.Text = "취소";
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // reset_btn
            // 
            this.reset_btn.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reset_btn.Appearance.Options.UseFont = true;
            this.reset_btn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("reset_btn.ImageOptions.Image")));
            this.reset_btn.Location = new System.Drawing.Point(562, 459);
            this.reset_btn.Name = "reset_btn";
            this.reset_btn.Size = new System.Drawing.Size(109, 43);
            this.reset_btn.TabIndex = 7;
            this.reset_btn.Text = "초기화";
            this.reset_btn.Click += new System.EventHandler(this.reset_btn_Click);
            // 
            // delete_btn
            // 
            this.delete_btn.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_btn.Appearance.Options.UseFont = true;
            this.delete_btn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("delete_btn.ImageOptions.Image")));
            this.delete_btn.Location = new System.Drawing.Point(447, 459);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(109, 43);
            this.delete_btn.TabIndex = 8;
            this.delete_btn.Text = "삭제";
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // add_btn
            // 
            this.add_btn.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_btn.Appearance.Options.UseFont = true;
            this.add_btn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("add_btn.ImageOptions.Image")));
            this.add_btn.Location = new System.Drawing.Point(332, 457);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(109, 43);
            this.add_btn.TabIndex = 9;
            this.add_btn.Text = "수정";
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // BookSearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 508);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.reset_btn);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.book_no_txt);
            this.Controls.Add(this.label1);
            this.Name = "BookSearchForm";
            this.Text = "BookSearchForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox book_no_txt;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox book_date_txt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox book_company_txt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox book_price_txt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox book_description_txt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox book_category_cmb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox book_writer_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox book_title_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox book_pages_txt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private DevExpress.XtraEditors.SimpleButton cancel_btn;
        private DevExpress.XtraEditors.SimpleButton reset_btn;
        private DevExpress.XtraEditors.SimpleButton delete_btn;
        private DevExpress.XtraEditors.SimpleButton add_btn;
        private System.Windows.Forms.Button image_btn;
        private System.Windows.Forms.TextBox book_image_txt;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox book_state_cmb;
        private System.Windows.Forms.ComboBox book_location_cmb;
    }
}