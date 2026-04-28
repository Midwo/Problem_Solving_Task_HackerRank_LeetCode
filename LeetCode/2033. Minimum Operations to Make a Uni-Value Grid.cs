using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2033
    {
        ////(2033.) Minimum Operations to Make a Uni-Value Grid (MEDIUM)
        public int MinOperations(int[][] grid, int x)
        {
            int length = grid.Length * grid[0].Length;
            var table1dGrid = new int[length];
            int indexTable1dGrid = 0;
            
            if(length == 1)
            {
                return 0;
            }

            foreach (var currGrid in grid)
            {
                foreach(var value in currGrid)
                {
                    table1dGrid[indexTable1dGrid++] = value;
                }
            }

            Array.Sort(table1dGrid);
            int minOperations = int.MaxValue;

            if(length % 2 == 1)
            {
                minOperations = CountTheNumberOfOperations(table1dGrid, x, length / 2, table1dGrid[length / 2]);
            }
            else
            {
                minOperations = Math.Min(CountTheNumberOfOperations(table1dGrid, x, length / 2 - 1, table1dGrid[length / 2 - 1]), 
                    CountTheNumberOfOperations(table1dGrid, x, length / 2, table1dGrid[length / 2]));
            }
            if (minOperations == int.MaxValue)
                return -1;

            return minOperations;
        }

        private int CountTheNumberOfOperations(int[] table1DGrid, int x, int indexMediane, int valueMediane)
        {
            int operations = 0;
            for (int index1DGrid = 0; index1DGrid < table1DGrid.Length; index1DGrid++)
            {
                if (index1DGrid == indexMediane)
                    continue;

                int diff = Math.Abs(valueMediane - table1DGrid[index1DGrid]);

                if (diff % x == 0)
                {
                    operations += diff / x;
                }
                else
                {
                    return int.MaxValue;
                }
            }
            return operations;
        }
    }
}
