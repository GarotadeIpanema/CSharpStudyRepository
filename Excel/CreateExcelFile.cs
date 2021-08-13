using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExcelApp = Microsoft.Office.Interop.Excel;

namespace Excel
{
    public partial class CreateExcelFile : Form
    {
        public CreateExcelFile()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Excel 파일에 넣을 임시 데이터 값
            List<string> testData = new List<string>()
            {
                "Excel"
                ,"Access"
                ,"Word"
                ,"OneNote"
            };

            // Excel 주요 개체
            ExcelApp.Application application = null;
            ExcelApp.Workbook workbook = null;
            ExcelApp.Worksheet worksheet = null;

            try
            {
                // 개체 초기화 및 인스턴스 생성
                application = new ExcelApp.Application();
                workbook = application.Workbooks.Add();
                worksheet = workbook.Worksheets.get_Item(1) as ExcelApp.Worksheet;

                // 데이터 삽입
                int r = 1;
                foreach (var d in testData)
                {
                    worksheet.Cells[r, 1] = d;
                    r++;
                }

                // 파일저장
                workbook.SaveAs(@"C:\Users\jjh\Desktop\img\test.xlsx", ExcelApp.XlFileFormat.xlWorkbookNormal);
                workbook.Close(true);
                application.Quit();
            }
            finally
            {
                // 개체 정리
                RelaseExcelObject(worksheet);
                RelaseExcelObject(workbook);
                RelaseExcelObject(application);
            }
        }

        // Excel 프로세스 죽이기
        // 위에서 Excel 인스턴스를 Quit로 죽였지만 ExcelWorkSheet가 살아있기 때문에 Excel.exe 프로세스가 죽지 않는다
        // 그렇기 때문에 worksheet부터 차근차근 죽여주어야 한다
        private void RelaseExcelObject(object obj)
        {
            try
            {
                if (obj != null)
                {
                    // 지정된 COM 개체와 연결된 지정된 RCW(런타임 호출 가능 래퍼)의 참조 횟수를 감소시킨다
                    // COM 개체를 닷넷으로 다루고자 할 때 사용하는 클래스
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
                // 가비지 컬렉션을 수행하도록 합니다.
                GC.Collect();
            }
        }
    }
}
