using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3105
    {
        ////(3105.) Longest Strictly Increasing or Strictly Decreasing Subarray (EASY)
        public int LongestMonotonicSubarray(int[] nums)
        {
            int maxStricly = 1;
            int status = -1;
            int currStricly = 1;
            int lastValue = nums[0];

            for (int i = 1; i < nums.Length; i++)
            {
                if (lastValue < nums[i])
                {
                    if (status == 2)
                    {
                        currStricly++;
                    }
                    else
                    {
                        status = 2;
                        currStricly = 2;
                    }
                    maxStricly = maxStricly < currStricly ? currStricly : maxStricly;
                }
                else if (lastValue > nums[i])
                {
                    if (status == 1)
                    {
                        currStricly++;
                    }
                    else
                    {
                        status = 1;
                        currStricly = 2;
                    }
                    maxStricly = maxStricly < currStricly ? currStricly : maxStricly;
                }
                else
                {
                    status = 0;
                    currStricly = 1;
                }
                lastValue = nums[i];
            }

            return maxStricly;
        }
    }
}
