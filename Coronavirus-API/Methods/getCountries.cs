using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Coronavirus.Methods
{
    public class getCountries
    {
        public static string Get()
        {
            List<string> Countries = new List<string>();
            int cnt = JsonData.Countries()["data"]["countries"].Count();
            for (int i = 0; i < cnt; i++)
            {
                string ru = JsonData.Countries()["data"]["countries"][i]["ru"].ToString();
                string deaths = JsonData.Countries()["data"]["countries"][i]["deaths"].ToString();
                string conf = JsonData.Countries()["data"]["countries"][i]["confirmed"].ToString();
                Countries.Add($"Страна: {ru}\nКол-во зараженных: {conf}\nКол-во смертей: {deaths}\n");
            }
            return String.Join("\n", Countries);
        }
    }
}
