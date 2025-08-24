using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1493
    {
        ////(1493.) Longest Subarray of 1's After Deleting One Element (MEDIUM)
        public int LongestSubarray(int[] nums)
        {
            int counterOne = 0;
            int lastValue = 0;
            int countZero = 0;
            int result = 0;
            int lastCounterOne = 0;

            for (int i = 0; i < nums.Length; i++) 
            {
                if (nums[i] == 1)
                {
                    counterOne++;
                    result = Math.Max(result, counterOne + lastCounterOne);
                    if (countZero > 1)
                    {
                        countZero = 0;
                    }
                }
                else
                {
                    lastCounterOne = counterOne;
                    countZero++;
                    counterOne = 0;
                    if (nums[i] == lastValue)
                    {
                        lastCounterOne = 0;
                    }
                }
                lastValue = nums[i];
            }

            if (result == nums.Length)
            {
                return result - 1;
            }

            return result;
        }
    }
}
