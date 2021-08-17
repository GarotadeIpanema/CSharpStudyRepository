
namespace CSharpBasic
{
    partial class ShadowGradientLabelControl
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
            this.shadowGradientLabel1 = new CSharpBasic.ShadowGradientLabel();
            this.SuspendLayout();
            // 
            // shadowGradientLabel1
            // 
            this.shadowGradientLabel1.Angle = 0F;
            this.shadowGradientLabel1.EndColor = System.Drawing.Color.Black;
            this.shadowGradientLabel1.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.shadowGradientLabel1.ForeColor = System.Drawing.Color.Black;
            this.shadowGradientLabel1.Location = new System.Drawing.Point(97, 52);
            this.shadowGradientLabel1.Name = "shadowGradientLabel1";
            this.shadowGradientLabel1.ShadowColor = System.Drawing.Color.Black;
            this.shadowGradientLabel1.Size = new System.Drawing.Size(307, 69);
            this.shadowGradientLabel1.StartColor = System.Drawing.Color.White;
            this.shadowGradientLabel1.TabIndex = 0;
            this.shadowGradientLabel1.Text = "shadowGradientLabel1";
            this.shadowGradientLabel1.XOffset = 5F;
            this.shadowGradientLabel1.YOffset = 5F;
            // 
            // ShadowGradientLabelControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.shadowGradientLabel1);
            this.Name = "ShadowGradientLabelControl";
            this.Text = "ShadowGradientLabelControl";
            this.ResumeLayout(false);

        }

        #endregion

        private ShadowGradientLabel shadowGradientLabel1;
    }
}