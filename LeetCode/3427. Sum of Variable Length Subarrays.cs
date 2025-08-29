using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3427
    {
        ////(3427.) Sum of Variable Length Subarrays (EASY)
        public int SubarraySum(int[] nums)
        {
            int result = nums[0];
            int currSum = 0;
            int indexStart = 0;

            for (int i = 1; i < nums.Length; i++) 
            {
                currSum = 0;
                indexStart = i - nums[i];
                if (indexStart < 0)
                {
                    indexStart = 0;
                }

                for (int j = indexStart; j <= i; j++)
                {
                    currSum += nums[j];
                }

                result += currSum;
            }

            return result;
        }
    }
}
