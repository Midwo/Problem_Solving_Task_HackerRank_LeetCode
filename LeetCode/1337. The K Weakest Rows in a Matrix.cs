using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1337
    {
        ////(1337.) The K Weakest Rows in a Matrix (EASY)
        public int[] KWeakestRows(int[][] mat, int k)
        {
            int[] weakestRow = new int[k];
            int[][] indexRowCount = new int[mat.Length][];

            for (int i = 0; i < mat.Length; i++)
            {
                int countSoldier = 0;
                for (int j = 0; j < mat[i].Length; j++)
                {
                    if (mat[i][j] == 1)
                    {
                        countSoldier++;
                    }
                }
                indexRowCount[i] = new int[] {i, countSoldier};
            }

            //indexRowCount = indexRowCount.OrderBy(x => x[1]).ToArray().Select(x => x[0]).ToArray();

            return indexRowCount.OrderBy(x => x[1]).ToArray().Select(x => x[0]).ToArray()[0..k];
        }
    }
}
