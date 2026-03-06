using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2500
    {
        ////(2500.) Delete Greatest Value in Each Row (EASY)
        public int DeleteGreatestValue(int[][] grid)
        {
            int sumDelGreatestValue = 0;
            int countRow = grid.Length;
            int countCol = grid[0].Length;

            for (int i = 0; i < countRow; i++)
            {
                Array.Sort(grid[i]);
            }

            for (int i = countCol - 1; i >= 0; i--)
            {
                int maxValue = 0;
                int currValue = 0;

                for (int j = 0; j < countRow; j++)
                {
                    currValue = grid[j][i];
                    maxValue = maxValue < currValue ? currValue : maxValue;
                }

                sumDelGreatestValue += maxValue;
            }

            return sumDelGreatestValue;
        }
    }
}
