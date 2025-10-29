using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2651
    {
        ////(2651.) Calculate Delayed Arrival Time (EASY)
        public int FindDelayedArrivalTime(int arrivalTime, int delayedTime)
        {
            ////0ms, Beats: 100.00%

            return (arrivalTime + delayedTime) % 24;
        }
    }
}
