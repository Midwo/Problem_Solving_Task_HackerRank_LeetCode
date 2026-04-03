using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.HackerRank
{
    internal class HackerRank_0024
    {
        public int powerSum(int X, int N)
        {
            return recursive(X, N, 1);
        }
        private int recursive(int total, int power, int num)
        {
            int val = Convert.ToInt32(total - Math.Pow(num, power));

            if (val == 0) return 1;
            if (val < 0) return 0;

            return recursive(val, power, num + 1) + recursive(total, power, num + 1);
        }
    }
}
