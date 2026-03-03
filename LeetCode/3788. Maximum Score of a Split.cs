using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3788
    {
        ////(3788.) Maximum Score of a Split (MEDIUM)
        public long MaximumScore(int[] nums)
        {
            int length = nums.Length;
            int[] tableMaxMin = new int[length];
            int currMin = nums[length - 1];

            for (int i = length-1; i >= 1; i--)
            {
                if (nums[i] < currMin)
                {
                    currMin = nums[i];
                    tableMaxMin[i] = currMin;
                }
                else
                {
                    tableMaxMin[i] = currMin;
                }
            }

            long currSum = nums[0];
            long bestScore = currSum - currMin;

            for (int i = 1; i < length - 1; i++) 
            {
                currSum += nums[i];
                long currScore = currSum - tableMaxMin[i+1];
                bestScore = bestScore < currScore ? currScore : bestScore;
            }

            return bestScore;
        }
    }
}
