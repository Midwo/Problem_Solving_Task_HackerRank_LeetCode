using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.HackerRank
{
    internal class HackerRank_0022
    {
        public int getMinimumCost(int k, int[] c)
        {

            int howManyFlowers = c.Count();
            Array.Sort(c);
            int cost = 0;
            int multipleCost = 1;
            int couterForMultipleCost = 0;
            if (howManyFlowers <= k)
            {
                //cost = c.Sum();
                return c.Sum();
            }
            else
            {
                do
                {
                    couterForMultipleCost++;
                    if (couterForMultipleCost > k)
                    {
                        couterForMultipleCost = 1;
                        multipleCost++;
                    }
                    cost += multipleCost * c[howManyFlowers - 1];
                    howManyFlowers -= 1;
                } while (howManyFlowers != 0);
            }
            return cost;
        }

    }
}
