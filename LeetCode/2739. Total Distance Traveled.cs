using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2739
    {
        ////(2739.) Total Distance Traveled (EASY)
        public int DistanceTraveled(int mainTank, int additionalTank)
        {
            int totalDistance = 0;
            
            while (mainTank >= 5)
            {
                int temp = mainTank / 5;
                mainTank -= temp*5;
                totalDistance += temp * 50;
                if (temp <= additionalTank)
                {
                    mainTank += temp;
                    additionalTank -= temp;
                }
                else
                {
                    mainTank += additionalTank;
                    additionalTank = 0;
                }
            }

            totalDistance += mainTank * 10;

            return totalDistance;
        }
    }
}
