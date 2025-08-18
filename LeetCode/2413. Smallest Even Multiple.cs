using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2413
    {
        ////(2413.) Smallest Even Multiple (EASY)
        public int SmallestEvenMultiple(int n)
        {
            if (n % 2 == 0)
            {
                return n;
            }
            else
            {
                return n * 2;
            }
        }
    }
}
