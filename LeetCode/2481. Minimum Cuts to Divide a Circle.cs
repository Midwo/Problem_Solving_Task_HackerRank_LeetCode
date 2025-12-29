using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2481
    {
        ////(2481.) Minimum Cuts to Divide a Circle (EASY)
        public int NumberOfCuts(int n)
        {
            if (n == 1)
            {
                return 0;
            }

            return (n & 1) == 0 ? n / 2 : n;
        }
    }
}
