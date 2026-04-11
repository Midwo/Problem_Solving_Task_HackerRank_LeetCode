using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.HackerRank
{
    internal class HackerRank_0063
    {
        ////63. Misère Nim (EASY)
        public string misereNim(List<int> s)
        {
            int n = s.Count();
            int xr = 0;
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                xr ^= s[i];
                sum += s[i];
            }

            if (n % 2 == 0)
            {
                return n != sum && xr == 0 ? "Second" : "First";
            }
            else
            {
                return n == sum || xr == 0 ? "Second" : "First";
            }

        }

    }
}

