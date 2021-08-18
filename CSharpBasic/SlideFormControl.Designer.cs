
namespace CSharpBasic
{
    partial class SlideFormControl
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
            this.gradientButton1 = new CSharpBasic.GradientButton();
            this.SuspendLayout();
            // 
            // gradientButton1
            // 
            this.gradientButton1.Angle = 0F;
            this.gradientButton1.Colors.Add(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128))))));
            this.gradientButton1.Colors.Add(System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128))))));
            this.gradientButton1.Location = new System.Drawing.Point(24, 30);
            this.gradientButton1.Name = "gradientButton1";
            this.gradientButton1.Size = new System.Drawing.Size(383, 145);
            this.gradientButton1.TabIndex = 0;
            this.gradientButton1.Text = "SlideForm";
            this.gradientButton1.Transparency = 64;
            this.gradientButton1.UseVisualStyleBackColor = true;
            this.gradientButton1.Click += new System.EventHandler(this.gradientButton1_Click);
            // 
            // SlideFormControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 192);
            this.Controls.Add(this.gradientButton1);
            this.Name = "SlideFormControl";
            this.Text = "SlideFormControl";
            this.ResumeLayout(false);

        }

        #endregion

        private GradientButton gradientButton1;
    }
}