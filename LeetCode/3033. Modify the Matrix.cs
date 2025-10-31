using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3033
    {
        ////(3033.) Modify the Matrix (EASY)
        public int[][] ModifiedMatrix(int[][] matrix)
        {
            int lengthMatrix = matrix.Length;
            for (int i = 0; i < matrix[0].Length; i++)
            {
                List<int> listWithMinusOne = new List<int>();
                int currMax = int.MinValue;
                for (int j = 0; j < lengthMatrix; j++)
                {
                    if (matrix[j][i] == -1)
                    {
                        listWithMinusOne.Add(j);
                    }
                    currMax = Math.Max(matrix[j][i], currMax);
                }
                if (listWithMinusOne.Count > 0)
                {
                    foreach (var item in listWithMinusOne)
                    {
                        matrix[item][i] = currMax;
                    }
                }
            }

            return matrix;
        }
    }
}
