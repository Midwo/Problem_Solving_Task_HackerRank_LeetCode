using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_63
    {            
        ////(63.) Unique Paths II (MEDIUM)
        public int UniquePathsWithObstacles(int[][] obstacleGrid)
        {
            int height = obstacleGrid.Length;
            int length = obstacleGrid[0].Length;

            int[] DP = new int[length];

            if (obstacleGrid[0][0] == 1)
            {
                return 0;
            }

            for (int i = 0; i < length; i++)
            {
                if (i == 0)
                {
                    DP[i] = 1;
                }
                else
                {
                    if (obstacleGrid[0][i] == 0 && DP[i - 1] == 1)
                    {
                        DP[i] = 1;
                    }
                    else
                    {
                        DP[i] = 0;
                    }
                }
            }

            for (int level = 1; level < height; level++)
            {
                for (int indexLength = 0; indexLength < length; indexLength++)
                {
                    if (indexLength == 0)
                    {
                        if (obstacleGrid[level][indexLength] != 0)
                        { 
                            DP[indexLength] = 0;
                        }
                    }
                    else
                    {
                        if (obstacleGrid[level][indexLength] != 0)
                        {
                            DP[indexLength] = 0;
                        }
                        else
                        {
                            DP[indexLength] = DP[indexLength-1] + DP[indexLength];
                        }
                    }
                }
            }

            return DP[length-1];
        }
    }
}
