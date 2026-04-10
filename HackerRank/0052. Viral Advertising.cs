using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.HackerRank
{
    internal class HackerRank_0052
    {
        ////52. Viral Advertising (EASY)
        public int viralAdvertising(int n)
        {
            int liked = 2;
            int shared = 5;
            int cumulative = 2;

            for (int i = 1; i < n; i++)
            {
                shared = liked * 3;
                liked = shared / 2;
                cumulative += liked;
            }
            return cumulative;
        }
    }
}
