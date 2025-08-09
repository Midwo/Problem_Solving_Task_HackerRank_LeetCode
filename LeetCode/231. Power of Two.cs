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

        //Standard way to solve without using BitOperations.IsPow2(n) from NET.
        public bool IsPowerOfTwo(int n)
        {
            return (n > 0) && ((n & (n - 1)) == 0);
        }

        ////Solution with listPowerTwo
        //public bool IsPowerOfTwo(int n)
        //{
        //    List<int> listPower2 = new List<int>() { 1, 2, 4, 8, 16, 32, 64, 128, 256, 512, 1024, 2048, 4096, 8192, 16384,
        //                                            32768, 65536, 131072, 262144, 524288, 1048576, 2097152, 4194304, 8388608,
        //                                            16777216, 33554432, 67108864, 134217728, 268435456, 536870912, 1073741824 };

        //    if (listPower2.Contains(n))
        //    {
        //        return true;
        //    }
        //    return false;
        //}
    }
}
