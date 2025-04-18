using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_867
    {
        ////(867.) Transpose Matrix (EASY)
        public int[][] Transpose(int[][] matrix)
        {
            int countColumn = matrix[0].Length;
            int countRows = matrix.Length;

            int[][] result = new int[countColumn][];

            for (int i = 0; i < countColumn; i++)
            {
                int[] currRow = new int[countRows];

                for (int j = 0; j < countRows; j++)
                {
                    currRow[j] = matrix[j][i];
                }
                result[i] = currRow;
            }

            return result;
        }
    }
}
