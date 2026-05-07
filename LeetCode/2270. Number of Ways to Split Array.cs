using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2270
    {
        ////(2270.) Number of Ways to Split Array (MEDIUM)
        public int WaysToSplitArray(int[] nums)
        {
            int countValid = 0;
            long totalSum = 0;
            long currSum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                totalSum += nums[i];
            }

            for (int i = 0; i < nums.Length-1; i++)
            {
                int currNums = nums[i];
                currSum += currNums;

                if (currSum >= totalSum - currSum)
                    countValid++;
            }

            return countValid;
        }
    }
}
