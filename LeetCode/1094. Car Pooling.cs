using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1094
    {
        ////(1094.) Car Pooling (MEDIUM)
        public bool CarPooling(int[][] trips, int capacity)
        {
            int[] countPassengers = new int[1001];

            trips = trips.OrderBy(x => x[1]).ToArray();

            for (int i = 0; i < trips.Length; i++) 
            {
                int currPassengers = trips[i][0];
                for (int j = trips[i][1]; j < trips[i][2]; j++)
                {
                    countPassengers[j] += currPassengers;
                    if (countPassengers[j] > capacity)
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
