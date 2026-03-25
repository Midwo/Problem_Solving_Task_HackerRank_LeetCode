using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3546
    {
        ////(3546.) Equal Sum Grid Partition I (MEDIUM)
        public bool CanPartitionGrid(int[][] grid)
        {
            int rows = grid.Length;
            int cols = grid[0].Length;

            long[] sumCols = new long[cols];
            long[] sumRows = new long[rows];

            for (int indexRow = 0; indexRow < rows; indexRow++)
            {
                long currSumRow = 0;
                for (int indexCol = 0; indexCol < cols; indexCol++)
                {
                    currSumRow += grid[indexRow][indexCol];
                }
                sumRows[indexRow] = currSumRow;
            }

            for (int indexCol = 0; indexCol < cols; indexCol++)
            {
                long currSumCol = 0;
                for (int indexRow = 0; indexRow < rows; indexRow++)
                {
                    currSumCol += grid[indexRow][indexCol];
                }
                sumCols[indexCol] = currSumCol;
            }

            int indexSide1 = 0;
            int indexSide2 = rows - 1;
            long sumSide1 = 0;
            long sumSide2 = 0;

            //Horizontal Check First
            if (rows > 1)
            {
                indexSide1 = 0;
                indexSide2 = rows - 1;
                sumSide1 = sumRows[0];
                sumSide2 = sumRows[indexSide2];

                while (indexSide1 != indexSide2)
                {
                    if (sumSide1 < sumSide2)
                    {
                        indexSide1++;
                        if (indexSide1 == indexSide2)
                        {
                            break;
                        }
                        sumSide1 += sumRows[indexSide1];
                    }
                    else
                    {
                        indexSide2--;
                        if (indexSide2 == indexSide1)
                        {
                            break;
                        }
                        sumSide2 += sumRows[indexSide2];
                    }
                }

                if (sumSide1 == sumSide2)
                {
                    return true;
                }
            }

            //Vertical Check
            if (cols > 1)
            {
                indexSide1 = 0;
                indexSide2 = cols - 1;
                sumSide1 = sumCols[0];
                sumSide2 = sumCols[indexSide2];

                while (indexSide1 != indexSide2)
                {
                    if (sumSide1 < sumSide2)
                    {
                        indexSide1++;
                        if (indexSide1 == indexSide2)
                        {
                            break;
                        }
                        sumSide1 += sumCols[indexSide1];
                    }
                    else
                    {
                        indexSide2--;
                        if (indexSide2 == indexSide1)
                        {
                            break;
                        }
                        sumSide2 += sumCols[indexSide2];
                    }
                }

                if (sumSide1 == sumSide2)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
