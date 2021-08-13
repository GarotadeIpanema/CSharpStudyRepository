
namespace CSharpBasic
{
    partial class STACKAlgorithm
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.TextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.TextBox3 = new System.Windows.Forms.MaskedTextBox();
            this.TextBox4 = new System.Windows.Forms.MaskedTextBox();
            this.TextBox5 = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(76, 79);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 0;
            // 
            // TextBox2
            // 
            this.TextBox2.Location = new System.Drawing.Point(76, 134);
            this.TextBox2.Name = "TextBox2";
            this.TextBox2.Size = new System.Drawing.Size(100, 21);
            this.TextBox2.TabIndex = 1;
            // 
            // TextBox3
            // 
            this.TextBox3.Location = new System.Drawing.Point(76, 193);
            this.TextBox3.Name = "TextBox3";
            this.TextBox3.Size = new System.Drawing.Size(100, 21);
            this.TextBox3.TabIndex = 2;
            // 
            // TextBox4
            // 
            this.TextBox4.Location = new System.Drawing.Point(76, 258);
            this.TextBox4.Name = "TextBox4";
            this.TextBox4.Size = new System.Drawing.Size(100, 21);
            this.TextBox4.TabIndex = 3;
            // 
            // TextBox5
            // 
            this.TextBox5.Location = new System.Drawing.Point(76, 323);
            this.TextBox5.Name = "TextBox5";
            this.TextBox5.Size = new System.Drawing.Size(100, 21);
            this.TextBox5.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(76, 378);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(263, 79);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 265);
            this.textBox6.TabIndex = 6;
            // 
            // STACKAlgorithm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 450);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TextBox5);
            this.Controls.Add(this.TextBox4);
            this.Controls.Add(this.TextBox3);
            this.Controls.Add(this.TextBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "STACKAlgorithm";
            this.Text = "STACKAlgorithm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.MaskedTextBox TextBox2;
        private System.Windows.Forms.MaskedTextBox TextBox3;
        private System.Windows.Forms.MaskedTextBox TextBox4;
        private System.Windows.Forms.MaskedTextBox TextBox5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox6;
    }
}