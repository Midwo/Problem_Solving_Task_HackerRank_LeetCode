using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.HackerRank
{
    internal class HackerRank_0049
    {
        ////49. Utopian Tree (EASY)
        public int utopianTree(int n)
        {
            int x = 1;
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    x++;
                }
                else
                {
                    x = x *= 2;
                }
            }
            return x;
        }
    }
}
