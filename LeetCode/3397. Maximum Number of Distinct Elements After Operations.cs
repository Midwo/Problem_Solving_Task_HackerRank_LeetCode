using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3397
    {
        ////(3397.) Maximum Number of Distinct Elements After Operations (MEDIUM)
        public int MaxDistinctElements(int[] nums, int k)
        {
            int count = 0;
            Array.Sort(nums);
            int currMinValue = int.MinValue;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] - k > currMinValue)
                {
                    currMinValue = nums[i] - k;
                    count++;
                }
                else if (currMinValue != nums[i] + k)
                {
                    currMinValue++;
                    count++;
                }
            }

            return count;
        }
    }
}
