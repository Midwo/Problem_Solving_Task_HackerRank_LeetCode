using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.HackerRank
{
    internal class HackerRank_0017
    {
        public string pokerNim(int k, List<int> c)
        {
            var xor = c[0];
            for (var i = 1; i < c.Count; ++i)
            {
                xor ^= c[i];
            }
            return xor != 0 ? "First" : "Second";
        }

    }
}
