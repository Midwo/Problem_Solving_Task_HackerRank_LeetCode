using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2485
    {
        ////(2485.) Find the Pivot Integer (EASY)
        public int PivotInteger(int n)
        {
            //// 1ms, Beats: 72.86%

            int currAn = 0;
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                currAn++;
                sum += currAn;

                //int sumN = sum / ((currAn+n) / 2);
                int sumN = (currAn + n)  * (n - currAn + 1);

                if (sum * 2 == sumN)
                {
                    return currAn;
                }
                //21 = (6 + 8) / 2 * n
                //n = 21 / ((6 + 8) / 2)
            }

            return -1;
        }
    }
}
