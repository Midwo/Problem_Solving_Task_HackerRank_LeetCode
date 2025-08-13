using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3190
    {
        ////(3190.) Find Minimum Operations to Make All Elements Divisible by Three (EASY)
        public int MinimumOperations(int[] nums)
        {
            int result = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                int temp = nums[i] % 3;

                if (temp > 0)
                {
                    result++;
                }

            }

            return result;
        }
    }
}
