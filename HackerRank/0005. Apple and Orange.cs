using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.HackerRank
{
    internal class HackerRank_0005
    {
        public void countApplesAndOranges(int s, int t, int a, int b, List<int> apples, List<int> oranges)
        {
            int houseAplle = 0;
            int houseOranges = 0;

            foreach (var i in apples)
            {
                if ((a + i) >= s && (a + i) <= t)
                {
                    houseAplle++;
                }
            }
            foreach (var i in oranges)
            {
                if ((b + i) <= t && (b + i) >= s)
                {
                    houseOranges++;
                }
            }
            Console.WriteLine(houseAplle);
            Console.WriteLine(houseOranges);
        }

    }
}
