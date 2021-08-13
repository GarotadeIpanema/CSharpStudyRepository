using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChartControll
{
    public partial class ChartDateBinding : Form
    {
        // 차트 컨트롤에서 X, Y 값을 하나씩 추가하는 방법 이외에 일반적으로 메모리상의 컬렉션 데이터 혹은
        // 외부 데이터 소스에서 데이터를 가져와 차트 컨트롤에 바인딩하는 방식을 흔히 사용한다
        // 차트 컨트롤은 배열(Array), 리스트(List), 혹은 IEnumerable을 지원하는 컬렉션을 데이터바인딩할 수 있다
        // 또한 DataSetm DataView 그리고 외부 데이터 소스에 대한 DataReader 등을 데이터 바인딩할 수 있다

        // 차트 컨트롤에서 데이터 바인딩 하는 방법(각각의 장단점은 MSDN 참조)
        // Series.Points.DataBindY() / .DataBindXY()
        // Series.Points.DataBind()
        // Chart.DataBindTable()
        // Chart.DataSource / Chart..DataBind()
        // Chart.DataBindCrossTable()

        public ChartDateBinding()
        {
            InitializeComponent();

            // 1. 배열 / 컬렉션에 대한 바인딩
            // 배열이나 컬렉션 같은 데이터 차트에 바인딩할 수 있다
            // 1) Y값 배열 데이터 바인딩
            double[] scores = new double[] { 80, 90, 85, 70, 95 };
            chart1.Series[0].Points.DataBindY(scores);

            // 2) X, Y값 List<T> 데이터 바인딩
            List<string> x = new List<string> { "철수", "영희", "길동", "재동", "민희" };
            List<double> y = new List<double> { 80, 90, 85, 70, 95};
            chart2.Series[0].Points.DataBindXY(x, y);

            // 3) 객체 컬렉션에 대한 데이터 바인딩
            List<Student> students = new List<Student>();
            students.Add(new Student("철수", 80));
            students.Add(new Student("영희", 90));
            students.Add(new Student("길동", 85));
            // X 축 : Name, Y축 : Score
            chart3.Series[0].Points.DataBind(students, "Name", "Score", null);
            // DataBindTable() 사용시, (X축 : Name, Y축 자동 검색)
            // chart3.DataBindTable(students, "Name");

            // 2. 테이블 데이터에 대한 바인딩
            // 차트 컨트롤에서 테이블데이터를 사용하는 경우, Char.DataBindTable(), Chart.DataSource/Chart.DataBind() 혹은 Series.Points.DataBind()등을 사용하면 편리
            // 각 메서드들은 행과 열을 갖는 테이블 데이터들 즉 DataReader, DataTable, DataSet 등과 같은 데이터 타입들을 바인딩할 때 유용

            /*
            // 1) DataBindTable() 사용
            string strConn = "Data Source=.;Initial Catalog=pubs;Integrated Security=SSPI;";
            string sql = "SELECT stor_name as store, SUM(qty) AS sales " +
                            "FROM stores st INNER JOIN sales sa ON st.stor_id = sa.stor_id " +
                            "GROUP BY stor_name";


            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader dataReader = cmd.ExecuteReader();

                // IDataReader 객체와 X축 필드를 지정한다
                chart4.DataBindTable(dataReader, "store");
            }

            // 2) DataSource와 DataBind() 사용
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                DataSet ds = new DataSet();
                SqlDataAdapter sa = new SqlDataAdapter(cmd);
                sa.Fill(ds);

                // DataTable 객체를 DataSource에 지정하고,
                // X, Y축 컬럼을 XValueMember와 YValueMembers에 지정
                chart5.DataSource = ds.Tables[0];
                chart5.Series[0].XValueMember = "store";
                chart5.Series[0].YValueMembers = "sales";
                chart5.DataBind();
            }

            // 3) Points.DataBind() 사용
            using(SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader dataReader = cmd.ExecuteReader();

                // IDataReader 객체와 X, Y축 컬럼 지정
                // 4번째 Param : 툴팁과 같은 다른 필드 지정가능, 여기선 sales 컬럼값을 툴팁에 표시
                chart6.Series[0].Points.DataBind(dataReader, "store", "sales", "Tooltip=sales");
            }
            */

            // 3. DataBindCrossTable() 바인딩
            // Chart.DataBindCrossTable() 바인딩은 약간 특별한 용도로 사용하는데, 이 메서드는 테이블 데이터를 사용하면서 X, Y축 이외의 데이터를 그룹으로 묶는 컬럼을 지정

            // 1) DataBindCrossTable() 사용
            DataTable dt = new DataTable("Order");
            dt.Columns.Add("customer");
            dt.Columns.Add("product");
            dt.Columns.Add("orders");
            dt.Rows.Add("Tom", "USB", 10);
            dt.Rows.Add("Tom", "HDD", 2);
            dt.Rows.Add("Tom", "Monitor", 1);
            dt.Rows.Add("Jane", "USB", 3);
            dt.Rows.Add("Jane", "HDD", 1);
            dt.Rows.Add("Jane", "Monitor", 2);
            // Product 별로 Series를 하나씩 자동으로 생성
            // X축은 customer 컬럼, Y축은 orders 컬럼
            // 각 그래프 상단에 product 명으로 Label을 붙임
            chart4.DataBindCrossTable(dt.AsEnumerable(), "product", "customer", "orders", "Label=product");

        }

        class Student
        {
            public string Name { get; set; }
            public double Score { get; set; }

            public Student(string name, double score)
            {
                Name = name;
                Score = score;
            }
        }
    }
}
