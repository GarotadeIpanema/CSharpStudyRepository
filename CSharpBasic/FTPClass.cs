using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CSharpBasic
{
    class FTPClass
    {
        // https://blog.hexabrain.net/151
        // delegate, 대리자, 대신 일을 해준다, 메소드 참조를 포함하고 있는 영역
        // delegate 반환형 델리게이트명(매개변수..); public delegate void Del(string message);
        // 메소드의 참조를 포함(JS Callbackfuntion과 유사한듯)
        // 메소드를 매개변수로 넘길 수 있다는 말인가요?'라고 생각하시는 분들이 있을지 모르겠는데, 네 맞습니다. 델리게이트를 이용해서 메소드를 넘겨줄 수 있습니다.
        // 매개변수의 데이터 형식과 반환형은 참조할 메소드의 매개변수의 데이터 형식과 반환형에 맞추어야만 합니다. 개수 역시도.

        // Delegate chain, 델리게이트 체인
        // 델리게이트 하나를 가지고 여러개의 메소드를 한번에 호출할 수 있습니다
        // delegate void PDelegate(int a, int b);
        // PDelegate pd = (PDelegate)Delegate.Combine(new PDelegate(Plus), new PDelegate(Minus), new PDelegate(Division), new PDelegate(Multiplication));
        public delegate void ExceptionEventHandler(string locationID, Exception ex);

        // Event 이벤트, 특정 사건이 벌어지면 알리는 메시지
        // 사용자가 컨트롤(버튼, 이미지, 레이블, 텍스트박스 등..)을 클릭하거나 창을 닫거나 열때 사용자에게 개체를 알리는 것을 이벤트 발생이라고 합니다.
        // 한정자 event 델리게이트 이름;, public delegate void MyEventHandler(string message); / public event MyEventHandler Active;
        public event ExceptionEventHandler ExceptionEvent;

        public Exception LastException = null;

        public bool isConnected { get; set; }

        private string ipAddr = string.Empty;
        private string port = string.Empty;
        private string userId = string.Empty;
        private string pwd = string.Empty;

        List<DirectoryPath> directoryPaths = null;

        public FTPClass()
        {
        }

        // 서버 연결
        public bool ConnectToServer(string ip, string port, string userId, string pwd)
        {
            this.isConnected = false;

            this.ipAddr = ip;
            this.port = port;
            this.userId = userId;
            this.pwd = pwd;

            string url = $@"FTP://{this.ipAddr}:{this.port}/";

            try
            {
                // FTP(파일 전송 프로토콜) 클라이언트를 구현
                FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(url);
                // 요청에 대한 인증 정보를 가져오거나 설정
                // 기본, 다이제스트, NTLM 및 Kerberos 인증과 같은 암호 기반의 인증 체계에 자격 증명을 제공
                ftpWebRequest.Credentials = new NetworkCredential(this.userId, this.pwd);
                // 인터넷 리소스에 영구 연결을 할 것인지 여부를 나타내는 값을 가져오거나 설정
                //  true HTTP 헤더 값이 Keep-alive이면 Connection이고, 그렇지 않으면 false입니다
                ftpWebRequest.KeepAlive = false;
                // 요청에 대한 메서드를 가져오거나 설정
                // FTP 서버에 있는 파일의 간단한 목록을 가져오는 FTP NLIST 프로토콜 메서드를 나타냅니다
                ftpWebRequest.Method = WebRequestMethods.Ftp.ListDirectory;
                // 클라이언트 애플리케이션의 데이터 전송 프로세스에 대한 동작을 가져오거나 설정
                ftpWebRequest.UsePassive = false;

                // FTP 서버 응답을 반환
                using (ftpWebRequest.GetResponse())
                {
                }

                this.isConnected = true;
            }
            catch(Exception ex)
            {
                this.LastException = ex;

                // 멤버의 특성에 대한 정보를 가져오고 멤버 메타데이터에 대한 액세스를 제공
                System.Reflection.MemberInfo info = System.Reflection.MethodInfo.GetCurrentMethod();
                string id = $"{info.ReflectedType.Name}.{info.Name}";

                if(this.ExceptionEvent != null)
                {
                    this.ExceptionEvent(id, ex);
                }

                return false;
            }

            return true;
        }

        // 파일업로드
        public bool UpLoad(string folder, string filename)
        {
            return upload(folder, filename);
        }

        private bool upload(string folder, string filename)
        {
            try
            {
                makeDir(folder);

                // 파일을 만들고, 복사하고, 삭제하고, 이동하고, 열기 위한 속성 및 인스턴스 메서드를 제공하고, FileStream 개체를 만드는 것을 도와줍니다. 이 클래스는 상속될 수 없습니다.
                FileInfo fileinfo = new FileInfo(filename);

                folder = folder.Replace('\\', '/');
                filename = fileinfo.Name;

                string url = $@"FTP://{this.ipAddr}:{this.port}/{folder}/{filename}";

                FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(url);
                ftpWebRequest.Method = WebRequestMethods.Ftp.UploadFile;
                ftpWebRequest.Credentials = new NetworkCredential(this.userId, this.pwd);
                ftpWebRequest.KeepAlive = false;
                // 파일 전송을 위한 데이터 형식을 지정하는 Boolean 값을 가져오거나 설정
                // 서버에 전송할 데이터가 이진 데이터임을 나타낼 경우 true이고, 데이터가 텍스트임을 나타낼 경우 false
                ftpWebRequest.UseBinary = false;
                ftpWebRequest.UsePassive = false;

                // FtpWebRequest 클래스에서 무시되는 값을 가져오거나 설정
                ftpWebRequest.ContentLength = fileinfo.Length;

                int buffLength = 2048;
                byte[] buff = new byte[buffLength];
                int contentLen;

                // 파일에 대해 Stream을 제공하여 동기 및 비동기 읽기/쓰기 작업을 모두 지원
                using (FileStream fs = fileinfo.OpenRead())
                {
                    // 바이트 시퀀스에 대한 일반 뷰를 제공합니다. 이 클래스는 추상 클래스입니다
                    // 스트림이란 소리는 데이터가 끊기지 않고 연속적으로 데이터가 전송되는 것
                    // 서브클래스에서 재정의될 때, 인터넷 리소스에 데이터를 쓰기 위해 Stream을 반환
                    using (Stream strm = ftpWebRequest.GetRequestStream())
                    {
                        contentLen = fs.Read(buff, 0, buffLength);

                        while(contentLen != 0)
                        {
                            strm.Write(buff, 0, contentLen);
                            contentLen = fs.Read(buff, 0, buffLength);
                        }
                    }
                    fs.Flush();
                    fs.Close();
                }

                if (buff != null)
                {
                    Array.Clear(buff, 0, buff.Length);
                    buff = null;
                }
            }
            catch(Exception ex)
            {
                this.LastException = ex;

                System.Reflection.MemberInfo info = System.Reflection.MethodInfo.GetCurrentMethod();
                string id = $"{info.ReflectedType.Name}.{info.Name}";

                if (this.ExceptionEvent != null)
                {
                    this.ExceptionEvent(id, ex);
                }

                return false;
            }

            return true;
        }

        private void makeDir(string dirName)
        {
            string[] arrDir = dirName.Split('\\');
            string currentDir = string.Empty;

            try
            {
                foreach(string tmpFolder in arrDir)
                {
                    try
                    {
                        if (tmpFolder == string.Empty) continue;

                        currentDir += @"/" + tmpFolder + @"/";

                        string url = $@"FTP://{this.ipAddr}:{this.port}{currentDir}";

                        FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(url);
                        ftpWebRequest.Credentials = new NetworkCredential(this.userId, this.pwd);
                        ftpWebRequest.Method = WebRequestMethods.Ftp.MakeDirectory;
                        ftpWebRequest.KeepAlive = false;
                        ftpWebRequest.UsePassive = false;


                        FtpWebResponse response = (FtpWebResponse)ftpWebRequest.GetResponse();
                        response.Close();
                    }
                    catch { }
                }
            }
            catch(Exception ex)
            {
                this.LastException = ex;

                System.Reflection.MemberInfo info = System.Reflection.MethodInfo.GetCurrentMethod();
                string id = $"{info.ReflectedType.Name}.{info.Name}";

                if (this.ExceptionEvent != null)
                {
                    this.ExceptionEvent(id, ex);
                }
            }
        }

        // 다운로드

        public bool DownLoad(string localFullPathFile, string serverFullPathFile)
        {
            return download(localFullPathFile, serverFullPathFile);
        }
        private bool download(string localFullPathFile, string serverFullPathFile)
        {
            try
            {
                // checkDir(localFullPathFile);

                string url = $@"FTP://{this.ipAddr}:{this.port}/{serverFullPathFile}";

                FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(url);

                ftpWebRequest.Credentials = new NetworkCredential(userId, pwd);
                ftpWebRequest.KeepAlive = false;
                ftpWebRequest.UseBinary = true;
                ftpWebRequest.UsePassive = false;
                
                using(FtpWebResponse response = (FtpWebResponse)ftpWebRequest.GetResponse())
                {
                    using(FileStream outputStrem = new FileStream(localFullPathFile, FileMode.Create, FileAccess.Write))
                    {
                        using(Stream ftpStream = response.GetResponseStream())
                        {
                            int bufferSize = 2048;
                            int readCount;
                            byte[] buffer = new byte[bufferSize];

                            readCount = ftpStream.Read(buffer, 0, bufferSize);
                            while(readCount > 0)
                            {
                                outputStrem.Write(buffer, 0, readCount);
                                readCount = ftpStream.Read(buffer, 0, bufferSize);
                            }

                            ftpStream.Close();
                            outputStrem.Close();

                            if(buffer != null)
                            {
                                Array.Clear(buffer, 0, buffer.Length);
                                buffer = null;
                            }
                        }
                    }
                }
                return true;
            }
            catch(Exception ex)
            {
                this.LastException = ex;
                if (serverFullPathFile.Contains(@"\ZOOM\")) return false;

                System.Reflection.MemberInfo info = System.Reflection.MethodInfo.GetCurrentMethod();
                string id = $"{info.ReflectedType.Name}.{info.Name}";

                if(this.ExceptionEvent != null)
                {
                    this.ExceptionEvent(id, ex);
                }
                return false;
            }
        }

        // 업로드할 폴더가 있는지 확인
        private void checkDir(string localFullPathFile)
        {
            FileInfo fileinfo = new FileInfo(localFullPathFile);

            // 파일이 없는지 확인
            if (!fileinfo.Exists)
            {
                DirectoryInfo dirinfo = new DirectoryInfo(fileinfo.DirectoryName);
                // 폴더가 없으면
                if (!dirinfo.Exists)
                {
                    dirinfo.Create();
                }
            }
        }

        public List<DirectoryPath> GetFTPList(string path)
        {
            directoryPaths = new List<DirectoryPath>(); ;
            return getFTPList(path);
        }

        // 전체파일 불러오기
        private List<DirectoryPath> getFTPList(string path)
        {
            string url = $@"FTP://{this.ipAddr}:{this.port}/{path}";
            DirectoryPath directoryPath = null;
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(url);
            request.Credentials = new NetworkCredential(userId, pwd);
            request.Method = WebRequestMethods.Ftp.ListDirectoryDetails;

            using (FtpWebResponse response = (FtpWebResponse)request.GetResponse())
            {
                using(StreamReader reader = new StreamReader(response.GetResponseStream(), System.Text.Encoding.UTF8))
                {
                    string strData = reader.ReadToEnd();
                    if(string.IsNullOrEmpty(strData))
                    {
                        directoryPath = new DirectoryPath();
                        directoryPath.Folder = path;
                        directoryPath.File = "EMPTY";
                        directoryPaths.Add(directoryPath);
                    }

                    string[] filename = strData.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);

                    foreach (string file in filename)
                    {
                        string[] fileDetailes = file.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);

                        directoryPath  = new DirectoryPath();

                        if (fileDetailes[0].Contains("d"))
                        {
                            getFTPList($"{path}{fileDetailes[8]}/");
                        }
                        else
                        {
                            directoryPath.Folder = path;
                            directoryPath.File = fileDetailes[8];
                            directoryPaths.Add(directoryPath);
                        }
                        //Console.WriteLine($"권한 : {fileDetailes[0]}");
                        //Console.WriteLine($"파일or폴더 : {fileDetailes[8]}");
                    }

                    return directoryPaths;
                }
            }
        }

        // FTP 파일 삭제
        public bool DeleteFTPFile(string path)
        {
            try
            {
                string url = $@"FTP://{this.ipAddr}:{this.port}/{path}";

                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(url);

                request.Credentials = new NetworkCredential(userId, pwd);
                
                if (Regex.IsMatch(path, @"(\.)[a-zA-Z0-9ㄱ-ㅎ가-힣]+$"))
                {
                    request.Method = WebRequestMethods.Ftp.DeleteFile;
                }
                else
                {
                    request.Method = WebRequestMethods.Ftp.RemoveDirectory;
                }

                using (request.GetResponse()) { }
            }
            catch
            {
                return false;
            }
            return true;
        }
    }
}
