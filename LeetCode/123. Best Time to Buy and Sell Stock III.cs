using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_123
    {
        ////(123.) Best Time to Buy and Sell Stock III (HARD)
        public int MaxProfit(int[] prices)
        {
            int length = prices.Length;

            if (length == 0) return 0;

            int[] left = new int[length];
            int[] right = new int[length];
            int leftMaxProfit = 0;
            int rigthMaxProfit = 0;
            int leftMinBuy = prices[0];
            int rigthMaxSell = prices[length-1];

            for (int i = 0, j = length - 1; i < length; i++, j--)
            {
                if(leftMinBuy > prices[i])
                {
                    leftMinBuy = prices[i];
                    left[i] = leftMaxProfit;
                }
                else
                {
                    if (leftMaxProfit < prices[i] - leftMinBuy)
                    {
                        leftMaxProfit = prices[i] - leftMinBuy;
                        left[i] = leftMaxProfit;
                    }
                    else
                    {
                        left[i] = leftMaxProfit;
                    }
                }


                if (rigthMaxSell < prices[j])
                {
                    rigthMaxSell = prices[j];
                    right[j] = rigthMaxProfit;
                }
                else
                {
                    if (rigthMaxProfit < rigthMaxSell - prices[j])
                    {
                        rigthMaxProfit = rigthMaxSell - prices[j];
                        right[j] = rigthMaxProfit;
                    }
                    else
                    {
                        right[j] = rigthMaxProfit;
                    }
                }
            }

            int max = int.MinValue;

            for (int i = 0; i < length; i++)
            {
                max = Math.Max(max, left[i] + right[i]);
            }

            return max;
        }
    }
}
