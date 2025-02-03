using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_326
    {
        ////(326.) Power of Three (EASY)
        public bool IsPowerOfThree(int n)
        {
            if (n == 0) return false;
            bool endLoop = false;
            while(!endLoop)
            {
                if (n == 1)
                {
                    return true;
                }
                if (n%3 != 0)
                {
                    return false;
                }
                n = n / 3;
            }
            return true;
        }
    }
}
