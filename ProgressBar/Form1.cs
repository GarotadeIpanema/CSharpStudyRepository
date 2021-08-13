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

namespace ProgressBar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Task ProcessData(List<string> list, IProgress<ProgressReport> progress)
        {
            int index = 1;
            int totalProcess = list.Count;

            var progressReport = new ProgressReport();

            return Task.Run(() =>
            {
                for (int i = 0; i < totalProcess; i++)
                {
                    progressReport.PercentComplate = index++ * 100 / totalProcess;
                    progress.Report(progressReport);

                    Thread.Sleep(20); // used to simulate length of operation
                }
            });
        }

        private async void progress_btn_Click(object sender, EventArgs e)
        {
            List<string> list = new List<string>();

            for(int i = 0; i < 1000; i++)
            {
                list.Add(i.ToString());
            }

            progress_lbl.Text = "Working...";

            var progress = new Progress<ProgressReport>();
            progress.ProgressChanged += (o, report) =>
            {
                progress_lbl.Text = $"Procesing...{ report.PercentComplate}%"; ;
                progressbar.Value = report.PercentComplate;
                progressbar.Update();
            };
            await ProcessData(list, progress);

            progress_lbl.Text = "Done !";
        }
    }
}
