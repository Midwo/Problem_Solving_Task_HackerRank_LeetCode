using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1217
    {
        ////(1217.) Minimum Cost to Move Chips to The Same Position (EASY)
        public int MinCostToMoveChips(int[] position)
        {
            int howManyDivisibleByOne = 0;
            int howManyDivisibleByTwo = 0;

            foreach (int i in position) 
            {
                if (i % 2 != 0)
                {
                    howManyDivisibleByOne++;
                }
                else
                {
                    howManyDivisibleByTwo++;
                }
            }

            return Math.Min(howManyDivisibleByOne, howManyDivisibleByTwo);
        }
    }
}
