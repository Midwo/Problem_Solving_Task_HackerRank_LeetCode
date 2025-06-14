using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_221
    {
        ////(221.) Maximal Square (MEDIUM)
        public int MaximalSquare(char[][] matrix)
        {
            int max = 0;
            int high = matrix.Length;
            int length = matrix[0].Length;

            int[] dp = new int[length];
            int[] lastDP = new int[length];

            for (int i = 0; i <high; i++)
            {
                for (int j = 0; j<length; j++)
                {
                    if(i == 0)
                    {
                        dp[j] = matrix[i][j] - '0';
                        if (matrix[i][j] == '1')
                        {
                            max = 1;
                        }
                    }
                    else if(j == 0)
                    {
                        if (matrix[i][0] == '0')
                        {
                            dp[0] = 0;
                        }
                        else
                        {
                            dp[0] = 1;
                            if(max == 0)
                            {
                                max = 1;
                            }
                        }
                    }
                    else
                    {
                        if (matrix[i][j] == '1' && matrix[i][j-1] == '1' && matrix[i-1][j - 1] == '1' && dp[j-1] >= 1 && dp[j] >= 1)
                        {
                            if (dp[j-1] == lastDP[j-1] && dp[j-1] == dp[j])
                            {
                                dp[j]++;
                            }
                            else if (dp[j] < dp[j - 1])
                            {
                                dp[j]++;
                            }
                            else if (dp[j] > dp[j - 1])
                            {
                                dp[j] = dp[j - 1] + 1;
                            }
                            else if (dp[j] < lastDP[j - 1])
                            {
                                dp[j]++;
                            }
                            if (dp[j] > max)
                            {
                                max = dp[j];
                            }
                            //if (dp[j - 1] == dp[j])
                            //{
                            //    dp[j] = dp[j] + 1;
                            //}
                            //else
                            //{
                            //    dp[j] = 1;
                            //}
                        }
                        else if (matrix[i][j] == '1')
                        {
                            dp[j] = 1;
                            if (max == 0)
                            {
                                max = 1;
                            }
                        }
                        else
                        {
                            dp[j] = 0;
                        }
                    }
                }
                lastDP = dp.ToArray();
            }

            if (max == 1)
            {
                return 1;
            }
            else
            {
                return max * max;
            }
        }
    }
}
