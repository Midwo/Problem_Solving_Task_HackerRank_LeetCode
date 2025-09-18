using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2965
    {
        ////(2965.) Find Missing and Repeated Values (EASY)
        public int[] FindMissingAndRepeatedValues(int[][] grid)
        {
            // 1ms, Beats: 98.65%

            int[] result = new int[2];
            int[] listValue = new int[grid.Length*grid[1].Length];

            for (int i = 0; i < grid.Length; i++) 
            { 
                for (int j = 0; j < grid[i].Length; j++)
                {
                    if (listValue[grid[i][j] - 1] == 0)
                    {
                        listValue[grid[i][j]-1] = grid[i][j];
                    }
                    else
                    {
                        result[0] = grid[i][j];
                    }
                }
            }

            for (int i = 0; i < listValue.Length; i++)
            {
                if (listValue[i] == 0)
                {
                    result[1] = i + 1;
                    break;
                }
            }

            return result;
        }
    }
}
