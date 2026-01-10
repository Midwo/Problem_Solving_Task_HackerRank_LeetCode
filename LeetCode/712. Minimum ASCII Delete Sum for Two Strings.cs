using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_712
    {
        ////(712.) Minimum ASCII Delete Sum for Two Strings (MEDIUM)
        public int MinimumDeleteSum(string s1, string s2)
        {
            int row = s1.Length+1;
            int col = s2.Length+1;

            int[][] dp = new int[row][];

            for (int indexRow = 0; indexRow < row; indexRow++)
            {
                dp[indexRow] = new int[col];
                if (indexRow == 0) 
                {
                    dp[0][0] = 0;
                    for (int indexCol = 1; indexCol < col; indexCol++) 
                    {
                        dp[0][indexCol] = dp[0][indexCol - 1] + s2[indexCol - 1];
                    }
                }
                else
                {
                    dp[indexRow][0] = dp[indexRow-1][0] + s1[indexRow - 1];

                    for (int indexCol = 1; indexCol < col; indexCol++)
                    {
                        int leftValue = s2[indexCol - 1];
                        int topValue = s1[indexRow - 1];
                       
                        if (leftValue == topValue)
                        {
                            int tempValue = dp[indexRow - 1][indexCol - 1];
                            dp[indexRow][indexCol] = dp[indexRow - 1][indexCol - 1];
                        }
                        else
                        {
                            leftValue += dp[indexRow][indexCol-1];
                            topValue += dp[indexRow-1][indexCol];

                            leftValue = leftValue > topValue ? topValue : leftValue;
                            dp[indexRow][indexCol] = leftValue;
                        }

                    }
                }
            }

            return dp[row-1][col-1];
        }
    }
}
