using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ChartControll
{
    public partial class BasicChart : Form
    {
        public BasicChart()
        {
            InitializeComponent();

            // 선 1
            chart1.Series.Clear(); // chart1 default Series 삭제
            Series series1 = chart1.Series.Add("sin"); // 새로운 Series를 생성하고 객체에 전달
            series1.ChartType = SeriesChartType.Line; // 그래프 모양을 지정
            for (double k = 0; k < 2 * Math.PI; k += 0.1)  // 데이터 포인트 지정
            {
                series1.Points.AddXY(k, Math.Sin(k));
            }

            // 선 2
            Series series2 = chart1.Series.Add("cos");
            series2.ChartType = SeriesChartType.Line;
            for (double k = 0; k < 2 * Math.PI; k += 0.1)
            {
                series2.Points.AddXY(k, Math.Cos(k));
            }
        }

    }
}
