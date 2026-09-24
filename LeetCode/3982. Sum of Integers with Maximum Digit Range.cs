using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3982
    {
        ////(3982.) Sum of Integers with Maximum Digit Range (EASY)
        public int MaxDigitRange(int[] nums)
        {
            int maxDigitRangeSum = -1;
            int maxDigitRange = -1;

            foreach (int num in nums) 
            {
                int minNum = int.MaxValue;
                int maxNum = int.MinValue;
                
                int temp = num;

                while (temp != 0) 
                { 
                    int modulo = temp % 10;

                    minNum = minNum > modulo ? modulo : minNum;
                    maxNum = maxNum < modulo ? modulo : maxNum;

                    temp /= 10;
                }
            
                int diffMaxMin = maxNum - minNum;
                if(diffMaxMin > maxDigitRange)
                {
                    maxDigitRange = diffMaxMin;
                    maxDigitRangeSum = num;
                }
                else if (diffMaxMin == maxDigitRange)
                {
                    maxDigitRangeSum += num;
                }
            }

            return maxDigitRangeSum;
        }
    }
}
