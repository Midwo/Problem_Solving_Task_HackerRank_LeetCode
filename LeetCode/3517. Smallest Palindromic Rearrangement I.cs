using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3517
    {
        ////(3517.) Smallest Palindromic Rearrangement I (MEDIUM)
        public string SmallestPalindrome(string s)
        {
            int[] countChars = new int[26];
            StringBuilder stringBuilder = new StringBuilder();

            for (int i = 0; i < s.Length; i++) 
            {
                countChars[s[i] - 'a']++;
            }

            bool remember = false;
            char charRemember = ' ';

            for (int i = 0; i < 26; i++)
            {
                int count = countChars[i];
                int howManyAdd = count / 2;
                if (count > 0 && count % 2 == 1)
                {
                    remember = true;
                    charRemember = (char)('a' + i);
                    if (count > 2)
                    {
                        stringBuilder.Append((char)('a'+i), howManyAdd);
                    }
                }
                else
                {
                    stringBuilder.Append((char)('a' + i), howManyAdd);
                }
            }
            if (remember)
            {
                char[] tempReverseChars = stringBuilder.ToString().Reverse().ToArray();
                stringBuilder.Append(charRemember);
                stringBuilder.Append(tempReverseChars);  
            }
            else
            {
                stringBuilder.Append(stringBuilder.ToString().Reverse().ToArray());
            }

            return stringBuilder.ToString();
        }
    }
}
