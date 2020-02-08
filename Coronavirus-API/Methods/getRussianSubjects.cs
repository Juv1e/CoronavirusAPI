using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Coronavirus.Methods
{
    public class getRussianSubjects
    {
        public static string Get()
        {
            List<string> Subjects = new List<string>();
            int cnt = JsonData.RussianSubjects()["data"]["subjects"].Count();
            for (int i = 0; i < cnt; i++)
            {
                Subjects.Add(JsonData.RussianSubjects()["data"]["subjects"][i]["ru"].ToString());
            }
            return String.Join("\n", Subjects);
        }
    }
}
