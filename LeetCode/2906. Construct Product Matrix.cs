using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2906
    {
        ////(2906.) Construct Product Matrix (MEDIUM)
        public int[][] ConstructProductMatrix(int[][] grid)
        {
            int rows = grid.Length;
            int cols = grid[0].Length;

            int length = rows * cols;
            int[] tableLeftToRight = new int[length];
            int[] tableRightToLeft = new int[length];

            int indexTable = 0;
            int sumLeftToRight = 1;
            int sumRightToLeft = 1;

            for (int indexRow = 0; indexRow < rows; indexRow++)
            {
                for (int indexCol = 0; indexCol < cols; indexCol++)
                {
                    sumLeftToRight *= grid[indexRow][indexCol] % 12345;
                    sumLeftToRight = sumLeftToRight % 12345;
                    sumRightToLeft *= grid[rows - indexRow - 1][cols - 1 - indexCol] % 12345;
                    sumRightToLeft = sumRightToLeft % 12345;
                    tableLeftToRight[indexTable] = sumLeftToRight;
                    tableRightToLeft[length - indexTable -1] = sumRightToLeft;
                    indexTable++;
                }
            }

            indexTable = 0;
            
            for (int indexRow = 0; indexRow < rows; indexRow++)
            {
                for (int indexCol = 0; indexCol < cols; indexCol++)
                {
                    if(indexTable == 0)
                    {
                        grid[indexRow][indexCol] = (tableRightToLeft[indexCol+1])%12345;
                    }
                    else if(indexTable == length-1)
                    {
                        grid[indexRow][indexCol] = (tableLeftToRight[indexTable - 1])% 12345;
                    }
                    else 
                    {
                        grid[indexRow][indexCol] = (tableRightToLeft[indexTable + 1] * tableLeftToRight[indexTable - 1])%12345;
                    }
                    indexTable++;
                }
            }

            return grid;
        }
    }
}
