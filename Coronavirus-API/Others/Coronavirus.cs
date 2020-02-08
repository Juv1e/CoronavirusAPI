using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using Newtonsoft.Json.Linq;

namespace Coronavirus
{
    public class JsonData
    {
        public static JObject News()
        {
            WebClient wc = new WebClient();
            string jsonResponse = wc.DownloadString("https://coronavirus-monitor.ru/api/v1/statistics/get-news");
            JObject parse = JObject.Parse(jsonResponse);
            return parse;
        }
        public static JObject Countries()
        {
            WebClient wc = new WebClient();
            string jsonResponse = wc.DownloadString("https://coronavirus-monitor.ru/api/v1/statistics/get-countries");
            JObject parse = JObject.Parse(jsonResponse);
            return parse;
        }
        public static JObject Сities()
        {
            WebClient wc = new WebClient();
            string jsonResponse = wc.DownloadString("https://coronavirus-monitor.ru/api/v1/statistics/get-cities");
            JObject parse = JObject.Parse(jsonResponse);
            return parse;
        }
        public static JObject RussianSubjects()
        {
            WebClient wc = new WebClient();
            string jsonResponse = wc.DownloadString("https://coronavirus-monitor.ru/api/v1/statistics/get-russian-subjects");
            JObject parse = JObject.Parse(jsonResponse);
            return parse;
        }
        public static JObject Statistic()
        {
            WebClient wc = new WebClient();
            string jsonResponse = wc.DownloadString("https://corona-virus.live/live");
            JObject parse = JObject.Parse(jsonResponse);
            return parse;
        }
    }
}
