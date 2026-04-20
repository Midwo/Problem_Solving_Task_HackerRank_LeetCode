using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3560
    {
        ////(3560.) Find Minimum Log Transportation Cost (EASY)
        public long MinCuttingCost(int n, int m, int k)
        {
            long costCutting = 0;

            if(n > k)
            {
                costCutting += (long)(n - k) * k; 
            }
            if(m > k)
            {
                costCutting += (long)(m - k) * k;
            }

            return costCutting;
        }
    }
}
