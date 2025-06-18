using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_198
    {
        ////(198.) House Robber (MEDIUM)
        public int Rob(int[] nums)
        {
            //int sumPrevRob = 0;
            //int sumPrevNoRob = 0;

            //foreach (int i in nums) 
            //{
            //    int temp = Math.Max(sumPrevRob, sumPrevNoRob);

            //    sumPrevRob = sumPrevNoRob + i;

            //    sumPrevNoRob = temp;

            //}

            //return Math.Max(sumPrevRob, sumPrevNoRob);

            ////Option 2 - Dynamic programming, the same principle of operation - difference: instead of a few variables an int array
            int length = nums.Length;
            int[] dp = new int[nums.Length+1];
            dp[0] = 0;
            dp[1] = nums[0];
            
            for (int i = 1; i < length; i++)
            {
                dp[i+1] = dp[i-1] + nums[i];

                dp[i] = Math.Max(dp[i-1], dp[i]);
            }

            return Math.Max(dp[length], dp[length-1]);
        }
    }
}
