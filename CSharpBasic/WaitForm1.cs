using DevExpress.XtraWaitForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CSharpBasic
{
    public partial class WaitForm1 : WaitForm
    {
        public WaitForm1()
        {
            InitializeComponent();
            this.progressPanel1.AutoHeight = true;

            progressPanel1.Caption = "데이터를 조회중입니다.. 잠시만 기다려주십시오.";
            progressPanel1.Description = "Loading...";
        }
    }
}