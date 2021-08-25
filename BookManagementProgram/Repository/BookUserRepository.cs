using BookManagementProgram.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Net;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Text;

namespace BookManagementProgram.Repository
{
    class BookUserRepository
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

        // 로그 입력
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

        // 사용자 전체 리스트
        public DataTable GetAllUsers()
        {
            DataTable dt = new DataTable();
            try
            {
                string sql = "EXEC BOOK_LOGIN_S3;";

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

        // 권한 리스트
        public Dictionary<string, object> GetAuthList()
        {
            Dictionary<string, object> dic = new Dictionary<string, object>();
            try
            {
                string sql = "EXEC BOOK_LOGIN_S4;";

                cmd.CommandText = sql;
                conn.Open();

                // 데이터 출력
                using (SqlDataReader SR = cmd.ExecuteReader())
                {
                    while(SR.Read())
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

        // 등급 리스트
        public Dictionary<string, object> GetGradeList()
        {
            Dictionary<string, object> dic = new Dictionary<string, object>();
            try
            {
                string sql = "EXEC BOOK_LOGIN_S5;";

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

        // 사용자 등록
        public bool AddUser(User user)
        {
            try
            {
                string pw = Encryption(user.userPw);
                string sql = $"EXEC BOOK_LOGIN_I2 @USER_NAME = '{user.userName}', @USER_ADDR = '{user.userAddress}', @USER_BIRTH='{user.userBirth}', @USER_ID='{user.userId}', @USER_PW='{pw}', @USER_AUTH={user.authorityNo}, @USER_GRADE={user.gradeNo};";

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

        // 유저 조회
        public User GetUserByNumber(string userNo)
        {
            User user = null;
            try
            {
                string sql = $"EXEC BOOK_LOGIN_S6 @USER_NO = {userNo};";

                cmd.CommandText = sql;
                conn.Open();

                // 데이터 출력
                using (SqlDataReader SR = cmd.ExecuteReader())
                {
                    while(SR.Read())
                    {
                        user = new User();
                        user.userNo = SR[0].ToString();
                        user.userName = SR[1].ToString();
                        user.userAddress = SR[2].ToString();
                        user.userBirth = SR[3].ToString();
                        user.userId = SR[4].ToString();
                        user.userPw = SR[5].ToString();
                        user.registerDate = SR[6].ToString();
                        user.deregisterDate = SR[7].ToString();
                        user.authorityNo = (int)SR[8];
                        user.gradeNo = (int)SR[9];
                    }
                }
                return user;
            }
            catch (SqlException e)
            {
                return user;
            }
            finally
            {
                conn.Close();
            }
        }

        // 사용자 삭제
        public bool DeleteUserByNumber(string userNo)
        {
            try
            {
                string sql = $"EXEC BOOK_LOGIN_D1 @USER_NO = {userNo};";

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
        public bool UpdateUserInfo(User user)
        {
            try
            {
                string sql = $"EXEC BOOK_LOGIN_U2 @USER_NO = {user.userNo}, @USER_NAME = '{user.userName}', @USER_ADDR = '{user.userAddress}', @USER_BIRTH = '{user.userBirth}', @USER_ID = '{user.userId}', @AUTH_NO = {user.authorityNo}, @GRADE_NO = {user.gradeNo};";

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