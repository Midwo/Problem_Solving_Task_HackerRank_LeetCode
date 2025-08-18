using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2373
    {
        ////(2373.) Largest Local Values in a Matrix (EASY)
        public int[][] LargestLocal(int[][] grid)
        {
            int length = grid.Length;
            int[][] newResultGrid = new int[length-2][];
            for (int i = 0; i < length -2; i++)
            {
                newResultGrid[i] = new int[length-2];
            }
            int currMax = 0;

            for (int i = 1; i < length - 1; i++)
            {
                for (int j = 1; j < length - 1; j++)
                {
                    currMax = 0;
                    currMax = Math.Max(currMax, grid[i][j]);
                    currMax = Math.Max(currMax, grid[i - 1][j]);
                    currMax = Math.Max(currMax, grid[i + 1][j]);
                    currMax = Math.Max(currMax, grid[i][j - 1]);
                    currMax = Math.Max(currMax, grid[i][j + 1]);
                    currMax = Math.Max(currMax, grid[i+1][j + 1]);
                    currMax = Math.Max(currMax, grid[i-1][j + 1]);
                    currMax = Math.Max(currMax, grid[i - 1][j - 1]);
                    currMax = Math.Max(currMax, grid[i + 1][j - 1]);

                    newResultGrid[i - 1][j-1] = currMax;
                }
            }


            return newResultGrid;
        }
    }
}
