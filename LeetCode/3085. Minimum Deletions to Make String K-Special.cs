using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3085
    {
        ////(3085). Minimum Deletions to Make String K-Special (MEDIUM)
        public int MinimumDeletions(string word, int k)
        {
            int minDelete = int.MaxValue;
            int[] listFreq = new int[26];

            for (int i = 0; i < word.Length; i++)
            {
                listFreq[word[i] - 'a']++;
            }

            Array.Sort(listFreq);
            int sumLeft = 0;
            int sumRight = 0;
            int prev = int.MaxValue;
            int[] dp = new int[listFreq.Length];

            for (int i = 0; i < listFreq.Length; i++) 
            {
                if(prev == listFreq[i])
                {
                    dp[i] = dp[i - 1];
                    sumLeft += prev;
                }
                else
                {
                    sumRight = 0;
                    for (int j = i+1; j < listFreq.Length; j++)
                    {
                        if (listFreq[j] - listFreq[i] > k)
                        {
                            sumRight += listFreq[j] - (listFreq[i]+k);
                        }
                    }
                    prev = listFreq[i];
                    minDelete = Math.Min(minDelete, sumLeft+sumRight);
                    sumLeft += prev;
                    dp[i] = minDelete;
                }                     
            }

            return minDelete;
        }
    }
}
