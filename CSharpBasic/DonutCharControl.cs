using DevExpress.XtraCharts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpBasic
{
    public partial class DonutCharControl : Form
    {
        public DonutCharControl()
        {
            InitializeComponent();

            this.Shown += DevForm_Shown;
        }

        private void DevForm_Shown(object sender, EventArgs e)
        {
            InitCityChart();
            //MessageBox.Show(System.Windows.Forms.Application.StartupPath);
            //MessageBox.Show(NetworkInterface.GetIsNetworkAvailable().ToString());
            //IPHostEntry host = Dns.GetHostEntry(Dns.GetHostName());
            //MessageBox.Show(host.HostName.ToString());
            //MessageBox.Show(new WebClient().DownloadString("http://ipinfo.io./ip").Trim());

        }

        private void InitCityChart()
        {
            // 도넛 차트 시리즈 생성
            Series series1 = new Series("Series 1", ViewType.Doughnut);

            // 시리즈 값 설정
            series1.Points.Add(new SeriesPoint("Seoul", 17.0752));
            series1.Points.Add(new SeriesPoint("Daegu", 9.98467));
            series1.Points.Add(new SeriesPoint("Busan", 9.63142));
            series1.Points.Add(new SeriesPoint("Gwangju", 9.59696));
            series1.Points.Add(new SeriesPoint("Inchen", 8.51965));

            series1 = CharAnimation(series1, "Doughnut");

            // 차트에 시리즈 추가
            uiChart_Main.Series.Add(series1);

            // 시리즈 라벨에 구체적인 데이터 표시
            series1.Label.TextPattern = "{A} : {VP:P0}";

            // 시리즈 포인팅 정렬
            series1.SeriesPointsSorting = SortingMode.Ascending;
            series1.SeriesPointsSortingKey = SeriesPointKey.Argument;

            // 시리즈 라벨 동작 설정
            ((DoughnutSeriesLabel)series1.Label).Position = PieSeriesLabelPosition.TwoColumns;
            ((DoughnutSeriesLabel)series1.Label).ResolveOverlappingMode = ResolveOverlappingMode.Default;
            ((DoughnutSeriesLabel)series1.Label).ResolveOverlappingMinIndent = 5;

            //시리즈 유형별 옵션 조정(튀어나오는 효과)
             ((DoughnutSeriesView)series1.View).ExplodedPoints.Add(series1.Points[0]);
            ((DoughnutSeriesView)series1.View).ExplodedDistancePercentage = 30;


            // 다이어그램 옵션 액세스
            ((SimpleDiagram)uiChart_Main.Diagram).Dimension = 2;

            // 차트 Title 설정
            ChartTitle chartTitle1 = new ChartTitle();
            chartTitle1.Text = "도시별 인구 분포도";
            uiChart_Main.Titles.Add(chartTitle1);
            uiChart_Main.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;

            // 차트 Dock 설정
            uiChart_Main.Dock = DockStyle.Fill;

            // 차트 애니메이션 효과
            uiChart_Main.AnimationStartMode = ChartAnimationMode.OnDataChanged;
        }

        private Series CharAnimation(Series series1, string v)
        {
            if(v == "Doughnut")
            {
                // Series1
                NestedDoughnutSeriesView nestedDoughnutSeriesView = new NestedDoughnutSeriesView();
                PieSpinAnimation pieSpinAnimation = new PieSpinAnimation();
                pieSpinAnimation.Duration = System.TimeSpan.Parse("00:00:02.5000000");
                nestedDoughnutSeriesView.Animation = pieSpinAnimation;
                series1.View = nestedDoughnutSeriesView;
            }

            return series1;
        }
    }
}
