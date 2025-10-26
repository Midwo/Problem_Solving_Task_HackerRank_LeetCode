using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3492
    {
        ////(3492.) Maximum Containers on a Ship (EASY)
        public int MaxContainers(int n, int w, int maxWeight)
        {
            ////0ms, Beats: 100.00%
            
            return Math.Min(n * n, maxWeight / w);
        }
    }
}
