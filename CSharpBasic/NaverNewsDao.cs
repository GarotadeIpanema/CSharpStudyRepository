using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace CSharpBasic
{
    class NaverNewsDao
    {
        private string SRC { get; set; } // search title
        private string ID { get; set; } // naver api id
        private string Secret { get; set; } // naver api secret

        private string XMLUrl = "https://openapi.naver.com/v1/search/news.xml";
        private string JsonUrl = "https://openapi.naver.com/v1/search/news.json";
        public NaverNewsDao(string iD, string secret)
        {
            this.ID = iD;
            this.Secret = secret;
        }

        // XML 데이터를 받아올 때
        public int Find(string src)
        {
            this.SRC = src;
            Stream stream;
            string url = $"{XMLUrl}?query={SRC}&sort=date";
            XmlDocument xdoc = MakeXMLDocument(url, out stream);
            XmlNode node = xdoc.SelectSingleNode("rss");
            XmlNode n = node.SelectSingleNode("channel");
            int total = int.Parse(n.SelectSingleNode("total").InnerText);
            stream.Close();
            return total;
        }

        private XmlDocument MakeXMLDocument(string url, out Stream stream)
        {
            WebRequest request = null;
            request = WebRequest.Create(url);
            request.Headers.Add("X-Naver-Client-Id", ID);
            request.Headers.Add("X-Naver-Client-Secret", Secret);

            WebResponse response = request.GetResponse();
            stream = response.GetResponseStream();
            XmlDocument xdoc = new XmlDocument();
            xdoc.Load(stream);
            return xdoc;
        }

        public List<NaverNewsDto> FindNewsToXML(int start, int display)
        {
            Stream stream;
            string url = $"{XMLUrl}?query={SRC}&display={display}&start={start}&sort=date";

            XmlDocument xdoc = MakeXMLDocument(url, out stream);
            XmlNode node = xdoc.SelectSingleNode("rss");
            XmlNode n = node.SelectSingleNode("channel");
            XmlNodeList xnl = n.SelectNodes("item");
            List<NaverNewsDto> nc = new List<NaverNewsDto>();
            NaverNewsDto news;
            foreach (XmlNode xn in xnl)
            {
                news = NaverNewsDto.Make(xn);
                if (news == null)
                {
                    break;
                }
                nc.Add(news);
            }
            stream.Close();
            return nc;
        }

        // JSON 형식으로 받아올 때
        private string MakeJSONDocument(string url)
        {
            string responseFromServer = string.Empty;

            try
            {
                WebRequest request = WebRequest.Create(url);

                request.Method = "GET";
                request.ContentType = "application/json";
                request.Headers["X-Naver-Client-Id"] = ID;
                request.Headers["X-Naver-Client-Secret"] = Secret;

                using (WebResponse response = request.GetResponse())
                using (Stream dataStream = response.GetResponseStream())
                using (StreamReader reader = new StreamReader(dataStream))
                    responseFromServer = reader.ReadToEnd();
            }
            catch
            {
                return null;
            }

            return responseFromServer;
        }

        public List<NaverNewsDto> FindNewsJson(int start, int display, string src)
        {
            this.SRC = src;
            string url = $"{JsonUrl}?query={SRC}&display={display}&start={start}&sort=date";

            var parseJson = JObject.Parse(MakeJSONDocument(url));

            // var QueryResultCount = Convert.ToInt32(parseJson["display"]);
            // var TotalResultCount = Convert.ToInt32(parseJson["total"]);

            List<NaverNewsDto> news = JsonConvert.DeserializeObject<List<NaverNewsDto>>(parseJson["items"].ToString());

            NaverNewsDto dto;
            List<NaverNewsDto> nc = new List<NaverNewsDto>();

            foreach (NaverNewsDto ns in news)
            {
                dto = NaverNewsDto.Make(ns);
                if (dto == null)
                {
                    break;
                }
                nc.Add(dto);
            }
            return nc;
        }
    }
}