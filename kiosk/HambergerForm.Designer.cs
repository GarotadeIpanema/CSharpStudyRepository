
namespace kiosk
{
    partial class HambergerForm
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

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.bulgogi = new System.Windows.Forms.RadioButton();
            this.doublebulgogi = new System.Windows.Forms.RadioButton();
            this.doublecheese = new System.Windows.Forms.RadioButton();
            this.cheese = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // bulgogi
            // 
            this.bulgogi.AutoSize = true;
            this.bulgogi.Location = new System.Drawing.Point(128, 143);
            this.bulgogi.Name = "bulgogi";
            this.bulgogi.Size = new System.Drawing.Size(59, 16);
            this.bulgogi.TabIndex = 0;
            this.bulgogi.TabStop = true;
            this.bulgogi.Text = "불고기";
            this.bulgogi.UseVisualStyleBackColor = true;
            // 
            // doublebulgogi
            // 
            this.doublebulgogi.AutoSize = true;
            this.doublebulgogi.Location = new System.Drawing.Point(215, 143);
            this.doublebulgogi.Name = "doublebulgogi";
            this.doublebulgogi.Size = new System.Drawing.Size(83, 16);
            this.doublebulgogi.TabIndex = 1;
            this.doublebulgogi.TabStop = true;
            this.doublebulgogi.Text = "더블불고기";
            this.doublebulgogi.UseVisualStyleBackColor = true;
            // 
            // doublecheese
            // 
            this.doublecheese.AutoSize = true;
            this.doublecheese.Location = new System.Drawing.Point(405, 143);
            this.doublecheese.Name = "doublecheese";
            this.doublecheese.Size = new System.Drawing.Size(71, 16);
            this.doublecheese.TabIndex = 3;
            this.doublecheese.TabStop = true;
            this.doublecheese.Text = "더블치즈";
            this.doublecheese.UseVisualStyleBackColor = true;
            // 
            // cheese
            // 
            this.cheese.AutoSize = true;
            this.cheese.Location = new System.Drawing.Point(318, 143);
            this.cheese.Name = "cheese";
            this.cheese.Size = new System.Drawing.Size(47, 16);
            this.cheese.TabIndex = 2;
            this.cheese.TabStop = true;
            this.cheese.Text = "치즈";
            this.cheese.UseVisualStyleBackColor = true;
            // 
            // HambergerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.doublecheese);
            this.Controls.Add(this.cheese);
            this.Controls.Add(this.doublebulgogi);
            this.Controls.Add(this.bulgogi);
            this.Name = "HambergerForm";
            this.Size = new System.Drawing.Size(644, 348);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton bulgogi;
        private System.Windows.Forms.RadioButton doublebulgogi;
        private System.Windows.Forms.RadioButton doublecheese;
        private System.Windows.Forms.RadioButton cheese;
    }
}
