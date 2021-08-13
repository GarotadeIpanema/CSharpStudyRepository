using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Xml;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace NewCloling
{
    class NaverNews
    {
        public string SRC { get; set; }
        public string ID { get; set; }
        public string Secret { get; set; }

        public NaverNews(string iD, string secret)
        {
            this.ID = iD;
            this.Secret = secret;
        }

        public int Find(string src)
        {
            this.SRC = src;
            Stream stream;
            string url = $"https://openapi.naver.com/v1/search/news.xml?query={SRC}&sort=date";
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

        public List<News> FindNewsToXML(int start, int display)
        {
            Stream stream;
            string url = $"https://openapi.naver.com/v1/search/news.xml?query={SRC}&display={display}&start={start}&sort=date";

            XmlDocument xdoc = MakeXMLDocument(url, out stream);
            XmlNode node = xdoc.SelectSingleNode("rss");
            XmlNode n = node.SelectSingleNode("channel");
            XmlNodeList xnl = n.SelectNodes("item");
            List<News> nc = new List<News>();
            News news;
            foreach(XmlNode xn in xnl)
            {
                news = News.Make(xn);
                if(news == null)
                {
                    break;
                }
                nc.Add(news);
            }
            stream.Close();
            return nc;
        }

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

        public List<News> FindNewsJson(int start, int display)
        {
            string url = $"https://openapi.naver.com/v1/search/news.json?query={SRC}&display={display}&start={start}&sort=date";

            var parseJson = JObject.Parse(MakeJSONDocument(url));
            
            // var QueryResultCount = Convert.ToInt32(parseJson["display"]);
            // var TotalResultCount = Convert.ToInt32(parseJson["total"]);

            List<News> news =  JsonConvert.DeserializeObject<List<News>>(parseJson["items"].ToString());

            return news;
        }
    }
}
