using BookManagementProgram.Model;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;

namespace BookManagementProgram.Repository
{
    class BookUserRepository : IBookUserRepository
    {
        private SqlConnection conn = null;
        private SqlCommand cmd = null;
        public static List<User> userList = null;
        public static User user = null;

        public BookUserRepository()
        {
            conn = DBConn.DBConn.getConn();
            cmd = new SqlCommand();
            cmd.Connection = conn;
        }

        // 로그인 로직
        public string Login(string userId, string userPw)
        {
            try
            {
                string sql = $"EXEC BOOK_LOGIN_S1 @USER_ID = '{userId}', @USER_PW = '{Encryption(userPw)}';";

                cmd.CommandText = sql;
                conn.Open();

                // 데이터 출력
                using (SqlDataReader SR = cmd.ExecuteReader())
                {
                    while (SR.Read())
                    {
                        user = new User(
                            SR[0].ToString()
                            , SR[1].ToString()
                            , SR[2].ToString()
                            , SR[3].ToString()
                            , SR[4].ToString()
                            , SR[5].ToString()
                            , SR[6].ToString()
                            , SR[7].ToString()
                            , SR[8].ToString()
                            );
                    }
                    SR.Close();
                }

                return user.userNo;
            }
            catch(SqlException e)
            {
                return e.Message;
            }
            finally
            {
                conn.Close();
            }
        }

        // SHA256 암호화 메서드
        public static string Encryption(string data)
        {
            SHA256 sha = new SHA256Managed();
            byte[] hash = sha.ComputeHash(Encoding.ASCII.GetBytes(data));
            StringBuilder stringBuilder = new StringBuilder();
            foreach (byte b in hash)
            {
                stringBuilder.AppendFormat("{0:x2}", b);
            }
            return stringBuilder.ToString();
        }

        // 아이디 찾기 로직
        public string FindById(string userNo, string userName)
        {
            try
            {
                string sql = $"EXEC BOOK_LOGIN_S2 @USER_NO = {userNo}, @USER_NAME = '{userName}';";
                string user_id = string.Empty;

                cmd.CommandText = sql;
                conn.Open();

                // 데이터 출력
                using (SqlDataReader SR = cmd.ExecuteReader())
                {
                    while (SR.Read())
                    {
                        user_id = SR[0].ToString();
                    }
                    SR.Close();
                }

                return $"아이디 : {user_id} 입니다.";
            }
            catch (SqlException e)
            {
                return e.Message;
            }
            finally
            {
                conn.Close();
            }
        }

        // 비밀번호 찾기 로직
        public bool FindByPassword(string userNo, string userId, string newPassword)
        {
            try
            {
                string sql = $"EXEC BOOK_LOGIN_U1 @USER_NO = {userNo}, @USER_ID = '{userId}', @NEW_PW = '{Encryption(newPassword)}';";

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
    }
}