using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2144
    {
        ////(2144.) Minimum Cost of Buying Candies With Discount (EASY)
        public int MinimumCost(int[] cost)
        {
            int totalMinimumCost = 0;
            Array.Sort(cost);
            int lastIndex = cost.Length-1;
            
            while (lastIndex > -1)
            {
                if(lastIndex > 1)
                {
                    totalMinimumCost += cost[lastIndex--];
                    totalMinimumCost += cost[lastIndex--];
                    lastIndex--;
                }
                else
                {
                    totalMinimumCost += cost[lastIndex--];    
                }
            }

            return totalMinimumCost;
        }
    }
}
