
namespace CSharpBasic
{
    partial class JSONFILE
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.create_json_btn = new CSharpBasic.GradientButton();
            this.write_json_btn = new CSharpBasic.GradientButton();
            this.read_json_btn = new CSharpBasic.GradientButton();
            this.json_txt = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.json_txt, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.read_json_btn, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.write_json_btn, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.create_json_btn, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(794, 84);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // create_json_btn
            // 
            this.create_json_btn.Angle = 0F;
            this.create_json_btn.Colors.Add(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128))))));
            this.create_json_btn.Colors.Add(System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))));
            this.create_json_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.create_json_btn.Location = new System.Drawing.Point(3, 3);
            this.create_json_btn.Name = "create_json_btn";
            this.create_json_btn.Size = new System.Drawing.Size(258, 78);
            this.create_json_btn.TabIndex = 0;
            this.create_json_btn.Text = "Create JSON";
            this.create_json_btn.Transparency = 64;
            this.create_json_btn.UseVisualStyleBackColor = true;
            // 
            // write_json_btn
            // 
            this.write_json_btn.Angle = 0F;
            this.write_json_btn.Colors.Add(System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128))))));
            this.write_json_btn.Colors.Add(System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255))))));
            this.write_json_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.write_json_btn.Location = new System.Drawing.Point(267, 3);
            this.write_json_btn.Name = "write_json_btn";
            this.write_json_btn.Size = new System.Drawing.Size(258, 78);
            this.write_json_btn.TabIndex = 1;
            this.write_json_btn.Text = "Write JSON";
            this.write_json_btn.Transparency = 64;
            this.write_json_btn.UseVisualStyleBackColor = true;
            // 
            // read_json_btn
            // 
            this.read_json_btn.Angle = 0F;
            this.read_json_btn.Colors.Add(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128))))));
            this.read_json_btn.Colors.Add(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255))))));
            this.read_json_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.read_json_btn.Location = new System.Drawing.Point(531, 3);
            this.read_json_btn.Name = "read_json_btn";
            this.read_json_btn.Size = new System.Drawing.Size(260, 78);
            this.read_json_btn.TabIndex = 2;
            this.read_json_btn.Text = "Read JSON";
            this.read_json_btn.Transparency = 64;
            this.read_json_btn.UseVisualStyleBackColor = true;
            // 
            // json_txt
            // 
            this.json_txt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.json_txt.Location = new System.Drawing.Point(3, 93);
            this.json_txt.Name = "json_txt";
            this.json_txt.Size = new System.Drawing.Size(794, 354);
            this.json_txt.TabIndex = 1;
            this.json_txt.Text = "";
            // 
            // JSONFILE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "JSONFILE";
            this.Text = "JSONFILE";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private GradientButton read_json_btn;
        private GradientButton write_json_btn;
        private GradientButton create_json_btn;
        private System.Windows.Forms.RichTextBox json_txt;
    }
}