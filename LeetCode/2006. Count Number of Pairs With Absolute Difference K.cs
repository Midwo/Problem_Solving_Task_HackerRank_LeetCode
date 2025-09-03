using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2006
    {
        ////(2006.) Count Number of Pairs With Absolute Difference K (EASY)
        public int CountKDifference(int[] nums, int k)
        {
            int count = 0;

            for (int i = 0; i < nums.Length-1; i++) 
            { 
                for (int j = i+1; j < nums.Length; j++)
                {
                    if (Math.Abs(nums[i] - nums[j]) == k)
                    {
                        count++;
                    }
                }
            }

            return count;
        }
    }
}
