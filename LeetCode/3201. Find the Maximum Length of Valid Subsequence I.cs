using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3201
    {
        ////(3201.) Find the Maximum Length of Valid Subsequence I (MEDIUM)
        public int MaximumLength(int[] nums)
        {
            int even = 0;
            int odd = 0;
            int length = nums.Length;
            int wrongSequenceCount = 0;

            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] % 2 == 0)
                {
                    even++;
                }
                else
                {
                    odd++;
                }

                if (nums[i] % 2 != nums[i + 1] % 2)
                {
                    wrongSequenceCount++;
                }

            }

            if (nums[nums.Length - 1] % 2 == 0)
            {
                even++;

            }
            else
            {
                odd++;
            }

            return Math.Max(wrongSequenceCount + 1, Math.Max(even, odd));
        }
    }
}
