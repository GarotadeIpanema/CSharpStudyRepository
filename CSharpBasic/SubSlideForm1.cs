using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpBasic
{
    public partial class SubSlideForm1 : UserControl
    {
        public DataTable dt = null;

        public SubSlideForm1()
        {
            InitializeComponent();

            this.Load += Load_Evnet;
        }

        private void Load_Evnet(object sender, EventArgs e)
        {
            GetDataTable();

            dataGridView1.DataSource = dt;
        }

        private void GetDataTable()
        {
            dt = new DataTable();

            dt.Columns.Add("Column1", typeof(int));
            dt.Columns.Add("Column2", typeof(int));
            dt.Columns.Add("Column3", typeof(int));
            dt.Columns.Add("Column4", typeof(int));
            dt.Columns.Add("Column5", typeof(int));
            dt.Columns.Add("Column6", typeof(int));
            dt.Columns.Add("Column7", typeof(int));

            dt.Rows.Add(1, 2, 3, 4, 5, 6, 7);
            dt.Rows.Add(1, 2, 3, 4, 5, 6, 7);
            dt.Rows.Add(1, 2, 3, 4, 5, 6, 7);
            dt.Rows.Add(1, 2, 3, 4, 5, 6, 7);
            dt.Rows.Add(1, 2, 3, 4, 5, 6, 7);
            dt.Rows.Add(1, 2, 3, 4, 5, 6, 7);
            dt.Rows.Add(1, 2, 3, 4, 5, 6, 7);
            dt.Rows.Add(1, 2, 3, 4, 5, 6, 7);
            dt.Rows.Add(1, 2, 3, 4, 5, 6, 7);
            dt.Rows.Add(1, 2, 3, 4, 5, 6, 7);
        }
    }
}
