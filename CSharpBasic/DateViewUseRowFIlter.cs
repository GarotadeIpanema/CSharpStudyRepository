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
    public partial class DateViewUseRowFIlter : Form
    {
        public DateViewUseRowFIlter()
        {
            InitializeComponent();

            DataSet ds = new DataSet();

            DataTable dt = new DataTable("Student");
            dt.Columns.Add(new DataColumn("name", typeof(string)));
            dt.Columns.Add(new DataColumn("score", typeof(int)));

            DataRow dr1 = dt.NewRow();
            dr1["name"] = "kim";
            dr1["score"] = 100;
            dt.Rows.Add(dr1);

            DataRow dr2 = dt.NewRow();
            dr2["name"] = "lee";
            dr2["score"] = 95;
            dt.Rows.Add(dr2);

            DataRow dr3 = dt.NewRow();
            dr3["name"] = "gu";
            dr3["score"] = 85;
            dt.Rows.Add(dr3);

            DataRow dr4 = dt.NewRow();
            dr4["name"] = "yee";
            dr4["score"] = 75;
            dt.Rows.Add(dr4);

            ds.Tables.Add(dt);

            // 성적이 90점 이상인 학생 Filter
            DataSet scoreDs = new DataSet();
            scoreDs = ds.Copy();
            DataView dv = scoreDs.Tables[0].DefaultView;

            dv.RowFilter = "Convert(score, 'System.Int32') > " + 90 + " ";

            dataGridView1.DataSource = dv;
        }
    }
}
