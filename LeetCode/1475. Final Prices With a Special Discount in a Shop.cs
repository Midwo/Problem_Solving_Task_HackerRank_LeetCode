using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1475
    {
        ////(1475.) Final Prices With a Special Discount in a Shop (EASY)
        public int[] FinalPrices(int[] prices)
        {
            //// 1ms, Beats: 97.54%

            int length = prices.Length;

            for (int i = 0; i < length; i++) 
            { 
                int tempValue = prices[i];
                int lessValue = 0;
                for (int j = i+1; j < length; j++)
                {
                    if (tempValue >= prices[j])
                    {
                        lessValue = prices[j];
                        break;
                    }
                }
                prices[i] = tempValue - lessValue;
            }

            return prices;
        }
    }
}
