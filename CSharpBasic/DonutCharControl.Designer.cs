
namespace CSharpBasic
{
    partial class DonutCharControl
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
            this.uiChart_Main = new DevExpress.XtraCharts.ChartControl();
            ((System.ComponentModel.ISupportInitialize)(this.uiChart_Main)).BeginInit();
            this.SuspendLayout();
            // 
            // uiChart_Main
            // 
            this.uiChart_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiChart_Main.Legend.Name = "Default Legend";
            this.uiChart_Main.Location = new System.Drawing.Point(0, 0);
            this.uiChart_Main.Name = "uiChart_Main";
            this.uiChart_Main.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.uiChart_Main.Size = new System.Drawing.Size(800, 450);
            this.uiChart_Main.TabIndex = 0;
            // 
            // DonutCharControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.uiChart_Main);
            this.Name = "DonutCharControl";
            this.Text = "DonutCharControl";
            ((System.ComponentModel.ISupportInitialize)(this.uiChart_Main)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraCharts.ChartControl uiChart_Main;
    }
}