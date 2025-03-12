using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_5
    {
        ////(5.) Longest Palindromic Substring (MEDIUM)
        public string LongestPalindrome(string s)
        {
            int slength = s.Length;
            if (slength < 2)
            {
                if (slength < 1)
                {
                    return "";
                }
                else
                {
                    return s[0].ToString();
                }
            }

            int maxLongestPalindrome = 0;
            int currMaxLongestPalindrome = 0;
            int currStartPalindromeIndex = 0;
            int startPalindromeIndex = 0;
            int backToCurrLength = 0;

            bool palindromeStart = false; 
            StringBuilder stringBuilder = new StringBuilder();

            int currlength = slength-1;
            for (int i = 0; i < slength; i++) 
            {
                palindromeStart = false;
                int tempI = i;
                currMaxLongestPalindrome = 0;
                // Console.WriteLine(s[i]);
                currlength = slength-1;
                while (tempI <= currlength)
                {
                    if (s[tempI] == s[currlength])
                    {
                        if (!palindromeStart)
                        {
                            backToCurrLength = currlength;
                            palindromeStart = true;
                            currStartPalindromeIndex = tempI;
                        }
                        if (tempI == currlength)
                        {
                            currMaxLongestPalindrome++;
                        }
                        else 
                        {
                            currMaxLongestPalindrome += 2;
                        };
                        tempI++;
                    }
                    else
                    {
                        currMaxLongestPalindrome = 0;
                        if (palindromeStart)
                        {
                            currlength = backToCurrLength;
                        }
                        palindromeStart = false;
                        tempI = i;
                    }
                    currlength--;
                }
                if (maxLongestPalindrome < currMaxLongestPalindrome)
                {
                    maxLongestPalindrome = currMaxLongestPalindrome;
                    startPalindromeIndex = currStartPalindromeIndex;
                }  
            }

            return s[startPalindromeIndex..(startPalindromeIndex+maxLongestPalindrome)];
        }
    }
}
