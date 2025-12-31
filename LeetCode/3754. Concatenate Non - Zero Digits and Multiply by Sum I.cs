using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3754
    {
        ////(3754.) Concatenate Non - Zero Digits and Multiply by Sum I (EASY)
        public long SumAndMultiply(int n)
        {
            long sumMultiply = 0;
            int multiplicationFactorForLoop = 1;
            long concatenateNonZeroValue = 0;
            
            while (n > 0)
            {
                int temp = n % 10;
                if (temp > 0)
                {
                    concatenateNonZeroValue += multiplicationFactorForLoop * temp;
                    multiplicationFactorForLoop *= 10;
                    sumMultiply += temp;
                }
                n /= 10;
            }

            return concatenateNonZeroValue * sumMultiply;
        }
    }
}
