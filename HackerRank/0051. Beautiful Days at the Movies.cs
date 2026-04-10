using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.HackerRank
{
    internal class HackerRank_0051
    {
        ////51. Beautiful Days at the Movies (EASY)
        public int beautifulDays(int i, int j, int k)
        {
            int countBeatifulDay = 0;
            for (int x = i; x <= j; x++)
            {
                int reverseint = int.Parse(x.ToString().Reverse().ToArray());
                if ((x - reverseint) % k == 0)
                {
                    countBeatifulDay++;
                }
            }
            return countBeatifulDay;
        }
    }
}
