using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_289
    {
        ////(289.) Game of Life (MEDIUM)
        public void GameOfLife(int[][] board)
        {
            int height = board.Length;
            int width = board[0].Length;

            int[][] nextBoard = new int[height][];

            for (int i = 0; i < height; i++)
            {
                nextBoard[i] = board[i].ToArray();
            }
            int countLiveNeighbors = 0;
            if (height == 1 || width == 1)
            {
                if (width == 1 && height == 1)
                {
                    board[0][0] = 0;
                }
                else if (width == 1)
                {
                    for (int i = 0; i < height; i++)
                    {
                        countLiveNeighbors = 0;

                        if (i == 0)
                        {
                            if (nextBoard[i + 1][0] == 1)
                            {
                                countLiveNeighbors++;
                            }
                        }
                        else if (i == height - 1)
                        {
                            if (nextBoard[i - 1][0] == 1)
                            {
                                countLiveNeighbors++;
                            }
                        }
                        else
                        {
                            if (nextBoard[i + 1][0] == 1)
                            {
                                countLiveNeighbors++;
                            }
                            if (nextBoard[i - 1][0] == 1)
                            {
                                countLiveNeighbors++;
                            }
                        }


                        if (nextBoard[i][0] == 0)
                        {
                            if (countLiveNeighbors == 3)
                            {
                                board[i][0] = 1;
                            }
                        }
                        else
                        {
                            if (countLiveNeighbors > 3)
                            {
                                board[i][0] = 0;
                            }
                            if (countLiveNeighbors < 2)
                            {
                                board[i][0] = 0;
                            }
                        }
                    }

                }
                else
                {
                    for (int i = 0; i < width; i++)
                    {
                        countLiveNeighbors = 0;

                        if (i == 0)
                        {
                            if (nextBoard[0][i + 1] == 1)
                            {
                                countLiveNeighbors++;
                            }
                        }
                        else if (i == width - 1)
                        {
                            if (nextBoard[0][i - 1] == 1)
                            {
                                countLiveNeighbors++;
                            }
                        }
                        else
                        {
                            if (nextBoard[0][i + 1] == 1)
                            {
                                countLiveNeighbors++;
                            }
                            if (nextBoard[0][i - 1] == 1)
                            {
                                countLiveNeighbors++;
                            }
                        }

                        if (nextBoard[0][i] == 0)
                        {
                            if (countLiveNeighbors == 3)
                            {
                                board[0][i] = 1;
                            }
                        }
                        else
                        {
                            if (countLiveNeighbors > 3)
                            {
                                board[0][i] = 0;
                            }
                            if (countLiveNeighbors < 2)
                            {
                                board[0][i] = 0;
                            }
                        }
                    }
                }
            } 
            else
            {
                for (int i = 0; i < height; i++)
                {
                    for (int j = 0; j < width; j++)
                    {
                        countLiveNeighbors = 0;

                        if (i > 0 && i < height - 1 && j > 0 && j < width - 1)
                        {
                            if (nextBoard[i][j - 1] == 1)
                            {
                                countLiveNeighbors++;
                            }
                            if (nextBoard[i - 1][j - 1] == 1)
                            {
                                countLiveNeighbors++;
                            }
                            if (nextBoard[i - 1][j] == 1)
                            {
                                countLiveNeighbors++;
                            }
                            if (nextBoard[i - 1][j + 1] == 1)
                            {
                                countLiveNeighbors++;
                            }
                            if (nextBoard[i][j + 1] == 1)
                            {
                                countLiveNeighbors++;
                            }
                            if (nextBoard[i + 1][j + 1] == 1)
                            {
                                countLiveNeighbors++;
                            }
                            if (nextBoard[i + 1][j] == 1)
                            {
                                countLiveNeighbors++;
                            }
                            if (nextBoard[i + 1][j - 1] == 1)
                            {
                                countLiveNeighbors++;
                            }
                        }
                        else
                        {
                            if (i == 0)
                            {
                                if (j == 0)
                                {
                                    if (nextBoard[i][j + 1] == 1)
                                    {
                                        countLiveNeighbors++;
                                    }
                                    if (nextBoard[i + 1][j + 1] == 1)
                                    {
                                        countLiveNeighbors++;
                                    }
                                    if (nextBoard[i + 1][j] == 1)
                                    {
                                        countLiveNeighbors++;
                                    }
                                }
                                else if (j == width - 1)
                                {
                                    if (nextBoard[i][j - 1] == 1)
                                    {
                                        countLiveNeighbors++;
                                    }
                                    if (nextBoard[i + 1][j - 1] == 1)
                                    {
                                        countLiveNeighbors++;
                                    }
                                    if (nextBoard[i + 1][j] == 1)
                                    {
                                        countLiveNeighbors++;
                                    }
                                }
                                else
                                {
                                    if (nextBoard[i][j - 1] == 1)
                                    {
                                        countLiveNeighbors++;
                                    }
                                    if (nextBoard[i][j + 1] == 1)
                                    {
                                        countLiveNeighbors++;
                                    }
                                    if (nextBoard[i + 1][j + 1] == 1)
                                    {
                                        countLiveNeighbors++;
                                    }
                                    if (nextBoard[i + 1][j] == 1)
                                    {
                                        countLiveNeighbors++;
                                    }
                                    if (nextBoard[i + 1][j - 1] == 1)
                                    {
                                        countLiveNeighbors++;
                                    }
                                }
                            }
                            else if (i == height - 1)
                            {
                                if (j == 0)
                                {
                                    if (nextBoard[i - 1][j] == 1)
                                    {
                                        countLiveNeighbors++;
                                    }
                                    if (nextBoard[i - 1][j + 1] == 1)
                                    {
                                        countLiveNeighbors++;
                                    }
                                    if (nextBoard[i][j + 1] == 1)
                                    {
                                        countLiveNeighbors++;
                                    }
                                }
                                else if (j == width - 1)
                                {
                                    if (nextBoard[i][j - 1] == 1)
                                    {
                                        countLiveNeighbors++;
                                    }
                                    if (nextBoard[i - 1][j - 1] == 1)
                                    {
                                        countLiveNeighbors++;
                                    }
                                    if (nextBoard[i - 1][j] == 1)
                                    {
                                        countLiveNeighbors++;
                                    }
                                }
                                else
                                {
                                    if (nextBoard[i][j - 1] == 1)
                                    {
                                        countLiveNeighbors++;
                                    }
                                    if (nextBoard[i - 1][j - 1] == 1)
                                    {
                                        countLiveNeighbors++;
                                    }
                                    if (nextBoard[i - 1][j] == 1)
                                    {
                                        countLiveNeighbors++;
                                    }
                                    if (nextBoard[i - 1][j + 1] == 1)
                                    {
                                        countLiveNeighbors++;
                                    }
                                    if (nextBoard[i][j + 1] == 1)
                                    {
                                        countLiveNeighbors++;
                                    }
                                }
                            }
                            else if (j == 0)
                            {
                                if (nextBoard[i - 1][j] == 1)
                                {
                                    countLiveNeighbors++;
                                }
                                if (nextBoard[i - 1][j + 1] == 1)
                                {
                                    countLiveNeighbors++;
                                }
                                if (nextBoard[i][j + 1] == 1)
                                {
                                    countLiveNeighbors++;
                                }
                                if (nextBoard[i + 1][j + 1] == 1)
                                {
                                    countLiveNeighbors++;
                                }
                                if (nextBoard[i + 1][j] == 1)
                                {
                                    countLiveNeighbors++;
                                }
                            }
                            else //j == width - 1
                            {
                                if (nextBoard[i][j - 1] == 1)
                                {
                                    countLiveNeighbors++;
                                }
                                if (nextBoard[i - 1][j - 1] == 1)
                                {
                                    countLiveNeighbors++;
                                }
                                if (nextBoard[i - 1][j] == 1)
                                {
                                    countLiveNeighbors++;
                                }
                                if (nextBoard[i + 1][j] == 1)
                                {
                                    countLiveNeighbors++;
                                }
                                if (nextBoard[i + 1][j - 1] == 1)
                                {
                                    countLiveNeighbors++;
                                }
                            }
                        }

                        if (nextBoard[i][j] == 0)
                        {
                            if (countLiveNeighbors == 3)
                            {
                                board[i][j] = 1;
                            }
                        }
                        else
                        {
                            if (countLiveNeighbors > 3)
                            {
                                board[i][j] = 0;
                            }
                            if (countLiveNeighbors < 2)
                            {
                                board[i][j] = 0;
                            }
                        }
                    }
                }
            }
        }
    }
}
