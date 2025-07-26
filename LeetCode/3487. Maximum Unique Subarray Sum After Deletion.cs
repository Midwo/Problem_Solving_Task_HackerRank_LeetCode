using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3487
    {
        ////(3487.) Maximum Unique Subarray Sum After Deletion (EASY)
        public int MaxSum(int[] nums)
        {
            HashSet<int> result = new HashSet<int>();
            int maxNumber = int.MinValue;
            int maxSum = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if(maxNumber < nums[i]) maxNumber = nums[i];

                if (nums[i] > 0)
                {
                    if (result.Add(nums[i]))
                    {
                        maxSum += nums[i];
                    }
                }

            }

            if (maxNumber >= 0) 
            {
                return maxSum;
            }
            return maxNumber;
        }
    }
}
