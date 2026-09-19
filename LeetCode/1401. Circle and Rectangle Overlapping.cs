using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1401
    {
        ////(1401.) Circle and Rectangle Overlapping (MEDIUM)
        public bool CheckOverlap(int radius, int xCenter, int yCenter, int x1, int y1, int x2, int y2)
        {
            double dist = 0;
            if (xCenter < x1 || xCenter > x2)
            {
                dist += Math.Min(Math.Pow(x1 - xCenter, 2), Math.Pow(x2 - xCenter, 2));
            }
            if (yCenter < y1 || yCenter > y2)
            {
                dist += Math.Min(Math.Pow(y1 - yCenter, 2), Math.Pow(y2 - yCenter, 2));
            }

            return dist <= radius * radius;
        }
    }
}
