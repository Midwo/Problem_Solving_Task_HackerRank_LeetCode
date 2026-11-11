using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3789
    {
        ////(3789.) Minimum Cost to Acquire Required Items (MEDIUM)
        public long MinimumCost(int cost1, int cost2, int costBoth, int need1, int need2)
        {
            long minimumCost = 0;

            if(costBoth < cost1 + cost2 && costBoth <= cost1 && costBoth <= cost2)
            {
                long maxNeed = Math.Max(need1, need2);
                minimumCost = maxNeed * costBoth;

            }
            else if (costBoth < cost1 + cost2)
            {
                long minNeed = Math.Min(need1, need2);

                if(need1 - minNeed > 0 && cost1 >= costBoth)
                {
                    return (long)need1 * costBoth;
                }
                else if (need2 - minNeed > 0 && cost2 >= costBoth)
                {
                    return (long)need2 * costBoth;
                }

                return (long)(need1 - minNeed) * cost1 + (long)(need2 - minNeed) * cost2 + (long)minNeed * costBoth;

            }
            else
            {
                return (long)cost1 * need1 + (long)cost2 * need2;
            }

            return minimumCost;
        }
    }
}
