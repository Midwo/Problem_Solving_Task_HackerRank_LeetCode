using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1137
    {
        ////(1137.) N-th Tribonacci Number (EASY)
        public int Tribonacci(int n)
        {
            int prev = 0;
            int prevprev = 0;
            int prevprevprev = 0;
            int result = 0;

            if (n > 2)
            {
                prev = 1;
            }
            else
            {
                return 0;
            }

            while (n > 1)
            {
                result = prev + prevprev + prevprevprev;
                prevprevprev = prevprev;
                prevprev = prev;
                prev = result;
                n--;
            }

            return result;
        }
    }
}
