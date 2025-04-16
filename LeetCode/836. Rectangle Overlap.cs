using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_836
    {
        ////(836.) Rectangle Overlap (EASY)
        public bool IsRectangleOverlap(int[] rec1, int[] rec2)
        {
            ////rec1 = [0,0,2,2], rec2 = [1,1,3,3]
            
            int minX1 = rec1[0];
            int maxX1 = rec1[2];
            int minY1 = rec1[1];
            int maxY1 = rec1[3];

            //Console.WriteLine(minX1);
            //Console.WriteLine(maxX1);
            //Console.WriteLine(minY1);
            //Console.WriteLine(maxY2);

            int minX2 = rec2[0];
            int maxX2 = rec2[2];
            int minY2 = rec2[1];
            int maxY2 = rec2[3];

            if (maxX2 > minX1 && maxY2 > minY1 &&  minX2 < maxX1 && minY2 < maxY1)
            {
                return true;
            }
            return false;
        }
    }
}
