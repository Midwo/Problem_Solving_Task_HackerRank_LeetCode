using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2639
    {
        ////(2639.) Find the Width of Columns of a Grid (EASY)
        public int[] FindColumnWidth(int[][] grid)
        {
            List<int> ans = new List<int>();
            int rows = grid.Length;

            for (int indexCol = 0; indexCol < grid[0].Length; indexCol++)
            {
                int maxValue = 0;
                int minValue = 0;

                for (int indexRow = 0; indexRow < rows; indexRow++)
                {
                    maxValue = Math.Max(maxValue, grid[indexRow][indexCol]);
                    minValue = Math.Min(minValue, grid[indexRow][indexCol]);
                }
                int maxlenght = 0;
                int currLenght = 1;

                if(minValue < 0)
                {
                    while(minValue != 0)
                    {
                        currLenght++;
                        minValue /= 10;
                    }
                }
                maxlenght = currLenght;
                if(maxValue > 0)
                {
                    currLenght = 0;
                    while (maxValue != 0)
                    {
                        currLenght++;
                        maxValue /= 10;
                    }
                }
                maxlenght = Math.Max(maxlenght, currLenght);
                ans.Add(maxlenght);
            } 


            return ans.ToArray();
        }
    }
}
