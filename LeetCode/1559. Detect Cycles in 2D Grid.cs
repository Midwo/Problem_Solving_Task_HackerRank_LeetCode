using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1559
    {
        ////(1559.) Detect Cycles in 2D Grid (MEDIUM)
        private int[][] directions = new int[][]
        {
            new []{ 1, 0 },
            new []{ -1, 0 },
            new []{ 0, 1 },
            new []{ 0, -1 }
        };

        public bool ContainsCycle(char[][] grid)
        {
            int rows = grid.Length;
            int cols = grid[0].Length;
            bool[][] visited = new bool[rows][];
            for (int i = 0; i < rows; i++)
            {
                visited[i] = new bool[cols];
            }

            for (int indexRow = 0; indexRow < rows; indexRow++) 
            { 
                for (int indexCol = 0; indexCol < cols; indexCol++)
                {
                    if (!visited[indexRow][indexCol])
                    {
                        if (StatusDecetCycles(grid, visited, indexRow, indexCol, -1, -1, grid[indexRow][indexCol]))
                            return true;
                    }
                }
            }
            return false;
        }

        private bool StatusDecetCycles(char[][] grid, bool[][] visited, int indexRow, int indexCol, int prevRow, int prevCol, char seachrChar)
        {
            visited[indexRow][indexCol] = true;

            foreach (var direction in directions) 
            {
                int newRow = indexRow + direction[0];
                int newCol = indexCol + direction[1];

                if (newRow < 0 || newRow >= grid.Length || newCol < 0 || newCol >= grid[0].Length)
                    continue;

                if (grid[newRow][newCol] != seachrChar)
                    continue;

                if(newRow == prevRow && newCol == prevCol)
                    continue;

                if (visited[newRow][newCol])
                    return true;

                if (StatusDecetCycles(grid, visited, newRow, newCol, indexRow, indexCol, seachrChar))
                    return true;
            }

            return false;
        }

    }
}
