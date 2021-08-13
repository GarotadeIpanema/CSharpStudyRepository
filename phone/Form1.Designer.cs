
namespace phone
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.customBorderRoundPanel1 = new phone.CustomBorderRoundPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.customPlaceholderTextBox1 = new WindowsFormsApp1.CustomPlaceholderTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.customPlaceholderTextBox2 = new WindowsFormsApp1.CustomPlaceholderTextBox();
            this.customRoundButton1 = new WindowsFormsApp1.CustomRoundButton();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.customBorderRoundPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateBlue;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(355, 170);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(150, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // customBorderRoundPanel1
            // 
            this.customBorderRoundPanel1.BackColor = System.Drawing.Color.White;
            this.customBorderRoundPanel1.Controls.Add(this.checkBox1);
            this.customBorderRoundPanel1.Controls.Add(this.customRoundButton1);
            this.customBorderRoundPanel1.Controls.Add(this.panel2);
            this.customBorderRoundPanel1.Controls.Add(this.panel3);
            this.customBorderRoundPanel1.CornerRadius = 45;
            this.customBorderRoundPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.customBorderRoundPanel1.Location = new System.Drawing.Point(0, 131);
            this.customBorderRoundPanel1.Name = "customBorderRoundPanel1";
            this.customBorderRoundPanel1.Size = new System.Drawing.Size(355, 380);
            this.customBorderRoundPanel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.customPlaceholderTextBox1);
            this.panel2.Location = new System.Drawing.Point(32, 61);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(290, 30);
            this.panel2.TabIndex = 2;
            // 
            // customPlaceholderTextBox1
            // 
            this.customPlaceholderTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.customPlaceholderTextBox1.Font = new System.Drawing.Font("굴림", 13F);
            this.customPlaceholderTextBox1.ForeColor = System.Drawing.Color.DarkGray;
            this.customPlaceholderTextBox1.Location = new System.Drawing.Point(10, 5);
            this.customPlaceholderTextBox1.Name = "customPlaceholderTextBox1";
            this.customPlaceholderTextBox1.Placeholder = "아이디를 입력해주세요.";
            this.customPlaceholderTextBox1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.customPlaceholderTextBox1.Size = new System.Drawing.Size(270, 20);
            this.customPlaceholderTextBox1.TabIndex = 0;
            this.customPlaceholderTextBox1.Text = "아이디를 입력해주세요.";
            this.customPlaceholderTextBox1.WriteColor = System.Drawing.Color.Black;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.customPlaceholderTextBox2);
            this.panel3.Location = new System.Drawing.Point(32, 138);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(290, 30);
            this.panel3.TabIndex = 3;
            // 
            // customPlaceholderTextBox2
            // 
            this.customPlaceholderTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.customPlaceholderTextBox2.Font = new System.Drawing.Font("굴림", 13F);
            this.customPlaceholderTextBox2.ForeColor = System.Drawing.Color.DarkGray;
            this.customPlaceholderTextBox2.Location = new System.Drawing.Point(10, 5);
            this.customPlaceholderTextBox2.Name = "customPlaceholderTextBox2";
            this.customPlaceholderTextBox2.Placeholder = "비밀번호를 입력해주세요.";
            this.customPlaceholderTextBox2.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.customPlaceholderTextBox2.Size = new System.Drawing.Size(277, 20);
            this.customPlaceholderTextBox2.TabIndex = 0;
            this.customPlaceholderTextBox2.Text = "비밀번호를 입력해주세요.";
            this.customPlaceholderTextBox2.WriteColor = System.Drawing.Color.Black;
            // 
            // customRoundButton1
            // 
            this.customRoundButton1.BackColor = System.Drawing.Color.SlateBlue;
            this.customRoundButton1.CornerRadius = 35;
            this.customRoundButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.customRoundButton1.FlatAppearance.BorderColor = System.Drawing.Color.SlateBlue;
            this.customRoundButton1.FlatAppearance.BorderSize = 0;
            this.customRoundButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customRoundButton1.Font = new System.Drawing.Font("굴림", 16F, System.Drawing.FontStyle.Bold);
            this.customRoundButton1.ForeColor = System.Drawing.Color.White;
            this.customRoundButton1.Location = new System.Drawing.Point(84, 249);
            this.customRoundButton1.Name = "customRoundButton1";
            this.customRoundButton1.Size = new System.Drawing.Size(180, 40);
            this.customRoundButton1.TabIndex = 4;
            this.customRoundButton1.Text = "로그인";
            this.customRoundButton1.UseVisualStyleBackColor = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("굴림", 12F);
            this.checkBox1.Location = new System.Drawing.Point(194, 199);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(128, 20);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "비밀번호 확인";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 511);
            this.Controls.Add(this.customBorderRoundPanel1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.customBorderRoundPanel1.ResumeLayout(false);
            this.customBorderRoundPanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private CustomBorderRoundPanel customBorderRoundPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private WindowsFormsApp1.CustomPlaceholderTextBox customPlaceholderTextBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private WindowsFormsApp1.CustomPlaceholderTextBox customPlaceholderTextBox2;
        private WindowsFormsApp1.CustomRoundButton customRoundButton1;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

