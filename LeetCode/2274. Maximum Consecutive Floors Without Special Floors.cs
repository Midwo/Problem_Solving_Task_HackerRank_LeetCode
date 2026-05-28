using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2274
    {
        ////(2274.) Maximum Consecutive Floors Without Special Floors (MEDIUM)
        public int MaxConsecutive(int bottom, int top, int[] special)
        {
            int maxConsecutive = 0;
            Array.Sort(special);

            foreach(int blockingValue in special)
            {
                int currDiff = blockingValue - bottom;
                maxConsecutive = Math.Max(maxConsecutive, currDiff);
                bottom = blockingValue +1;
            }
            maxConsecutive = Math.Max(maxConsecutive, top - special[special.Length-1]);

            return maxConsecutive;
        }
    }
}
