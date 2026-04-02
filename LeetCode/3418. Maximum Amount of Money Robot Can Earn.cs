using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3418
    {
        ////(3418.) Maximum Amount of Money Robot Can Earn (MEDIUM)
        public int MaximumAmount(int[][] coins)
        {
            int rows = coins.Length;
            int cols = coins[0].Length;

            int[][][] dp = new int[rows][][];
            for (int i = 0; i < rows; i++)
            {
                dp[i] = new int[cols][];
                for (int j = 0; j < cols; j++) 
                { 
                    dp[i][j] = new int[3]; 
                }
            }

            for (int indexRows = 0; indexRows < rows; indexRows++)
            {
                for (int indexCols = 0; indexCols < cols; indexCols++) 
                {
                    int currValue = coins[indexRows][indexCols];

                    if(indexRows == 0)
                    {
                        if(indexCols == 0)
                        {
                            dp[indexRows][indexCols][0] = currValue;
                            if (currValue < 0)
                            {
                                dp[indexRows][indexCols][1] = 0;
                                dp[indexRows][indexCols][2] = 0;
                            }
                            else
                            {
                                dp[indexRows][indexCols][1] = currValue;
                                dp[indexRows][indexCols][2] = currValue;
                            }
                        }
                        else
                        {
                            dp[indexRows][indexCols][0] = currValue + dp[indexRows][indexCols-1][0];
                            dp[indexRows][indexCols][1] = Math.Max(currValue + dp[indexRows][indexCols - 1][1], dp[indexRows][indexCols - 1][0]);
                            dp[indexRows][indexCols][2] = Math.Max(currValue + dp[indexRows][indexCols - 1][2], dp[indexRows][indexCols - 1][1]); 
                        }
                    }
                    else
                    {
                        if (indexCols == 0)
                        {
                            dp[indexRows][indexCols][0] = currValue + dp[indexRows - 1][indexCols][0];
                            dp[indexRows][indexCols][1] = Math.Max(currValue + dp[indexRows - 1][indexCols][1], dp[indexRows - 1][indexCols][0]);
                            dp[indexRows][indexCols][2] = Math.Max(currValue + dp[indexRows - 1][indexCols][2], dp[indexRows - 1][indexCols][1]);
                        }
                        else
                        {
                            dp[indexRows][indexCols][0] = Math.Max(dp[indexRows - 1][indexCols][0] + currValue, dp[indexRows][indexCols - 1][0] + currValue);
                            dp[indexRows][indexCols][1] = Math.Max(
                                //TOP Value best
                                Math.Max(currValue + dp[indexRows - 1][indexCols][1], dp[indexRows - 1][indexCols][0]),
                                //LEFT Value best
                                Math.Max(currValue + dp[indexRows][indexCols - 1][1], dp[indexRows][indexCols - 1][0])
                                );
                            dp[indexRows][indexCols][2] = Math.Max(
                                //TOP Value best
                                Math.Max(currValue + dp[indexRows - 1][indexCols][2], dp[indexRows - 1][indexCols][1]),
                                //LEFT Value best
                                Math.Max(currValue + dp[indexRows][indexCols - 1][2], dp[indexRows][indexCols - 1][1])
                                );
                        }
                    }
                }
            }

            return  Math.Max(dp[rows - 1][cols - 1][0], Math.Max(dp[rows - 1][cols - 1][2], dp[rows - 1][cols - 1][1]));
        }
    }
}
