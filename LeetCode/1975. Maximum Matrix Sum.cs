using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1975
    {
        ////(1975.) Maximum Matrix Sum (MEDIUM)
        public long MaxMatrixSum(int[][] matrix)
        {
            int length = matrix.Length;
            int minValue = int.MaxValue;
            int countMinusValue = 0;
            long sumMatrix = 0;
            int currValue = 0;

            for (int indexRow = 0; indexRow < length; indexRow++) 
            {
                for (int indexCol = 0; indexCol < length; indexCol++) 
                { 
                    currValue = matrix[indexRow][indexCol];
                    if (currValue < 0)
                    {
                        countMinusValue++;
                        currValue *= -1;
                    }
                    minValue = minValue > currValue ? currValue : minValue;
                    sumMatrix += currValue;
                }
            }

            if ((countMinusValue & 1) == 1)
            {
                return sumMatrix - minValue - minValue;
            }
            return sumMatrix;
        }
    }
}
