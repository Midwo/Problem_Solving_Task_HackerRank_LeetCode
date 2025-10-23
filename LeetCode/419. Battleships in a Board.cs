using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_419
    {
        ////(419.) Battleships in a Board (MEDIUM)
        public int CountBattleships(char[][] board)
        {
            int lengthY = board.Length;
            int lengthX = board[0].Length;
            int countX = 0;
            int countY = 0;
            bool statusX = false;
            for (int y = 0; y < lengthY; y++)
            {
                statusX = false;
                for (int x = 0; x < lengthX; x++)
                {
                    if (board[y][x] == 'X')
                    {
                        statusX = true;
                        int tempY = y + 1;
                        while(tempY < lengthY)
                        {
                            if (board[tempY][x] == 'X')
                            {
                                board[tempY][x] = '.';
                                tempY++;
                            }
                            else
                            {
                                break;
                            }
                        }
                        if(tempY != y + 1)
                        {
                            statusX = false;
                            x ++;
                            countY++;
                        }
                    }
                    else
                    {
                        if (statusX)
                        {
                            countX++;
                            statusX = false;
                        }
                    }
                }
                if (statusX)
                {
                    countX++;
                    statusX = false;
                }
            }
            if (statusX)
            {
                countX++;
                statusX = false;
            }

            return countY + countX;
        }
    }
}
