using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2177
    {
        ////(2177.) Find Three Consecutive Integers That Sum to a Given Number (MEDIUM)
        public long[] SumOfThree(long num)
        {
            if (num % 3 != 0)
            {
                return new long[] { };
            }

            long x = num / 3; 
            
            return new long[] { x - 1, x, x + 1 };
        }
    }
}
