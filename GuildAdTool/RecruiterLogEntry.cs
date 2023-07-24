using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using JohnBPearson.Windows.Forms.Recruiting;

namespace JohnBPearson.Windows.Forms.Recruiting
{
    public class RecruiterLogEntry
    {
        private const string delim = " - ";

        public string CreateLogEntry(IList planetsListsplanetsLists)
        {
            var sb = new StringBuilder();

            var now = DateTime.Now;
            sb.Append($"{now.Month}/{now.Day}{delim}");
            sb.Append($"{now.DayOfWeek.ToString()}{delim}");
            sb.Append($"SUN/DARK {delim}");
            DateTime.Now.AddHours(1);
            sb.Append($"{DateTime.Now.AddHours(1).ToString("t")} EST {delim}");
            foreach (Planets planets in planetsListsplanetsLists)
            {
                sb.Append($"{planets.Type.ToString()},");
                //  plan
                //  ets.Type.
                // PlanetsListItems.
             //   planets.Type
            }
            return sb.ToString();
        }

        ///07/22 - Sunday - Sun - 12:01am EST - A, C, G
    }
}
