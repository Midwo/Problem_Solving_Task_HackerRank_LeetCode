using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.HackerRank
{
    internal class HackerRank_0066
    {
        ////66. Flipping bits (EASY)    
        public long flippingBits(long n)
        {
            uint binaryValue = Convert.ToUInt32(n);
            binaryValue = ~binaryValue;
            n = Convert.ToInt64(binaryValue);
            return n;
        }
    }
}
