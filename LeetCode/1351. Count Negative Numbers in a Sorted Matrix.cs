using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1351
    {
        ////(1351.) Count Negative Numbers in a Sorted Matrix (EASY)
        public int CountNegatives(int[][] grid)
        {
            int count = 0;

            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[i].Length; j++)
                {
                    if (grid[i][j] < 0)
                    {
                        count++;
                    }
                }
            }

            return count;
        }
    }
}
