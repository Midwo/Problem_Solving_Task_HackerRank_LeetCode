using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_322
    {
        ////(322.) Coin Change (MEDIUM)
        public int CoinChange(int[] coins, int amount)
        {
            int howManyCoins = coins.Length;
            int[] dp = new int[amount + 1];
            Array.Fill(dp, amount + 1);
            dp[0] = 0;

            for (int i = 1; i <= amount; i++)
            {
                foreach (int item in coins)
                {
                    if (i - item >= 0)
                    {
                        dp[i] = Math.Min(dp[i], dp[i - item] + 1);
                    }
                }
            }

            if (dp[amount] == amount + 1)
            {
                return -1;
            }
            
            return dp[amount];
        }
    }
}
