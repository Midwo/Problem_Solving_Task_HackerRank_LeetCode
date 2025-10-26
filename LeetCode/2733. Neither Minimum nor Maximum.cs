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
                int min;
                int max;
                if (nums[0] > nums[1])
                {
                    min = nums[1];
                    max = nums[0];
                }
                else
                {
                    min = nums[0];
                    max = nums[1];
                }

                if (nums[2] > max)
                {
                    return max;
                }
                else if (nums[2] < min)
                {
                    return min;
                }
                return nums[2];
            }            
            else
            {
                return -1;
            }
        }
    }
}
