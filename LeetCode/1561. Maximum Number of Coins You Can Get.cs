using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1561
    {
        ////(1561.) Maximum Number of Coins You Can Get (MEDIUM)
        public int MaxCoins(int[] piles)
        {
            Array.Sort(piles);
            int sum = 0;

            int length = piles.Length;

            for (int i = length / 3; i < length - 1; i += 2) 
            {
                sum += piles[i];
            }

            return sum;
        }
    }
}
