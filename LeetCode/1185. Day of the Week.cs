using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1185
    {
        ////(1185.) Day of the Week (EASY)
        public string DayOfTheWeek(int day, int month, int year)
        {
            DateTime dateTime = new DateTime(year, month, day);

            return dateTime.DayOfWeek.ToString();
        }
    }
}
