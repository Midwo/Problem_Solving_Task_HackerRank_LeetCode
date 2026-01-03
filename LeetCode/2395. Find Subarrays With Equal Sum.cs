using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2395
    {
        ////(2395.) Find Subarrays With Equal Sum (EASY)
        public bool FindSubarrays(int[] nums)
        {
            HashSet<int> uniqueSum = new HashSet<int>();
            int length = nums.Length;
            int firstValue;
            int secondValue = nums[0];

            for (int indexSecondValue = 1; indexSecondValue < length; indexSecondValue++) 
            {
                firstValue = secondValue;
                secondValue = nums[indexSecondValue];

                if (!uniqueSum.Add(firstValue + secondValue))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
