using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3871
    {
        ////(3871.) Count Commas in Range II (MEDIUM)
        public long CountCommas(long n)
        {
            long countCommas = 0;
            long multiplier = 1000;

            while(n >= multiplier)
            {
                long diff = (n - multiplier + 1);
                countCommas += diff;
                multiplier *= 1000;
            }

            return countCommas;
        }
    }
}
