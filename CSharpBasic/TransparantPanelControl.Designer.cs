
namespace CSharpBasic
{
    partial class TransparantPanelControl
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
            this.transparentPanel1 = new CSharpBasic.TransparentPanel();
            this.SuspendLayout();
            // 
            // transparentPanel1
            // 
            this.transparentPanel1.Location = new System.Drawing.Point(100, 79);
            this.transparentPanel1.Name = "transparentPanel1";
            this.transparentPanel1.Opacity = 50;
            this.transparentPanel1.Size = new System.Drawing.Size(611, 311);
            this.transparentPanel1.TabIndex = 0;
            this.transparentPanel1.Text = "TransparentPanel";
            // 
            // TransparantPanelControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.transparentPanel1);
            this.Name = "TransparantPanelControl";
            this.Text = "TransparantPanelControl";
            this.Load += new System.EventHandler(this.TransparantPanelControl_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private TransparentPanel transparentPanel1;
    }
}