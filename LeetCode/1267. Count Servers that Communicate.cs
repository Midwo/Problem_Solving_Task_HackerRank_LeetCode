using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1267
    {
        ////(1267.) Count Servers that Communicate (MEDIUM)
        public int CountServers(int[][] grid)
        {
            int rows = grid.Length;
            int cols = grid[0].Length;
            int countServers = 0;

            var countServersInRows = new int[rows];
            var countServersInCols = new int[cols];

            for(int indexRows = 0; indexRows < rows; indexRows++)
            {
                for (int indexCols = 0; indexCols < cols; indexCols++)
                {
                    int currServer = grid[indexRows][indexCols];
                    countServersInRows[indexRows] += currServer;
                    countServersInCols[indexCols] += currServer;
                }
            }

            for (int indexRows = 0; indexRows < rows; indexRows++)
            {
                for (int indexCols = 0; indexCols < cols; indexCols++)
                {
                    if (grid[indexRows][indexCols] == 1 && (countServersInRows[indexRows] > 1 || countServersInCols[indexCols] > 1))
                    {
                        countServers++;
                    }
                }
            }

            return countServers;
        }
    }
}
