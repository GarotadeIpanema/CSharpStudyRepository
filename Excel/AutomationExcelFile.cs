using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExcelApp = Microsoft.Office.Interop.Excel;

namespace Excel
{
    public partial class AutomationExcelFile : Form
    {
        public AutomationExcelFile()
        {
            InitializeComponent();
        }

        // Excel Automation 을 사용하여 대량의 데이타를 처리하기 위해서는 배열 데이타를 Excel 의 Range에 쓰거나 읽으면서 처리하는 것이 성능면에서 효율적이다
        // 즉, 루프를 돌며 Cell 에 데이타를 하나씩 넣게 되면, 여러번 COM 메서드를 호출하게 되어 성능이 저하되기 때문에, Range 를 한번 호출하여 대량의 배열 데이타를 한번에 처리하는 것이 효율적이다.
        private void button1_Click(object sender, EventArgs e)
        {
            ExcelApp.Application excel = null;
            ExcelApp.Workbook wb = null;
            ExcelApp.Worksheet ws = null;

            try
            {
                excel = new ExcelApp.Application();

                // 엑셀 파일 열기
                wb = excel.Workbooks.Open(@"C:\Users\jjh\Desktop\img\test.xls");

                // 첫번째 Worksheet
                ws = wb.Worksheets.get_Item(1) as ExcelApp.Worksheet;

                // 현재 Worksheet에서 사용된 Range 전체를 선택
                ExcelApp.Range rng = ws.UsedRange;

                // 현재 Worksheet에서 일부 범위만 선택
                //ExcelApp.Range rng = ws.Range[ws.Cells[2, 1], ws.Cells[5, 3]];

                // Range 데이터를 배열(One-based array)로 변환
                object[,] data = rng.Value;

                for(int r = 1; r <= data.GetLength(0); r++)
                {
                    for(int c = 1; c <= data.GetLength(1); c++)
                    {
                        Debug.Write(data[r, c].ToString() + " ");
                    }
                    Debug.WriteLine("");
                }

                wb.Close(true);
                excel.Quit();
            }
            finally
            {
                // Clean up
                ReleaseExcelObject(ws);
                ReleaseExcelObject(wb);
                ReleaseExcelObject(excel);
            }
        }
        private static void ReleaseExcelObject(object obj)
        {
            try
            {
                if (obj != null)
                {
                    Marshal.ReleaseComObject(obj);
                    obj = null;
                }
            }
            catch (Exception ex)
            {
                obj = null;
                throw ex;
            }
            finally
            {
                GC.Collect();
            }
        }

    }
}
