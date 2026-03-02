using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1893
    {
        ////(1893.) Check if All the Integers in a Range Are Covered (EASY)
        public bool IsCovered(int[][] ranges, int left, int right)
        {
            HashSet<int> leftRightValue = new HashSet<int>();
            for (int i = left; i <= right; i++)
            {
                leftRightValue.Add(i);
            }

            for (int indexRanges = 0; indexRanges < ranges.Length; indexRanges++) 
            {
                if (ranges[indexRanges][1] >= left && ranges[indexRanges][0] <= right)
                {
                    for (int i = ranges[indexRanges][0]; i <= ranges[indexRanges][1]; i++)
                    {
                        if (leftRightValue.Contains(i))
                        {
                            leftRightValue.Remove(i);
                        }
                    }
                }
            }

            if (leftRightValue.Count == 0) return true;
            return false;
        }
    }
}
