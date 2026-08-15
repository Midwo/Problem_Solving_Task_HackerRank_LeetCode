using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1219
    {
        ////(1219.) Path with Maximum Gold (MEDIUM)
        public int GetMaximumGold(int[][] grid)
        {
            int maxGold = 0;

            int height = grid.Length;
            int width = grid[0].Length;

            bool[][] visited = new bool[height][];

            for (int y = 0; y < height; y++)
            {
                visited[y] = new bool[width];    
            }

            void BackTrackCheckMax(int x, int y, int currSum)
            {

                if (x < width && x >= 0 && y < height && y >= 0 && !visited[y][x] && grid[y][x]>0)
                {
                    visited[y][x] = true;
                    currSum += grid[y][x];
                    maxGold = maxGold < currSum ? currSum : maxGold;

                    BackTrackCheckMax(x + 1, y, currSum);
                    BackTrackCheckMax(x - 1, y, currSum);
                    BackTrackCheckMax(x, y + 1, currSum);
                    BackTrackCheckMax(x, y - 1, currSum);
                    visited[y][x] = false;

                }
                else
                {
                    return;
                }

            }

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    if (grid[y][x] > 0)
                    {
                        BackTrackCheckMax(x, y, 0);
                    }
                }
            }

            return maxGold;
        }
    }
}
