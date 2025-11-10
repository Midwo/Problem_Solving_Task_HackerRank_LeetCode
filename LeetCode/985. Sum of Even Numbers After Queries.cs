using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_985
    {
        ////(985.) Sum of Even Numbers After Queries (MEDIUM)
        public int[] SumEvenAfterQueries(int[] nums, int[][] queries)
        {
            List<int> resultList = new List<int>();
            int currSum = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 == 0)
                {
                    currSum += nums[i];
                }
            }

            for (int i = 0; i < queries.Length; i++) 
            {
                int tempValue = queries[i][0];
                int tempIndex = queries[i][1];

                if (nums[tempIndex] % 2 == 0)
                {
                    currSum -= nums[tempIndex];
                }
                nums[tempIndex] += tempValue;
                if (nums[tempIndex] % 2 == 0)
                {
                    currSum += nums[tempIndex];
                }
                resultList.Add(currSum);
            }

            return resultList.ToArray();
        }
    }
}
