using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3545
    {
        ////(3545.) Minimum Deletions for At Most K Distinct Characters (EASY)
        public int MinDeletion(string s, int k)
        {
            int[] countChars = new int[26];

            foreach (char item in s)
            {
                countChars[item - 'a']++;
            }

            Array.Sort(countChars);
            int minDelete = 0;

            for (int i = 25-k; i >= 0; i--)
            {
                if (countChars[i] == 0)
                {
                    break;
                }
                else
                {
                    minDelete += countChars[i];
                }
            } 

            return minDelete;
        }
    }
}
