using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2427
    {
        ////(2427.) Number of Common Factors (EASY)
        public int CommonFactors(int a, int b)
        {
            ////0ms, Beats: 100.00%
            
            int count = 0;

            if (a > b)
            {
                int temp = b;
                b = a;
                a = temp;
            }

            for (int i = 1; i <= a; i++)
            {
                if(a % i == 0 & b % i == 0)
                {
                    count++;
                }
            }

            return count;
        }
    }
}
