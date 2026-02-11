using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1403
    {
        ////(1403.) Minimum Subsequence in Non-Increasing Order (EASY)
        public IList<int> MinSubsequence(int[] nums)
        {
            int sumNums = 0;

            foreach (int valueNums in nums)
            {
                sumNums += valueNums;
            }

            nums = nums.OrderByDescending(x => x).ToArray();
            int minimumSubsequenceSum = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                int currValue = nums[i];
                sumNums -= currValue;
                minimumSubsequenceSum += currValue;

                if(minimumSubsequenceSum > sumNums)
                {
                    return nums[0..(i+1)];
                }
            }

            return new int[] { };
        }
    }
}
