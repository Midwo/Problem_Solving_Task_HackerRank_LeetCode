using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2016
    {
        ////(2016.) Maximum Difference Between Increasing Elements (EASY)
        public int MaximumDifference(int[] nums)
        {
            int min = nums[0];
            int maxDifference = -1;

            for (int i = 1; i < nums.Length; i++) 
            { 
                if (nums[i] <= min)
                {
                    min = nums[i];
                }
                else
                {
                    maxDifference = Math.Max(maxDifference, nums[i] - min);
                }

            }

            return maxDifference;
        }
    }
}
