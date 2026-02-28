using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2697
    {
        ////(2697.) Lexicographically Smallest Palindrome (EASY)
        public string MakeSmallestPalindrome(string s)
        {
            char[] sToTable = s.ToCharArray();
            int length = s.Length;

            for (int i = 0; i < s.Length/2; i++) 
            {
                if (s[i] < s[length - 1 - i])
                {
                    sToTable[length-1-i] = s[i];
                }
                else
                {
                    sToTable[i] = s[length-1-i];
                }
            }

            return new string(sToTable);
        }
    }
}
