using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Coronavirus.Methods
{
    public class getСities
    {
        public static string Cities()
        {
            List<string> cities = new List<string>();
            int cnt = Coronavirus.JsonData.Сities()["data"]["cities"].Count();
            for (int i = 0; i < cnt; i++)
            {
                cities.Add(Coronavirus.JsonData.Сities()["data"]["cities"][i]["en"].ToString());
            }
            return String.Join("\n", cities);
        }
    }
}
