using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1605
    {
        ////(1605.) Find Valid Matrix Given Row and Column Sums (MEDIUM)
        public int[][] RestoreMatrix(int[] rowSum, int[] colSum)
        {
            int height = rowSum.Length;
            int width = colSum.Length;

            int[][] resultTable = new int[height][];
            for (int i = 0; i < height; i++)
            {
                resultTable[i] = new int[width];
            }

            int indexRow = 0, indexCol = 0;

            while (indexRow < height && indexCol < width)
            {
                int temp = Math.Min(rowSum[indexRow], colSum[indexCol]);
                resultTable[indexRow][indexCol] = temp;
                rowSum[indexRow] -= temp;
                colSum[indexCol] -= temp;

                if (rowSum[indexRow] == 0)
                {
                    indexRow++;
                }
                if (colSum[indexCol] == 0)
                {
                    indexCol++;
                }
            }

            return resultTable;
        }
    }
}
