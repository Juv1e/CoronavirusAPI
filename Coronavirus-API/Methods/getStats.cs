using System;
using System.Collections.Generic;
using System.Text;

namespace Coronavirus.Methods
{
    public class getStats
    {
        public static string Confirmed()
        {
            string data = Coronavirus.JsonData.Statistic()["infected"].ToString();
            return data;
        }
        public static string Deaths()
        {
            string data = Coronavirus.JsonData.Statistic()["deaths"].ToString();
            return data;
        }
        public static string Recovered()
        {
            string data = Coronavirus.JsonData.Statistic()["recovered"].ToString();
            return data;
        }
    }
}
