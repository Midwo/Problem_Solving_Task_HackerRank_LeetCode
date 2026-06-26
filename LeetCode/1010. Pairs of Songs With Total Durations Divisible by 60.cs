using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1010
    {
        ////(1010.) Pairs of Songs With Total Durations Divisible by 60 (MEDIUM)
        public int NumPairsDivisibleBy60(int[] time)
        {
            int[] moduloRestCount = new int[60];
            long countPairsDivisibleBy60 = 0;

            foreach (int currTime in time) 
            {
                moduloRestCount[currTime % 60]++;
                //Console.WriteLine(currTime % 60);
            }

            countPairsDivisibleBy60 += ((long)moduloRestCount[0] * (moduloRestCount[0] - 1)) / 2;
            countPairsDivisibleBy60 += ((long)moduloRestCount[30] * (moduloRestCount[30] - 1)) / 2;

            for (int i = 1; i < 30; i++)
            {
                countPairsDivisibleBy60 += moduloRestCount[i] * moduloRestCount[60 - i];
            }

            return (int)countPairsDivisibleBy60;
        }
    }
}
