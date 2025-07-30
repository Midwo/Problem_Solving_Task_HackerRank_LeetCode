using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2419
    {
        ////(2419.) Longest Subarray With Maximum Bitwise AND (MEDIUM)
        public int LongestSubarray(int[] nums)
        {
            int lengthNums = nums.Length;
            int currBitwiseAnd = nums[0];
            int maxValue = 0;
            for (int i = 0; i < lengthNums; i++)
            {
                maxValue = Math.Max(nums[i], maxValue);
            }

            int count = 0;
            int maxCount = 0;

            for (int i = 0; i < lengthNums; i++)
            {
                if (nums[i] == maxValue)
                {
                    count++;
                    maxCount = Math.Max(maxCount, count);
                }
                else
                {
                    maxCount = Math.Max(maxCount, count);
                    count = 0;
                }
            }

            return maxCount;
        }
    }
}
