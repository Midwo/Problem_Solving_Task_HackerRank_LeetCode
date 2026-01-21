using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2133
    {
        ////(2133.) Check if Every Row and Column Contains All Numbers (EASY)
        public bool CheckValid(int[][] matrix)
        {
            int length = matrix.Length;
            int[] currRowCol;

            int currValue = 0;

            for (int row = 0; row < length; row++)
            {
                currRowCol = new int[length + 1];
                for (int col = 0; col < length; col++)
                {
                    currValue = matrix[row][col];
                    currRowCol[currValue]++;
                    if (currRowCol[currValue] > 1)
                    {
                        return false;
                    }
                }
            }

            for (int col = 0; col < length; col++)
            {
                currRowCol = new int[length + 1];
                for (int row = 0; row < length; row++)
                {
                    currValue = matrix[row][col];
                    currRowCol[currValue]++;
                    if (currRowCol[currValue] > 1)
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
