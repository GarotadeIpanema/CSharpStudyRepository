using DevExpress.Spreadsheet;
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
    public partial class SpreadSheetControll : Form
    {
        public SpreadSheetControll()
        {
            InitializeComponent();

            this.Shown += DevForm_Shown;
        }

        private void DevForm_Shown(object sender, EventArgs e)
        {
            SetSpreadSheetData(GridControllGetCellData());
        }

        private DataTable GridControllGetCellData()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Name");
            dt.Columns.Add("Age");
            dt.Columns.Add("Grade");
            dt.Columns.Add("Score");
            dt.Columns.Add("Check");

            dt.Rows.Add(new string[] { "kim", "1", "1", "1", "True" });
            dt.Rows.Add(new string[] { "lee", "2", "2", "2", "False" });
            dt.Rows.Add(new string[] { "son", "3", "3", "3", "True" });
            dt.Rows.Add(new string[] { "moon", "4", "4", "4", "False" });
            dt.Rows.Add(new string[] { "an", "5", "5", "5", "True" });
            dt.Rows.Add(new string[] { "park", "6", "6", "6", "False" });

            return dt;
        }
        private void SetSpreadSheetData(DataTable v)
        {
            // BeginUpdate, Workbook.EndUpdate 메서드가 호출될 때까지 Workbook 개체를 잠급니다.
            this.spreadsheetControl1.BeginUpdate();

            Worksheet worksheet = this.spreadsheetControl1.Document.Worksheets[0];
            worksheet.Name = "Student"; // Sheet 이름 설정

            // 컬럼 Row추가
            for(int i = 0; i < v.Columns.Count; i++)
            {
                Cell cell = worksheet.Rows[0][i];
                SetCellStyle(cell, true, 9, Color.LightBlue); //Cell Style 설정
                cell.SetValue(v.Columns[i].ToString());
            }

            // Data Row 추가
            for (int i = 0; i < v.Rows.Count; i++)
            {
                for (int j = 0; j < v.Columns.Count; j++)
                {
                    Cell cell = worksheet.Rows[i+1][j];
                    SetCellStyle(cell, false, 9, Color.Wheat);
                    cell.SetValue(v.Rows[i][j]);
                }
            }

            // Data 크기에 맞게 Cell 사이즈 조정
            worksheet.GetUsedRange().AutoFitColumns();
            worksheet.GetUsedRange().AutoFitRows();

            this.spreadsheetControl1.EndUpdate();
        }

        // Cell Style 지정
        private void SetCellStyle(Cell cell, bool v1, int v2, Color wheat)
        {
            cell.Font.Bold = v1;
            cell.Font.Size = v2;
            cell.FillColor = wheat;
            cell.Borders.SetAllBorders(Color.Black, BorderLineStyle.Thin);
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Worksheet worksheet = this.spreadsheetControl1.Document.Worksheets[0];
            worksheet.Clear(worksheet.GetUsedRange());
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.InitialDirectory = @"C:\Users\jjh\Desktop";
            dialog.Title = "저장 위치 지정";
            dialog.DefaultExt = "xls";
            dialog.Filter = "Xls files(*.xls) | *.xls";
            dialog.FileName = "test";

            if (dialog.ShowDialog() == DialogResult.OK )
            {
                string file = dialog.FileName.ToString();
                spreadsheetControl1.SaveDocument(file, DocumentFormat.Xls);
            }
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.InitialDirectory = @"C:\Users\jjh\Desktop";
            dialog.Title = "불러오기 위치 지정";
            dialog.DefaultExt = "xls";
            dialog.Filter = "Xls files(*.xls) | *.xls";
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                string file = dialog.FileName.ToString();
                spreadsheetControl1.LoadDocument(file, DocumentFormat.Xls);
            }
        }
    }
}
