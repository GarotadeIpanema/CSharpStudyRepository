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
    public partial class DataTableToList : Form
    {
        public DataTableToList()
        {
            InitializeComponent();

            DataTable dt = new DataTable("Student");
            dt.Columns.Add("StudentId", typeof(Int32));
            dt.Columns.Add("StudentName", typeof(String));
            dt.Columns.Add("Address", typeof(String));
            dt.Columns.Add("MobileNo", typeof(String));

            dt.Rows.Add(1, "A", "A Street", "000-0000-0000");
            dt.Rows.Add(2, "B", "B Street", "000-0000-0001");
            dt.Rows.Add(3, "C", "C Street", "000-0000-0002");
            dt.Rows.Add(4, "D", "D Street", "000-0000-0003");

            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string adress = string.Empty;
            string name = string.Empty;

            // DatagridView to DataSource
            DataTable dt = null;
            try
            {
                if (dataGridView1.Columns.Count == 0) return;

                 dt = new DataTable();

                // create columns
                foreach(DataGridViewColumn col in dataGridView1.Columns)
                {
                    if (col.ValueType == null)
                        dt.Columns.Add(col.Name, typeof(string));
                    else
                        dt.Columns.Add(col.Name, col.ValueType);
                    dt.Columns[col.Name].Caption = col.HeaderText;
                }

                // insert row data
                foreach(DataGridViewRow row in dataGridView1.Rows)
                {
                    // datagridview에 데이터가 없으면 띄어넘기
                    // datagridview는 빈 행이 생기는 경우가 있다
                    if (row.Cells[0].Value == null) continue;

                    DataRow dtrow = dt.NewRow();
                    foreach(DataColumn col in dt.Columns)
                    {
                        dtrow[col.ColumnName] = row.Cells[col.ColumnName].Value;
                    }
                    dt.Rows.Add(dtrow);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            var query = (from table in dt.AsEnumerable()
                         select new
                         {
                             address = table.Field<string>("Address"),
                             name = table.Field<string>("StudentName")
                         }).ToList();

            string str = "";
            query.ForEach(item =>
            {
                str += $"{item.name} : {item.address}\r\n";
            });
            textBox1.Text = str;
        }
    }
}
