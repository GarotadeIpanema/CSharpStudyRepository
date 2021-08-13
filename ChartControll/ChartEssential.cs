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
    public partial class ChartEssential : Form
    {
        // Series
        // 차트에서 데이타에 해당하는 X, Y 값들을 갖고 있다
        // Series는 복수 Series 컬렉션을 의미
        // CharType 속성을 활용하여 차트의 종류(Line, Pi ... 등)를 지정 할 수 있다
        // Point 속성을 활용하여 데이터를 관리할 수 있다
        // CharArea 속성을 통해 특정 차트 영역을 지정할 수도 있다

        // CharArea
        // 하나의 차트는 하나 이상의 차트 영역을 가질 수 있다
        // 일반적으로 한 차트는 하나의 차트영역을 갖지만, 하나의 차트 컨트롤이 복수의 차트영역을 가질 수 있다

        // Legends
        // 범례에 해당하는 것으로 0개 이상의 범례를 가질 수 있고, 0 개면 범례가 표시되지 않는다

        // Titles
        // 차트 컨트롤 상단에 표시되는 제목으로 복수일 경우 위에서 한 라인씩 제목을 표시한다
        public ChartEssential()
        {
            InitializeComponent();


            // Y만 추가(X는 1부터 1씩 증가한다)
            chart1.Titles.Add("기본 Column 형태");
            chart1.Series["Series1"].Points.Clear();
            chart1.Series["Series1"].Points.Add(100); // x = 1
            chart1.Series["Series1"].Points.Add(200); // x = 2
            chart1.Series["Series1"].Points.Add(300); // x = 3
            chart1.Series["Series1"].Points.Add(400); // x = 4

            // X, Y 추가
            chart2.Titles.Add("Bar 형태");
            chart2.Series["Series1"].Points.Clear();
            chart2.Series["Series1"].Points.AddXY(10, 100);
            chart2.Series["Series1"].Points.AddXY(20, 200);
            chart2.Series["Series1"].Points.AddXY(30, 300);
            chart2.Series["Series1"].Points.AddXY(40, 400);

            chart3.Titles.Add("선 형태");
            chart3.Series["Series1"].Points.Clear();
            chart3.Series["Series1"].Points.AddXY(10, 100);
            chart3.Series["Series1"].Points.AddXY(20, 200);
            chart3.Series["Series1"].Points.AddXY(30, 300);
            chart3.Series["Series1"].Points.AddXY(40, 400);

            chart4.Titles.Add("PI 형태");
            chart4.Series["Series1"].Points.Clear();
            chart4.Series["Series1"].Points.AddXY(10, 100);
            chart4.Series["Series1"].Points.AddXY(20, 200);
            chart4.Series["Series1"].Points.AddXY(30, 300);
            chart4.Series["Series1"].Points.AddXY(40, 400);

            chart5.Titles.Add("스플라인 영역 형태");
            chart5.Series["Series1"].Points.Clear();
            chart5.Series["Series1"].Points.AddXY(10, 100);
            chart5.Series["Series1"].Points.AddXY(20, 200);
            chart5.Series["Series1"].Points.AddXY(30, 300);
            chart5.Series["Series1"].Points.AddXY(40, 400);

            chart6.Titles.Add("도넛 형태");
            chart6.Series["Series1"].Points.Clear();
            chart6.Series["Series1"].Points.AddXY(10, 100);
            chart6.Series["Series1"].Points.AddXY(20, 200);
            chart6.Series["Series1"].Points.AddXY(30, 300);
            chart6.Series["Series1"].Points.AddXY(40, 400);

            // ChartType(Bar, Line, Pie, SplineArea ...)
            chart2.Series["Series1"].ChartType = SeriesChartType.Bar; // X, Y축 위치 변경
            chart3.Series["Series1"].ChartType = SeriesChartType.Line; // 선형
            chart4.Series["Series1"].ChartType = SeriesChartType.Pie; // PI모양
            chart5.Series["Series1"].ChartType = SeriesChartType.SplineArea; // 스플라인 영역
            chart6.Series["Series1"].ChartType = SeriesChartType.Doughnut; // 도넛
        }
    }
}
