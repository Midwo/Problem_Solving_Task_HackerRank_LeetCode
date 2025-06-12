using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_72
    {
        ////(72.) Edit Distance (MEDIUM)
        public int MinDistance(string word1, string word2)
        {
            int lengthWord1 = word1.Length;
            int lengthWord2 = word2.Length;

            int[][] dp = new int[lengthWord2 + 1][];

            for (int i = 0; i <= lengthWord2; i++)
            {
                dp[i] = new int[lengthWord1 + 1];
                dp[i][0] = i;
            }

            for (int i = 1; i <= lengthWord1; i++)
            {
                dp[0][i] = i;
            }

            for (int i = 1; i <= lengthWord2; i++)
            {
                for (int j = 1; j <= lengthWord1; j++)
                {
                    if (word2[i-1] == word1[j - 1])
                    {
                        dp[i][j] = dp[i - 1][j - 1];
                    }
                    else
                    {
                        dp[i][j] = Math.Min(dp[i - 1][j - 1], Math.Min(dp[i][j - 1], dp[i - 1][j]))+1;
                    }
                }
            }


            return dp[lengthWord2][lengthWord1];
        }
    }
}
