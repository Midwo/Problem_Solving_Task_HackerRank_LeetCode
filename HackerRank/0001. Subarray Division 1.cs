using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.HackerRank
{
    internal class HackerRank_0001
    {
        public int birthday(List<int> s, int d, int m)
        {
            int sumChocolate = 0;
            for (int i = 0; i < s.Count; i++)
            {
                int y = 0;
                // Console.WriteLine(s[i]);
                if (i + m <= s.Count)
                {
                    for (int x = i; x < i + m; x++)
                    {
                        y += s[x];
                        if (y == d && x == i + m - 1)
                        {
                            sumChocolate++;
                        }
                    }
                }
            }
            return sumChocolate;
        }
    }
}
