using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2932
    {
        ////(2932.) Maximum Strong Pair XOR I (EASY)
        public int MaximumStrongPairXor(int[] nums)
        {
            ////low readability, high performance 

            int maxPairXor = 0;
            int firstValue;
            int secondValue;
            int length = nums.Length;

            for (int firstIndexValue = 0; firstIndexValue < length; firstIndexValue++)
            {
                firstValue = nums[firstIndexValue];
                for (int secondIndexValue = firstIndexValue; secondIndexValue < length; secondIndexValue++)
                {
                    secondValue = nums[secondIndexValue];
                    int diff = firstValue > secondValue ? firstValue - secondValue : secondValue - firstValue;
                    int min = firstValue > secondValue ? secondValue : firstValue;
                    if (diff <= min)
                    {
                        int xorValue = secondValue ^ firstValue;
                        maxPairXor = maxPairXor < xorValue ? xorValue : maxPairXor;
                    }
                }
            }

            return maxPairXor;


            ////average readability, average performance 

            //int maxPairXor = 0;
            //int firstValue;
            //int secondValue;
            //int length = nums.Length;

            //for (int firstIndexValue = 0; firstIndexValue < length; firstIndexValue++)
            //{
            //    firstValue = nums[firstIndexValue];
            //    for (int secondIndexValue = firstIndexValue; secondIndexValue < length; secondIndexValue++)
            //    {
            //        secondValue = nums[secondIndexValue];
            //        if (Math.Abs(firstValue - secondValue) <= Math.Min(firstValue, secondValue))
            //        {
            //            int xorValue = secondValue ^ firstValue;
            //            maxPairXor = maxPairXor < xorValue ? xorValue : maxPairXor;
            //        }
            //    }
            //}

            //return maxPairXor;


            ////high readability, low performance

            //int maxPairXor = 0;

            //foreach (int firstValue in nums)
            //{
            //    foreach (int secondValue in nums)
            //    {
            //        if (Math.Abs(firstValue - secondValue) <= Math.Min(firstValue, secondValue))
            //        {
            //            int xorValue = secondValue ^ firstValue;
            //            maxPairXor = maxPairXor < xorValue ? xorValue : maxPairXor;
            //        }
            //    }
            //}

            //return maxPairXor;

        }
    }
}
