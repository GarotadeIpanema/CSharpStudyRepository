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
    class BookRepository
    {
        private SqlConnection conn = null;
        private SqlCommand cmd = null;
        public static List<Book> bookList = null;

        public BookRepository()
        {
            conn = DBConn.DBConn.getConn();
            cmd = new SqlCommand();
            cmd.Connection = conn;
        }

        // 도서 전체 리스트
        public DataTable GetAllBooks()
        {
            DataTable dt = new DataTable();
            try
            {
                string sql = "EXEC BOOK_Book_S1;";

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

        // 카테고리 리스트
        public Dictionary<string, object> GetCategoryList()
        {
            Dictionary<string, object> dic = new Dictionary<string, object>();
            try
            {
                string sql = "EXEC BOOK_BOOK_S2;";

                cmd.CommandText = sql;
                conn.Open();

                // 데이터 출력
                using (SqlDataReader SR = cmd.ExecuteReader())
                {
                    while (SR.Read())
                    {
                        dic.Add(SR[1].ToString(), (int)SR[0]);
                    }
                }
                return dic;
            }
            catch (SqlException e)
            {
                return dic;
            }
            finally
            {
                conn.Close();
            }
        }

        // 책 위치 리스트
        public Dictionary<string, object> GetBookLocationList()
        {
            Dictionary<string, object> dic = new Dictionary<string, object>();
            try
            {
                string sql = "EXEC BOOK_BOOK_S3;";

                cmd.CommandText = sql;
                conn.Open();

                // 데이터 출력
                using (SqlDataReader SR = cmd.ExecuteReader())
                {
                    while (SR.Read())
                    {
                        dic.Add(SR[1].ToString(), (int)SR[0]);
                    }
                }
                return dic;
            }
            catch (SqlException e)
            {
                return dic;
            }
            finally
            {
                conn.Close();
            }
        }

        // 책 렌탈 상태 리스트
        public Dictionary<string, object> GetBookRentalStateList()
        {
            Dictionary<string, object> dic = new Dictionary<string, object>();
            try
            {
                string sql = "EXEC BOOK_BOOK_S4;";

                cmd.CommandText = sql;
                conn.Open();

                // 데이터 출력
                using (SqlDataReader SR = cmd.ExecuteReader())
                {
                    while (SR.Read())
                    {
                        dic.Add(SR[1].ToString(), (int)SR[0]);
                    }
                }
                return dic;
            }
            catch (SqlException e)
            {
                return dic;
            }
            finally
            {
                conn.Close();
            }
        }

        // 도서 등록
        public bool AddBook(Book book)
        {
            try
            {
                string sql = $@"EXEC	BOOK_Book_I1 @BOOK_TITLE = '{book.bookTitle}'
		                            ,@BOOK_WRITER = '{book.bookWriter}'
		                            ,@BOOK_CATEGORY = {book.bookCategory_no}
		                            ,@BOOK_DESCRIPTION = '{book.bookDescription}'
		                            ,@BOOK_PRICE = {book.bookPrice}
		                            ,@BOOK_COMPANY = '{book.bookCompany}'
		                            ,@BOOK_DATE = '{book.bookDate}'
		                            ,@BOOK_PAGES = {book.bookPages}
		                            ,@BOOK_ORIGINALPATH = '{book.bookOriginalImagePath}'
                                    ,@BOOK_SAVEPATH = '{book.bookSavenameImaegPath}'
		                            ,@BOOK_LOCATION = {book.bookLocationNo}
		                            ,@BOOK_STATE = {book.bookRentalNo};";

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

        // 도서 조회
        public Book GetBookByNumber(string bookNo)
        {
            Book book = null ;
            try
            {
                string sql = $"EXEC BOOK_BOOK_S5 @BOOK_NO = {bookNo};";

                cmd.CommandText = sql;
                conn.Open();

                // 데이터 출력
                using (SqlDataReader SR = cmd.ExecuteReader())
                {
                    while (SR.Read())
                    {
                        book = new Book();
                        book.bookNo = (int)SR[0];
                        book.bookTitle = SR[1].ToString();
                        book.bookWriter = SR[2].ToString();
                        book.bookCategory_no = (int)SR[3];
                        book.bookDescription = SR[4].ToString();
                        book.bookPrice = (int)SR[5];
                        book.bookCompany = SR[6].ToString();
                        book.bookDate = SR[7].ToString();
                        book.bookPages = (int)SR[8];
                        book.bookOriginalImagePath = SR[9].ToString();
                        book.bookSavenameImaegPath = SR[10].ToString();
                        book.bookRentalNo = (int)SR[11];
                        book.bookLocationNo = (int)SR[12];
                    }
                }
                return book;
            }
            catch (SqlException e)
            {
                return book;
            }
            finally
            {
                conn.Close();
            }
        }

        // 도서 삭제
        public bool DeleteBookByNumber(string bookNo)
        {
            try
            {
                string sql = $"EXEC BOOK_BOOK_D1 @BOOK_NO = {bookNo};";

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

        // 사용자 정보 수정
        public bool UpdateBookInfo(Book book)
        {
            try
            {
                string sql = $@"EXEC	BOOK_BOOK_U1 @BOOK_NO = {book.bookNo}
                                    ,@BOOK_TITLE = '{book.bookTitle}'
		                            ,@BOOK_WRITER = '{book.bookWriter}'
		                            ,@BOOK_CATEGORY = {book.bookCategory_no}
		                            ,@BOOK_DESCRIPTION = '{book.bookDescription}'
		                            ,@BOOK_PRICE = {book.bookPrice}
		                            ,@BOOK_COMPANY = '{book.bookCompany}'
		                            ,@BOOK_DATE = '{book.bookDate}'
		                            ,@BOOK_PAGES = {book.bookPages}
		                            ,@BOOK_ORIGINALPATH = '{book.bookOriginalImagePath}'
                                    ,@BOOK_SAVEPATH = '{book.bookSavenameImaegPath}'
		                            ,@BOOK_LOCATION = {book.bookLocationNo}
		                            ,@BOOK_STATE = {book.bookRentalNo};";

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

        // 랜덤하게 1개의 도서 받아오는 메서드
        public DataTable GetRandomBook()
        {
            DataTable dt = null;
            try
            {
                string sql = $"EXEC BOOK_BOOK_S6;";

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
    }
}
