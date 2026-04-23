using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.HackerRank
{
    internal class HackerRank_0121
    {
        ////120. Minimum Distances (EASY)
        public int minimumDistances(List<int> a)
        {
            ////Solution 1 (New - Better)
            var dictNumberLastIndex = new Dictionary<int, int>();
            int minDistance = int.MaxValue;

            for(int indexA = 0; indexA < a.Count; indexA++) 
            {
                int currA = a[indexA];
                if (dictNumberLastIndex.TryGetValue(currA, out int indexDict))
                {
                    minDistance = minDistance > indexA - indexDict ? indexA - indexDict : minDistance;
                }

                dictNumberLastIndex[currA] = indexA;
                
            }

            return minDistance == int.MaxValue ? -1 : minDistance;


            ////Solution 2 (Old - Poor)
            //int minDistance = int.MaxValue;
            //bool isMinDistance = false;
            //for (int i = 0; i < a.Count; i++)
            //{
            //    for (int x = 0; x < a.Count; x++)
            //    {

            //        if (a[i] == a[x] && i != x)
            //        {
            //            isMinDistance = true;
            //            int actualDistance = Math.Abs(Math.Abs(i) - Math.Abs(x));
            //            minDistance = minDistance > actualDistance ? actualDistance : minDistance;
            //        }
            //    }
            //}
            //if (isMinDistance)
            //{
            //    return minDistance;
            //}
            //return -1;

        }
    }
}
