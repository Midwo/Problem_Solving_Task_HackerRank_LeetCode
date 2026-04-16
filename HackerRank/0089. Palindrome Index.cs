using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.HackerRank
{
    internal class HackerRank_0089
    {
        ////89. Palindrome Index (EASY) 
        public int palindromeIndex(string s)
        {
            int left = 0;
            int right = s.Length - 1;

            while (left < right)
            {
                if (s[left] != s[right])
                {
                    if (IsPalindrome(s, left + 1, right))
                        return left;

                    if (IsPalindrome(s, left, right - 1))
                        return right;

                    return -1;
                }

                left++;
                right--;
            }

            return -1;
        }

        private bool IsPalindrome(string s, int left, int right)
        {
            while (left < right)
            {
                if (s[left] != s[right])
                    return false;

                left++;
                right--;
            }
            return true;
        }
    }
}
