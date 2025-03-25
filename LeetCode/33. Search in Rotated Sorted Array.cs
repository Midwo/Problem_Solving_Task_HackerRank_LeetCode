using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_33
    {
        ////(33.) Search in Rotated Sorted Array (MEDIUM)
        public int Search(int[] nums, int target)
        {
            int length = nums.Length;
            int start = 0;
            int stop = length - 1;

            while (start < stop)
            {
                int middle = (start + stop) / 2;

                if (nums[start] <= nums[middle])
                {
                    if (nums[start] <= target && nums[middle] >= target)
                    {
                        stop = middle;
                    }
                    else
                    {
                        start = middle + 1;
                    }
                }
                else
                {
                    if (nums[middle] < target && target <= nums[length - 1])
                    {
                        start = middle + 1;
                    }
                    else
                    {
                        stop = middle;
                    }
                }
            }
            if (nums[start] == target)
            {
                return start;
            }
            else
            {
                return -1;
            }
        }
    }
}
