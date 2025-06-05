using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_64
    {
        ////(64.) Minimum Path Sum (MEDIUM)
        public int MinPathSum(int[][] grid)
        {
            int height = grid.Length;
            int length = grid[0].Length;

            int[] DP = new int[length+1];

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    if (i == 0)
                    {
                        if (j == 0)
                        {
                            DP[j] = grid[i][j];
                        }
                        else
                        {
                            DP[j] = DP[j - 1]+ grid[i][j];
                        }
                    }
                    else
                    {
                        if (j == 0)
                        {
                            DP[j] = DP[j] + grid[i][j];
                        }
                        else
                        {
                            DP[j] = Math.Min(DP[j - 1], DP[j]) + grid[i][j];
                        }
                    }
                }
            }

            return DP[length-1];
        }
    }
}
