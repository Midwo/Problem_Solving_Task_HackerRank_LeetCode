using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2908
    {
        ////(2908.) Minimum Sum of Mountain Triplets I (EASY)
        public int MinimumSum(int[] nums)
        {
            int length = nums.Length;
            int[] rightMinValue = new int[length];

            int minRightValue = nums[length - 1];
            rightMinValue[length-1] = minRightValue;
            int currValue;
            int minSum = int.MaxValue;
            for (int indexRightMinValue = length -2; indexRightMinValue > -1; indexRightMinValue--)
            {
                currValue = nums[indexRightMinValue];
                minRightValue = minRightValue > currValue ? currValue : minRightValue;
                rightMinValue[indexRightMinValue] = minRightValue;
            }

            currValue = nums[0];
            int leftMinValue = currValue;

            for (int indexMidValue = 1; indexMidValue < length -1; indexMidValue++)
            {
                leftMinValue = leftMinValue > currValue ? currValue: leftMinValue;  
                currValue = nums[indexMidValue];

                if(leftMinValue < currValue && currValue > rightMinValue[indexMidValue + 1])
                {
                    int temp = leftMinValue + currValue + rightMinValue[indexMidValue + 1];
                    minSum = minSum > temp? temp: minSum;
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
