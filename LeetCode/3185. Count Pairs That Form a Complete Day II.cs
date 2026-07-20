using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3185
    {
        ////(3185.) Count Pairs That Form a Complete Day II (MEDIUM)
        public long CountCompleteDayPairs(int[] hours)
        {
            long result = 0;
            long[] countRestModulo = new long[24];

            foreach (int hour in hours) 
            { 
                countRestModulo[hour % 24]++;
            }

            long currCountModulo = countRestModulo[0];

            if(currCountModulo >= 2)
            {
                result += ((currCountModulo - 1) + 1)  * (currCountModulo - 1) /2;
            }

            currCountModulo = countRestModulo[12];
     
            if (currCountModulo >= 2)
            {
                result += ((currCountModulo - 1) + 1) * (currCountModulo - 1) / 2;
            }

            for (int i = 1; i < 12; i++)
            {
                result += countRestModulo[i] * countRestModulo[24 - i];
            }

            return result;
        }
    }
}
