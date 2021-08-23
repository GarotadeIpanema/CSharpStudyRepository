using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using SendGrid;
using SendGrid.Helpers.Mail;
using Twilio;
using Twilio.Rest.Api.V2010.Account;

namespace test
{
    
    class Program
    {
        private static SqlConnection conn = null;
        private static SqlCommand cmd = null;
        private static List<byte[]> pw = new List<byte[]>();

        static void Main(string[] args)
        {
            Console.WriteLine(Encryption("admin"));
            // ftp 삭제 폴더 경로 정규표현식
            // Console.WriteLine(Regex.IsMatch(@"/test/test", @"(\/|\\){1}[a-zA-Z0-9ㄱ-ㅎ가-힣]+$"));

            // ftp 파일 폴더 구분
            //Console.WriteLine(Regex.IsMatch("/test/test/test.xsl", @"(\/|\\){1}[a-zA-Z0-9ㄱ-ㅎ가-힣]+(\.)[a-zA-Z0-9ㄱ-ㅎ가-힣]+$"));


            /* 전화번호 확인
            for(int i = 0; i < 10; i++)
            {
                string phone = Console.ReadLine();
                string pattern = @"01[0-4]{1}[0-9]{3,4}[0-9]{4}";

                Console.WriteLine(Regex.IsMatch(phone, pattern));
            }
            */


            // twilo
            /*
            try
            {
                string accountSid = "";
                string authToken = "";

                TwilioClient.Init(accountSid, authToken);

                var message = MessageResource.Create(
                    body: "Join Earth's mightiest heroes. Like Kevin Bacon.",
                    from: new Twilio.Types.PhoneNumber("+"),
                    to: new Twilio.Types.PhoneNumber("+")
                );
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            */

            //var apiKey = Environment.GetEnvironmentVariable();

            /*
             // dit 접속 코드
            string DB_IP, DB_ID, DB_PW, DB_NM;

            DB_IP = "";
            DB_ID = "";
            DB_PW = "";
            DB_NM = "";

            string connString = "Server=" + DB_IP
                                  + ";database=" + DB_NM
                                  + ";uid=" + DB_ID
                                  + ";pwd=" + DB_PW;
            conn = new SqlConnection(connString);
            cmd = new SqlCommand();
            cmd.Connection = conn;

            string sql = "select * from TEST_B_LOG2";
            cmd.CommandText = sql;
            conn.Open();
            
            using (SqlDataReader SR = cmd.ExecuteReader())
            {
                while (SR.Read())
                {
                    pw.Add((byte[])SR[2]);
                }
                SR.Close();
            }
            conn.Close();

            string[] strs = { "test", "password@!!", "문민승", "문민승!@#$%^&*()", "test!@#$%^&*()00"};

            for (int i = 0; i < strs.Length; i++)
            {
                byte[] a1 = Encryption3(strs[i]);
                Console.WriteLine(a1);
                Console.WriteLine(pw[0]);
                Console.WriteLine(a1.Equals(pw[i]));
            }

            */

            //9f86d081884c7d659a2feaa0c55ad015a3bf4f1b2b0b822cd15d6c15b0f00a08

            /*
            // 외부 ip
            Console.WriteLine(getIP()); // http://checkip.dyndns.org/ 활용
            Console.WriteLine(GetExternalIPAddress()); // http://ipinfo.io/ip 활용, http://icanhazip.com 대체 가능

            // 타사이트 ip
            List<string> iplist = GetIP2("www.naver.net");
            foreach(string ip in iplist)
            {
                Console.WriteLine(ip);
            }
            */


            // 외부 아이피
            //Console.WriteLine(new WebClient().DownloadString("http://ipinfo.io./ip").Trim());
            //string email = Console.ReadLine();
            //Console.WriteLine(Regex.IsMatch(email, @"[a-zA-Z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-zA-Z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-zA-Z0-9](?:[a-zA-Z0-9-]*[a-zA-Z0-9])?\.)+[a-zA-Z0-9](?:[a-zA-Z0-9-]*[a-zA-Z0-9])?"));

            // Execute().Wait();
            /*
            string code = GetRandomCode();
            Console.WriteLine(code);
            string check = Console.ReadLine();
            Console.WriteLine(code == check);
            */

            /*
            string externalip = new WebClient().DownloadString("http://ipinfo.io./ip").Trim();

            if (String.IsNullOrWhiteSpace(externalip))
            {
                externalip = GetInternalIPAddress();
            }

            Console.WriteLine(externalip);
            */
            //Execute().Wait();

            //Console.WriteLine(Encryption("admin"));
            // 0x8c6976e5b5410415bde908bd4dee15dfb167a9c873fc4bb8a81f6f2ab448a918
            //0xB9E15D36DACFA970D8917F8A2D25B3E56074B572

            /*
            List<string> a = new List<string> { "a", "b", "c", "d", "e", "a", "d" };
            a = a.Distinct().ToList();
            a.ForEach(item =>
            {
                Console.WriteLine(item);
            });
            */
        }

        // sendgrid
        static async Task Execute()
        {
            try
            {
                //var apiKey = "";
                var apiKey = Environment.GetEnvironmentVariable("Variable");
                var client = new SendGridClient(apiKey);
                var from = new EmailAddress("","");
                var to = new EmailAddress("");
                var subject = "Sending with SendGrid is Fun";
                var plainTextContent = "and easy to do anywhere, even with C#";
                var htmlContent = "<strong>and easy to do anywhere, even with C#</strong>";
                var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);
                var response = await client.SendEmailAsync(msg);
                Console.WriteLine(response);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
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

        // 타사이트 ip 가져오는 메소드
        public static List<string> GetIP2(string url)
        {
            try
            {
                List<string> iplist = new List<string>();
                // 지정된 호스트의 IP 주소를 반환
                IPAddress[] addresslist = Dns.GetHostAddresses(url);

                foreach(IPAddress addr in addresslist)
                {
                    iplist.Add(addr.ToString());
                }
                return iplist;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        // 외부 IP
        // WebClient, URI로 식별되는 리소스와 데이터를 주고 받기 위한 일반적인 메서드를 제공
        // DownloadString, 요청한 리소스를 String으로 다운로드합니다. 다운로드할 리소스는 URI를 포함하는 String 또는 Uri로 지정할 수 있습니다.
        public static string GetExternalIPAddress()
        {
            string externalip = new WebClient().DownloadString("http://ipinfo.io/ip").Trim();

            if (String.IsNullOrWhiteSpace(externalip))
            {
                externalip = GetInternalIPAddress();//null경우 내부 IP 갖고 오기
            }

            return externalip;
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

        // IP 주소 받아오는 메서드(0(IPv6), 1(IPv4))
        public static string GetIPAddress(int i = 1)
        {
            String strHostName = string.Empty;
            IPHostEntry ipEntry = Dns.GetHostEntry(Dns.GetHostName());
            IPAddress[] addr = ipEntry.AddressList;

            return addr[i].ToString();
        }

        // 내부 ip(0(IPv6), 1(IPv4))
        public static string GetInternalIPAddress(int i = 1)
        {
            String strHostName = string.Empty;
            IPHostEntry ipEntry = Dns.GetHostEntry(Dns.GetHostName());
            IPAddress[] addr = ipEntry.AddressList;

            return addr[i].ToString();
        }

        // 입력받은 문자열 확인 메서드(문자열 반환)
        public string InputDataValidator(string str)
        {
            if (str == String.Empty) return str;

            string SC = @"['<>() \t\r]";
            str = Regex.Replace(str, SC, "", RegexOptions.IgnoreCase);

            string query = @"(insert|select|update|delete|delete from|drop|drop table|truncate|exec master|master)";
            str = Regex.Replace(str, query, "", RegexOptions.IgnoreCase);

            return str;
        }

        // 랜덤 코드 생성
        static string GetRandomCode()
        {
            Random rand = new Random();
            string input = "abcdefghijklmnopqrstuvxyz0123456789!@$&";

            var chars = Enumerable.Range(0, 6).Select(x => input[rand.Next(0, input.Length)]);

            return new string(chars.ToArray()); 
        }
    }
}