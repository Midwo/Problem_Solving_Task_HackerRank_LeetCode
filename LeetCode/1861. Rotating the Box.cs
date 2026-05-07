using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1861
    {
        ////(1861.) Rotating the Box (MEDIUM)
        public char[][] RotateTheBox(char[][] boxGrid)
        {
            int rows = boxGrid.Length;
            int cols = boxGrid[0].Length;

            var rotatedBox = new char[cols][];
            for (int i = 0; i < cols; i++)
            {
                rotatedBox[i] = new char[rows];
            }

            for (int indexRow = 0; indexRow < rows; indexRow++)
            {
                int availablePosition = cols - 1;
                int indexColsRotatedBox = rows - indexRow -1;
                int indexRowsRotatedBox = cols-1;
                for (int indexCol = cols-1; indexCol >= 0; indexCol--)
                {
                    char currChar = boxGrid[indexRow][indexCol];
                    if(currChar == '*')
                    {
                        rotatedBox[indexRowsRotatedBox][indexColsRotatedBox] = currChar;
                        availablePosition = indexCol - 1;
                    }
                    else if(currChar == '.')
                    {
                        rotatedBox[indexRowsRotatedBox][indexColsRotatedBox] = currChar;
                    }
                    else
                    {
                        if(availablePosition > indexRowsRotatedBox)
                        {
                            rotatedBox[availablePosition][indexColsRotatedBox] = currChar;
                            rotatedBox[indexRowsRotatedBox][indexColsRotatedBox] = '.';
                        }
                        else
                        {
                            rotatedBox[indexRowsRotatedBox][indexColsRotatedBox] = currChar;
                        }
                        availablePosition--;
                    }
                    indexRowsRotatedBox--;
                }
            }

            return rotatedBox;
        }
    }
}
