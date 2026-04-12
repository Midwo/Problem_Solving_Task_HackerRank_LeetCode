using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.HackerRank
{
    internal class HackerRank_0067
    {
        ////67. Sum vs XOR (EASY)    
        public long sumXor(long n)
        {
            long howMany = 0;
            for (long i = 0; i < n; i++)
            {
                if ((n ^ i) == n + i)
                {
                    howMany++;
                }
            }
            return howMany;
        }
    }
}
