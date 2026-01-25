using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1456
    {
        ////(1456.) Maximum Number of Vowels in a Substring of Given Length (MEDIUM)
        public int MaxVowels(string s, int k)
        {
            int maxVowelsInSubstring = 0;

            int length = s.Length;
            int left = 0;
            int right = k - 1;
            char currChar = ' ';

            while(left <= right)
            {
                currChar = s[left++];
                if (IsVowel(currChar))  maxVowelsInSubstring++;
            }

            int currVowelsInSubstring = maxVowelsInSubstring;
            
            left = 0;
            right++;

            while(right < length)
            {
                currChar = s[right++];
                if (IsVowel(currChar)) currVowelsInSubstring++;
                currChar = s[left++];
                if (IsVowel(currChar)) currVowelsInSubstring--;
                maxVowelsInSubstring = maxVowelsInSubstring < currVowelsInSubstring ? currVowelsInSubstring : maxVowelsInSubstring;
            }


            return maxVowelsInSubstring;
        }
        private bool IsVowel(char currChar)
        {
            return currChar == 'a' || currChar == 'e' || currChar == 'i' || currChar == 'o' || currChar == 'u';
        }
    }
}
