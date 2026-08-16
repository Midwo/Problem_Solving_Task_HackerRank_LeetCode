using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2029
    {
        ////(2029.) Stone Game IX (MEDIUM)
        public bool StoneGameIX(int[] stones)
        {
            int[] countValueMod3 = new int[3]; 

            foreach (int stone in stones) 
            {
                countValueMod3[stone % 3]++;
            }

            if (countValueMod3[0] % 2 == 0)
            {
                if (countValueMod3[1] > 0 && countValueMod3[2] > 0)
                    return true;
                return false;
            }

            if (Math.Abs(countValueMod3[1] - countValueMod3[2]) > 2)
                return true;
            return false;
        }
    }
}
