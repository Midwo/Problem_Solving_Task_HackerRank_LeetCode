using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1800
    {
        ////(1800.) Maximum Ascending Subarray Sum (EASY)
        public int MaxAscendingSum(int[] nums)
        {
            int last = nums[0];
            int maxAscendingSum = last;
            int currAscendingSum = last;
            for (int i = 1; i < nums.Length; i++)
            {
                if (last < nums[i])
                {
                    last = nums[i];
                    currAscendingSum += last;
                    maxAscendingSum = maxAscendingSum < currAscendingSum ? currAscendingSum : maxAscendingSum;
                }
                else
                {
                    last = nums[i];
                    currAscendingSum = last;
                }
            }

            return maxAscendingSum;
        }
    }
}
