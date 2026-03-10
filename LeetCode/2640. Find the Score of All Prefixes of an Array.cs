using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2640
    {
        ////(2640.) Find the Score of All Prefixes of an Array (MEDIUM)
        public long[] FindPrefixScore(int[] nums)
        {
            int length = nums.Length;
            long[] score = new long[length];
            int maxValue = 0;
            long sum = 0;
            for (int i = 0; i < length; i++) 
            { 
                int currValue = nums[i];
                if (currValue > maxValue)
                {
                    maxValue = currValue;
                }
                sum += currValue + maxValue;

                score[i] = sum;             
            }

            return score;
        }
    }
}
