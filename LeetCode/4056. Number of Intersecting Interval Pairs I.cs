using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_4056
    {
        ////(4056.) Number of Intersecting Interval Pairs I (EASY)
        public int CountIntersectingIntervals(int[][] intervals)
        {
            int countIntervalParis = 0;
            int length = intervals.Length;

            for (int startPairIndex = 0; startPairIndex < length; startPairIndex++)
            {
                int startValue = intervals[startPairIndex][0];
                int stopValue = intervals[startPairIndex][1];

                for (int nextPairIndex = startPairIndex + 1; nextPairIndex < length; nextPairIndex++)
                {
                    if (startValue <= intervals[nextPairIndex][1] && stopValue >= intervals[nextPairIndex][0])
                    {
                        countIntervalParis++;
                    }
                }
            }

            return countIntervalParis;
        }
    }
}
