using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Coronavirus.Methods
{
    public class getNews
    {
        public static string News()
        {
            List<string> Title = new List<string>();
            for (int i = 0; i < JsonData.News()["data"]["news"].Count(); i++)
            {
                string news = $"{JsonData.News()["data"]["news"][i]["title"].ToString()}\n{JsonData.News()["data"]["news"][i]["url"].ToString()}\n\n";
                Title.Add(news);
            }
            return String.Join("\n", Title);
        }
        public static string latestNews()
        {
            string Title = $"{JsonData.News()["data"]["news"][0]["title"].ToString()}\n{JsonData.News()["data"]["news"][0]["url"].ToString()}\n\n";
            return Title;
        }
    }
}
