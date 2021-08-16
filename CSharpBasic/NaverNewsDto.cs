using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace CSharpBasic
{
    class NaverNewsDto
    {
        public string Title { get; set; }
        public string OriginalLink { get; set; }
        public string Link { get; set; }
        public string Description { get; set; }
        public DateTime Pubdate { get; set; }

        public NaverNewsDto(string title, string originalLink, string link, string description, DateTime pubdate)
        {
            Title = title;
            OriginalLink = originalLink;
            Link = link;
            Description = description;
            Pubdate = pubdate;
        }

        // XML 형식으로 데이터를 받아올 때
        public static NaverNewsDto Make(XmlNode xn)
        {
            try
            {
                string title = Strip(xn.SelectSingleNode("title").InnerText);
                string olink = Strip(xn.SelectSingleNode("originallink").InnerText);
                string link = Strip(xn.SelectSingleNode("link").InnerText);
                string description = Strip(xn.SelectSingleNode("description").InnerText);
                DateTime pubdate = DateTime.Parse(xn.SelectSingleNode("pubDate").InnerText);
                return new NaverNewsDto(title, olink, link, description, pubdate);
            }
            catch
            {
                return null;
            }
        }
        // JSON
        public static NaverNewsDto Make(NaverNewsDto dto)
        {
            try
            {
                string title = Strip(dto.Title);
                string olink = Strip(dto.OriginalLink);
                string link = Strip(dto.Link);
                string description = Strip(dto.Description);
                DateTime pubdate = DateTime.Parse(dto.Pubdate.ToString());
                return new NaverNewsDto(title, olink, link, description, pubdate);
            }
            catch
            {
                return null;
            }
        }

        private static string Strip(string innerText)
        {
            int s = innerText.IndexOf("<");
            int e = innerText.IndexOf(">");
            while (s < e)
            {
                string b = innerText.Substring(0, s);
                string a = innerText.Substring(e + 1);
                innerText = b + a;
                s = innerText.IndexOf("<");
                e = innerText.IndexOf(">");
            }
            return innerText;
        }

        public override string ToString()
        {
            return Title;
        }
    }
}