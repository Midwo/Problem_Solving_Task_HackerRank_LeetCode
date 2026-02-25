using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1646
    {
        ////(1646.) Get Maximum in Generated Array (EASY)
        public int GetMaximumGenerated(int n)
        {
            int[] tableN = new int[n+2];
            tableN[0] = 0;
            tableN[1] = 1;
            
            int max = 0;

            if(n == 1)
            {
                max = 1;
            }

            for (int i = 1; i < n; i++)
            {
                int temp = 2 * i;
                if (2 <= temp && temp <= n)
                {
                    tableN[temp] = tableN[i];
                    max = Math.Max(tableN[temp], max);
                }
                if (2 <= temp+1 && temp+1 <= n)
                {
                    tableN[temp+1] = tableN[i] + tableN[i+1];
                    max = Math.Max(tableN[temp+1], max);
                }
            }

            return max;
        }
    }
}
