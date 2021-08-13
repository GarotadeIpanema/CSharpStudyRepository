using System;
using System.Collections.Generic;

namespace NewCloling
{
    class Program
    {
        static void Main(string[] args)
        {
            // naver api id & scret key
            string id = "";
            string secret = "";

            NaverNews nn = new NaverNews(id, secret);
            nn.SRC = "대구";
            List<News> news = nn.FindNewsJson(1, 20);

            foreach (News ns in news)
            {
                Console.WriteLine(ns.Title);
                Console.WriteLine("==");
                Console.WriteLine(ns.Description);
                Console.WriteLine("===========================");
            }

            /*
            int total = nn.Find("코로나");
            Console.WriteLine(total);
            List<News> nc = nn.FindNewsToXML(1, 20);
            foreach(News ns in nc)
            {
                Console.WriteLine(ns.Title);
                Console.WriteLine("==");
                Console.WriteLine(ns.Description);
                Console.WriteLine("===========================");
            }
            */
        }
    }
}
