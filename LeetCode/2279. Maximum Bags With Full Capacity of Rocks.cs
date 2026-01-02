using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2279
    {
        ////(2279.) Maximum Bags With Full Capacity of Rocks (MEDIUM)
        public int MaximumBags(int[] capacity, int[] rocks, int additionalRocks)
        {
            int length = capacity.Length;
            for (int i = 0; i < length; i++) 
            {
                capacity[i] -= rocks[i];
            }

            Array.Sort(capacity);
            int howManyMaxCapacity = 0;

            for (int i = 0;i < length; i++)
            {
                int howMuchSpaceIsLeft = capacity[i];
                if (howMuchSpaceIsLeft == 0)
                {
                    howManyMaxCapacity++;
                }
                else
                {
                    additionalRocks -= howMuchSpaceIsLeft;
                    if(additionalRocks < 0)
                    {
                        break;
                    }
                    else
                    {
                        howManyMaxCapacity++;
                    }
                }
            }

            return howManyMaxCapacity;
        }
    }
}
