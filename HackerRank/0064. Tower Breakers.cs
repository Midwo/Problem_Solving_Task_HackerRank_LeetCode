using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.HackerRank
{
    internal class HackerRank_0064
    {
        ////64. Tower Breakers (EASY)
        public int towerBreakers(int n, int m)
        {
            if (m == 1)
            {
                return 2;
            }
            else
            {
                return 2 - (n % 2);
            }
        }

    }
}
