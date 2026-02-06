using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1252
    {
        ////(1252.) Cells with Odd Values in a Matrix (EASY)
        public int OddCells(int m, int n, int[][] indices)
        {
            int[][] simulateTable = new int[m][];

            for (int i = 0; i < m; i++) 
            {
                simulateTable[i] = new int[n];
            }

            for (int indexIndices = 0; indexIndices < indices.Length; indexIndices++)
            {
                int[] currIndice = indices[indexIndices];

                for (int indexRow = 0; indexRow < m; indexRow++) 
                {
                    simulateTable[indexRow][currIndice[1]]++;
                }
                
                for (int indexCol = 0; indexCol < n; indexCol++)
                {
                    simulateTable[currIndice[0]][indexCol]++;
                }
            }

            int countOddValues = 0;

            foreach (var rowsData in simulateTable)
            {
                foreach (var valueInRow in rowsData)
                {
                    if ((valueInRow & 1) == 1)
                    {
                        countOddValues++;
                    }
                }
            }
            return countOddValues;
        }
    }
}
