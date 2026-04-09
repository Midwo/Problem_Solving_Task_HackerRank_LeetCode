using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.HackerRank
{
    internal class HackerRank_0043
    {
        ////43. Drawing Book (EASY)
        public int pageCount(int n, int p)
        {
            int howMany = 0;
            int howManyMax = 0;
            if (p == 1 || p == n)
            {
                howMany = 0;
            }
            else
            {
                double x = p / 2;
                howMany = (int)x;
                x = n / 2;
                howManyMax = (int)x - howMany;
                if (howMany > howManyMax)
                {
                    howMany = howManyMax;
                }
            }
            return howMany;
        }
    }
}
