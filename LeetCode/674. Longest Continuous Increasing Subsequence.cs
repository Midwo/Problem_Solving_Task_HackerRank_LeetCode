using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_674
    {
        ////(674.) Longest Continuous Increasing Subsequence (EASY)
        public int FindLengthOfLCIS(int[] nums)
        {
            int maxContinuousIncreasingSubsequence = 1;
            int currValue = nums[0];
            int currContinuousIncreasingSubsequence = 1;

            for (int i = 1; i<nums.Length; i++)
            {
                if (currValue < nums[i])
                {
                    currContinuousIncreasingSubsequence++;
                    currValue = nums[i];
                }
                else
                {
                    maxContinuousIncreasingSubsequence = maxContinuousIncreasingSubsequence < currContinuousIncreasingSubsequence ? currContinuousIncreasingSubsequence : maxContinuousIncreasingSubsequence;
                    currContinuousIncreasingSubsequence = 1;
                    currValue = nums[i];
                }
            }

            maxContinuousIncreasingSubsequence = maxContinuousIncreasingSubsequence < currContinuousIncreasingSubsequence ? currContinuousIncreasingSubsequence : maxContinuousIncreasingSubsequence;
            return maxContinuousIncreasingSubsequence;
        }
    }
}
