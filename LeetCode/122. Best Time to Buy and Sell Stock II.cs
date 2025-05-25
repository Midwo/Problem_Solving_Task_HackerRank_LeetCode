using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_122
    {
        ////(122.) Best Time to Buy and Sell Stock II (MEDIUM)
        public int MaxProfit(int[] prices)
        {
            int result = 0;
            int buy = prices[0];

            for (int i = 1; i < prices.Length; i++)
            {
                if (prices[i] < buy)
                {
                    buy = prices[i];
                }
                else
                {
                    result += prices[i] - buy;
                    buy = prices[i];
                }
            }

            return result;
        }
    }
}
