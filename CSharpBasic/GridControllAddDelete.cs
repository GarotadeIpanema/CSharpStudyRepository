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
    public partial class GridControllAddDelete : Form
    {
        public GridControllAddDelete()
        {
            // https://afsdzvcx123.tistory.com/entry/C-DevExpress-DevExpress%EB%8D%B0%EB%B8%8C%EC%9D%B5%EC%8A%A4%ED%94%84%EB%A0%88%EC%8A%A4-GridControl%EC%97%90%EC%84%9C-Row%ED%96%89-%EC%B6%94%EA%B0%80-%EC%82%AD%EC%A0%9C-%ED%95%98%EA%B8%B0?category=882076
            InitializeComponent();

            this.Shown += DevForm_Shown;

            simpleButton1.Click += UiBtn_Add_Click;
            simpleButton2.Click += UiBtn_Delete_Click;
        }

        // form이 보여질 때 일어나는 이벤트 핸들러
        private void DevForm_Shown(object sender, EventArgs e)
        {
            // GridControl 초기화
            InitGridControl();

            // DataTable 데이터 저장 및 바인딩
            gridControl1.DataSource = GetData();
        }
        private void InitGridControl()
        {
            GridView gv = this.gridView1 as GridView;
            // 그룹 패널이 표시되는지 여부를 지정하는 값을 가져오거나 설정합니다.
            gv.OptionsView.ShowGroupPanel = false;
            gv.OptionsBehavior.Editable = false;
        }

        private DataTable GetData()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Name");
            dt.Columns.Add("Age");
            dt.Columns.Add("Grade");
            dt.Columns.Add("Score");

            dt.Rows.Add(new string[] { "kim", "28", "2", "100" });
            dt.Rows.Add(new string[] { "lee", "56", "3", "10" });
            dt.Rows.Add(new string[] { "son", "34", "2", "78" });
            dt.Rows.Add(new string[] { "park", "33", "1", "54" });
            dt.Rows.Add(new string[] { "koo", "28", "1", "45" });

            return dt;
        }

        // Add button Click
        private void UiBtn_Add_Click(object sender, EventArgs e)
        {
            gridView1.AddNewRow();
        }
        
        private void UiBtn_Delete_Click(object sender, EventArgs e)
        {
            gridView1.DeleteRow(gridView1.FocusedRowHandle);
        }

        /*
        // 특정 셀 색상 변경이벤트 핸들러
        private void gridView1_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            // Appearance, 컨트롤의 모양을 결정하는 값을 가져오거나 설정
            // TextOptions.HAlignment, 텍스트의 가로 맞춤을 가져오거나 설정합니다.
            // DevExpress,  Visual Studio 컴포넌트 라이브러리
            //                    국내에선 무겁기로 소문난 컴포넌트 라이브러리입니다. 라이센스 종류에 따라 SDK도 제공해주기도 하는데요. 해외에선 굉장히 많이 사용되고 있다고 하네요.
            //                    실제로 설치후에 Visual Studio 실행시에 수많은 컴포넌트들이 도구박스에 올라오느라 버벅댄다는 것을 실감할 정도입니다.
            // DevExpress.Utils.HorzAlignment, 컨트롤에서 개체 또는 텍스트의 가로 맞춤을 지정합니다.
            e.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;

            GridView view = sender as GridView;
            if (view == null)
                return;

            if(e.RowHandle != view.FocusedRowHandle)
            {
                if(e.Column.Name.Contains("Name"))
                {
                    e.Appearance.ForeColor = Color.Blue;
                }
                else if(e.Column.Name.Contains("Grade")) {
                    e.Appearance.ForeColor = Color.Red;
                }
            }

            var row = gridView1.GetRowCellDisplayText(e.RowHandle, "Name");
            if (row.Equals("kim"))
            {
                e.Appearance.BackColor = Color.OrangeRed;
            }

        }
        */

    }
}
