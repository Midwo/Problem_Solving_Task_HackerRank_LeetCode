using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1260
    {
        ////(1260.) Shift 2D Grid (EASY)
        public IList<IList<int>> ShiftGrid(int[][] grid, int k)
        {
            int rows = grid.Length;
            int cols = grid[0].Length;

            int colAddSteps = k % cols;
            int rowAddSteps = (k / cols) % rows;

            var newGrid = new int[rows][];

            for (int i = 0; i < rows; i++)
            {
                newGrid[i] = new int[cols];
            }

            for (int indexRow = 0; indexRow < rows; indexRow++)
            {
                int currRow = (indexRow + rowAddSteps) % rows;
                
                for (int indexCol = 0; indexCol < cols; indexCol++)
                {
                    int currCol = (indexCol + colAddSteps) % cols;
                    if(indexCol + colAddSteps >= cols)
                    {
                        newGrid[currRow +1 >= rows? 0: currRow+1][currCol] = grid[indexRow][indexCol];
                    }
                    else
                    {
                        newGrid[currRow][currCol] = grid[indexRow][indexCol];
                    }

                }
            }

            ////Classic
            IList<IList<int>> listShiftGrid = new List<IList<int>>();
            foreach (var item in newGrid)
            {
                listShiftGrid.Add(item);
            }

            return listShiftGrid;
            
            //OR

            ////LINQ
            //return newGrid.Select(x => (IList<int>)x.ToList()).ToList();
        }
    }
}
