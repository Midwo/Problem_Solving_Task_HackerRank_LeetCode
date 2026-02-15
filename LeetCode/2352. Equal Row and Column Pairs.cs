using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2352
    {
        ////(2352.) Equal Row and Column Pairs (MEDIUM)
        public int EqualPairs(int[][] grid)
        {
            int lenght = grid.Length;
            Dictionary<string, int> dictionaryRows = new Dictionary<string, int>();
            int countEqualPairs = 0;


            for (int indexRow = 0; indexRow < lenght; indexRow++)
            {
                string currCol = string.Join(',',grid[indexRow]);
                if (dictionaryRows.ContainsKey(currCol))
                {
                    dictionaryRows[currCol]++;
                }
                else
                {
                    dictionaryRows.Add(currCol, 1);
                }
            }

            for (int indexCol = 0; indexCol < lenght; indexCol++)
            {
                int[] currColArr = new int[lenght];
                for (int indexRow = 0; indexRow < lenght; indexRow++)
                {
                    currColArr[indexRow] = grid[indexRow][indexCol];
                }
                string currCol = string.Join(',', currColArr);
                if (dictionaryRows.ContainsKey(currCol))
                {
                    countEqualPairs += dictionaryRows[currCol];
                }
            }

            return countEqualPairs;
        }
    }
}
