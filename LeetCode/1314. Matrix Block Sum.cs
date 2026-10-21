using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1314
    {
        ////(1314.) Matrix Block Sum (MEDIUM)
        public int[][] MatrixBlockSum(int[][] mat, int k)
        {
            int rows = mat.Length;
            int cols = mat[0].Length;

            int[][] verticalSum = new int[rows][];
            int[][] matrixBockSum = new int[rows][];

            for (int i = 0; i < rows; i++) 
            {
                verticalSum[i] = new int[cols];
                matrixBockSum[i] = new int[cols];
            }

            for (int col = 0; col < cols; col++)
            {
                int currSum = mat[0][col];
                verticalSum[0][col] = currSum;

                for (int row = 1; row < rows; row++)
                {
                    currSum += mat[row][col];
                    verticalSum[row][col] = currSum;
                }
            }

            for(int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    int currSum = 0;

                    int maxIndexRow = row + k > rows - 1 ? rows - 1 : row + k;
                    int minIndexRow = row - k < 0?  0: row-k;
                    int minIndexCol = col - k < 0 ? 0 : col - k;
                    int maxIndexCol = col + k > cols -1? cols - 1 : col + k;

                    if(minIndexRow > 0)
                    {
                        for(int currCols = minIndexCol; currCols <=  maxIndexCol; currCols++)
                        {
                            currSum += verticalSum[maxIndexRow][currCols] - verticalSum[minIndexRow-1][currCols];
                        }    
                    }
                    else
                    {
                        for (int currCols = minIndexCol; currCols <= maxIndexCol; currCols++)
                        {
                            currSum += verticalSum[maxIndexRow][currCols];
                        }
                    }

                    matrixBockSum[row][col] = currSum; 
                }
            }

            return matrixBockSum;
        }
    }
}
