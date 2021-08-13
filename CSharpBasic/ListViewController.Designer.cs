
namespace CSharpBasic
{
    partial class ListViewController
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
            this.components = new System.ComponentModel.Container();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Details = new System.Windows.Forms.RadioButton();
            this.List = new System.Windows.Forms.RadioButton();
            this.Tile = new System.Windows.Forms.RadioButton();
            this.LargeIcon = new System.Windows.Forms.RadioButton();
            this.SmallIcon = new System.Windows.Forms.RadioButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(583, 294);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Details
            // 
            this.Details.AutoSize = true;
            this.Details.Location = new System.Drawing.Point(622, 12);
            this.Details.Name = "Details";
            this.Details.Size = new System.Drawing.Size(93, 16);
            this.Details.TabIndex = 1;
            this.Details.TabStop = true;
            this.Details.Text = "View.Details";
            this.Details.UseVisualStyleBackColor = true;
            this.Details.CheckedChanged += new System.EventHandler(this.Details_CheckedChanged);
            // 
            // List
            // 
            this.List.AutoSize = true;
            this.List.Location = new System.Drawing.Point(622, 47);
            this.List.Name = "List";
            this.List.Size = new System.Drawing.Size(75, 16);
            this.List.TabIndex = 2;
            this.List.TabStop = true;
            this.List.Text = "View.List";
            this.List.UseVisualStyleBackColor = true;
            this.List.CheckedChanged += new System.EventHandler(this.List_CheckedChanged);
            // 
            // Tile
            // 
            this.Tile.AutoSize = true;
            this.Tile.Location = new System.Drawing.Point(622, 84);
            this.Tile.Name = "Tile";
            this.Tile.Size = new System.Drawing.Size(76, 16);
            this.Tile.TabIndex = 3;
            this.Tile.TabStop = true;
            this.Tile.Text = "View.Tile";
            this.Tile.UseVisualStyleBackColor = true;
            this.Tile.CheckedChanged += new System.EventHandler(this.Title_CheckedChanged);
            // 
            // LargeIcon
            // 
            this.LargeIcon.AutoSize = true;
            this.LargeIcon.Location = new System.Drawing.Point(622, 129);
            this.LargeIcon.Name = "LargeIcon";
            this.LargeIcon.Size = new System.Drawing.Size(111, 16);
            this.LargeIcon.TabIndex = 4;
            this.LargeIcon.TabStop = true;
            this.LargeIcon.Text = "View.LargeIcon";
            this.LargeIcon.UseVisualStyleBackColor = true;
            this.LargeIcon.CheckedChanged += new System.EventHandler(this.LargeIcon_CheckedChanged);
            // 
            // SmallIcon
            // 
            this.SmallIcon.AutoSize = true;
            this.SmallIcon.Location = new System.Drawing.Point(622, 163);
            this.SmallIcon.Name = "SmallIcon";
            this.SmallIcon.Size = new System.Drawing.Size(111, 16);
            this.SmallIcon.TabIndex = 5;
            this.SmallIcon.TabStop = true;
            this.SmallIcon.Text = "View.SmallIcon";
            this.SmallIcon.UseVisualStyleBackColor = true;
            this.SmallIcon.CheckedChanged += new System.EventHandler(this.SmallIcon_CheckedChanged);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imageList2
            // 
            this.imageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList2.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // ListViewController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 315);
            this.Controls.Add(this.SmallIcon);
            this.Controls.Add(this.LargeIcon);
            this.Controls.Add(this.Tile);
            this.Controls.Add(this.List);
            this.Controls.Add(this.Details);
            this.Controls.Add(this.listView1);
            this.Name = "ListViewController";
            this.Text = "ListViewController";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.RadioButton Details;
        private System.Windows.Forms.RadioButton List;
        private System.Windows.Forms.RadioButton Tile;
        private System.Windows.Forms.RadioButton LargeIcon;
        private System.Windows.Forms.RadioButton SmallIcon;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList2;
    }
}