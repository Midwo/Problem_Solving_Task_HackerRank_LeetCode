using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_849
    {
        ////(849.) Maximize Distance to Closest Person (MEDIUM)
        public int MaxDistToClosest(int[] seats)
        {
            int firstSeatIndex = -1;
            int lastSeatIndex = -1;
            int maxDistFreeSeats = 0;
            int length = seats.Length;

            for (int index = 0; index < length; index++) 
            {
                if (seats[index] == 1)
                {
                    if (firstSeatIndex == -1)
                    {
                        firstSeatIndex = index;
                        maxDistFreeSeats = index;
                        lastSeatIndex = index;
                    }
                    if(lastSeatIndex != index)
                    {
                        maxDistFreeSeats = Math.Max(maxDistFreeSeats, index - (lastSeatIndex+1));
                        lastSeatIndex = index;
                    }
                }
            }

            int maxDistanceToCLosestPerson = 0;

            maxDistanceToCLosestPerson = Math.Max(firstSeatIndex, (length - lastSeatIndex-1));

            if(maxDistFreeSeats % 2 == 1)
            {
                maxDistanceToCLosestPerson = Math.Max(maxDistanceToCLosestPerson, (maxDistFreeSeats / 2 + 1));
            }
            else
            {
                maxDistanceToCLosestPerson = Math.Max(maxDistanceToCLosestPerson, maxDistFreeSeats / 2);
            }

            return maxDistanceToCLosestPerson;
        }
    }
}
