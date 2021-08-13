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
    public partial class WaitForm2 : WaitForm
    {
        public WaitForm2()
        {
            InitializeComponent();
            this.progressPanel1.AutoHeight = true;
        }
    }
}