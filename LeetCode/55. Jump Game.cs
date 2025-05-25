using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_55
    {
        ////(55.) Jump Game (MEDIUM)
        public bool CanJump(int[] nums)
        {
            int maxIndex = 0;

            for (int i = 0; i < nums.Length; i++) 
            {
                if (maxIndex < i)
                {
                    return false;
                }

                maxIndex = Math.Max(maxIndex, i + (nums[i]));
                if (maxIndex >= nums.Length - 1)
                {
                    return true;
                }
            }

            return true;
        }
    }
}
