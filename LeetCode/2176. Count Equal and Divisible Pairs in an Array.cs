using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2176
    {
        ////(2176.) Count Equal and Divisible Pairs in an Array (EASY)
        public int CountPairs(int[] nums, int k)
        {
            int count = 0;

            for (int i = 0; i < nums.Length-1; i++) 
            {
                int tempValue1 = nums[i];
                for (int j = i + 1; j < nums.Length; j++) 
                {
                    if (tempValue1 == nums[j] && (i * j) % k == 0)
                    {
                        count++;
                    }
                }
            }

            return count;
        }
    }
}
