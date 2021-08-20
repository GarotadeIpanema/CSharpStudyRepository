
namespace CSharpBasic
{
    partial class GradientButtonCOntrol
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
            this.gradientButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gradientButton1.Angle = 0F;
            this.gradientButton1.Colors.Add(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192))))));
            this.gradientButton1.Colors.Add(System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192))))));
            this.gradientButton1.Location = new System.Drawing.Point(210, 94);
            this.gradientButton1.Name = "gradientButton1";
            this.gradientButton1.Size = new System.Drawing.Size(476, 233);
            this.gradientButton1.TabIndex = 0;
            this.gradientButton1.Text = "gradientButton1";
            this.gradientButton1.Transparency = 64;
            this.gradientButton1.UseVisualStyleBackColor = true;
            // 
            // GradientButtonCOntrol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 444);
            this.Controls.Add(this.gradientButton1);
            this.MinimumSize = new System.Drawing.Size(936, 483);
            this.Name = "GradientButtonCOntrol";
            this.Text = "GradientButtonCOntrol";
            this.ResumeLayout(false);

        }

        #endregion

        private GradientButton gradientButton1;
    }
}