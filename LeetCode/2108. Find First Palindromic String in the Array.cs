using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2108
    {
        ////(2108.) Find First Palindromic String in the Array (EASY)
        public string FirstPalindrome(string[] words)
        {
            for (int i = 0; i < words.Length; i++) 
            {
                int index = 0;
                bool notAPalindrome = false;
                for (int j = words[i].Length - 1; j >= 0; j--)
                {
                    if (words[i][index] != words[i][j])
                    {
                        notAPalindrome = true;
                        break;
                    }
                    index++;
                }
                if (!notAPalindrome)
                {
                    return words[i];
                }
            }

            return "";
        }
    }
}
