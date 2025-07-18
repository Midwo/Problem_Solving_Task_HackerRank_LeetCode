using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3202
    {
        ////3202. Find the Maximum Length of Valid Subsequence II
        public int MaximumLength(int[] nums, int k)
        {
            int[,] dp = new int[k, k];
            int resultMax = 0;
            int currResultMod = 0;

            //for (int i = 0; i < k; i++)
            //{
            //    dp[i] = new int[k];
            //}

            foreach (int number in nums)
            {
                currResultMod = number % k;

                for (int i = 0; i < k; i++)
                {
                    dp[i, currResultMod] = dp[currResultMod,i] + 1;
                    resultMax = Math.Max(resultMax, dp[i,currResultMod]);
                }
            }

            return resultMax;        
        }
    }
}
