
namespace Chart
{
    partial class Form1
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

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title5 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title6 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chartSalary = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chartRevenue = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.load_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartSalary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartRevenue)).BeginInit();
            this.SuspendLayout();
            // 
            // chartSalary
            // 
            chartArea5.Name = "ChartArea1";
            this.chartSalary.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chartSalary.Legends.Add(legend5);
            this.chartSalary.Location = new System.Drawing.Point(12, 12);
            this.chartSalary.Name = "chartSalary";
            series5.ChartArea = "ChartArea1";
            series5.CustomProperties = "PieStartAngle=270";
            series5.Legend = "Legend1";
            series5.Name = "Salary";
            this.chartSalary.Series.Add(series5);
            this.chartSalary.Size = new System.Drawing.Size(331, 346);
            this.chartSalary.TabIndex = 0;
            this.chartSalary.Text = "chart1";
            title5.Name = "Salary Chart";
            this.chartSalary.Titles.Add(title5);
            // 
            // dtoBindingSource
            // 
            this.dtoBindingSource.DataSource = typeof(Chart.Dto);
            // 
            // chartRevenue
            // 
            chartArea6.Name = "ChartArea1";
            this.chartRevenue.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chartRevenue.Legends.Add(legend6);
            this.chartRevenue.Location = new System.Drawing.Point(440, 12);
            this.chartRevenue.Name = "chartRevenue";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series6.CustomProperties = "PieStartAngle=270";
            series6.Legend = "Legend1";
            series6.Name = "Revenue";
            this.chartRevenue.Series.Add(series6);
            this.chartRevenue.Size = new System.Drawing.Size(348, 346);
            this.chartRevenue.TabIndex = 1;
            this.chartRevenue.Text = "chart2";
            title6.Name = "Revenue Chart";
            this.chartRevenue.Titles.Add(title6);
            // 
            // load_btn
            // 
            this.load_btn.Location = new System.Drawing.Point(713, 389);
            this.load_btn.Name = "load_btn";
            this.load_btn.Size = new System.Drawing.Size(75, 23);
            this.load_btn.TabIndex = 2;
            this.load_btn.Text = "새로고침";
            this.load_btn.UseCompatibleTextRendering = true;
            this.load_btn.UseVisualStyleBackColor = true;
            this.load_btn.Click += new System.EventHandler(this.load_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 437);
            this.Controls.Add(this.load_btn);
            this.Controls.Add(this.chartRevenue);
            this.Controls.Add(this.chartSalary);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartSalary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartRevenue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartSalary;
        private System.Windows.Forms.BindingSource dtoBindingSource;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRevenue;
        private System.Windows.Forms.Button load_btn;
    }
}

