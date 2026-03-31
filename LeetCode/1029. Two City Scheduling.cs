using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1029
    {
        ////(1029.) Two City Scheduling (MEDIUM)
        public int TwoCitySchedCost(int[][] costs)
        {
            int totalCost = 0;
            int countCityA = 0;
            int countCityB = 0;
            int length = costs.Length;
            int half = length / 2;

            int[][] diffABScostABTable = new int[length][];

            for (int i = 0; i < length; i++)
            {
                int currDiffAbs = Math.Abs(costs[i][0] - costs[i][1]);

                diffABScostABTable[i] = new int[3] { currDiffAbs, costs[i][0], costs[i][1] };
            }

            diffABScostABTable = diffABScostABTable.OrderByDescending(x => x[0]).ToArray();

            for (int i = 0; i < length; i++)
            {
                int currACity = diffABScostABTable[i][1];
                int currBCity = diffABScostABTable[i][2];

                if (currACity >= currBCity)
                {
                    if (countCityB < half)
                    {
                        countCityB++;
                        totalCost += currBCity;
                    }
                    else
                    {
                        countCityA++;
                        totalCost += currACity;
                    }
                }
                else
                {
                    if(countCityA < half)
                    {
                        countCityA++;
                        totalCost += currACity;
                    }
                    else
                    {
                        countCityB++;
                        totalCost += currBCity;
                    }
                }
            }

            return totalCost;
        }
    }
}
