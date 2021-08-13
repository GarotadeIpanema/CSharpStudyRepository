
namespace popup
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
            this.label2 = new System.Windows.Forms.Label();
            this.com_code_txt = new System.Windows.Forms.TextBox();
            this.emp_id = new System.Windows.Forms.TextBox();
            this.find_by_id_btn = new System.Windows.Forms.Button();
            this.close_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "회사 코드";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "사원 번호";
            // 
            // com_code_txt
            // 
            this.com_code_txt.Location = new System.Drawing.Point(75, 17);
            this.com_code_txt.Name = "com_code_txt";
            this.com_code_txt.Size = new System.Drawing.Size(288, 21);
            this.com_code_txt.TabIndex = 2;
            // 
            // emp_id
            // 
            this.emp_id.Location = new System.Drawing.Point(75, 60);
            this.emp_id.Name = "emp_id";
            this.emp_id.Size = new System.Drawing.Size(288, 21);
            this.emp_id.TabIndex = 3;
            // 
            // find_by_id_btn
            // 
            this.find_by_id_btn.Location = new System.Drawing.Point(75, 101);
            this.find_by_id_btn.Name = "find_by_id_btn";
            this.find_by_id_btn.Size = new System.Drawing.Size(92, 23);
            this.find_by_id_btn.TabIndex = 4;
            this.find_by_id_btn.Text = "아이디 찾기";
            this.find_by_id_btn.UseVisualStyleBackColor = true;
            this.find_by_id_btn.Click += new System.EventHandler(this.find_by_id_btn_Click);
            // 
            // close_btn
            // 
            this.close_btn.Location = new System.Drawing.Point(288, 101);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(75, 23);
            this.close_btn.TabIndex = 5;
            this.close_btn.Text = "닫기";
            this.close_btn.UseVisualStyleBackColor = true;
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // FindById
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 136);
            this.Controls.Add(this.close_btn);
            this.Controls.Add(this.find_by_id_btn);
            this.Controls.Add(this.emp_id);
            this.Controls.Add(this.com_code_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FindById";
            this.Text = "FindById";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox com_code_txt;
        private System.Windows.Forms.TextBox emp_id;
        private System.Windows.Forms.Button find_by_id_btn;
        private System.Windows.Forms.Button close_btn;
    }
}