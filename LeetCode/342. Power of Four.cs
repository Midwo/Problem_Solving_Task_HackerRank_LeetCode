using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_342
    {
        ////(342.) Power of Four(EASY)   
        public bool IsPowerOfFour(int n)
        {
            if (n == 1)
            {
                return true;
            }
            else if (n == 0)
            {
                return false;
            }
            while (n != 1)
            {
                if (n % 4 != 0)
                {
                    return false;
                }
                else
                {
                    n = n / 4;
                    if (n == 1)
                    {
                        return true;
                    }
                }
            }
            return true;
        }

    }
}
