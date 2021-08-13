using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpBasic
{
    public partial class ListToDataTable : Form
    {
        public ListToDataTable()
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

            DataTable dt = getDataTableFromDGV(dataGridView1);

            // List To DataTable
            var query = (from table in dt.AsEnumerable()
                         select new
                         {
                             address = table.Field<string>("Address"),
                             name = table.Field<string>("StudentName")
                         }).ToList();

            // List To DataTable
            DataTable convertDT = LinqQueryToDataTable(query);
            dataGridView1.DataSource = convertDT;
        }

        // List To DataTable Method
        private DataTable LinqQueryToDataTable(IEnumerable<dynamic> query)
        {
            // We really want to know if there is any data at all
            // 시퀀스의 첫 번째 요소를 반환하거나, 요소가 없으면 기본값을 반환합니다.
            var firstRecord = query.FirstOrDefault();
            if (firstRecord == null) return null;

            // So rear record, what do you have?
            // 속성의 특성을 검색하고 속성 메타데이터에 대한 액세스를 제공합니다.
            PropertyInfo[] infos = firstRecord.GetType().GetProperties();

            // Our table should have the columns to support the properties
            DataTable table = new DataTable();

            // Add the columns
            foreach(var info in infos)
            {
                Type propType = info.PropertyType;

                // Nullable types should be handled too
                // IsGenericType, 현재 형식이 제네릭 형식인지를 나타내는 값을 가져옵니
                // GetGenericTypeDefinition, 현재 제네릭 형식을 생성할 수 있는 제네릭 형식 정의를 나타내는 Type 개체를 반환합니다.
                if (propType.IsGenericType && propType.GetGenericTypeDefinition() == typeof(Nullable<>))
                {
                    // 지정된 nullable 형식의 내부 형식 인수를 반환합니다.
                    table.Columns.Add(info.Name, Nullable.GetUnderlyingType(propType));
                }
                else
                {
                    table.Columns.Add(info.Name, info.PropertyType);
                }
            }

            DataRow row;

            foreach(var record in query)
            {
                row = table.NewRow();
                for(int i = 0; i < table.Columns.Count; i++)
                {
                    row[i] = infos[i].GetValue(record) != null ? infos[i].GetValue(record) : DBNull.Value;
                }
                table.Rows.Add(row);
            }
            // Table is ready to serve.
            table.AcceptChanges();

            return table;
        }

        public DataTable getDataTableFromDGV(DataGridView gridView)
        {
            // DatagridView to DataSource
            DataTable dt = null;
            try
            {
                if (gridView.Columns.Count == 0) return null;

                dt = new DataTable();

                // create columns
                foreach (DataGridViewColumn col in gridView.Columns)
                {
                    if (col.ValueType == null)
                        dt.Columns.Add(col.Name, typeof(string));
                    else
                        dt.Columns.Add(col.Name, col.ValueType);
                    dt.Columns[col.Name].Caption = col.HeaderText;
                }

                // insert row data
                foreach (DataGridViewRow row in gridView.Rows)
                {
                    // datagridview에 데이터가 없으면 띄어넘기
                    // datagridview는 빈 행이 생기는 경우가 있다
                    if (row.Cells[0].Value == null) continue;

                    DataRow dtrow = dt.NewRow();
                    foreach (DataColumn col in dt.Columns)
                    {
                        dtrow[col.ColumnName] = row.Cells[col.ColumnName].Value;
                    }
                    dt.Rows.Add(dtrow);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return dt;
        }
    }
}
