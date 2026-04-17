using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.HackerRank
{
    internal class HackerRank_0091
    {
        ////91. The Love-Letter Mystery (EASY)
        public int theLoveLetterMystery(string s)
        {
            var cnt = 0;

            for (int i = 0; i < s.Length / 2; i++)
            {
                cnt += Math.Abs(s[i] - s[s.Length - 1 - i]);
            }

            return cnt;
        }
    }
}
