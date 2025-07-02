using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_73
    {
        ////(73.) Set Matrix Zeroes (MEDIUM)
        public void SetZeroes(int[][] matrix)
        {
            bool firstColumnZero = false;
            bool firstRowZero = false;

            for (int i = 0; i < matrix.Length; i++)
            {
                if (matrix[i][0] == 0)
                {
                    firstColumnZero = true;
                    break;
                }
            }

            for (int i = 0; i < matrix[0].Length; i++) 
            {
                if (matrix[0][i] == 0)
                {
                    firstRowZero = true;
                    break;
                }
            }

            for (int i = 1; i < matrix[0].Length; i++) 
            {
                for (int j = 1; j < matrix.Length; j++)
                {
                    if (matrix[j][i] == 0)
                    {
                        matrix[j][0] = 0;
                        matrix[0][i] = 0;
                    }
                }    
            }

            for (int i = 1; i < matrix[0].Length; i++)
            {
                for (int j = 1; j < matrix.Length; j++)
                {
                    if (matrix[j][0] == 0 || matrix[0][i] == 0)
                    {
                        matrix[j][i] = 0;
                    }
                }
            }

            if (firstColumnZero) 
            {
                for (int i = 0; i < matrix.Length; i++)
                {
                    matrix[i][0] = 0;
                }
            }

            if (firstRowZero)
            {
                for (int i = 0; i < matrix[0].Length; i++)
                {
                    matrix[0][i] = 0;
                }
            }
        }
    }
}
