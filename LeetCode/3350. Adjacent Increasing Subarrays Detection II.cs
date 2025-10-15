using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3350
    {
        ////(3350.) Adjacent Increasing Subarrays Detection II
        public int MaxIncreasingSubarrays(IList<int> nums)
        {
            int maxCountIncreasing = 0;
            int currCountIncreasing = 1;
            int prevCountIntressing = 0;
            int length = nums.Count;

            for (int i = 1; i < length; i++)
            {
                if (nums[i] > nums[i - 1])
                {
                    currCountIncreasing++;
                }
                else
                {
                    prevCountIntressing = currCountIncreasing;
                    currCountIncreasing = 1;
                }

                maxCountIncreasing = Math.Max(maxCountIncreasing, currCountIncreasing / 2);
                maxCountIncreasing = Math.Max(maxCountIncreasing, Math.Min(currCountIncreasing, prevCountIntressing));
            }

            return maxCountIncreasing;
        }
    }
}
