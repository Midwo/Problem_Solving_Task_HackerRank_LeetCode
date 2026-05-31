using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3895
    {
        ////(3895.) Count Digit Appearances (MEDIUM)
        public int CountDigitOccurrences(int[] nums, int digit)
        {
            int countDigit = 0;

            foreach (int currNum in nums)
            {
                int currValue = currNum;
                while (currValue != 0) 
                { 
                    int temp = currValue % 10;
                    if (temp == digit)
                        countDigit++;
                    currValue /= 10;
                }
            }  

            return countDigit;
        }
    }
}
