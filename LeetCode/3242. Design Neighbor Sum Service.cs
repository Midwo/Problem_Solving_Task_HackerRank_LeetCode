using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3242
    {
        ////(3242.) Design Neighbor Sum Service (EASY)
        public class NeighborSum
        {
            private int[][] _grid;
            private int _cols;
            private int _rows;
            private int[][] _diagonalPosition = [[-1,-1],[1,-1],[-1,1],[1,1]];
            private int[][] _adjacentPosition = [[0,-1],[0,1],[-1,0],[1,0]];
            Dictionary<int, int[]> _searchPosition;
            public NeighborSum(int[][] grid)
            {
                _grid = grid;
                _cols = grid[0].Length;
                _rows = grid.Length;
                _searchPosition = new Dictionary<int, int[]>();

                for (int indexRow = 0; indexRow < _rows; indexRow++)
                {
                    for (int indexCol = 0; indexCol < _cols; indexCol++)
                    {
                        _searchPosition.Add(_grid[indexRow][indexCol], [indexRow, indexCol]);
                    }
                }

            }

            public int AdjacentSum(int value)
            {
                int[] position = _searchPosition[value];
                int sum = 0;
                for (int i = 0; i < 4; i++)
                {
                    int currCol = position[1] + _adjacentPosition[i][1];
                    int currRow = position[0] + _adjacentPosition[i][0];

                    if(currCol >= 0 && currCol < _cols && currRow >= 0 && currRow < _rows)
                    {
                        sum += _grid[currRow][currCol];
                    }
                }
                return sum;
            }

            public int DiagonalSum(int value)
            {
                int[] position = _searchPosition[value];
                int sum = 0;
                for (int i = 0; i < 4; i++)
                {
                    int currCol = position[1] + _diagonalPosition[i][1];
                    int currRow = position[0] + _diagonalPosition[i][0];

                    if (currCol >= 0 && currCol < _cols && currRow >= 0 && currRow < _rows)
                    {
                        sum += _grid[currRow][currCol];
                    }
                }
                return sum;
            }
        }
    }
}
