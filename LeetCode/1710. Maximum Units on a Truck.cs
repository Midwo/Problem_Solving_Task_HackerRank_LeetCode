using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1710
    {
        ////(1710.) Maximum Units on a Truck (EASY)
        public int MaximumUnits(int[][] boxTypes, int truckSize)
        {
            boxTypes = boxTypes.OrderByDescending(t => t[1]).ToArray();
            int sumUnits = 0;

            for (int i = 0; i < boxTypes.Length; i++)
            {
                int howManyBoxs = boxTypes[i][0];
                int unitsPerBox = boxTypes[i][1];
                int maxBoxs = Math.Min(howManyBoxs, truckSize);
                truckSize -= maxBoxs;
                sumUnits += maxBoxs * unitsPerBox;
                if (truckSize == 0)
                {
                    break;
                }
            }
            
            return sumUnits;
        }
    }
}
