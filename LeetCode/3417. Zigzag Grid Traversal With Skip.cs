using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3417
    {
        ////(3417.) Zigzag Grid Traversal With Skip (EASY)
        public IList<int> ZigzagTraversal(int[][] grid)
        {
            int rowCount = grid.Length;
            int columCount = grid[0].Length;

            int currIndex = 0;
            int currRow = 0;
            IList<int> listZigzagValues = new List<int>();
            bool right = true;

            while (currRow < rowCount && currIndex >= 0 && currIndex < columCount)
            {
                int currValue = grid[currRow][currIndex];
                listZigzagValues.Add(currValue);

                if (right)
                {
                    currIndex += 2;
                    if (currIndex == columCount)
                    {
                        currIndex--;
                        currRow++;
                        right = false;
                    }
                    else
                    if (currIndex >= columCount)
                    {
                        currRow++;
                        currIndex -=3;
                        right = false;
                    }
                }
                else
                {
                    currIndex -= 2;
                    if (currIndex == -1)
                    {
                        currIndex++;
                        currRow++;
                        right = true;
                    }
                    else
                    if (currIndex < 0)
                    {
                        currIndex +=3;
                        currRow++;
                        right = true;
                    }
                }
            }

            return listZigzagValues;
        }
    }
}
