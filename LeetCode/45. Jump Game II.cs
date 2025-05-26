using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_45
    {
        ////(45.) Jump Game II (MEDIUM)
        public int Jump(int[] nums)
        {
            int maxRange = 0;
            int endIndex = nums.Length - 1;
            int jumpCount = 0;
            int currMax = 0;

            for (int i = 0; i < endIndex; i++)
            {
                maxRange = Math.Max(maxRange, i + nums[i]);

                if (currMax == i)
                {
                    jumpCount++;
                    currMax = maxRange;
                    if (currMax >= endIndex)
                    {
                        return jumpCount;
                    }
                }
            }

            return jumpCount;
        }
    }
}
