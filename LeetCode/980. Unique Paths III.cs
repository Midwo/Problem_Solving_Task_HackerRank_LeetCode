using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_980
    {
        ////(980.) Unique Paths III (HARD)
        private bool[][] _visitedGrid;
        private int[][] _grid;
        private int _countRow;
        private int _countCol;
        private int _howManyZero;
        private int _howManyPath;
        private int[] _direction;
        public int UniquePathsIII(int[][] grid)
        {
            _grid = grid;
            _countRow = grid.Length;
            _countCol = grid[0].Length;
            _howManyZero = 0;
            int positionRow = 0;
            int positionCol = 0;
            _howManyPath = 0;
            _direction = new int[5] { 0, 1, 0, -1, 0 }; 
            _visitedGrid = new bool[_countRow][];

            for (int i = 0; i < _countRow; i++) 
            {
                _visitedGrid[i] = new bool[_countCol];    
                for (int j = 0; j < _countCol; j++)
                {
                    if (grid[i][j] == 0)
                    {
                        _howManyZero++;
                    }
                    else if (grid[i][j] == 1)
                    {
                        positionRow = i;
                        positionCol = j;
                    }
                }
            }
            _visitedGrid[positionRow][positionCol] = true;

            dfsPath(positionRow, positionCol, 0);

            return _howManyPath;
        }

        private void dfsPath(int row, int col, int countZero)
        {
            if (_grid[row][col] == 2)
            {
                if (countZero == _howManyZero+1)
                {
                    _howManyPath++;
                }
                return;
            }

            for (int i = 0; i < 4; i++)
            {
                int currRow = row + _direction[i];
                int currCol = col + _direction[i+1];

                if (currRow >= 0 && currCol >= 0 && currRow < _countRow && currCol < _countCol && !_visitedGrid[currRow][currCol] &&_grid[currRow][currCol] != -1)
                {
                    _visitedGrid[currRow][currCol] = true;

                    dfsPath(currRow, currCol, countZero +1);

                    _visitedGrid[currRow][currCol] = false;
                }
            }
        }
    }
}
