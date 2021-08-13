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
    public partial class ChartArea : Form
    {
        public ChartArea()
        {
            InitializeComponent();

            chart1.Series.Clear(); // default Series clear

            // CharArea는 따로 지정하지 않으면 자동으로 CharArea[0]과 연결된다
            // 그렇게 되면 Series는 CharArea[0]의 x, y축을 공유하게 된다
            // Series1
            Series series1 = chart1.Series.Add("graph1");
            series1.ChartType = SeriesChartType.Line;
            for(double k = 0; k < 2*Math.PI; k += 0.1)
            {
                series1.Points.AddXY(k, Math.Sin(k));
            }

            // Series2
            Series series2 = chart1.Series.Add("graph2");
            series2.ChartType = SeriesChartType.Line;
            for(double k = 0; k < 2 * Math.PI; k += 0.1)
            {
                series2.Points.AddXY(k, Math.Cos(k));
            }

            // 같은 CharArea여도 그래프의 축을 분리할 수 있다
            // y축 스케일이 다른 두 개의 그래프를 하나의 영역에 겹쳐서 도시하는 방법을 사용한다
            series2.YAxisType = AxisType.Secondary;

            // series1과 series2는 Y축만 분리되었고, X축은 공통이기 때문에 CharArea[0]의 X축을 변경하면 둘 다 영향을 받는다
            // chart1.ChartAreas[0].AxisX.Minimum = 2.0;
            // chart1.ChartAreas[0].AxisX.Maximum = 4.0;

            // 하지만 Y는 분리되어 있기 때문에 CharArea[0]의 Y축을 변경하면 series1만 영향을 받는다
            // chart1.ChartAreas[0].AxisY.Minimum = -0.5;
            // chart1.ChartAreas[0].AxisY.Maximum = 0.5;

            // series2의 Y축 범위를 조절하는 방법
            chart1.ChartAreas[0].AxisY2.Minimum = -2.5;
            chart1.ChartAreas[0].AxisY2.Maximum = -1.5;
        }
    }
}
