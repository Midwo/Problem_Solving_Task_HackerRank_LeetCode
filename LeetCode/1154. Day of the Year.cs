using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1154
    {
        ////(1154.) Day of the Year (EASY)
        public int DayOfYear(string date)
        {
            DateTime stringToDateTime = DateTime.Parse(date);

            return stringToDateTime.DayOfYear;
        }
    }
}
