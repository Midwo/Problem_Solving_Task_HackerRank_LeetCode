using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3232
    {
        ////(3232.) Find if Digit Game Can Be Won (EASY)
        public bool CanAliceWin(int[] nums)
        {
            long singleDigitSum = 0;
            long doubleDigitSum = 0;

            for (int i = 0; i < nums.Length; i++) 
            {
                if (nums[i] < 10)
                {
                    singleDigitSum += nums[i];
                }
                else
                {
                    doubleDigitSum += nums[i];
                }
            }

            if (singleDigitSum != doubleDigitSum) { return true; }
            return false;
        }
    }
}
