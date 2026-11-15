using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1706
    {
        ////(1706.) Where Will the Ball Fall (MEDIUM)
        public int[] FindBall(int[][] grid)
        {
            int cols = grid[0].Length;
            int rows = grid.Length; 
            int[] resultTable = new int[cols];
            Array.Fill(resultTable, -1);

            for (int startBallCol = 0; startBallCol < cols; startBallCol++)
            {
                bool statusCompletedPath = true;

                int currColPosition = startBallCol;

                for (int level = 0; level < rows; level++)
                {
                    int direction = grid[level][currColPosition];

                    if(direction == 1)
                    {
                        currColPosition++;
                        if(currColPosition >= cols || grid[level][currColPosition] == -1 )
                        {
                            statusCompletedPath = false;
                            break;
                        }
                    }
                    else
                    {
                        currColPosition--;
                        if (currColPosition < 0 || grid[level][currColPosition] == 1) 
                        { 
                            statusCompletedPath = false;
                            break;
                        } 
                    }
                }

                if (statusCompletedPath)
                {
                    resultTable[startBallCol] = currColPosition;
                }
            }

            return resultTable;
        }
    }
}
