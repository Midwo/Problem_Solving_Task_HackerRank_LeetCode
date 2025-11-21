using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1930
    {
        ////(1930.) Unique Length-3 Palindromic Subsequences (MEDIUM)
        public int CountPalindromicSubsequence(string s)
        {
            HashSet<string> possiblePalindromes = new HashSet<string>();
            HashSet<char> leftChars = new HashSet<char>();
            leftChars.Add(s[0]);
            int[] rightChars = new int[27];
            int length = s.Length;

            for (int i = 1; i < length; i++)
            {
                rightChars[s[i] - 'a']++;
            }

            for (int i = 1; i < length-1; i++)
            {
                char tempChar = s[i];
                rightChars[tempChar-'a']--;

                foreach (var item in leftChars)
                {
                    if (rightChars[item - 'a'] > 0)
                    {
                        char[] chars = { item, tempChar};
                        possiblePalindromes.Add(new string(chars));
                    }
                }

                leftChars.Add(tempChar);
            }

            return possiblePalindromes.Count;
        }
    }
}
