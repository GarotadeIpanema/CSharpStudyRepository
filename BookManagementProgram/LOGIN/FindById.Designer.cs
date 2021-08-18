
namespace BookManagementProgram.LOGIN
{
    partial class FindById
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
            this.label1 = new System.Windows.Forms.Label();
            this.memberNumber_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.memberName_txt = new System.Windows.Forms.TextBox();
            this.find_btn = new System.Windows.Forms.Button();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "회원번호 :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // memberNumber_txt
            // 
            this.memberNumber_txt.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.memberNumber_txt.Location = new System.Drawing.Point(121, 19);
            this.memberNumber_txt.Name = "memberNumber_txt";
            this.memberNumber_txt.Size = new System.Drawing.Size(345, 26);
            this.memberNumber_txt.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "회원성명 :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // memberName_txt
            // 
            this.memberName_txt.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.memberName_txt.Location = new System.Drawing.Point(121, 54);
            this.memberName_txt.Name = "memberName_txt";
            this.memberName_txt.Size = new System.Drawing.Size(345, 26);
            this.memberName_txt.TabIndex = 3;
            // 
            // find_btn
            // 
            this.find_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.find_btn.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.find_btn.Location = new System.Drawing.Point(15, 97);
            this.find_btn.Name = "find_btn";
            this.find_btn.Size = new System.Drawing.Size(226, 30);
            this.find_btn.TabIndex = 4;
            this.find_btn.Text = "아이디 찾기";
            this.find_btn.UseVisualStyleBackColor = true;
            this.find_btn.Click += new System.EventHandler(this.find_btn_Click);
            // 
            // cancel_btn
            // 
            this.cancel_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancel_btn.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cancel_btn.Location = new System.Drawing.Point(248, 97);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(218, 30);
            this.cancel_btn.TabIndex = 5;
            this.cancel_btn.Text = "취소";
            this.cancel_btn.UseVisualStyleBackColor = true;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // FindById
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 139);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.find_btn);
            this.Controls.Add(this.memberName_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.memberNumber_txt);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FindById";
            this.Text = "FindById";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox memberNumber_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox memberName_txt;
        private System.Windows.Forms.Button find_btn;
        private System.Windows.Forms.Button cancel_btn;
    }
}