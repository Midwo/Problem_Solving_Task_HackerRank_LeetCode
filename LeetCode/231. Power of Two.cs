using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_231
    {
        ////(231.) Power of Two (EASY)

        ////Solution only for net 6 and newer.
        //public bool IsPowerOfTwo(int n)
        //{
        //    return BitOperations.IsPow2(n);
        //}

        ////Standard way to solve without using BitOperations.IsPow2(n) from NET.
        public bool IsPowerOfTwo(int n)
        {
            return (n > 0) && ((n & (n - 1)) == 0);
        }
    }
}
