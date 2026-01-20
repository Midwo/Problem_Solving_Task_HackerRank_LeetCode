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
            num -= 3;
            long firstValue = num / 3;
            if (firstValue * 3 == num)
            {
                return new long[] { firstValue, firstValue+1, firstValue+2 };
            }
            return new long[] { };
        }
    }
}
