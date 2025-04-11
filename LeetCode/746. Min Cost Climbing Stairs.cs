using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_746
    {
        ////(746.) Min Cost Climbing Stairs
        public int MinCostClimbingStairs(int[] cost)
        {
            int startIndex0 = cost[0];
            int startIndex1 = cost[1];
            int minStepCost = 0;

            for (int i = 2; i < cost.Length; i++)
            {
                minStepCost = cost[i] + Math.Min(startIndex0, startIndex1);

                startIndex0 = startIndex1;
                startIndex1 = minStepCost;

            }

            return Math.Min(startIndex0, startIndex1);
        }
    }
}
