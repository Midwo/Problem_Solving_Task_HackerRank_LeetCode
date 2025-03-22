using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_29
    {
        ////(29.) Divide Two Integers (MEDIUM)
        public int Divide(long dividend, long divisor)
        {
            int quotient = 0;
            bool divisiorOne = false;
            bool isPositive = dividend > 0 && divisor > 0 || dividend < 0 && divisor < 0;

            divisor = Math.Abs(divisor);
            dividend = Math.Abs(dividend);
            long copydiVidend = dividend;
            if (divisor != 1 && divisor != -1)
            {
                while (dividend >= divisor)
                {
                    dividend -= divisor;
                    quotient++;
                }
            }
            else
            {
                divisiorOne = true;
            }
            if (isPositive)
            {   
                if (divisiorOne)
                {
                    if (copydiVidend >= 2147483648)
                    {
                        return int.MaxValue;
                    }
                    else if (copydiVidend <= -2147483648)
                    {
                        return 2147483647;
                    }
                    return (int)copydiVidend;
                }
                if (quotient >= 2147483648)
                {
                    return int.MaxValue;
                }
                else if (quotient <= -2147483648)
                {
                    return 2147483647;
                }
                return (int)quotient;
            }
            else
            {
                if (divisiorOne)
                {
                    if (copydiVidend <= -2147483648)
                    {
                        return -2147483648;
                    }
                    return (int)copydiVidend - (int)copydiVidend - (int)copydiVidend;
                }
                quotient = quotient - quotient - quotient;
                if (quotient <= -2147483648)
                {
                    return -2147483648;
                }
                return (int)quotient;
            }
        }
    }
}
