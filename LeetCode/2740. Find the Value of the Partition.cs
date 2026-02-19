using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2740
    {
        ////(2740.) Find the Value of the Partition (MEDIUM)
        public int FindValueOfPartition(int[] nums)
        {
            Array.Sort(nums);
            int minDiff = int.MaxValue;
            int lastValue = nums[0];

            for (int i = 1; i < nums.Length; i++)
            {
                int currValue = nums[i];
                int currDiff = currValue - lastValue;
                lastValue = currValue;
                minDiff = minDiff > currDiff? currDiff : minDiff;
            }

            return minDiff;
        }
    }
}
