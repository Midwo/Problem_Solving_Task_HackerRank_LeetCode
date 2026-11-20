using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_695
    {
        ////(695.) Max Area of Island (MEDIUM)
        public int MaxAreaOfIsland(int[][] grid)
        {
            int rows = grid.Length;
            int cols = grid[0].Length;
            int maxIsland = 0;
            bool[][] visited = new bool[rows][];

            for (int i = 0; i < rows; i++) 
            {
                visited[i] = new bool[cols];
            }

            int[][] direct = [[1,0],[0,1],[-1,0],[0,-1]];
            int currArea = 0;

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    if (!visited[row][col]) 
                    {
                        currArea = 0;
                        CheckSizeIsland(row, col);
                        maxIsland = maxIsland < currArea ? currArea : maxIsland;
                    }
                }
            }

            void CheckSizeIsland(int row, int col)
            {
                if (!visited[row][col])
                {
                    visited[row][col] = true;
                    
                    if (grid[row][col] == 1)
                    {
                        currArea++;

                        if (row + direct[0][0] >= 0 && row + direct[0][0] < rows && col + direct[0][1] >= 0 && col + direct[0][1] < cols)
                            CheckSizeIsland(row+ direct[0][0], col+ direct[0][1]);
                        if (row + direct[1][0] >= 0 && row + direct[1][0] < rows && col + direct[1][1] >= 0 && col + direct[1][1] < cols)
                            CheckSizeIsland(row + direct[1][0], col + direct[1][1]);
                        if (row + direct[2][0] >= 0 && row + direct[2][0] < rows && col + direct[2][1] >= 0 && col + direct[2][1] < cols)
                            CheckSizeIsland(row + direct[2][0], col + direct[2][1]);
                        if (row + direct[3][0] >= 0 && row + direct[3][0] < rows && col + direct[3][1] >= 0 && col + direct[3][1] < cols)
                            CheckSizeIsland(row + direct[3][0], col + direct[3][1]);
                    }
                }
            }

            return maxIsland;
        }
    }
}
