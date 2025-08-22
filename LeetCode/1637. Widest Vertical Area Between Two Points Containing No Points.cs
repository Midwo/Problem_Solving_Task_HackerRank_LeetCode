using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1637
    {
        ////(1637.) Widest Vertical Area Between Two Points Containing No Points (EASY)
        public int MaxWidthOfVerticalArea(int[][] points)
        {
            int maxWidth = 0;

            int[][] newPoints = points.OrderBy(c => c[0]).ToArray();

            for (int i = 1; i < points.Length; i++)
            {
                maxWidth = Math.Max(newPoints[i][0] - newPoints[i - 1][0], maxWidth);
            }

            return maxWidth;
        }
    }
}
