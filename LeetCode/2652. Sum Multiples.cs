using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2652
    {
        ////(2652.) Sum Multiples (EASY)
        public int SumOfMultiples(int n)
        {
            int sumResult = 0;
            for (int i = 1; i <= n; i++)
            {
                if (i % 3 == 0 || i % 5 == 0 || i % 6 == 0 || i % 7 == 0)
                {
                    sumResult += i;
                }
            }

            return sumResult;
        }
    }
}
