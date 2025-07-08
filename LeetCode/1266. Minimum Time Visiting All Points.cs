using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1266
    {
        ////(1266.) Minimum Time Visiting All Points (EASY)
        public int MinTimeToVisitAllPoints(int[][] points)
        {
            int resultTime = 0;
            int positionX = points[0][0];
            int positionY = points[0][1];

            for (int i = 1; i < points.Length; i++)
            {
                int currX = points[i][0];
                int currY = points[i][1];

                resultTime += Math.Max(Math.Abs(currX - positionX), Math.Abs(currY - positionY));
                
                positionX = currX;
                positionY = currY;
            } 

            return resultTime;
        }
    }
}
