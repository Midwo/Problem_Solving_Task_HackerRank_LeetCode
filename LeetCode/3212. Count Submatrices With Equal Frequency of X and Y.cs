using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3212
    {
        ////(3212.) Count Submatrices With Equal Frequency of X and Y (MEDIUM)
        public int NumberOfSubmatrices(char[][] grid)
        {
            int rowLength = grid.Length;
            int colLength = grid[0].Length;
            int countSubmatices = 0;

            bool[] statusX = new bool[colLength];
            int[] diffTable = new int[colLength];

            for (int indexRow = 0; indexRow < rowLength; indexRow++)
            {
                int diffXY = 0;
                for (int indexCol = 0; indexCol < colLength; indexCol++)
                {
                    if (grid[indexRow][indexCol] == 'X')
                    {
                        diffXY += ++diffTable[indexCol];
                        if (!statusX[indexCol])
                        {
                            statusX[indexCol] = true;
                        }
                    }
                    else if (grid[indexRow][indexCol] == 'Y')
                    {
                        diffXY += --diffTable[indexCol];
                        if(indexCol > 0 && statusX[indexCol - 1])
                        {
                            statusX[indexCol] = true;
                        }
                    }
                    else
                    {
                        diffXY += diffTable[indexCol];
                        if (indexCol > 0 && statusX[indexCol - 1])
                        {
                            statusX[indexCol] = true;
                        }
                    }

                    if (diffXY == 0 && statusX[indexCol])
                    {
                        countSubmatices++;
                    }
                }
            }

            return countSubmatices;
        }
    }
}
