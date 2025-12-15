using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2110
    {
        ////(2110.) Number of Smooth Descent Periods of a Stock (MEDIUM)
        public long GetDescentPeriods(int[] prices)
        {
            long sum = 0;
            long currContiguousCount = 1;
            int last = prices[0];

            for (int i = 1; i < prices.Length; i++) 
            {
                if (last - prices[i] == 1)
                {
                    currContiguousCount++;
                }
                else if (currContiguousCount > 1)
                {
                    sum += (1 + currContiguousCount) * currContiguousCount / 2;
                    currContiguousCount = 1;
                }
                else
                {
                    sum += 1;
                }
                last = prices[i];
            }

            if (currContiguousCount > 0)
            {
                sum += (1 + currContiguousCount) * currContiguousCount / 2;
            }

            return sum;
        }
    }
}
