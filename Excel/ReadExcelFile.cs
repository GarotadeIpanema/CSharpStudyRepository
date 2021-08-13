using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Excel
{
    public partial class ReadExcelFile : Form
    {
        public ReadExcelFile()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // OLEDB를 이용한 엑셀 연결
            // EXCEL 97 - 2003 .xls
            string szConn = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\jjh\Desktop\img\test.xls;Extended Properties='Excel 8.0; HDR=No'";

            // Excel 2007 이후 .xlsx
            //string szConn = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\Users\jjh\Desktop\img\test.xlsx; ExtendedProperties = 'Excel 8.0; HDR=No' ";

            OleDbConnection conn = new OleDbConnection(szConn);
            conn.Open();

            // 엑셀 파일에서 데이터 읽기
            // 주의점! 엑셀시트명 뒤에 $ 붙이기, 시트명을 []로 묶기
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM [Sheet1$]", conn);
            OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);

            foreach(DataRow dr in ds.Tables[0].Rows)
            {
                string data = string.Format($"F1:{dr[0]}");
                MessageBox.Show(data);
            }

            // 엑셀 데이터 갱신
            cmd = new OleDbCommand("UPDATE [Sheet1$] SET F1 = 'Hello' Where F1 = 'Excel'", conn);
            cmd.ExecuteNonQuery();

            // 데이터 추가
            cmd = new OleDbCommand("INSERT INTO [Sheet1$](F1) Values('Excel')", conn);
            cmd.ExecuteNonQuery();

            conn.Close();



        }
    }
}
