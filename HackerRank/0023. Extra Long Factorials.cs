using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.HackerRank
{
    internal class HackerRank_0023
    {
        public void extraLongFactorials(int n)
        {
            BigInteger x = 1;
            for (int i = n; i > 1; i--)
            {
                x = x * (BigInteger)i;
            }
            Console.WriteLine(x);
        }

    }
}
