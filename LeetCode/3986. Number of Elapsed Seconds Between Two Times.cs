using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3986
    {
        ////(3986.) Number of Elapsed Seconds Between Two Times (EASY)
        public int SecondsBetweenTimes(string startTime, string endTime)
        {
            return (int.Parse(endTime[0..2]) - int.Parse(startTime[0..2])) * 3600 + (int.Parse(endTime[3..5]) - int.Parse(startTime[3..5]))*60 + (int.Parse(endTime[6..8]) - int.Parse(startTime[6..8]));
        }
    }
}
