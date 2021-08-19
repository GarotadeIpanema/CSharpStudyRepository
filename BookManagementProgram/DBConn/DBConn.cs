using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagementProgram.DBConn
{
    class DBConn
    {
        private static string DBIP = Properties.Settings.Default.DBIP;
        private static string DBID = Properties.Settings.Default.DBID;
        private static string DBPW = Properties.Settings.Default.DBPW;
        private static string DB = Properties.Settings.Default.DB;
        private static SqlConnection conn = null;

        public static SqlConnection getConn()
        {
            string connString = "Server=" + DBIP
                                  + ";database=" + DB
                                  + ";uid=" + DBID
                                  + ";pwd=" + DBPW;

            conn = new SqlConnection(connString);

            return conn;
        }
    }
}
