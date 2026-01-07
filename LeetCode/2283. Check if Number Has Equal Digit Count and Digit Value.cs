using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2283
    {
        ////(2283.) Check if Number Has Equal Digit Count and Digit Value (EASY)
        public bool DigitCount(string num)
        {
            int[] countNum = new int[10];
            int length = num.Length;

            for (int indexNum = 0; indexNum < length; indexNum++) 
            {
                countNum[num[indexNum]-'0']++;
            }

            for (int indexNum = 0; indexNum < length; indexNum++)
            {
                if (num[indexNum]-'0' != countNum[indexNum])
                {
                    return false;
                }
            } 

            return true;
        }
    }
}
