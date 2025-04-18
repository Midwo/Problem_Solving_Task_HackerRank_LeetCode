using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_883
    {
        ///(883.) Projection Area of 3D Shapes (EASY)
        public int ProjectionArea(int[][] grid)
        {
            int countYX = 0;
            int countZX = 0;
            int countZY = 0;

            int countGrid = grid.Length;
            int lengthInGrid = grid[0].Length;
            
            for (int i = 0; i < countGrid; i++)
            {
                int tempCurrMaxZX = 0;
                for (int j = 0; j < lengthInGrid; j++)
                {
                    int tempCurrGrid = grid[i][j];
                    if (tempCurrGrid > 0)
                    {
                        countYX++;
                    }
                    tempCurrMaxZX = Math.Max(tempCurrMaxZX, tempCurrGrid);
                }
                countZX += tempCurrMaxZX;
            }

            for (int i = 0; i < lengthInGrid; i++)
            {
                int tempCurrMaxZY = 0;
                for (int j = 0; j < countGrid; j++)
                {
                    int tempCurrGrid = grid[j][i];
                    tempCurrMaxZY = Math.Max(tempCurrMaxZY, tempCurrGrid);
                }
                countZY += tempCurrMaxZY;
            }

            return countYX + countZX + countZY;
        }
    }
}
