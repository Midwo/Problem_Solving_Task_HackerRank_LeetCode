using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_128
    {
        ////(128.) Longest Consecutive Sequence (MEDIUM)
        public int LongestConsecutive(int[] nums)
        {
            HashSet<int> numsHashSet = new HashSet<int>(nums);
            int maxLengthConsecutive = 0;
            int currLength = 1;
            foreach (int i in numsHashSet)
            {
                if (!numsHashSet.Contains(i - 1))
                {
                    currLength = 1;
                    while (numsHashSet.Contains(i + currLength))
                    {
                        currLength++;
                    }

                    maxLengthConsecutive = Math.Max(maxLengthConsecutive, currLength);
                }
            }

            return maxLengthConsecutive;
        }
    }
}
