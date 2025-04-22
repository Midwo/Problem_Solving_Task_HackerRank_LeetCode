using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_976
    {
        ////(976.) Largest Perimeter Triangle (EASY)
        public int LargestPerimeter(int[] nums)
        {
            int maxArea = 0;
            int length = nums.Length;

            Array.Sort(nums);
            for (int i = length - 1; i >= 2; i--)
            {
                if (nums[i] < nums[i - 1] + nums[i - 2])
                {
                    return nums[i] + nums[i - 1] + nums[i - 2];
                }
            }
            return maxArea;
        }
    }
}
