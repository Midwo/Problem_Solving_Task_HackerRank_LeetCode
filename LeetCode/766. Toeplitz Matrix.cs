using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_766
    {
        ////(766.) Toeplitz Matrix (EASY)

        private int _height;
        private int _width;
        private int[][] _matrix;

        public bool IsToeplitzMatrix(int[][] matrix)
        {
            _matrix = matrix;
            _height = matrix.Length;
            if (_height == 0)
            {
                return false;
            }
            _width = matrix[0].Length;
 
            for (int i = 1; i < _height-1; i++)
            {
                if(!IsCorrectLine(i, 0))
                {
                    return false;
                }
            }

            for (int i = 0; i < _width; i++)
            {
                if (!IsCorrectLine(0, i))
                {
                    return false;
                }
            }

            return true;
        }
        private bool IsCorrectLine(int row, int column)
        { 
            int currValue = _matrix[row++][column++];
            for (int i = row; i < _height; i++)
            {
                if (column > _width-1)
                {
                    continue;
                }
                if (currValue != _matrix[row][column])
                {
                    return false;
                }
                row++;
                column++;
            }

            return true;
        }
    }
}
