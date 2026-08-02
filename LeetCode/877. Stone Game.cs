using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_877
    {
        ////(877.) Stone Game (MEDIUM)
        public bool StoneGame(int[] piles)
        {
            int n = piles.Length;
            int[,] dp = new int[n, n];

            for (int i = 0; i < n; i++)
                dp[i, i] = piles[i];

            for (int length = 2; length <= n; length++)
            {
                for (int L = 0; L + length - 1 < n; L++)
                {
                    int R = L + length - 1;

                    int takeLeft = piles[L] - dp[L + 1, R];
                    int takeRight = piles[R] - dp[L, R - 1];

                    dp[L, R] = Math.Max(takeLeft, takeRight);
                }
            }

            return dp[0, n - 1] >= 0;
        }
    }
}
