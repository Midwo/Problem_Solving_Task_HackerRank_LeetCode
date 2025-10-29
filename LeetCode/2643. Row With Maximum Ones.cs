using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2643
    {
        ////(2643.) Row With Maximum Ones (EASY)
        public int[] RowAndMaximumOnes(int[][] mat)
        {
            int length = mat.Length;
            int lengthRow = mat[0].Length;

            int firstIndex = 0;
            int count = 0;

            for (int i = 0; i < length; i++) 
            {
                int currCount = 0;
                for (int j = 0; j < lengthRow; j++)
                {
                    if (mat[i][j] == 1)
                    {
                        currCount++;
                    }
                }
                if(currCount > count)
                {
                    count = currCount;
                    firstIndex = i;
                    if (currCount == lengthRow)
                    {
                        break;
                    }
                }
            }

            return new int[] { firstIndex, count };
        }
    }
}
