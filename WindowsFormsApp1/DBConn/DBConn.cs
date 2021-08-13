using System.Data.SqlClient;

namespace WindowsFormsApp1.Conn
{
    class DBConn
    {
        private static string uid = null; // DB 접속 아이디
        private static string password = null; // DB 접속 비밀번호
        private static string database = null;  // 사용할 DB 이름
        private static string server = null;  // 서버 주소 -- sql 서버 접속시 사용한 주소
        private static SqlConnection conn = null;

        public static SqlConnection getConn()
        {
            //uid = "";
            //password = "";
            //database = "";
            //server = "";

            string connStr = $"SERVER = {server}; DATABASE = {database}; UID = {uid}; PASSWORD = {password};";

            conn = new SqlConnection(connStr);

            return conn;
        }

    }
}
