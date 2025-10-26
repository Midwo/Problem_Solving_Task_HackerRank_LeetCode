using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2733
    {
        ////(2733.) Neither Minimum nor Maximum (EASY)
        public int FindNonMinOrMax(int[] nums)
        {
            ////1ms, Beats: 100.00%

            int length = nums.Length;

            if (length > 2)
            {
                int max = Math.Max(nums[0], nums[1]);
                int min = Math.Min(nums[0], nums[1]);
                int nextValue = nums[2];
                if (nextValue > max)
                {
                    return max;
                }
                else if (nextValue < min)
                {
                    return min;
                }
                return nextValue;
            }            
            else
            {
                return -1;
            }
        }
    }
}
