using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3179
    {
        ////(3179.) Find the N-th Value After K Seconds (MEDIUM)
        public int ValueAfterKSeconds(int n, int k)
        {
            if (n == 1)
            {
                return 1;
            }
            else if (n == 2) 
            {
                return k + 1;            
            }

            int mod = 1000000007;
            int[] tableValues = new int[n];
            Array.Fill(tableValues, 1);

            for (int i = 0; i < k; i++)
            {
                for (int j = 1; j < n; j++)
                {
                    tableValues[j] = (tableValues[j - 1] + tableValues[j]) % mod;
                }
            }

            return tableValues[n - 1];
        }
    }
}
