using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.HackerRank
{
    internal class HackerRank_0018
    {
        public string nimGame(List<int> pile)
        {
            var xor = pile[0];
            for (var i = 1; i < pile.Count; ++i)
            {
                xor ^= pile[i];
            }
            return xor != 0 ? "First" : "Second";
        }

    }
}
