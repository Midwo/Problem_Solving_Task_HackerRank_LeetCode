using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1103
    {
        ////(1103.) Distribute Candies to People (EASY)
        public int[] DistributeCandies(int candies, int num_people)
        {
            int[] result = new int[num_people];
            int currIndex = 0;
            int increment = 1;

            while(candies != 0)
            {
                if (candies >= increment)
                {
                    result[currIndex] += increment;
                    candies -= increment;
                    increment++;
                }
                else
                {
                    result[currIndex] += candies;
                    candies = 0;
                }

                currIndex++;
                if (currIndex == num_people)
                {
                    currIndex = 0;
                }
            }

            return result;
        }
    }
}
