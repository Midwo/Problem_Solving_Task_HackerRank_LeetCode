using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_498
    {
        ///(498.) Diagonal Traverse (MEDIUM)
        public int[] FindDiagonalOrder(int[][] mat)
        {
            bool reverse = true;
            bool change = true;
            int hight = mat.Length;
            int length = mat[0].Length;
            int countAll = hight * length;
            int[] result = new int[countAll];
            int currIndexX = 0;
            int currindexY = 0;
            int lessNormal = 0;

            if (hight == 1)
            {
                for (int i = 0; i < length; i++)
                {
                    result[i] = mat[0][i];
                }
                return result;
            }
            else if (length == 1)
            {
                for (int i = 0; i < hight; i++)
                {
                    result[i] = mat[i][0];
                }
                return result;
            }

            result[0] = mat[0][0];

            for (int i = 1; i < countAll; i++)
            {
                if (reverse)
                {
                    if (change)
                    {
                        currIndexX++;
                        change = false;
                        if (currIndexX > length - 1)
                        {
                            lessNormal++;
                            currIndexX = length - 1;
                            currindexY++;
                        }
                        if (currindexY > hight - 1)
                        {
                            currindexY = hight - 1;
                        }
                        result[i] = mat[currindexY][currIndexX];
                    }
                    else
                    {
                        change = false;
                        currIndexX--;
                        currindexY++;
                        if (currIndexX < 0 || currindexY > hight - 1)
                        {
                            currIndexX++;
                            currindexY--;
                            reverse = false;
                            change = true;
                            i--;
                        }
                        else
                        {
                            result[i] = mat[currindexY][currIndexX];
                        }
                    }
                }
                else
                {
                    if (change)
                    {
                        currindexY++;
                        change = false;
                        if (currindexY > hight - 1)
                        {
                            currindexY = hight - 1;
                            currIndexX++;
                        }
                        if (currIndexX > length - 1)
                        {
                            currIndexX = length - 1;
                        }
                        result[i] = mat[currindexY][currIndexX];
                    }
                    else
                    {
                        change = false;
                        currIndexX++;
                        currindexY--;
                        if (currIndexX > length - 1 || currindexY < 0)
                        {
                            currIndexX--;
                            currindexY++;
                            reverse = true;
                            change = true;
                            i--;
                        }
                        else
                        {
                            result[i] = mat[currindexY][currIndexX];
                        }
                    }
                }
            }

            return result;
        }
    }
}
