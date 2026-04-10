using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.HackerRank
{
    internal class HackerRank_0053
    {
        ////53. Save the Prisoner! (EASY)
        public int saveThePrisoner(int n, int m, int s)
        {
            var pos = s + (m % n) - 1;
            return (pos == 0 || pos > n) ? Math.Abs(pos - n) : pos;
        }
    }
}
