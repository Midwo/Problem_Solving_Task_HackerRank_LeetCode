using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2579
    {
        ////(2579.) Count Total Number of Colored Cells (MEDIUM)
        public long ColoredCells(int n)
        {
            if (n == 1)
            {
                return 1;
            }

            long temp = (1 + (n - 1)*2);
            long result = ((temp + 1) * n/2) + ((temp - 1) * (n - 1)/2);

            return result;
        }
    }
}
