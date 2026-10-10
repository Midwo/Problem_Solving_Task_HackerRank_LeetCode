using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_4024
    {
        ////(4024.) Nearest Available Drone (EASY)
        public int NearestDrone(int[][] drones, int[] target)
        {
            int nearsetAvailableDroneIndex = int.MinValue;
            int minDistance = int.MaxValue;
            int x = target[0];
            int y = target[1];

            for(int index = 0; index < drones.Length; index++)
            {
                int currDistance = Math.Abs(drones[index][0] - x) + Math.Abs(drones[index][1] - y);
                if(currDistance < minDistance && currDistance <= drones[index][2])
                {
                    nearsetAvailableDroneIndex = index;
                    minDistance = currDistance;
                }
            }

            return nearsetAvailableDroneIndex == int.MinValue? -1: nearsetAvailableDroneIndex;
        }
    }
}
