using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2022
    {
        ////(2022.) Convert 1D Array Into 2D Array (EASY)
        public int[][] Construct2DArray(int[] original, int m, int n)
        {
            int length = original.Length;
            if (m*n != length)
            {
                return new int[][] { };
            }

            int[][] resultTable = new int[m][];
            int startIndex = 0;
           
            for (int i = 0; i < m; i++)
            {
                resultTable[i] = original[startIndex..(startIndex + n)];

                startIndex += n;
            }


            return resultTable;
        }
    }
}
