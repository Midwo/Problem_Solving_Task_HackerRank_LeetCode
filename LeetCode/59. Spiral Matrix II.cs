using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_59
    {
        ////(59.) Spiral Matrix II (MEDIUM)
        public int[][] GenerateMatrix(int n)
        {
            int[][] resultTable = new int[n][];

            for (int i = 0; i < n; i++)
            {
                resultTable[i] = new int[n];
            }

            int[][] direction = [[0,1], [1,0], [0,-1], [-1, 0]];
            int currDirection = 0;
            int positionY = 0;
            int positionX = 0;

            for (int i = 1; i <= n*n; i++)
            {
                if (i == 1)
                {
                    resultTable[0][0] = i;
                }
                else
                {
                    int currY = positionY + direction[currDirection][0];
                    int currX = positionX + direction[currDirection][1];

                    if (currX < 0 || currY < 0 || currX >= n || currY >= n || resultTable[currY][currX] != 0)
                    {
                        currDirection++;
                        if(currDirection == 4)
                        {
                            currDirection = 0;
                        }
                        currY = positionY + direction[currDirection][0];
                        currX = positionX + direction[currDirection][1];
                    }

                    positionY = currY;
                    positionX = currX;
                    resultTable[positionY][positionX] = i;
                }
            }

            return resultTable;
        }
    }
}
