using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3532
    {
        ////(3532.) Path Existence Queries in a Graph I (MEDIUM)
        public bool[] PathExistenceQueries(int n, int[] nums, int maxDiff, int[][] queries)
        {
            bool[] result = new bool[queries.Length];

            int[] counterMoreMaxDiff = new int[n];
            int currCounterMoreMaxDiff = 0;

            for(int index = 1; index < n; index++)
            {
                if (nums[index] - nums[index-1] > maxDiff)
                    currCounterMoreMaxDiff++;

                counterMoreMaxDiff[index] = currCounterMoreMaxDiff;
            }

            for (int indexQueries = 0; indexQueries < queries.Length; indexQueries++)
            {
                result[indexQueries] = counterMoreMaxDiff[queries[indexQueries][0]] == counterMoreMaxDiff[queries[indexQueries][1]];
            }

            return result;
        }
    }
}
