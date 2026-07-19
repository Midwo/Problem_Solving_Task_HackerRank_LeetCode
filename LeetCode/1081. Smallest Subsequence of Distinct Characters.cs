using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1081
    {
        ////(1081.) Smallest Subsequence of Distinct Characters (MEDIUM)
        public string SmallestSubsequence(string s)
        {
            int[] vis = new int[26];
            int[] num = new int[26];

            foreach (char ch in s)
            {
                num[ch - 'a']++;
            }
            var sb = new StringBuilder();

            foreach (char ch in s)
            {
                if (vis[ch - 'a'] == 0)
                {
                    while (sb.Length > 0 && sb[sb.Length - 1] > ch)
                    {
                        if (num[sb[sb.Length - 1] - 'a'] > 0)
                        {
                            vis[sb[sb.Length - 1] - 'a'] = 0;
                            sb.Length--;
                        }
                        else
                        {
                            break;
                        }
                    }
                    vis[ch - 'a'] = 1;
                    sb.Append(ch);
                }
                num[ch - 'a']--;
            }

            return sb.ToString();
        }
    }
}

