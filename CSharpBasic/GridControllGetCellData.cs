using DevExpress.XtraGrid.Views.Grid;
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
    public partial class GridControllGetCellData : Form
    {
        public GridControllGetCellData()
        {
            InitializeComponent();

            this.Shown += DevForm_Shown;
        }

        private void DevForm_Shown(object sender, EventArgs e)
        {
            InitGridControl();

            this.gridControl1.DataSource = GetData();

            gridView1.Columns[0].View.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.MouseUp;
            gridView1.RowCellClick += RowCellCLick_Event;
            //gridView1.RowClick += RowClick_Evnet;
        }


        private void InitGridControl()
        {
            // 최상위 계층 구조 수준에서 데이터를 표시하는 View를 가져오거나 설정합니다.
            GridView gv = this.gridControl1.MainView as GridView;
            // 
            gv.OptionsView.ShowGroupPanel = false;
            gv.OptionsBehavior.Editable = true;
        }

        private DataTable GetData()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Name");
            dt.Columns.Add("Age");
            dt.Columns.Add("Grade");
            dt.Columns.Add("Score");
            dt.Columns.Add("Check");

            dt.Rows.Add(new string[] { "bum", "28", "2", "100", "True" });
            dt.Rows.Add(new string[] { "hwang", "56", "3", "10", "True" });
            dt.Rows.Add(new string[] { "an", "34", "2", "78", "False" });
            dt.Rows.Add(new string[] { "seour", "33", "1", "54", "False" });
            dt.Rows.Add(new string[] { "lee", "28", "1", "45", "True" });
            dt.Rows.Add(new string[] { "park", "23", "4", "10", "False" });

            return dt;
        }

        // RowCell 클릭 이벤트 핸들러
        private void RowCellCLick_Event(object sender, RowCellClickEventArgs e)
        {

            int i = gridView1.GetSelectedRows()[0];
            DataRow row = gridView1.GetDataRow(i);
            textBox1.Text = row[0].ToString();
            textBox2.Text = row[1].ToString();
            textBox3.Text = row[2].ToString();
            textBox4.Text = row[3].ToString();
            textBox5.Text = row[4].ToString();

            /*
            if (e.Column.FieldName.Equals("Name"))
            {
                // 그리드 선택된 cell의 데이터 가져오기
                string str = gridView1.GetFocusedRowCellValue("Name").ToString();
                string msg = $"지금 선택하신 컬럼의 값 : {str}입니다";
                MessageBox.Show(msg);
            }*/
        }


        /*
        private void RowClick_Evnet(object sender, RowClickEventArgs e)
        {
            GridView gv = sender as GridView;
            if(e.RowHandle == gv.FocusedRowHandle)
            {
                gv.RowStyle += GridViewRowStyle;
            }
            else
            {
                gv.RowStyle += GridViewRowStyle2;
            }
            
        }

        private void GridViewRowStyle2(object sender, RowStyleEventArgs e)
        {
            e.Appearance.BackColor = Color.White;
        }

        private void GridViewRowStyle(object sender, RowStyleEventArgs e)
        {
            // e.RowHandle != view.FocusedRowHandle
            e.Appearance.BackColor = Color.Red;
        }
        */
    }
}
