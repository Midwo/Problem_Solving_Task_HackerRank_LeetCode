using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1765
    {
        ////(1765.) Map of Highest Peak (MEDIUM)
        public int[][] HighestPeak(int[][] isWater)
        {
            int cols = isWater[0].Length;
            int rows = isWater.Length;

            List<int[]> currList = new List<int[]>();

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    if (isWater[row][col] == 1)
                    {
                        isWater[row][col] = 0;
                        currList.Add(new int[] { row, col });
                    }
                    else
                    {
                        isWater[row][col] = int.MaxValue;
                    }
                }
            }

            int[][] directions = [[-1, 0], [0, 1], [1, 0], [0, -1]];

            while (currList.Count > 0)
            {
                List<int[]> newList = new List<int[]>();

                foreach (int[] currPoint in currList)
                {
                    int currPossibleHeight = isWater[currPoint[0]][currPoint[1]] + 1;

                    foreach (var direction in directions)
                    {
                        int[] newPoint = new int[2] { currPoint[0] + direction[0], currPoint[1] + direction[1] };

                        if (newPoint[0] >= 0 && newPoint[0] < rows && newPoint[1] >= 0 && newPoint[1] < cols && isWater[newPoint[0]][newPoint[1]] > 0)
                        {
                            int valueNewPoint = isWater[newPoint[0]][newPoint[1]];

                            if (valueNewPoint > currPossibleHeight)
                            {
                                newList.Add(new int[2] { newPoint[0], newPoint[1] });
                                isWater[newPoint[0]][newPoint[1]] = currPossibleHeight;
                            }
                        }
                    }
                }

                currList = newList;
            }

            return isWater;
        }
    }
}
