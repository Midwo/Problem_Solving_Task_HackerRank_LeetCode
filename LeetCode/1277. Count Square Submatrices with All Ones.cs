using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1277
    {
        ////(1277.) Count Square Submatrices with All Ones (MEDIUM)
        public int CountSquares(int[][] matrix)
        {
            int result = 0;
            //int[][] dpTable = new int[matrix.Length][];

            //for (int i = 0; i < matrix[0].Length; i++)
            //{
            //    dpTable[i] = new int[matrix[0].Length];
            //}
            int left = 0;
            int leftDown = 0;
            int down = 0;
            
            int currValue = 0;
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    currValue = matrix[i][j];
                    if (i == 0)
                    {
                        if(currValue == 1)
                        {
                            result++;
                        }
                    }
                    else if (j == 0)
                    {
                        if (currValue == 1)
                        {
                            result++;
                        }
                    }
                    else
                    {
                        left = matrix[i][j - 1];
                        leftDown = matrix[i - 1][j - 1];
                        down = matrix[i - 1][j];
                        int minValue = int.MaxValue;
                        minValue = Math.Min(minValue, left);
                        minValue = Math.Min(minValue, down);
                        minValue = Math.Min(minValue, leftDown);

                        if (minValue > 0)
                        {
                            if (currValue == 1)
                            {
                                matrix[i][j] = minValue + 1;
                                result += minValue + 1;
                            }
                        }
                        else if (currValue == 1)
                        {
                            result++;
                        }
                    }
                }
            }

            return result;
        }
    }
}
