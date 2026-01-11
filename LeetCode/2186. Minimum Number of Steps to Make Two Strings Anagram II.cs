using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2186
    {
        ////(2186.) Minimum Number of Steps to Make Two Strings Anagram II (MEDIUM)
        public int MinSteps(string s, string t)
        {
            int[] diffCountChars = new int[26];

            for (int indexS = 0; indexS < s.Length; indexS++)
            {
                diffCountChars[s[indexS] - 'a']++;
            }

            for (int indexT = 0; indexT < t.Length; indexT++) 
            {
                diffCountChars[t[indexT] - 'a']--;
            }

            int howMuchToDelete = 0;

            for (int indexAlphabet = 0; indexAlphabet < 26; indexAlphabet++) 
            {
                howMuchToDelete += Math.Abs(diffCountChars[indexAlphabet]);
            }

            return howMuchToDelete;
        }
    }
}
