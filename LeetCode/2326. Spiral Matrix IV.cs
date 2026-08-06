using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2326
    {
        ////(2326.) Spiral Matrix IV (MEDIUM)
        public int[][] SpiralMatrix(int m, int n, ListNode head)
        {
            int[][] spiralMatrixTable = new int[m][];

            for (int i = 0; i < m; i++)
            {
                spiralMatrixTable[i] = new int[n];
                Array.Fill(spiralMatrixTable[i], -1);
            }
            int currDirection = 0;
            int[][] direction = new int[4][];
            direction[0] = new int[2] { 0, 1 };
            direction[1] = new int[2] { 1, 0 };
            direction[2] = new int[2] { 0, -1};
            direction[3] = new int[2] { -1, 0 };

            int x = -1;
            int y = 0;

            int decreaseSizeY = 0;
            int decreaseSizeX = 0;

            while (head != null)
            {
                int currVal = head.val;
                head = head.next;

                if(x+direction[currDirection][1] < n - decreaseSizeX && x + direction[currDirection][1] >= decreaseSizeX && y + direction[currDirection][0] < m - decreaseSizeY && y + direction[currDirection][0] >= decreaseSizeY)
                {
                    x += direction[currDirection][1];
                    y += direction[currDirection][0];
                    spiralMatrixTable[y][x] = currVal;   
                }
                else
                {
                    currDirection++;

                    if(currDirection == 3)
                    {
                        decreaseSizeY++;
                    }

                    if (currDirection > 3)
                    {
                        currDirection = 0;
                        decreaseSizeX++;
                    }

                    x += direction[currDirection][1];
                    y += direction[currDirection][0];
                    spiralMatrixTable[y][x] = currVal;
                }
            }

            return spiralMatrixTable;
        }
    }
}
