using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_566
    {
        ////(566.) Reshape the Matrix (EASY)
        public int[][] MatrixReshape(int[][] mat, int r, int c)
        {
            int countMat = mat.Length;
            //Console.WriteLine(countMat);
            int lengthMat = mat[0].Length;

            if (countMat*lengthMat != r * c)
            {
                return mat;
            }
            int[][] resultTable = new int [r][];
            
            int CurrR = 0;
            int CurrC = 0;

            for (int i = 0; i < r; i++)
            {
                int[] currTable = new int[c];
                for (int j = 0; j < c; j++)
                {
                    currTable[j] = mat[CurrR][CurrC];
                    CurrC++;
                    if (CurrC == lengthMat)
                    {
                        CurrR++;
                        CurrC = 0;
                    }
                }
                resultTable[i] = currTable;
            }

            return resultTable;
        }
    }
}
