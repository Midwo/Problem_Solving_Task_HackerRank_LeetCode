using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_263
    {
        ////(263.) Ugly Number (EASY)
        public bool IsUgly(int n)
        {
            if (n <= 0) return false;
            while (n > 1)
            {
                if (n % 2 == 0)
                {
                    n = n / 2;
                }
                else if (n % 3 == 0)
                {
                    n = n / 3;
                }
                else if (n % 5 == 0)
                {
                    n = n / 5;
                }
                else { break; }
            }
            return n == 1;
        }
    }
}
