
namespace ProgressBar
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
            this.progressbar = new System.Windows.Forms.ProgressBar();
            this.progress_btn = new System.Windows.Forms.Button();
            this.progress_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // progressbar
            // 
            this.progressbar.Location = new System.Drawing.Point(12, 52);
            this.progressbar.Name = "progressbar";
            this.progressbar.Size = new System.Drawing.Size(596, 23);
            this.progressbar.TabIndex = 0;
            // 
            // progress_btn
            // 
            this.progress_btn.Location = new System.Drawing.Point(533, 81);
            this.progress_btn.Name = "progress_btn";
            this.progress_btn.Size = new System.Drawing.Size(75, 23);
            this.progress_btn.TabIndex = 1;
            this.progress_btn.Text = "다운로드";
            this.progress_btn.UseVisualStyleBackColor = true;
            this.progress_btn.Click += new System.EventHandler(this.progress_btn_Click);
            // 
            // progress_lbl
            // 
            this.progress_lbl.AutoSize = true;
            this.progress_lbl.Location = new System.Drawing.Point(303, 9);
            this.progress_lbl.Name = "progress_lbl";
            this.progress_lbl.Size = new System.Drawing.Size(97, 12);
            this.progress_lbl.TabIndex = 2;
            this.progress_lbl.Text = "Processing...0%";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 113);
            this.Controls.Add(this.progress_lbl);
            this.Controls.Add(this.progress_btn);
            this.Controls.Add(this.progressbar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressbar;
        private System.Windows.Forms.Button progress_btn;
        private System.Windows.Forms.Label progress_lbl;
    }
}

