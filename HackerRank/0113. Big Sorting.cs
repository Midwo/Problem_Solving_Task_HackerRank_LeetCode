using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.HackerRank
{
    internal class HackerRank_0113
    {
        ////113. Big Sorting (EASY)
        public List<string> bigSorting(List<string> unsorted)
        {
            return unsorted.OrderBy(s => s.Length).ThenBy(s => s).ToList();
        }
    }
}
