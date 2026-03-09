using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2342
    {
        ////(2342.) Max Sum of a Pair With Equal Sum of Digits (MEDIUM)
        public int MaximumSum(int[] nums)
        {
            Dictionary<int, int[]> dictionarySumOfDigitsAndTwoMaxNums = new Dictionary<int, int[]>();
            int maxSum = -1;
            foreach  (int num in nums)
            {
                int currNum = num;
                int sumDigits = 0;
                while(currNum != 0)
                {
                    sumDigits += currNum % 10;
                    currNum /= 10;
                }

                if (dictionarySumOfDigitsAndTwoMaxNums.ContainsKey(sumDigits))
                {
                    int firstValue = dictionarySumOfDigitsAndTwoMaxNums[sumDigits][0];
                    int secondValue = dictionarySumOfDigitsAndTwoMaxNums[sumDigits][1];

                    if(num > firstValue)
                    {
                        dictionarySumOfDigitsAndTwoMaxNums[sumDigits][1] = firstValue;
                        dictionarySumOfDigitsAndTwoMaxNums[sumDigits][0] = num;
                        maxSum = Math.Max(maxSum, firstValue + num);
                    }
                    else if (num > secondValue)
                    {
                        dictionarySumOfDigitsAndTwoMaxNums[sumDigits][1] = num;
                        maxSum = Math.Max(maxSum, firstValue+num);
                    }
                }
                else
                {
                    dictionarySumOfDigitsAndTwoMaxNums.Add(sumDigits, new int[] { num, 0 });
                }
            }

            return maxSum;
        }
    }
}
