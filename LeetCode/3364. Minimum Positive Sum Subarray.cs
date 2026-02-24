using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3364
    {
        ////(3364.) Minimum Positive Sum Subarray (EASY)
        public int MinimumSumSubarray(IList<int> nums, int l, int r)
        {
            int length = nums.Count;
            int minSum = int.MaxValue;

            for (int startIndex = 0; startIndex <= length-l; startIndex ++) 
            {
                int currSum = nums[startIndex];
                int indexL = startIndex + 1;
                int maxIndex = Math.Min(startIndex + l, length);
                while (indexL < maxIndex)
                {
                    currSum += nums[indexL++];
                }

                if (currSum > 0)
                {
                    minSum = Math.Min(currSum, minSum);
                }
                maxIndex = Math.Min(startIndex + r, length);

                while (indexL < maxIndex)
                {
                    currSum += nums[indexL++];
                    if (currSum > 0)
                    {
                        minSum = Math.Min(currSum, minSum);
                    }
                }
            }

            if (minSum == int.MaxValue)
            {
                return -1;
            }

            return minSum;
        }
    }
}
