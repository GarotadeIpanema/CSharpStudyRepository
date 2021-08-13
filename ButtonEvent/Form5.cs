using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Net.Configuration;
using System.Diagnostics;
using System.Collections.Specialized;

namespace ButtonEvent
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();

            // ConfigurationManager.AppSettings["TwiloHost"]
            string connectionString = ConfigurationManager.AppSettings["abc"];
            textBox1.Text = connectionString;
        }

        
    }
}
