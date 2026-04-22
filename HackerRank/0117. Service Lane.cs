using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.HackerRank
{
    internal class HackerRank_0117
    {
        ////117. Service Lane (EASY)
        public List<int> serviceLane(int n, List<int> width, List<List<int>> cases)
        { 
            ////Solution 1 (New)
            var serviceLine = new List<int>();
  
            for (int index = 0; index < cases.Count; index++)
            {
                int minValue = int.MaxValue;

                for (int indexWidth = cases[index][0]; indexWidth <= cases[index][1]; indexWidth++)
                {
                    minValue = minValue > width[indexWidth] ? width[indexWidth] : minValue;

                }
                serviceLine.Add(minValue);
            }

            return serviceLine;

            ////Solution 2 (Old)
            //List<int> newList = new List<int>();
            //foreach (List<int> subList in cases)
            //{
            //    int resultValue = int.MaxValue;
            //    int minRange = int.MaxValue;
            //    int maxRange = int.MinValue;
            //    foreach (int item in subList)
            //    {
            //        minRange = item < minRange ? item : minRange;
            //        maxRange = item > maxRange ? item : maxRange;
            //    }
            //    for (int i = minRange; i <= maxRange; i++)
            //    {
            //        resultValue = resultValue > width[i] ? width[i] : resultValue;
            //    }
            //    newList.Add(resultValue);
            //}
            //return newList;
        }
    }
}
