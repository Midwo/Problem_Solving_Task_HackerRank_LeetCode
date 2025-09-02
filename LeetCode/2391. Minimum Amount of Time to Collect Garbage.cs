using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2391
    {
        ////(2391.) Minimum Amount of Time to Collect Garbage (MEDIUM)
        public int GarbageCollection(string[] garbage, int[] travel)
        {
            int howManyM = 0;
            int howManyG = 0;
            int howMAnyP = 0;

            int lastDistanceM = 0;
            int lastDistanceG = 0;
            int lastDistanceP = 0;

            int currDistance = 0;
            int length = garbage.Length;
  
            for (int i = 0; i < length; i++) 
            { 
                for (int j = 0; j < garbage[i].Length; j++)
                {
                    if (garbage[i][j] == 'M')
                    {
                        howManyM++;
                        lastDistanceM = currDistance;
                    }
                    else if (garbage[i][j] == 'G')
                    {
                        howManyG++;
                        lastDistanceG = currDistance;
                    }
                    else
                    {
                        howMAnyP++;
                        lastDistanceP = currDistance;
                    }
                }
            
                if (length - 1 != i)
                {
                    currDistance += travel[i];
                } 
            }


            return howManyM + howManyG + howMAnyP + lastDistanceP + lastDistanceM + lastDistanceG;
        }
    }
}
