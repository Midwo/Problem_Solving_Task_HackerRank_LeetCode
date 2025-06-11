using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1752
    {
        ////(1752.) Check if Array Is Sorted and Rotated (EASY)
        public bool Check(int[] nums)
        {
            int lastValue = nums[0];
            bool statusBreak = false;

            for (int i = 1; i < nums.Length; i++) 
            { 
                if (lastValue > nums[i])
                {
                    if (statusBreak) 
                    {
                        return false;
                    }
                    else
                    {
                        statusBreak = true;
                    }
                }
                lastValue = nums[i];
            }

            if (statusBreak) 
            {
                if (nums[0] >= nums[nums.Length - 1])
                {
                    return true;
                }
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
