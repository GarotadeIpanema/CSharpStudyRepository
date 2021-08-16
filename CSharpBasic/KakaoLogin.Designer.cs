
namespace CSharpBasic
{
    partial class KakaoLogin
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
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.customMsgRdo = new System.Windows.Forms.RadioButton();
            this.templateMsgRdo = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.msgTxt = new System.Windows.Forms.TextBox();
            this.sendBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 50);
            this.button1.TabIndex = 0;
            this.button1.Text = "로그인";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sendBtn);
            this.groupBox1.Controls.Add(this.msgTxt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.templateMsgRdo);
            this.groupBox1.Controls.Add(this.customMsgRdo);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(577, 82);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "나에게 메시지 보내기";
            // 
            // customMsgRdo
            // 
            this.customMsgRdo.AutoSize = true;
            this.customMsgRdo.Location = new System.Drawing.Point(128, 20);
            this.customMsgRdo.Name = "customMsgRdo";
            this.customMsgRdo.Size = new System.Drawing.Size(99, 16);
            this.customMsgRdo.TabIndex = 1;
            this.customMsgRdo.TabStop = true;
            this.customMsgRdo.Text = "커스텀 메시지";
            this.customMsgRdo.UseVisualStyleBackColor = true;
            // 
            // templateMsgRdo
            // 
            this.templateMsgRdo.AutoSize = true;
            this.templateMsgRdo.Location = new System.Drawing.Point(128, 54);
            this.templateMsgRdo.Name = "templateMsgRdo";
            this.templateMsgRdo.Size = new System.Drawing.Size(99, 16);
            this.templateMsgRdo.TabIndex = 2;
            this.templateMsgRdo.TabStop = true;
            this.templateMsgRdo.Text = "템플릿 메시지";
            this.templateMsgRdo.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(233, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "메시지";
            // 
            // msgTxt
            // 
            this.msgTxt.Location = new System.Drawing.Point(280, 19);
            this.msgTxt.Name = "msgTxt";
            this.msgTxt.Size = new System.Drawing.Size(195, 21);
            this.msgTxt.TabIndex = 4;
            // 
            // sendBtn
            // 
            this.sendBtn.Location = new System.Drawing.Point(481, 19);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(90, 50);
            this.sendBtn.TabIndex = 5;
            this.sendBtn.Text = "전송";
            this.sendBtn.UseVisualStyleBackColor = true;
            this.sendBtn.Click += new System.EventHandler(this.sendBtn_Click);
            // 
            // KakaoLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 82);
            this.Controls.Add(this.groupBox1);
            this.Name = "KakaoLogin";
            this.Text = "KakaoLogin";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button sendBtn;
        private System.Windows.Forms.TextBox msgTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton templateMsgRdo;
        private System.Windows.Forms.RadioButton customMsgRdo;
    }
}