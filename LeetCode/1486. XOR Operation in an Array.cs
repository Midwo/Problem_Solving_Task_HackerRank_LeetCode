using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1486
    {
        ////(1486.) XOR Operation in an Array (EASY)
        public int XorOperation(int n, int start)
        {
            int result = 0;

            for (int i = 0; i < n; i++)
            {
                result ^= start + 2 * i;
            }

            return result;
        }
    }
}
