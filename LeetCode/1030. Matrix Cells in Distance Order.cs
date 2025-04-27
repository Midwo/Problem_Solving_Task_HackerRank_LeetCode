using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1030
    {
        ////(1030.) Matrix Cells in Distance Order (EASY)
        public int[][] AllCellsDistOrder(int rows, int cols, int rCenter, int cCenter)
        {
            List<(int, int, int)> distanceList = new List<(int, int, int)>();

            for (int row = 0; row < rows; row++)
            {
                for (int column = 0; column < cols; column++)
                {
                    distanceList.Add((row, column, (Math.Abs(column - cCenter)+ Math.Abs(row - rCenter))));
                }
            }

            distanceList = distanceList.OrderBy(c => c.Item3).ToList();

            int[][] sortedCells = new int[distanceList.Count][];

            for (int indexSortedCells = 0; indexSortedCells < distanceList.Count; indexSortedCells++)
            {
                sortedCells[indexSortedCells] = new int[] { distanceList[indexSortedCells].Item1, distanceList[indexSortedCells].Item2 };
            }

            return sortedCells.ToArray();
        }
    }
}
