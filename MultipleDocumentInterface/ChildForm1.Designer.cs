﻿
namespace MultipleDocumentInterface
{
    partial class ChildForm1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tabPage1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tabPage1ToolStripMenuItem,
            this.tabPage2ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tabPage1ToolStripMenuItem
            // 
            this.tabPage1ToolStripMenuItem.Name = "tabPage1ToolStripMenuItem";
            this.tabPage1ToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.tabPage1ToolStripMenuItem.Text = "tabPage1";
            // 
            // tabPage2ToolStripMenuItem
            // 
            this.tabPage2ToolStripMenuItem.Name = "tabPage2ToolStripMenuItem";
            this.tabPage2ToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.tabPage2ToolStripMenuItem.Text = "tabPage2";
            // 
            // ChildForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ChildForm1";
            this.Text = "ChildForm1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tabPage1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tabPage2ToolStripMenuItem;
    }
}