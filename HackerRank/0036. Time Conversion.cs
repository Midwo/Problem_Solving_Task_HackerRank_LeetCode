using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.HackerRank
{
    internal class HackerRank_0036
    {
        ////36. Time Conversion (EASY)
        public string timeConversion(string s)
        {
            DateTime timeValue = Convert.ToDateTime(s);
            return timeValue.ToString("HH:mm:ss");
        }
    }
}
