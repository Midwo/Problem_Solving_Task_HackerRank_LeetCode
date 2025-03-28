using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
    internal class LeetCode_575
    {
        ////(575.) Distribute Candies (EASY)

        public int DistributeCandies(int[] candyType)
        {
            int length = candyType.Length;
            int maxEat = length / 2;

            HashSet<int> hashSetValues = candyType.ToHashSet();

            int numberOfDifferent = hashSetValues.Count;

            if (numberOfDifferent > maxEat)
            {
                return maxEat;
            }

            return numberOfDifferent;
        }
    }
}
