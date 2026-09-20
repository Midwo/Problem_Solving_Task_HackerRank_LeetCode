using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_4052
    {
        ////(4052.) Cyclically Shift Rows and Columns (EASY)
        public int[][] CyclicShift(int n, int[][] grid, int[] rowShift, int[] colShift)
        {
            int[][] gridRowShift = new int[n][];
            for (int row = 0; row < n; row++)
            {
                int shift = rowShift[row] % n;
                
                if (shift != 0)
                {
                    gridRowShift[row] = new int[n];
                    for (int col = 0; col < n; col++)
                    {
                        gridRowShift[row][col] = grid[row][(col+shift)%n];
                    }
                }
                else
                {
                    gridRowShift[row] = (int[])grid[row].Clone();
                }
            }
            
            for (int col = 0; col < n; col++) 
            {
                int shift = colShift[col] % n;

                if (shift != 0)
                {
                    for (int row = 0; row < n; row++)
                    {
                        grid[row][col] = gridRowShift[(row + shift) % n][col];
                    }
                }
                else
                {
                    for (int row = 0; row < n; row++)
                    {
                        grid[row][col] = gridRowShift[row][col];
                    }
                }
            }

            return grid;
        }
    }
}
