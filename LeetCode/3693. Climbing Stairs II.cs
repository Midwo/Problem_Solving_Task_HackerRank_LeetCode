using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3693
    {
        ////(3693.) Climbing Stairs II (MEDIUM)
        public int ClimbStairs(int n, int[] costs)
        {
            int[] dpTotalCost = new int[n+1];

            for (int i = 0; i < n; i++)
            {
                int currCostDP = dpTotalCost[i];
                int newCost = currCostDP + 1 + costs[i];

                if (dpTotalCost[i+1] == 0)
                    dpTotalCost[i + 1] = newCost;
                else
                {
                    dpTotalCost[i + 1] = dpTotalCost[i + 1] > newCost ? newCost : dpTotalCost[i+1];
                }
                if (i + 2 <= n)
                {
                    newCost = currCostDP + 4 + costs[i +1];
                    if (dpTotalCost[i + 2] == 0)
                        dpTotalCost[i + 2] = newCost;
                    else
                    {
                        dpTotalCost[i + 2] = dpTotalCost[i + 2] > newCost ? newCost : dpTotalCost[i + 2];
                    }
                }
                if(i+3 <= n)
                {
                    newCost = currCostDP + 9 + costs[i + 2];
                    if (dpTotalCost[i + 3] == 0)
                        dpTotalCost[i + 3] = newCost;
                    else
                    {
                        dpTotalCost[i + 3] = dpTotalCost[i + 3] > newCost ? newCost : dpTotalCost[i + 3];
                    }
                }
            }

            return dpTotalCost[n];
        }
    }
}
