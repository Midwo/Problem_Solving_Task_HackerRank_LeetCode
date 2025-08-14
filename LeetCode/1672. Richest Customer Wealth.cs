using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1672
    {
        ////(1672.) Richest Customer Wealth (EASY)
        public int MaximumWealth(int[][] accounts)
        {
            int maxWealth = int.MinValue;
            int currWealth = 0;

            for (int i = 0; i < accounts.Length; i++)
            {
                currWealth = 0;
                for(int j = 0; j < accounts[i].Length; j++)
                {
                    currWealth += accounts[i][j];
                }

                maxWealth = Math.Max(maxWealth, currWealth);
            }

            return maxWealth;
        }
    }
}
