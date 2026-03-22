using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1886
    {
        ////(1886.) Determine Whether Matrix Can Be Obtained By Rotatio (EASY)
        public bool FindRotation(int[][] mat, int[][] target)
        {
            bool status = true;
            int rows = target.Length;
            int col = target[0].Length;

            for (int i = 0; i < 4; i++) 
            {
                status = true;

                if (i == 0)
                {
                    for (int indexRow = 0; indexRow < rows; indexRow++)
                    {
                        for (int indexCol = 0; indexCol < col; indexCol++)
                        {
                            if (target[indexRow][indexCol] != mat[indexCol][rows-indexRow-1])
                            {
                                status = false;
                                break;
                            }
                            if(status == false)
                            {
                                break;
                            }
                        }
                        if (status == false)
                        {
                            break;
                        }
                    }        
                }
                else if(i == 1)
                {
                    for (int indexRow = 0; indexRow < rows; indexRow++)
                    {
                        for (int indexCol = 0; indexCol < col; indexCol++)
                        {
                            if (target[indexRow][indexCol] != mat[rows-1-indexRow][rows-indexCol-1])
                            {
                                status = false;
                                break;
                            }
                            if (status == false)
                            {
                                break;
                            }
                        }
                        if (status == false)
                        {
                            break;
                        }
                    }
                }
                else if (i == 2)
                {
                    for (int indexRow = 0; indexRow < rows; indexRow++)
                    {
                        for (int indexCol = 0; indexCol < col; indexCol++)
                        {
                            if (target[indexRow][indexCol] != mat[indexRow][indexCol])
                            {
                                status = false;
                                break;
                            }
                            if (status == false)
                            {
                                break;
                            }
                        }
                        if (status == false)
                        {
                            break;
                        }
                    }
                }
                else if(i == 3)
                {
                    for (int indexRow = 0; indexRow < rows; indexRow++)
                    {
                        for (int indexCol = 0; indexCol < col; indexCol++)
                        {
                            if (target[indexRow][indexCol] != mat[rows-1-indexCol][indexRow])
                            {
                                status = false;
                                break;
                            }
                            if (status == false)
                            {
                                break;
                            }
                        }
                        if (status == false)
                        {
                            break;
                        }
                    }
                }

                if (status) return true;
            }
            return status;
        }
    }
}
