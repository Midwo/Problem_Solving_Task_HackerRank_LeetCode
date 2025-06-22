using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2894
    {
        ////(2894.) Divisible and Non-divisible Sums Difference (EASY)
        public int DifferenceOfSums(int n, int m)
        {
            int sumNum1 = 0;
            int sumNum2 = 0;

            for (int i = 1; i <= n; i++)
            {
                if (i % m > 0)
                {
                    sumNum1 += i;
                }
                else
                {
                    sumNum2 += i;
                }
            }

            return sumNum1 - sumNum2;
        }
    }
}
