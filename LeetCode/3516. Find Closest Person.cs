using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3516
    {
        ////(3516.) Find Closest Person (EASY)
        public int FindClosest(int x, int y, int z)
        {
            if (Math.Abs(x-z) > Math.Abs(y - z))
            {
                return 2;
            }
            else if (Math.Abs(x - z) < Math.Abs(y - z))
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
