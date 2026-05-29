using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3898
    {
        ////(3898.) Find the Degree of Each Vertex (EASY)
        public int[] FindDegrees(int[][] matrix)
        {
            int cols = matrix[0].Length;
            int rows = matrix.Length;
            var resultTable = new int[cols];

            for (int indexCol = 0; indexCol < cols; indexCol++)
            {
                int sum = 0;
                for (int indexRow = 0; indexRow < matrix[0].Length; indexRow++)
                {
                    sum += matrix[indexRow][indexCol];
                }
                resultTable[indexCol] = sum;
            }

            return resultTable;  
        }
    }
}
