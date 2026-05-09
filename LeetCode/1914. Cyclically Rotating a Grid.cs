using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1914
    {
        ////(1914.) Cyclically Rotating a Grid (MEDIUM)
        public int[][] RotateGrid(int[][] grid, int k)
        {
            int rows = grid.Length;
            int cols = grid[0].Length;

            var rotatedGrid = new int[rows][];

            for (int i = 0; i < rows; i++) 
            {
                rotatedGrid[i] = new int[cols];  
            }

            int indexStartRow = 0;
            int indexStartCol = 0;
            int currRows = rows;
            int currCols = cols;
            int[][] direction = [[0, 1], [1, 0], [0, -1], [-1, 0]];

            for (int i = 0; i < Math.Min(cols, rows) / 2; i++)
            {
                ///Console.WriteLine(string.Concat(indexStartRow, ", ", indexStartCol));

                int moduloMove = k % (currCols + currCols + currRows + currRows - 4);

                if (moduloMove != 0)
                {
                    int[] currList = new int[currCols+currCols+currRows+currRows-4];
                    int currRowIndexList = i;
                    int currColIndexList = i;
                    int currDirection = 0;
                    for (int indexCurrList = 0; indexCurrList < currList.Length; indexCurrList++)
                    {
                        currList[indexCurrList] = grid[currRowIndexList][currColIndexList];
                        currRowIndexList += direction[currDirection][0];
                        currColIndexList += direction[currDirection][1];
                        if (currColIndexList == cols - i)
                        {
                            currColIndexList--;
                            currDirection++;
                            currRowIndexList += direction[currDirection][0];
                            currColIndexList += direction[currDirection][1];
                        }
                        else if (currColIndexList == i -1)
                        {
                            currColIndexList = i;
                            currDirection++;
                            currRowIndexList += direction[currDirection][0];
                            currColIndexList += direction[currDirection][1];
                        }
                        else if(currRowIndexList == i -1)
                        {
                            currRowIndexList = i;
                            currDirection++;
                            currRowIndexList += direction[currDirection][0];
                            currColIndexList += direction[currDirection][1];
                        }
                        else if(currRowIndexList == rows -i)
                        {
                            currRowIndexList--;
                            currDirection++;
                            currRowIndexList += direction[currDirection][0];
                            currColIndexList += direction[currDirection][1];
                        }
                    }

                    currRowIndexList = i;
                    currColIndexList = i;
                    currDirection = 0;

                    for (int indexOperation = 0; indexOperation < currList.Length; indexOperation++)
                    {
                        int indexInListAfterK = (currList.Length - (currList.Length - k) + indexOperation) % currList.Length;
                        rotatedGrid[currRowIndexList][currColIndexList] = currList[indexInListAfterK];
                        currRowIndexList += direction[currDirection][0];
                        currColIndexList += direction[currDirection][1];
                        if (currColIndexList == cols - i)
                        {
                            currColIndexList--;
                            currDirection++;
                            currRowIndexList += direction[currDirection][0];
                            currColIndexList += direction[currDirection][1];
                        }
                        else if (currColIndexList == i - 1)
                        {
                            currColIndexList = i;
                            currDirection++;
                            currRowIndexList += direction[currDirection][0];
                            currColIndexList += direction[currDirection][1];
                        }
                        else if (currRowIndexList == i - 1)
                        {
                            currRowIndexList = i;
                            currDirection++;
                            currRowIndexList += direction[currDirection][0];
                            currColIndexList += direction[currDirection][1];
                        }
                        else if (currRowIndexList == rows - i)
                        {
                            currRowIndexList--;
                            currDirection++;
                            currRowIndexList += direction[currDirection][0];
                            currColIndexList += direction[currDirection][1];
                        }
                    }

                }
                else
                {
                    for (int indexCols = i; indexCols < cols - i; indexCols++)
                    {
                        rotatedGrid[i][indexCols] = grid[indexStartRow][indexCols];
                        rotatedGrid[rows - i - 1][indexCols] = grid[rows - i - 1][indexCols];
                    }

                    for (int indexRows = i + 1; indexRows < rows - 1 - i; indexRows++)
                    {
                        rotatedGrid[indexRows][indexStartCol] = grid[indexRows][indexStartCol];
                        rotatedGrid[indexRows][cols - indexStartCol - 1] = grid[indexRows][cols - indexStartCol - 1];
                    }
                }

                indexStartRow++;
                indexStartCol++;
                currCols -= 2;
                currRows -= 2;
            }

            return rotatedGrid;
        }
    }
}
