using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1431
    {
        ////(1431.) Kids With the Greatest Number of Candies (EASY)
        public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
        {
            bool[] result = new bool[candies.Length];

            int maxValue = 0;
            for (int i = 0; i < candies.Length; i++) 
            {
                if (maxValue < candies[i])
                {
                    maxValue = candies[i];
                }
            }

            for (int i = 0;i < candies.Length; i++)
            {
                if (candies[i] + extraCandies < maxValue)
                {
                    result[i] = false;
                }
                else
                {
                    result[i] = true;
                }
            }

            return result;

        }
    }
}
