using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3502
    {
        ////(3502.) Minimum Cost to Reach Every Position (EASY)
        public int[] MinCosts(int[] cost)
        {
            int currMinValue = cost[0];

            for (int i = 0; i < cost.Length; i++)
            {
                if(currMinValue < cost[i])
                {
                    cost[i] = currMinValue;
                }
                else
                {
                    currMinValue = cost[i];
                    cost[i] = currMinValue;
                }
            }

            return cost;
        }
    }
}
