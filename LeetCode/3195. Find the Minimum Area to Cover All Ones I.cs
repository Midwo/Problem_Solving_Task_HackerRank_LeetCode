using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3195
    {
        ////(3195.) Find the Minimum Area to Cover All Ones I (MEDIUM)
        public int MinimumArea(int[][] grid)
        {
            int minLeft = int.MaxValue;
            int maxRight = int.MinValue;
            int minUp = int.MaxValue;
            int maxDown = int.MinValue;

            for (int i = 0; i < grid.Length; i++) 
            {
                for (int j = 0; j < grid[i].Length; j++)
                {
                    if (grid[i][j] == 1)
                    {
                        minLeft = Math.Min(minLeft, j);
                        maxRight = Math.Max(maxRight, j);
                        minUp = Math.Min(minUp, i);
                        maxDown = Math.Max(maxDown, i);
                    }
                }
            }

            return (maxRight-minLeft+1)*(maxDown-minUp+1);
        }
    }
}

