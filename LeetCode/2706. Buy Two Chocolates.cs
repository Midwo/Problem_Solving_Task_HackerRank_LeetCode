using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2706
    {
        ////(2706.) Buy Two Chocolates (EASY)
        public int BuyChoco(int[] prices, int money)
        {
            int firstMinValue = prices[0];
            int secondMinValue = int.MaxValue;

            for (int i = 1; i < prices.Length; i++)
            {
                if (prices[i] < firstMinValue)
                {
                    secondMinValue = firstMinValue;
                    firstMinValue = prices[i];
                }
                else if (prices[i] < secondMinValue)
                {
                    secondMinValue = prices[i];
                }
            }

            if (firstMinValue+secondMinValue > money)
            {
                return money;
            }
            return money - firstMinValue - secondMinValue;
        }
    }
}
