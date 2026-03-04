using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1582
    {
        ////(1582.) Special Positions in a Binary Matrix (EASY)
        public int NumSpecial(int[][] mat)
        {
            int countNumSpecial = 0;
            int lengthRow = mat.Length;
            int lengthCol = mat[0].Length;
            int[] colCountValues = new int[lengthCol];
            int[] rowCountValues = new int[lengthRow];

            for (int index = 0; index < lengthRow; index++)
            {
                for (int i = 0; i < lengthCol; i++)
                {
                    if (mat[index][i] == 1)
                    {
                        rowCountValues[index]++;
                    }
                }
            }

            for (int index = 0; index < lengthCol; index++)
            {
                for (int i = 0; i < lengthRow; i++)
                {
                    if (mat[i][index] == 1)
                    {
                        colCountValues[index]++;
                    }
                }
            }

            for (int i = 0; i < lengthRow; i++)
            {
                for (int j = 0; j < lengthCol; j++)
                {
                    if (mat[i][j] == 1 && colCountValues[j] == 1 && rowCountValues[i] == 1)
                    {
                        countNumSpecial++;
                    }
                }
            }

            return countNumSpecial;
        }
    }
}
