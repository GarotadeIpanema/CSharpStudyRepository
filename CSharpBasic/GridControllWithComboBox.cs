using DevExpress.XtraEditors.Repository;
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
    public partial class GridControllWithComboBox : Form
    {

        // 콤보박스 객체 선언
        // ComboBoxEdit 컨트롤과 관련된 설정을 저장하는 리포지토리 항목을 나타냅니다.
        private RepositoryItemComboBox gradeComboBox;

        public GridControllWithComboBox()
        {
            InitializeComponent();

            this.Shown += DevForm_Shown;

            simpleButton2.Click += Add_Click;
            simpleButton1.Click += Delete_Click;
        }

        private void DevForm_Shown(object sender, EventArgs e)
        {
            InitGridControl();

            gridControl1.DataSource = GetData();

            gradeComboBox = new RepositoryItemComboBox();
            gridView1.Columns[2].ColumnEdit = gradeComboBox;
            InitalizeComboBoxEdit();
        }


        private void InitGridControl()
        {
            GridView gv = gridControl1.MainView as GridView;
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

            dt.Rows.Add(new string[] { "kim", "28", "2", "100" });
            dt.Rows.Add(new string[] { "lee", "56", "3", "10" });
            dt.Rows.Add(new string[] { "park", "34", "2", "78" });
            dt.Rows.Add(new string[] { "son", "33", "1", "54" });
            dt.Rows.Add(new string[] { "moon", "28", "1", "45" });
            dt.Rows.Add(new string[] { "an", "23", "4", "10" });

            return dt;
        }

        private void Add_Click(object sender, EventArgs e)
        {
            gridView1.AddNewRow();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            gridView1.DeleteRow(gridView1.FocusedRowHandle);
        }
        private void InitalizeComboBoxEdit()
        {
            DevExpressHelper.ClearComboBoxEditData(this.gradeComboBox);
            DevExpressHelper.SetComboBoxEditData(this.gradeComboBox, "1", "2", "3", "4");
            this.gridView1.SetRowCellValue(this.gridView1.FocusedRowHandle, "Grade", gradeComboBox.Items[0]);
            this.gradeComboBox.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
        }
        
    }

    public class DevExpressHelper
    {
        public static void ClearComboBoxEditData(RepositoryItemComboBox sourControl)
        {
            sourControl.Items.Clear();
        }

        // params 키워드를 사용하면 가변 개수의 인수를 사용하는 메서드 매개 변수를 지정할 수 있습니다. 매개 변수 배열은 1차원 배열이어야 합니다.
        // 메서드 선언에서 params 키워드 뒤에는 추가 매개 변수가 허용되지 않으며, params 키워드 하나만 메서드 선언에 사용할 수 있습니다.
        public static void SetComboBoxEditData(RepositoryItemComboBox sourceControl, params string[] itemValueArray)
        {
            foreach (string itemValue in itemValueArray)
            {
                sourceControl.Items.Add(itemValue);
            }
        }
    }
}
