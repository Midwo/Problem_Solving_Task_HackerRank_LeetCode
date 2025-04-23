using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_999
    {
        ////(999.) Available Captures for Rook (EASY)
        private char[][] _board;
        public int NumRookCaptures(char[][] board)
        {
            int indexHeightTarget = 0;
            int indexWidthTarget = 0;
            _board = board;

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    bool currPositionIsATarget1 = CheckIfThereIsAR(i,j);
                    if (currPositionIsATarget1)
                    {
                        indexHeightTarget = i;
                        indexWidthTarget = j;
                        goto LoopEnd;
                    }
                    bool currPositionIsATarget2 = CheckIfThereIsAR(i, 7 - j);
                    if (currPositionIsATarget2)
                    {
                        indexHeightTarget = i;
                        indexWidthTarget = 7 - j;
                        goto LoopEnd;
                    }
                    bool currPositionIsATarget3 = CheckIfThereIsAR(7 - i, j);
                    if (currPositionIsATarget3)
                    {
                        indexHeightTarget = 7 - i;
                        indexWidthTarget = j;
                        goto LoopEnd;
                    }
                    bool currPositionIsATarget4 = CheckIfThereIsAR(7 - i, 7 - j);
                    if (currPositionIsATarget4)
                    {
                        indexHeightTarget = 7 - i;
                        indexWidthTarget = 7 - j;
                        goto LoopEnd;
                    }
                }
            }

        LoopEnd:

            int result = 0;
            bool endLeft = false;
            bool endRight = false;
            bool endTop = false;
            bool endBottom = false;
            int indexMove = 1;
            while (endLeft != true || endRight != true || endTop != true || endBottom != true)
            {
                if (!endLeft) 
                {
                    if (indexWidthTarget - indexMove >= 0)
                    {
                        if (_board[indexHeightTarget][indexWidthTarget-indexMove] == 'B')
                        {
                            endLeft = true;
                        }
                        else if(_board[indexHeightTarget][indexWidthTarget - indexMove] == 'p')
                        {
                            result++;
                            endLeft = true;
                        }
                    }
                    else
                    {
                        endLeft = true;
                    }
                }
                if (!endRight)
                {
                    if (indexWidthTarget + indexMove < 8)
                    {
                        if (_board[indexHeightTarget][indexWidthTarget + indexMove] == 'B')
                        {
                            endRight = true;
                        }
                        else if (_board[indexHeightTarget][indexWidthTarget + indexMove] == 'p')
                        {
                            result++;
                            endRight = true;
                        }
                    }
                    else
                    {
                        endRight = true;
                    }
                }
                if (!endTop)
                {
                    if (indexHeightTarget - indexMove >= 0)
                    {
                        if (_board[indexHeightTarget - indexMove][indexWidthTarget] == 'B')
                        {
                            endTop = true;
                        }
                        else if (_board[indexHeightTarget - indexMove][indexWidthTarget] == 'p')
                        {
                            result++;
                            endTop = true;
                        }
                    }
                    else
                    {
                        endTop = true;
                    }
                }
                if (!endBottom)
                {
                    if(indexHeightTarget + indexMove < 8)
                    {
                        if (_board[indexHeightTarget + indexMove][indexWidthTarget] == 'B')
                        {
                            endBottom = true;
                        }
                        else if (_board[indexHeightTarget + indexMove][indexWidthTarget] == 'p')
                        {
                            result++;
                            endBottom = true;
                        }
                    }
                    else
                    {
                        endBottom = true;
                    }
                }
                indexMove++;
            }


            return result;
        }

        private bool CheckIfThereIsAR(int indexHeight, int indexWidth)
        {
            if (_board[indexHeight][indexWidth] == 'R')
            {
                return true;
            }
            return false;
        }

    }
}
