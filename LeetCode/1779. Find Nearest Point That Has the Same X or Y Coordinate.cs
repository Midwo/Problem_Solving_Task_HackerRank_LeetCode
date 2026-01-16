using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1779
    {
        ////(1779.) Find Nearest Point That Has the Same X or Y Coordinate (EASY)
        public int NearestValidPoint(int x, int y, int[][] points)
        {
            int indexNearestPoint = -1;
            int minManhattanDistance = int.MaxValue;
            int currX = 0;
            int currY = 0;
            for (int i = 0; i < points.Length; i++)
            {
                currX = points[i][0];
                currY = points[i][1];
                if (x == currX || y == currY)
                {
                    int currManhattanDistance = Math.Abs(x - currX) + Math.Abs(y - currY);
                    if (currManhattanDistance < minManhattanDistance)
                    {
                        minManhattanDistance = currManhattanDistance;
                        indexNearestPoint = i;
                    }
                }
            }

            return indexNearestPoint;
        }
    }
}
