using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3100
    {
        ////(3100.) Water Bottles II (MEDIUM)
        public int MaxBottlesDrunk(int numBottles, int numExchange)
        {
            int count = numBottles;
            while (numBottles >= numExchange)
            {
                numBottles -= numExchange++ -1;
                count++;
            }

            return count;
        }
    }
}
