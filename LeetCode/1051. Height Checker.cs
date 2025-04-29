using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1051
    {
        ////(1051.) Height Checker (EASY)
        public int HeightChecker(int[] heights)
        {
            List<int> sortedHeights = heights.ToList();
            sortedHeights.Sort();

            int result = 0;

            for (int i = 0; i < heights.Length; i++)
            {
                if (heights[i] != sortedHeights[i])
                {
                    result++;
                }
            }

            return result;
        }
    }
}
