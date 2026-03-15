using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3572
    {
        ////(3572.) Maximize Y‑Sum by Picking a Triplet of Distinct X‑Values (MEDIUM)
        public int MaxSumDistinctTriplet(int[] x, int[] y)
        {
            int maxSumTriplet = 0;
            Dictionary<int,int> distictXWithMaxValues = new Dictionary<int,int>();

            for (int indexX = 0; indexX < x.Length; indexX++) 
            {
                int currYValue = y[indexX];
                int currXValue = x[indexX];
                if (distictXWithMaxValues.ContainsKey(currXValue))
                {
                    if (currYValue > distictXWithMaxValues[currXValue])
                    {
                        distictXWithMaxValues[currXValue] = currYValue;
                    }
                }
                else
                {
                    distictXWithMaxValues.Add(currXValue, currYValue);
                }
            }

            if (distictXWithMaxValues.Count < 3)
            {
                return -1;
            }

            int[] maxThree = distictXWithMaxValues.Values.OrderDescending().Take(3).ToArray();

            for (int i = 0; i < 3; i++)
            {
                maxSumTriplet += maxThree[i];
            }

            return maxSumTriplet;
        }
    }
}
