using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3996
    {
        ////(3996.) Even Number of Knight Moves (EASY)
        public bool CanReach(int[] start, int[] target)
        {
            return (start[0] % 2 == start[1] % 2) == (target[0] % 2 == target[1] % 2);
        }
    }
}
