using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1288
    {
        ////(1288.) Remove Covered Intervals (MEDIUM)
        public int RemoveCoveredIntervals(int[][] intervals)
        {
            int countRemove = 0;
            int countIntervals = intervals.Length;

            intervals = intervals.OrderBy(x => x[0]).ThenByDescending(x => x[1]).ToArray();

            int endPeriod = intervals[0][1];

            for (int indexInterval = 1; indexInterval < countIntervals; indexInterval++)
            {
                if(endPeriod >= intervals[indexInterval][1])
                {
                    countRemove++;
                }
                else
                {
                    endPeriod = intervals[indexInterval][1];
                }
            } 

            return countIntervals - countRemove;
        }
    }
}
