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
    public partial class DataTableControll : Form
    {
        public DataTableControll()
        {
            InitializeComponent();

            // DataTable 객체 생성및 Table 이름 명명
            DataTable dt = new DataTable("DataTable");

            // TableName에 Column(열) 지정
            DataColumn col1 = new DataColumn();
            col1.DataType = System.Type.GetType("System.String");
            col1.ColumnName = "TestStr1";
            dt.Columns.Add(col1);

            DataColumn col2 = new DataColumn();
            col2.DataType = System.Type.GetType("System.Int32");
            col2.ColumnName = "TestInt1";
            dt.Columns.Add(col2);

            // Table에 값 넣기
            DataRow dr1 = dt.NewRow(); // Row(행) 생성
            dr1["TestStr1"] = "test";
            dr1["TestInt1"] = 123;

            dt.Rows.Add(dr1);

            dataGridView1.DataSource = dt;
        }
    }
}
