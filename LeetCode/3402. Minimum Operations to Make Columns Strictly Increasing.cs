using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3402
    {
        ////(3402.) Minimum Operations to Make Columns Strictly Increasing (EASY)
        public int MinimumOperations(int[][] grid)
        {
            int sumAllOperations = 0;
            int lengthCol = grid[0].Length;
            int lengthRow = grid.Length;
            int lastValue = 0;

            for (int i = 0; i < lengthCol; i++)
            {
                lastValue = grid[0][i];

                for (int j = 1; j < lengthRow; j++)
                {
                    int currValue = grid[j][i];

                    if (lastValue >= currValue)
                    {
                        sumAllOperations += lastValue - currValue + 1;
                        lastValue++;
                    }
                    else
                    {
                        lastValue = currValue;
                    }
                }
            }

            return sumAllOperations;
        }
    }
}
