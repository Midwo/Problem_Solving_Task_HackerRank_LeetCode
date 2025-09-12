using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_885
    {
        ////(885.) Spiral Matrix III (MEDIUM)
        public int[][] SpiralMatrixIII(int rows, int cols, int rStart, int cStart)
        {
            int length = rows * cols;
            int[][] result = new int[length][];
            result[0] = new int[] { rStart, cStart };
            int index = 1;
            int turn = 1;
            int count = 2;
            int howLength = 1;
            int currHowlength = howLength;

            while(index != length)
            {
                if (turn == 1)
                {
                    cStart++;
                    currHowlength--;
                    if (currHowlength == 0)
                    {
                        count--;
                        currHowlength = howLength;
                        if (count == 0)
                        {
                            count = 2;
                            currHowlength = ++howLength;
                        }
                        turn = 2;
                    }
                }
                else if (turn == 2) 
                {
                    rStart++;
                    currHowlength--;
                    if (currHowlength == 0)
                    {
                        count--;
                        currHowlength = howLength;
                        if (count == 0)
                        {
                            count = 2;
                            currHowlength = ++howLength;
                        }
                        turn = 3;
                    }
                }
                else if (turn == 3)
                {
                    cStart--;
                    currHowlength--;
                    if (currHowlength == 0)
                    {
                        count--;
                        currHowlength = howLength;
                        if (count == 0)
                        {
                            count = 2;
                            currHowlength = ++howLength;
                        }
                        turn = 4;
                    }
                }
                else
                {
                    rStart--;
                    currHowlength--;
                    if (currHowlength == 0)
                    {
                        count--;
                        currHowlength = howLength;
                        if (count == 0)
                        {
                            count = 2;
                            currHowlength = ++howLength;
                        }
                        turn = 1;
                    }
                }


                if (rStart >= 0 && rStart < rows && cStart >= 0 && cStart < cols)
                {
                    result[index] = new int[] { rStart, cStart };
                    index++;
                }
            }
            return result;
        }
    }
}
