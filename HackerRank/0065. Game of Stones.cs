using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.HackerRank
{
    internal class HackerRank_0065
    {
        ////65. Game of Stones (EASY)   
        public string gameOfStones(int n)
        {
            return n % 7 <= 1 ? "Second" : "First";
        }

    }
}
