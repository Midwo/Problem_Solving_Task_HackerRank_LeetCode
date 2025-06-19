using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2294
    {
        ////(2294.) Partition Array Such That Maximum Difference Is K (MEDIUM)
        public int PartitionArray(int[] nums, int k)
        {
            Array.Sort(nums);
            int result = 1;
            int start = nums[0];
            int length = nums.Length;

            for (int i = 1; i < length; i++)
            {
                if (k < nums[i] - start)
                {
                    result++;
                    start = nums[i];
                }
            }
            return result;
        }
    }
}
