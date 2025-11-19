using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2154
    {
        public int FindFinalValue(int[] nums, int original)
        {
            while (nums.Contains(original))
            {
                original *= 2;
            }
            return original;
        }
    }
}
