using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1594
    {
        ////(1594.) Maximum Non Negative Product in a Matrix (MEDIUM)
        public int MaxProductPath(int[][] grid)
        {
            int rows = grid.Length;
            int cols = grid[0].Length;
            
            long[,] gridMinMax = new long[cols,2];

            for (int indexRows = 0; indexRows < rows; indexRows++) 
            { 
                for (int indexCols = 0; indexCols < cols; indexCols++)
                {
                    if(indexRows == 0)
                    {
                        if(indexCols == 0)
                        {
                            gridMinMax[indexCols,0] = grid[indexRows][indexCols];
                            gridMinMax[indexCols,1] = grid[indexRows][indexCols];
                        }
                        else
                        {
                            long temp = gridMinMax[indexCols-1,0] * grid[indexRows][indexCols];
                            gridMinMax[indexCols, 0] = temp;
                            gridMinMax[indexCols, 1] = temp;
                        }
                    }
                    else
                    {
                        if(indexCols == 0)
                        {
                            long temp = gridMinMax[indexCols, 0];
                            long currValue = grid[indexRows][indexCols];

                            long newTemp = temp * currValue;
                            gridMinMax[indexCols, 0] = newTemp;
                            gridMinMax[indexCols, 1] = newTemp;
                        }
                        else
                        {
                            long currValue = grid[indexRows][indexCols];

                            long[] possibleValues = new long[4];
                            possibleValues[0] = gridMinMax[indexCols - 1, 0] * currValue;
                            possibleValues[1] = gridMinMax[indexCols - 1, 1] * currValue;
                            possibleValues[2] = gridMinMax[indexCols, 0] * currValue;
                            possibleValues[3] = gridMinMax[indexCols, 1] * currValue;

                            Array.Sort(possibleValues);

                            gridMinMax[indexCols, 0] = possibleValues[0];
                            gridMinMax[indexCols, 1] = possibleValues[3];
                        }
                    }
                }
            }

            if (gridMinMax[cols - 1,1] < 0) 
            {
                return -1;
            }

            return (int)(gridMinMax[cols - 1, 1] % 1000000007);
        }
    }
}
