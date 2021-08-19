using BookManagementProgram.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Net;
using System.Net.Sockets;
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
                            , (int)SR[7]
                            , (int)SR[8]
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

        public bool InsertLoginLog()
        {
            try
            {
                string sql = $"EXEC BOOK_LOGIN_I1 @USER_NO = {user.userNo}, @USER_ID = '{user.userId}', @ENTER_IP = '{GetExternalIPAddress()}';";

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

        // 외부 IP
        public static string GetExternalIPAddress()
        {
            string externalip = new WebClient().DownloadString("http://ipinfo.io/ip").Trim();

            return externalip ?? GetInternalIPAddress();//null경우 내부 IP 반환;
        }

        // 내부
        // DNS, 단순 도메인 이름 확인 기능이 제공
        // GetGostEntity, 호스트 이름 또는 IP 주소를 IPHostEntry 인스턴스로 확인
        // GetHostName, 로컬 컴퓨터의 호스트 이름을 가져온다
        public static string GetInternalIPAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());

            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }

            throw new Exception("인터넷 연결 없음");
        }
    }
}