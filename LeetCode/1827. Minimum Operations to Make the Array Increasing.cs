using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1827
    {
        ////(1827.) Minimum Operations to Make the Array Increasing (EASY)
        public int MinOperations(int[] nums)
        {
            int countOperations = 0;
            int lastValue = nums[0];

            for (int i = 1; i < nums.Length; i++)
            {
                int currValue = nums[i];
                if(lastValue < currValue)
                {
                    lastValue = currValue;
                }
                else
                {
                    countOperations += lastValue - currValue + 1;
                    lastValue++;
                }
            }

            return countOperations;
        }
    }
}
