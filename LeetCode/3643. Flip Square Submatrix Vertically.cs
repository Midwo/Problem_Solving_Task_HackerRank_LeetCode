using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3643
    {
        ////(3643.) Flip Square Submatrix Vertically (EASY)
        public int[][] ReverseSubmatrix(int[][] grid, int x, int y, int k)
        {
            int x1 = 0;
            int maxI = x + k / 2;
            if (k % 2 == 0)
            {
                maxI--;
            }
            for (int i = x; i <= maxI; i++)
            {
                int[] tempX = grid[i][y..(y + k)];
                int where = x + k - x1 - 1;
                int indexJ = 0;
                for (int j = y; j < y + k; j++)
                {
                    grid[i][j] = grid[where][j];
                    indexJ++;
                }
                indexJ = 0;
                for (int j = y; j < y + k; j++)
                {
                    grid[where][j] = tempX[indexJ];
                    indexJ++;
                }

                x1++;
            }

            return grid;
        }
    }
}
