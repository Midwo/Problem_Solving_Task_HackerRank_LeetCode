using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3010
    {
        ////(3010.) Divide an Array Into Subarrays With Minimum Cost I (EASY)
        public int MinimumCost(int[] nums)
        {
            int firstValue = nums[0];
            int minValue = int.MaxValue;
            int secondMinValue = int.MaxValue;
            int currValue = 0;

            for (int i = 1; i < nums.Length; i++)
            {
                currValue = nums[i];
                if(currValue < minValue)
                {
                    if (minValue < secondMinValue)
                    {
                        secondMinValue = minValue;
                    }
                    minValue = currValue;
                }
                else if(currValue < secondMinValue)
                {
                    secondMinValue = currValue;
                }
            }

            return firstValue + minValue + secondMinValue;
        }
    }
}
