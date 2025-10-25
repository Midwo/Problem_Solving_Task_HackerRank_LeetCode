using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2428
    {
        ////(2428.) Maximum Sum of an Hourglass (MEDIUM)
        public int MaxSum(int[][] grid)
        {
            ////1ms, Beats: 100.00%
            int lengthX = grid[0].Length;
            int lengthY = grid.Length;
            int maxSum = int.MinValue;

            for (int y = 0; y < lengthY-2; y++)
            {
                int currSum = 0;
                for (int x = 0; x < lengthX-2; x++)
                {
                    currSum = grid[y][x] + grid[y][x + 1] + grid[y][x + 2] + grid[y + 1][x + 1] + grid[y + 2][x] + grid[y + 2][x + 1] + grid[y + 2][x + 2];
                    maxSum = currSum > maxSum ? currSum : maxSum; 
                }
            }

            return maxSum;
        }
    }
}
