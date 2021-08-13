using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LiveChart
{
    public partial class LiveChart : Form
    {
        public LiveChart()
        {
            InitializeComponent();
        }

        private void LiveChart_Load(object sender, EventArgs e)
        {
            revenueBindingSource1.DataSource = new List<Revenue>();
            cartesianChart1.AxisX.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Month",
                Labels = new[] { "1월", "2월", "3월", "4월", "5월", "6월", "7월", "8월", "9월", "10월", "11월", "12월" }
            });
            cartesianChart1.AxisY.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Revenue",
                LabelFormatter = value => value.ToString("C")
            });
            cartesianChart1.LegendLocation = LiveCharts.LegendLocation.Right;

        }
        private void load_btn_Click(object sender, EventArgs e)
        {
            if(load_btn.Text == "새로고침")
            {
                load_btn.Text = "중지";

                timer1.Interval = 5000;
                timer1.Tick += new EventHandler(autoUpdate);
                timer1.Start();
            }
            else if(load_btn.Text == "중지")
            {
                load_btn.Text = "새로고침";

                timer1.Stop();
            }
            
        }

        private void autoUpdate(object sender, EventArgs args)
        {
            SeriesCollection seriesViews = cartesianChart1.Series;
            if (seriesViews.Count > 0)
            {

                Console.WriteLine($"{-1}. {seriesViews[0].Values}");
                for(int i = 0; i < seriesViews.Count; i ++)
                {
                    Console.WriteLine($"{i}. {seriesViews[i].Values}");
                }
            }
            if (UpdateDateInfo().Equals(seriesViews)) MessageBox.Show("같네");
            else UpdateDate();

        }

        // 데이터 차트에 전달 메소드
        private void UpdateDate()
        {
            // Init data
            cartesianChart1.Series.Clear();
            SeriesCollection series = new SeriesCollection();
            var years = (from o in revenueBindingSource1.DataSource as List<Revenue>
                         select new { Year = o.Year }).Distinct();
            foreach (var year in years)
            {
                List<double> values = new List<double>();
                for (int month = 1; month <= 12; month++)
                {
                    double value = 0;
                    var data = from o in revenueBindingSource1.DataSource as List<Revenue>
                               where o.Year.Equals(year.Year) && o.Month.Equals(month)
                               orderby o.Month ascending
                               select new { o.Value, o.Month };
                    if (data.SingleOrDefault() != null)
                        value = data.SingleOrDefault().Value;
                    values.Add(value);
                }
                series.Add(new LineSeries() { Title = year.Year.ToString(), Values = new ChartValues<double>(values) });
            }
            cartesianChart1.Series = series;
        }

        private SeriesCollection UpdateDateInfo()
        {
            // Init data
            cartesianChart1.Series.Clear();
            SeriesCollection series = new SeriesCollection();
            var years = (from o in revenueBindingSource1.DataSource as List<Revenue>
                         select new { Year = o.Year }).Distinct();
            foreach (var year in years)
            {
                List<double> values = new List<double>();
                for (int month = 1; month <= 12; month++)
                {
                    double value = 0;
                    var data = from o in revenueBindingSource1.DataSource as List<Revenue>
                               where o.Year.Equals(year.Year) && o.Month.Equals(month)
                               orderby o.Month ascending
                               select new { o.Value, o.Month };
                    if (data.SingleOrDefault() != null)
                        value = data.SingleOrDefault().Value;
                    values.Add(value);
                }
                series.Add(new LineSeries() { Title = year.Year.ToString(), Values = new ChartValues<double>(values) });
            }
            // cartesianChart1.Series = series;

            return series;
        }

    }
}
