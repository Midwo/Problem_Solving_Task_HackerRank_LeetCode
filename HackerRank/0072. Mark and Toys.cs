using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.HackerRank
{
    internal class HackerRank_0072
    {
        ////72. Mark and Toys (EASY)
        public int maximumToys(List<int> prices, int k)
        {
            prices.Sort();
            int sumCost = 0;
            int sumCount = 0;
            for (int i = 0; i < prices.Count; i++)
            {
                if (sumCost + prices[i] <= k)
                {
                    sumCount++;
                    sumCost += prices[i];
                }
                else
                {
                    break; ;
                }
            }
            return sumCount;
        }
    }
}
