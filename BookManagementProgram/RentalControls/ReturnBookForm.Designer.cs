
namespace BookManagementProgram.RentalControls
{
    partial class ReturnBookForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReturnBookForm));
            this.label1 = new System.Windows.Forms.Label();
            this.book_no_txt = new System.Windows.Forms.TextBox();
            this.select_rental_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.user_no_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.user_name_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.book_name_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rental_date_txt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.today_txt = new System.Windows.Forms.TextBox();
            this.return_btn = new DevExpress.XtraEditors.SimpleButton();
            this.cancel_btn = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "도서번호";
            // 
            // book_no_txt
            // 
            this.book_no_txt.Location = new System.Drawing.Point(95, 7);
            this.book_no_txt.Name = "book_no_txt";
            this.book_no_txt.Size = new System.Drawing.Size(248, 21);
            this.book_no_txt.TabIndex = 1;
            // 
            // select_rental_btn
            // 
            this.select_rental_btn.Location = new System.Drawing.Point(349, 5);
            this.select_rental_btn.Name = "select_rental_btn";
            this.select_rental_btn.Size = new System.Drawing.Size(75, 23);
            this.select_rental_btn.TabIndex = 2;
            this.select_rental_btn.Text = "렌탈조회";
            this.select_rental_btn.UseVisualStyleBackColor = true;
            this.select_rental_btn.Click += new System.EventHandler(this.select_rental_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "사용자번호";
            // 
            // user_no_txt
            // 
            this.user_no_txt.Location = new System.Drawing.Point(95, 41);
            this.user_no_txt.Name = "user_no_txt";
            this.user_no_txt.ReadOnly = true;
            this.user_no_txt.Size = new System.Drawing.Size(329, 21);
            this.user_no_txt.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(12, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "사용자이름";
            // 
            // user_name_txt
            // 
            this.user_name_txt.Location = new System.Drawing.Point(95, 78);
            this.user_name_txt.Name = "user_name_txt";
            this.user_name_txt.ReadOnly = true;
            this.user_name_txt.Size = new System.Drawing.Size(329, 21);
            this.user_name_txt.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(12, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "도서이름";
            // 
            // book_name_txt
            // 
            this.book_name_txt.Location = new System.Drawing.Point(95, 113);
            this.book_name_txt.Name = "book_name_txt";
            this.book_name_txt.ReadOnly = true;
            this.book_name_txt.Size = new System.Drawing.Size(329, 21);
            this.book_name_txt.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(12, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "렌탈날짜";
            // 
            // rental_date_txt
            // 
            this.rental_date_txt.Location = new System.Drawing.Point(95, 151);
            this.rental_date_txt.Name = "rental_date_txt";
            this.rental_date_txt.ReadOnly = true;
            this.rental_date_txt.Size = new System.Drawing.Size(329, 21);
            this.rental_date_txt.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(12, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "오늘날짜";
            // 
            // today_txt
            // 
            this.today_txt.Location = new System.Drawing.Point(95, 192);
            this.today_txt.Name = "today_txt";
            this.today_txt.ReadOnly = true;
            this.today_txt.Size = new System.Drawing.Size(329, 21);
            this.today_txt.TabIndex = 12;
            // 
            // return_btn
            // 
            this.return_btn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.return_btn.Location = new System.Drawing.Point(228, 235);
            this.return_btn.Name = "return_btn";
            this.return_btn.Size = new System.Drawing.Size(89, 43);
            this.return_btn.TabIndex = 13;
            this.return_btn.Text = "반납";
            this.return_btn.Click += new System.EventHandler(this.return_btn_Click);
            // 
            // cancel_btn
            // 
            this.cancel_btn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.cancel_btn.Location = new System.Drawing.Point(335, 235);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(89, 43);
            this.cancel_btn.TabIndex = 14;
            this.cancel_btn.Text = "취소";
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // ReturnBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 290);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.return_btn);
            this.Controls.Add(this.today_txt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rental_date_txt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.book_name_txt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.user_name_txt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.user_no_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.select_rental_btn);
            this.Controls.Add(this.book_no_txt);
            this.Controls.Add(this.label1);
            this.Name = "ReturnBookForm";
            this.Text = "ReturnBookForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox book_no_txt;
        private System.Windows.Forms.Button select_rental_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox user_no_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox user_name_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox book_name_txt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox rental_date_txt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox today_txt;
        private DevExpress.XtraEditors.SimpleButton return_btn;
        private DevExpress.XtraEditors.SimpleButton cancel_btn;
    }
}