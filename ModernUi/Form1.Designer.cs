
namespace ModernUi
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.customPlaceholderTextBox2 = new WindowsFormsApp1.CustomPlaceholderTextBox();
            this.customPlaceholderTextBox1 = new WindowsFormsApp1.CustomPlaceholderTextBox();
            this.gradientRoundBorderButton1 = new ModernUi.GradientRoundBorderButton();
            this.gradient_pnl = new ModernUi.CustomBorderRadiusPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gradient_pnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(435, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(110, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(441, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 27);
            this.label3.TabIndex = 3;
            this.label3.Text = "로그인";
            // 
            // customPlaceholderTextBox2
            // 
            this.customPlaceholderTextBox2.ForeColor = System.Drawing.Color.DarkGray;
            this.customPlaceholderTextBox2.Location = new System.Drawing.Point(405, 260);
            this.customPlaceholderTextBox2.Name = "customPlaceholderTextBox2";
            this.customPlaceholderTextBox2.Placeholder = "비밀번호를 입력해주세요.";
            this.customPlaceholderTextBox2.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.customPlaceholderTextBox2.Size = new System.Drawing.Size(180, 21);
            this.customPlaceholderTextBox2.TabIndex = 8;
            this.customPlaceholderTextBox2.Text = "비밀번호를 입력해주세요.";
            this.customPlaceholderTextBox2.WriteColor = System.Drawing.Color.Black;
            // 
            // customPlaceholderTextBox1
            // 
            this.customPlaceholderTextBox1.ForeColor = System.Drawing.Color.DarkGray;
            this.customPlaceholderTextBox1.Location = new System.Drawing.Point(405, 208);
            this.customPlaceholderTextBox1.Name = "customPlaceholderTextBox1";
            this.customPlaceholderTextBox1.Placeholder = "아이디를 입력해주세요.";
            this.customPlaceholderTextBox1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.customPlaceholderTextBox1.Size = new System.Drawing.Size(180, 21);
            this.customPlaceholderTextBox1.TabIndex = 7;
            this.customPlaceholderTextBox1.Text = "아이디를 입력해주세요.";
            this.customPlaceholderTextBox1.WriteColor = System.Drawing.Color.Black;
            // 
            // gradientRoundBorderButton1
            // 
            this.gradientRoundBorderButton1.Angle = 0F;
            this.gradientRoundBorderButton1.Colors.Add(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192))))));
            this.gradientRoundBorderButton1.Colors.Add(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0))))));
            this.gradientRoundBorderButton1.CornerRadius1 = 40;
            this.gradientRoundBorderButton1.CornerRadius2 = 40;
            this.gradientRoundBorderButton1.CornerRadius3 = 40;
            this.gradientRoundBorderButton1.CornerRadius4 = 40;
            this.gradientRoundBorderButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gradientRoundBorderButton1.FlatAppearance.BorderSize = 0;
            this.gradientRoundBorderButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gradientRoundBorderButton1.Font = new System.Drawing.Font("굴림", 25F);
            this.gradientRoundBorderButton1.Location = new System.Drawing.Point(405, 329);
            this.gradientRoundBorderButton1.Name = "gradientRoundBorderButton1";
            this.gradientRoundBorderButton1.Size = new System.Drawing.Size(180, 40);
            this.gradientRoundBorderButton1.TabIndex = 6;
            this.gradientRoundBorderButton1.Text = "로그인";
            this.gradientRoundBorderButton1.Transparency = 64;
            this.gradientRoundBorderButton1.UseVisualStyleBackColor = true;
            // 
            // gradient_pnl
            // 
            this.gradient_pnl.Controls.Add(this.label2);
            this.gradient_pnl.Controls.Add(this.label1);
            this.gradient_pnl.CornerRadius = 450;
            this.gradient_pnl.Dock = System.Windows.Forms.DockStyle.Left;
            this.gradient_pnl.Location = new System.Drawing.Point(0, 0);
            this.gradient_pnl.Name = "gradient_pnl";
            this.gradient_pnl.Size = new System.Drawing.Size(300, 450);
            this.gradient_pnl.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("굴림", 25F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(28, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 34);
            this.label2.TabIndex = 1;
            this.label2.Text = "XXX Program";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("굴림", 25F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(25, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcom to the";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 450);
            this.Controls.Add(this.customPlaceholderTextBox2);
            this.Controls.Add(this.customPlaceholderTextBox1);
            this.Controls.Add(this.gradientRoundBorderButton1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gradient_pnl);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gradient_pnl.ResumeLayout(false);
            this.gradient_pnl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomBorderRadiusPanel gradient_pnl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private GradientRoundBorderButton gradientRoundBorderButton1;
        private WindowsFormsApp1.CustomPlaceholderTextBox customPlaceholderTextBox1;
        private WindowsFormsApp1.CustomPlaceholderTextBox customPlaceholderTextBox2;
    }
}

