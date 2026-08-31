using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3726
    {
        ////(3726.) Remove Zeros in Decimal Representation (EASY)
        public long RemoveZeros(long n)
        {
            long result = 0;
            long multiplier = 1;

            while(n != 0)
            {
                long temp = n % 10;
                if (temp > 0)
                {
                    result += multiplier * temp;
                    multiplier *= 10;
                }
                n /= 10; 
            }

            return result;
        }
    }
}
