using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3945
    {
        ////(3945.) Digit Frequency Score (EASY)
        public int DigitFrequencyScore(int n)
        {
            int sumDigit = 0;

            while(n != 0)
            {
                int temp = n % 10;
                sumDigit += temp;
                n /= 10;
            }

            return sumDigit;
        }
    }
}
