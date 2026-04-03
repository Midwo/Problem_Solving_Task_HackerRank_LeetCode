using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.HackerRank
{
    internal class HackerRank_0004
    {
        public int divisibleSumPairs(int n, int k, List<int> ar)
        {
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    int sum = ar[i] + ar[j];
                    if (sum % k == 0)
                    {
                        count++;
                    }
                }
            }
            return count;
        }

    }
}
