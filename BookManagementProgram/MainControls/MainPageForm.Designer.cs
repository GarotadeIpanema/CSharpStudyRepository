
namespace BookManagementProgram.MainControls
{
    partial class MainPageForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.book_no_txt = new System.Windows.Forms.TextBox();
            this.book_title_txt = new System.Windows.Forms.TextBox();
            this.book_writer_txt = new System.Windows.Forms.TextBox();
            this.book_description_txt = new System.Windows.Forms.TextBox();
            this.book_rentalcount_txt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.book_category_txt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(17, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(253, 328);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(474, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "안녕하세요. 오늘도 좋은 하루 되시구요, 파이팅~!!!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(285, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "도서번호 : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(285, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 14);
            this.label3.TabIndex = 4;
            this.label3.Text = "도서제목 : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(285, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 14);
            this.label4.TabIndex = 6;
            this.label4.Text = "도서설명 : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(285, 366);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 14);
            this.label5.TabIndex = 7;
            this.label5.Text = "렌탈횟수 : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(285, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 14);
            this.label6.TabIndex = 8;
            this.label6.Text = "도서저자 : ";
            // 
            // book_no_txt
            // 
            this.book_no_txt.Font = new System.Drawing.Font("굴림", 10F);
            this.book_no_txt.Location = new System.Drawing.Point(375, 49);
            this.book_no_txt.Name = "book_no_txt";
            this.book_no_txt.ReadOnly = true;
            this.book_no_txt.Size = new System.Drawing.Size(413, 23);
            this.book_no_txt.TabIndex = 1;
            // 
            // book_title_txt
            // 
            this.book_title_txt.Font = new System.Drawing.Font("굴림", 10F);
            this.book_title_txt.Location = new System.Drawing.Point(375, 78);
            this.book_title_txt.Name = "book_title_txt";
            this.book_title_txt.ReadOnly = true;
            this.book_title_txt.Size = new System.Drawing.Size(413, 23);
            this.book_title_txt.TabIndex = 2;
            // 
            // book_writer_txt
            // 
            this.book_writer_txt.Font = new System.Drawing.Font("굴림", 10F);
            this.book_writer_txt.Location = new System.Drawing.Point(375, 109);
            this.book_writer_txt.Name = "book_writer_txt";
            this.book_writer_txt.ReadOnly = true;
            this.book_writer_txt.Size = new System.Drawing.Size(413, 23);
            this.book_writer_txt.TabIndex = 3;
            // 
            // book_description_txt
            // 
            this.book_description_txt.Font = new System.Drawing.Font("굴림", 10F);
            this.book_description_txt.Location = new System.Drawing.Point(375, 172);
            this.book_description_txt.Multiline = true;
            this.book_description_txt.Name = "book_description_txt";
            this.book_description_txt.ReadOnly = true;
            this.book_description_txt.Size = new System.Drawing.Size(413, 181);
            this.book_description_txt.TabIndex = 5;
            // 
            // book_rentalcount_txt
            // 
            this.book_rentalcount_txt.Font = new System.Drawing.Font("굴림", 10F);
            this.book_rentalcount_txt.Location = new System.Drawing.Point(375, 363);
            this.book_rentalcount_txt.Name = "book_rentalcount_txt";
            this.book_rentalcount_txt.ReadOnly = true;
            this.book_rentalcount_txt.Size = new System.Drawing.Size(413, 23);
            this.book_rentalcount_txt.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(285, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 14);
            this.label7.TabIndex = 14;
            this.label7.Text = "도서장르 : ";
            // 
            // book_category_txt
            // 
            this.book_category_txt.Font = new System.Drawing.Font("굴림", 10F);
            this.book_category_txt.Location = new System.Drawing.Point(376, 140);
            this.book_category_txt.Name = "book_category_txt";
            this.book_category_txt.ReadOnly = true;
            this.book_category_txt.Size = new System.Drawing.Size(413, 23);
            this.book_category_txt.TabIndex = 4;
            // 
            // MainPageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 453);
            this.Controls.Add(this.book_category_txt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.book_rentalcount_txt);
            this.Controls.Add(this.book_description_txt);
            this.Controls.Add(this.book_writer_txt);
            this.Controls.Add(this.book_title_txt);
            this.Controls.Add(this.book_no_txt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MainPageForm";
            this.Text = "MainPageForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox book_no_txt;
        private System.Windows.Forms.TextBox book_title_txt;
        private System.Windows.Forms.TextBox book_writer_txt;
        private System.Windows.Forms.TextBox book_description_txt;
        private System.Windows.Forms.TextBox book_rentalcount_txt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox book_category_txt;
    }
}