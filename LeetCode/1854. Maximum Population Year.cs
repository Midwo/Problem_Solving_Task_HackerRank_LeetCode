using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1854
    {
        ////(1854.) Maximum Population Year (EASY)
        public int MaximumPopulation(int[][] logs)
        {
            ////Solution 1 
            int maxPopulationValue = 0;
            int maxPopulationYear = 0;

            for (int startYear = 1950;  startYear < 2050; startYear++)
            {
                int count = 0;

                foreach(var log in logs)
                {
                    if (log[0] <= startYear && log[1] > startYear)
                    {
                        count++;
                    }
                }

                if(count > maxPopulationValue)
                {
                    maxPopulationValue = count;
                    maxPopulationYear = startYear;
                }
            }

            return maxPopulationYear;

            ////Solution 2
            //int maxPopulationValue = 0;
            //int maxPopulationYear = 0;

            //var tableSumPopulationPerYear = new int[100];

            //foreach (var currLogs in logs)
            //{
            //    for (int i = currLogs[0]; i < currLogs[1]; i++)
            //    {
            //        tableSumPopulationPerYear[i - 1950]++;
            //    }
            //}

            //for (int index = 0; index < 100; index++)
            //{
            //    int currPop = tableSumPopulationPerYear[index];

            //    if (currPop > maxPopulationValue)
            //    {
            //        maxPopulationValue = currPop;
            //        maxPopulationYear = 1950 + index;
            //    }
            //} 

            //return maxPopulationYear;
        }
    }
}
