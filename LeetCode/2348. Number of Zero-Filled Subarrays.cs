using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2348
    {
        ////(2348.) Number of Zero-Filled Subarrays (MEDIUM)
        public long ZeroFilledSubarray(int[] nums)
        {
            long result = 0;
            long currLengthZero = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                {
                    currLengthZero++;
                }
                else
                {
                    if (currLengthZero > 0)
                    {
                        result += (1 + currLengthZero) * currLengthZero / 2;
                        currLengthZero = 0;
                    }
                }
            }

            if (currLengthZero > 0)
            {
                result += (1 + currLengthZero) * currLengthZero / 2;
            }
            return result;
        }
    }
}
