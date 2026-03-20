using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3567
    {
        ////(3567.) Minimum Absolute Difference in Sliding Submatrix (MEDIUM)
        public int[][] MinAbsDiff(int[][] grid, int k)
        {
            int countCol = grid[0].Length;
            int countRow = grid.Length;

            int[][] resultTable = new int[countRow-k+1][];
            for (int i = 0; i <= countRow-k; i++)
            {
                resultTable[i] = new int[countCol - k + 1];
            }

            for (int indexRow = 0; indexRow <= countRow-k; indexRow++)
            {

                for (int indexColStart = 0; indexColStart <= countCol - k; indexColStart++)
                {
                    int[] temp = new int[k*k];
                    int indexTemp = 0;

                    for (int currIndexRow = indexRow; currIndexRow <= indexRow+k-1; currIndexRow++)
                    {
                        for (int currIndexCol = indexColStart; currIndexCol < indexColStart + k; currIndexCol++)
                        {
                            temp[indexTemp] = grid[currIndexRow][currIndexCol];
                            indexTemp++;
                        }
                    }

                    //for (int currIndexCol = indexColStart; currIndexCol < indexColStart + k; currIndexCol++)
                    //{
                    //    temp[indexTemp] = grid[indexRow][currIndexCol];
                    //    indexTemp++;
                    //}

                    Array.Sort(temp);

                    int minABS = int.MaxValue;

                    for (int i = 1; i < temp.Length; i++)
                    {
                        if (temp[i] != temp[i - 1])
                        {
                            minABS = Math.Min(minABS, Math.Abs(temp[i-1] - temp[i]));
                        }
                    }

                    if(minABS != int.MaxValue)
                    {
                        resultTable[indexRow][indexColStart] = minABS;
                    }
                    else
                    {
                        resultTable[indexRow][indexColStart] = 0;
                    }
                }
            }

            return resultTable;
        }
    }
}
