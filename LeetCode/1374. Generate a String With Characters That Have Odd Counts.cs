using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1374
    {
        ////(1374.) Generate a String With Characters That Have Odd Counts (EASY)
        public string GenerateTheString(int n)
        {
            ////1ms, Beats: 76.79%
            if(n % 2 == 0)
            {
                return new string('a', n - 1) + 'b';
            }
            else
            {
                return  new string('a', n);
            }
        }
    }
}
