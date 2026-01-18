using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3627
    {
        ////(3627.) Maximum Median Sum of Subsequences of Size 3 (MEDIUM)
        public long MaximumMedianSum(int[] nums)
        {
            Array.Sort(nums);

            int indexLeft = 0;
            int indexMiddle = nums.Length - 2;
            long totalSumMedian = 0;

            while (indexLeft < indexMiddle) 
            {
                totalSumMedian += nums[indexMiddle];
                indexMiddle -= 2;
                indexLeft++;
            }

            return totalSumMedian;
        }
    }
}
