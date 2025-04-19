using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_892
    {
        ////(892.) Surface Area of 3D Shapes (EASY) 
        ///
        public int SurfaceArea(int[][] grid)
        {
            int widthX = grid[0].Length;
            int widthY = grid.Length;

            int areaSurfaceCount = 0;

            for (int i = 0; i < widthY; i++)
            {
                for (int j = 0; j < widthX; j++)
                {
                    int currHigth = grid[i][j];
                    if (currHigth > 0)
                    {
                        areaSurfaceCount += 2 + currHigth * 4;
                    }
                    if (j < widthX - 1)
                    {
                        areaSurfaceCount -= Math.Min(currHigth, grid[i][j+1])*2;
                    }
                }
            }
            for (int i = 0; i < widthX; i++)
            {
                for (int j = 0; j < widthY; j++)
                {
                    int currHigth = grid[j][i];
                    if (j < widthY - 1)
                    {
                        areaSurfaceCount -= Math.Min(currHigth, grid[j+1][i]) * 2;
                    }
                }
            }
            return areaSurfaceCount;
        }
    }
}
