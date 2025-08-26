using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_807
    {
        ////(807.) Max Increase to Keep City Skyline (MEDIUM)
        public int MaxIncreaseKeepingSkyline(int[][] grid)
        {
            int[] gridRow = new int[grid[0].Length];
            int[] gridColumn = new int[grid.Length];
            int result = 0;

            for (int i = 0; i < grid.Length; i++)
            {
                int maxValueRow = 0;
                int maxValueColumn = 0;
                for (int j = 0; j < grid[i].Length; j++)
                {
                    maxValueRow = Math.Max(maxValueRow, grid[i][j]);
                    maxValueColumn = Math.Max(maxValueColumn, grid[j][i]);
                }
                gridRow[i] = maxValueRow;
                gridColumn[i] = maxValueColumn;
            }
            
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[i].Length; j++)
                {
                    int temp = Math.Min(gridRow[i], gridColumn[j]);
                    result += temp - grid[i][j];
                }
            }

            return result;
        }
    }
}
