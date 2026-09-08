using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3870
    {
        ////(3870.) Count Commas in Range (EASY)
        public int CountCommas(int n)
        {
            if (n < 1000) return 0;

            return n-999;
        }
    }
}
