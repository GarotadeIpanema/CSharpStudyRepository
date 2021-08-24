using BookManagementProgram.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagementProgram.Repository
{
    class BookRentalRepository : IBookRentalRepository
    {
        private SqlConnection conn = null;
        private SqlCommand cmd = null;
        //public static List<Book> bookList = null;

        public BookRentalRepository()
        {
            conn = DBConn.DBConn.getConn();
            cmd = new SqlCommand();
            cmd.Connection = conn;
        }
    
        // 렌탈 정보 리스트
        public DataTable GetAllRental()
        {
            DataTable dt = new DataTable();
            try
            {
                string sql = "EXEC BOOK_RENTAL_S1;";

                cmd.CommandText = sql;
                conn.Open();

                // 데이터 출력
                using (SqlDataReader SR = cmd.ExecuteReader())
                {
                    dt.Load(SR);
                }
                return dt;
            }
            catch (SqlException e)
            {
                return dt;
            }
            finally
            {
                conn.Close();
            }
        }
        // 연체 정보 리스트
        public DataTable GetAllDelinquent()
        {
            DataTable dt = new DataTable();
            try
            {
                string sql = "EXEC BOOK_RENTAL_S2;";

                cmd.CommandText = sql;
                conn.Open();

                // 데이터 출력
                using (SqlDataReader SR = cmd.ExecuteReader())
                {
                    dt.Load(SR);
                }
                return dt;
            }
            catch (SqlException e)
            {
                return dt;
            }
            finally
            {
                conn.Close();
            }
        }

        // 도서정보 검색
        public DataTable GetBookInfo(string bookNo)
        {
            DataTable dt = null;
            try
            {
                string sql = $"EXEC BOOK_RENTAL_S3 @BOOK_NO = {bookNo};";

                cmd.CommandText = sql;
                conn.Open();

                // 데이터 출력
                using (SqlDataReader SR = cmd.ExecuteReader())
                {
                    dt = new DataTable();
                    dt.Load(SR);
                }
                return dt;
            }
            catch (SqlException e)
            {
                return dt;
            }
            finally
            {
                conn.Close();
            }   
        }

        // 사용자정보 검색
        public DataTable GetUserInfo(string userNo)
        {
            DataTable dt = null;
            try
            {
                string sql = $"EXEC BOOK_RENTAL_S4 @USER_NO = {userNo};";

                cmd.CommandText = sql;
                conn.Open();

                // 데이터 출력
                using (SqlDataReader SR = cmd.ExecuteReader())
                {
                    dt = new DataTable();
                    dt.Load(SR);
                }
                return dt;
            }
            catch (SqlException e)
            {
                return dt;
            }
            finally
            {
                conn.Close();
            }
        }

        // 렌탈정보등록
        public bool AddBook(Rental rental)
        {
            try
            {
                string sql = $@"EXEC	BOOK_RENTAL_I1
                                    @USER_NO  = {rental.userNo}
                                    ,@BOOK_NO = {rental.bookNo}
                                    ,@BOOK_TITLE = '{rental.bookTitle}'
		                            ;";

                cmd.CommandText = sql;
                conn.Open();

                return cmd.ExecuteNonQuery() > 0 ? true : false;
            }
            catch (SqlException e)
            {
                return false;
            }
            finally
            {
                conn.Close();
            }
        }

        // 반납 도서 확인
        public DataTable CheckRentalBook(string bookNo)
        {
            DataTable dt = null;
            try
            {
                string sql = $"EXEC BOOK_RENTAL_S5 @BOOK_NO = {bookNo};";

                cmd.CommandText = sql;
                conn.Open();

                // 데이터 출력
                using (SqlDataReader SR = cmd.ExecuteReader())
                {
                    dt = new DataTable();
                    dt.Load(SR);
                }
                return dt;
            }
            catch (SqlException e)
            {
                return dt;
            }
            finally
            {
                conn.Close();
            }
        }

        // 반납정보등록
        public bool ReturnBook(string userNo, string bookNo)
        {
            try
            {
                string sql = $@"EXEC	BOOK_RENTAL_U1
                                    @USER_NO  = {userNo}
                                    ,@BOOK_NO = {bookNo}
		                            ;";

                cmd.CommandText = sql;
                conn.Open();

                return cmd.ExecuteNonQuery() > 0 ? true : false;
            }
            catch (SqlException e)
            {
                return false;
            }
            finally
            {
                conn.Close();
            }

        }

        // 모든 렌탈 정보 리스트
        public DataTable GetRentalHistory()
        {
            DataTable dt = new DataTable();
            try
            {
                string sql = "EXEC BOOK_RENTAL_S6;";

                cmd.CommandText = sql;
                conn.Open();

                // 데이터 출력
                using (SqlDataReader SR = cmd.ExecuteReader())
                {
                    dt.Load(SR);
                }
                return dt;
            }
            catch (SqlException e)
            {
                return dt;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
