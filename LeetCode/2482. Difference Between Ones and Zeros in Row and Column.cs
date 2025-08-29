using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2482
    {
        ////(2482.) Difference Between Ones and Zeros in Row and Column (MEDIUM)
        public int[][] OnesMinusZeros(int[][] grid)
        {
            int height = grid.Length;
            int length = grid[0].Length;

            int[] oneRow = new int[height];
            int[] oneCol = new int[length];
            int[] zeroRow = new int[height];
            int[] zeroCol = new int[length];
            
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    if (grid[i][j] == 0)
                    {
                        zeroCol[j]++;
                        zeroRow[i]++;
                    }
                    else
                    {
                        oneCol[j]++;
                        oneRow[i]++;
                    }
                }
            }

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    grid[i][j] = oneRow[i] + oneCol[j] - zeroRow[i] - zeroCol[j];
                }
            }

            return grid;
        }
    }
}
