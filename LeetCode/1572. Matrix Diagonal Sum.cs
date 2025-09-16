using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1572
    {
        ////(1572.) Matrix Diagonal Sum (EASY)
        public int DiagonalSum(int[][] mat)
        {
            //// 0ms, Beats: 100%

            int sum = 0;

            int[] indexPrimaryDiagonal = [0,0];
            int[] indexSecondaryDiagonal = [0, mat[0].Length-1];

            for (int i = 0; i < mat.Length; i++) 
            {
                sum += mat[indexPrimaryDiagonal[0]++][indexPrimaryDiagonal[1]++] + mat[indexSecondaryDiagonal[0]++][indexSecondaryDiagonal[1]--];
            }

            if(mat.Length % 2 != 0)
            {
                sum -= mat[mat.Length/2][mat.Length/2];
            }

            return sum;
        }
    }
}
