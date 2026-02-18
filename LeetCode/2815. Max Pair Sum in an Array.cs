using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2815
    {
        ////(2815.) Max Pair Sum in an Array (EASY)
        public int MaxSum(int[] nums)
        {
            int[,] maxDigitAndTwoMaxNums = new int[10,2];

            foreach (int num in nums) 
            {
                int maxDigit = 0;
                int tempNum = num;

                while (tempNum != 0) 
                {
                    maxDigit = Math.Max(maxDigit, tempNum % 10);
                    tempNum = tempNum / 10;
                }

                if (maxDigitAndTwoMaxNums[maxDigit,0] < num)
                {
                    maxDigitAndTwoMaxNums[maxDigit, 1] = maxDigitAndTwoMaxNums[maxDigit, 0];
                    maxDigitAndTwoMaxNums[maxDigit, 0] = num;
                }
                else if (maxDigitAndTwoMaxNums[maxDigit, 1] < num)
                {
                    maxDigitAndTwoMaxNums[maxDigit, 1] = num;
                }
            }

            int maxSum = -1;
            
            for (int i = 1; i < 10; i++) 
            {
                int currSum = -1;
                if(maxDigitAndTwoMaxNums[i, 1] > 0)
                {
                    currSum = maxDigitAndTwoMaxNums[i, 1] + maxDigitAndTwoMaxNums[i, 0];
                    maxSum = Math.Max(maxSum, currSum);
                }
            }

            return maxSum;
        }
    }
}
