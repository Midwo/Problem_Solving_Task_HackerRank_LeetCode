using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_4117
    {
        ////(4117.) Minimum Range After Sum Operations (MEDIUM)
        public int MinRange(int a, int b, int c)
        {
            while (true)
            {
                if (a > b + c)
                    a = b + c;
                else if (b > a + c)
                    b = a + c;
                else if(c > a + b)
                    c = a + b;
                else
                {
                    break;
                }
            }

            return Math.Max(Math.Max(a, b), c) - Math.Min(Math.Min(a, b), c);
        }
    }
}
