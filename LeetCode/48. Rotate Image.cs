using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_48
    {
        ////(48.) Rotate Image (MEDIUM)
        public void Rotate(int[][] matrix)
        {
            int length = matrix.Length;
            for (int i = 0; i < length; i++) 
            {
                for(int j = i+1; j < length; j++)
                {
                    int temp = matrix[i][j];
                    matrix[i][j] = matrix[j][i];
                    matrix[j][i] = temp;
                }
            }

            for(int i = 0;i < length; i++)
            {
                for (int j = 0; j < length/2; j++)
                {
                    int temp = matrix[i][j];
                    matrix[i][j] = matrix[i][length - 1 - j];
                    matrix[i][length - 1 - j] = temp;
                }
            }
        }
    }
}
