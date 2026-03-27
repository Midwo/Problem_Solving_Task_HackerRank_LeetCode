using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2946
    {
        ////(2946.) Matrix Similarity After Cyclic Shifts (EASY)
        public bool AreSimilar(int[][] mat, int k)
        {
            int rows = mat.Length;
            int cols = mat[0].Length;
            int howManyOperations = k % cols;

            if(howManyOperations == 0)
            {
                return true;
            }

            for (int i = 0; i < rows; i++)
            {
                if( i % 2 == 0)
                {
                    int newIndex = cols-howManyOperations;
                    for(int indexCol = 0; indexCol < cols; indexCol++)
                    {
                        if(newIndex == cols)
                        { 
                            newIndex = 0;
                        }
                        if (mat[i][indexCol] != mat[i][newIndex++])
                        {
                            return false;
                        }
                    }
                }
                else
                {
                    int newIndex = howManyOperations;
                    for (int indexCol = 0; indexCol < cols; indexCol++)
                    {
                        if (newIndex == cols)
                        {
                            newIndex = 0;
                        }
                        if (mat[i][indexCol] != mat[i][newIndex++])
                        {
                            return false;
                        }
                    }
                }
            }

            return true;
        }
    }
}
