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
    public partial class NaverNews : Form
    {
        private DataTable dt = null;
        public NaverNews()
        {
            InitializeComponent();

            // DataGridView 초기화(선택사항)
            dt = new DataTable();
            dt.Columns.Add("Title", typeof(String));
            dt.Columns.Add("OriginalLink", typeof(String));
            dt.Columns.Add("Link", typeof(String));
            dt.Columns.Add("Description", typeof(String));
            dt.Columns.Add("Pubdate", typeof(DateTime));
            newScriptGv.DataSource = dt;
        }

        // 검색 버튼 이벤트
        private void searchBtn_Click(object sender, EventArgs e)
        {
            SearchNews(titleTxt.Text);
        }

        // 텍스트박스 키업 이벤트
        private void titleTxt_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SearchNews(titleTxt.Text);
            }
        }

        // 검색 메서드
        private void SearchNews(string searchTitle)
        {
            // naver api id & scret key
            string id = "";
            string secret = "";
            NaverNewsDao nn = new NaverNewsDao(id, secret);

            // JSON
            List<NaverNewsDto> news = nn.FindNewsJson(1, 20, searchTitle);
            dt = LinqQueryToDataTable(news);

            // XML
            //int total = nn.Find(searchTitle);
            //List<NaverNewsDto> nc = nn.FindNewsToXML(1, 20);
            //dt = LinqQueryToDataTable(nc);

            newScriptGv.DataSource = dt;
        }

        // List -> DataTable
        private DataTable LinqQueryToDataTable(IEnumerable<dynamic> query)
        {
            // 시퀀스의 첫 번째 요소를 반환하거나, 요소가 없으면 기본값을 반환합니다.
            var firstRecord = query.FirstOrDefault();
            if (firstRecord == null) return null;

            // 속성의 특성을 검색하고 속성 메타데이터에 대한 액세스를 제공합니다.
            PropertyInfo[] infos = firstRecord.GetType().GetProperties();

            // 반환할 데이터테이블
            DataTable table = new DataTable();

            // 데이터 테이블에 컬럼 추가
            foreach (var info in infos)
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

            // 데이터 테이블에 데이터 추가
            foreach (var record in query)
            {
                row = table.NewRow();
                for (int i = 0; i < table.Columns.Count; i++)
                {
                    row[i] = infos[i].GetValue(record) != null ? infos[i].GetValue(record) : DBNull.Value;
                }
                table.Rows.Add(row);
            }
            // 마지막으로 호출된 이후 이 테이블에서 변경된 내용을 모두 커밋
            table.AcceptChanges();

            return table;
        }

        // 크롬 브라우저 보여주기
        private void newScriptGv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView gv = (DataGridView)sender;

            if (e.ColumnIndex != 1 && e.ColumnIndex != 2 || e.RowIndex < 0)
            {
                MessageBox.Show("링크를 클릭하면 해당 페이지가 열립니다");
                return;
            }

            string url = gv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            if (string.IsNullOrEmpty(url))
            {
                MessageBox.Show("검색 후 클릭해주세요.");
                return;
            }

            (new NaverNewsBrowser(url)).ShowDialog();
        }
    }
}