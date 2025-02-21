using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_485
    {
        ////(485.) Max Consecutive Ones (EASY)
        public int FindMaxConsecutiveOnes(int[] nums)
        {
            int result = 0;
            int currConsecutiveOnes = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 1)
                {
                    currConsecutiveOnes++;
                    result = result < currConsecutiveOnes ? currConsecutiveOnes : result;
                }
                else
                {
                    currConsecutiveOnes = 0;
                }
            }

            return result;
        }
    }
}
