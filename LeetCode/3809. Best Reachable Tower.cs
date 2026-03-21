using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3809
    {
        ////(3809.) Best Reachable Tower (MEDIUM)
        public int[] BestTower(int[][] towers, int[] center, int radius)
        {
            //int[] result = [-1,-1];
            int resultX = -1;
            int resultY = -1;

            int maxQuality = -1;

            int cx = center[0];
            int cy = center[1];

            for (int indexTowers = 0; indexTowers < towers.Length; indexTowers++)
            {
                int currMangattanDistance = Math.Abs(towers[indexTowers][0] - cx) + Math.Abs(towers[indexTowers][1] - cy);

                if(currMangattanDistance <= radius && maxQuality <= towers[indexTowers][2])
                {
                    if(maxQuality < towers[indexTowers][2])
                    {
                        maxQuality = towers[indexTowers][2];

                        //result = towers[indexTowers][0..2];
                        resultX = towers[indexTowers][0];
                        resultY = towers[indexTowers][1];
                    }
                    else if (resultX > towers[indexTowers][0])
                    {
                        //result = towers[indexTowers][0..2];
                        resultX = towers[indexTowers][0];
                        resultY = towers[indexTowers][1];
                    }
                    else if (resultX == towers[indexTowers][0] && resultY > towers[indexTowers][1])
                    {
                        //result = towers[indexTowers][0..2];
                        resultY = towers[indexTowers][1];
                    }
                }
            }

            return new int[] {resultX, resultY};
        }
    }
}
