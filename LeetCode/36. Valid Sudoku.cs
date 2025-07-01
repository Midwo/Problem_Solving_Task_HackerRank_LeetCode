using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_36
    {
        ////(36.) Valid Sudoku (MEDIUM)
        public bool IsValidSudoku(char[][] board)
        {
            int levelIndex = 0;
            int widthIndex = 0;

            bool result = true;

            for (int i = 0; i < 9; i++)
            {
                int[] miniFields = new int[9];
                int[] vertical = new int[9];
                int[] horizontal = new int[9];
                int currMiniWidthIndex = 0;
                int currMiniLevelIndex = 0;

                for (int j = 0; j < 9; j++)
                {
                    if (board[j][i] != '.')
                    {
                        vertical[board[j][i] - '1'] += 1;
                    }

                    if (board[i][j] != '.')
                    {
                        horizontal[board[i][j] - '1'] += 1;
                    }

                    if (board[currMiniLevelIndex+ levelIndex][currMiniWidthIndex+ widthIndex] != '.')
                    {
                        miniFields[board[currMiniLevelIndex + levelIndex][currMiniWidthIndex + widthIndex] - '1'] += 1;
                    }

                    currMiniWidthIndex++;

                    if (currMiniWidthIndex > 2)
                    {
                        currMiniLevelIndex ++;
                        currMiniWidthIndex = 0;
                    }
                }

                widthIndex += 3;

                if (widthIndex > 7)
                {
                    widthIndex = 0;
                    levelIndex += 3;
                }

                for (int j = 0;j < 9; j++)
                {
                    if (vertical[j] > 1 || horizontal[j] > 1 || miniFields[j] > 1)
                    {
                        result = false;
                        break;
                    }
                }
                
                if (!result)
                {
                    break;
                }
            }

            return result;
        }
    }
}
