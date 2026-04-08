using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.HackerRank
{
    internal class HackerRank_0031
    {
        ////31. Diagonal Difference (EASY)
        public int diagonalDifference(List<List<int>> arr)
        {
            int z1 = 0;
            int y1 = 0;
            int x1 = 0;
            for (int i = 0; i < arr.Count; i++)
            {
                y1 += arr[i][arr.Count - 1 - i];
                x1 += arr[i][i];
            }
            z1 = x1 - y1;
            return Math.Abs(z1);
        }
    }
}
