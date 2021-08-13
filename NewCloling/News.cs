using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace NewCloling
{
    class News
    {
        public string Title { get; set; }
        public string OriginalLink{get; set;}
        public string Link { get; set; }
        public string Description { get; set; }
        public DateTime Pubdate { get; set; }

        public News(string title, string originalLink, string link, string description, DateTime pubdate)
        {
            Title = title;
            OriginalLink = originalLink;
            Link = link;
            Description = description;
            Pubdate = pubdate;
        }

        public static News Make(XmlNode xn)
        {
            try
            {
                string title = Strip(xn.SelectSingleNode("title").InnerText);
                string olink = Strip(xn.SelectSingleNode("originallink").InnerText);
                string link = Strip(xn.SelectSingleNode("link").InnerText);
                string description = Strip(xn.SelectSingleNode("description").InnerText);
                DateTime pubdate = DateTime.Parse(xn.SelectSingleNode("pubDate").InnerText);
                return new News(title, olink, link, description, pubdate);
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
            while(s < e)
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
