using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2327
    {
        ////(2327.) Number of People Aware of a Secret (MEDIUM)
        private static int MOD = 1000000007;
        public int PeopleAwareOfSecret(int n, int delay, int forget)
        {
            int size = n * 2 + 1;
            long[] dpNewKnow = new long[size];
            long[] dpKnow = new long[size];

            dpNewKnow[1] = 1;

            int day = 1;

            while (day <= n)
            {
                if (dpNewKnow[day] > 0)
                {
                    dpKnow[day] = (dpKnow[day] + dpNewKnow[day]) % MOD;

                    dpKnow[day + forget] = (dpKnow[day + forget] - dpNewKnow[day] + MOD) % MOD;

                    int shareStartDay = day + delay;

                    while (shareStartDay < day + forget)
                    {
                        dpNewKnow[shareStartDay] = (dpNewKnow[shareStartDay] + dpNewKnow[day]) % MOD;
                        shareStartDay++;
                    }
                }
                day++;

            }

            long resultKnowing = 0;

            for (int start = 1; start <= n; start++)
            {
                resultKnowing = (resultKnowing + dpKnow[start]) % MOD;
            }

            return (int)resultKnowing;
        }
    }
}
