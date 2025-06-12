using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3423
    {            
        ////(3423.) Maximum Difference Between Adjacent Elements in a Circular Array (EASY)

        public int MaxAdjacentDistance(int[] nums)
        {
            int max = Math.Abs(nums[0] - nums[nums.Length-1]);

            for (int i = 0; i < nums.Length-1; i++) 
            {
                max = Math.Max(max, Math.Abs(nums[i] - nums[i + 1]));
            }

            return max;
        }
    }
}
