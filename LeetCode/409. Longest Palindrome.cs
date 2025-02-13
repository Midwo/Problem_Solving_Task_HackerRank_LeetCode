using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_409
    {
        ////(409.) Longest Palindrome (EASY)
        public int LongestPalindrome(string s)
        {
            int result = 0;
            int stringSlenght = s.Length;
            if (stringSlenght < 1)
            {
                return 0;
            }
            else if (stringSlenght == 1)
            {
                return 1;
            }
            else
            {

                char[] chars = s.ToCharArray();
                Array.Sort(chars);
                bool firstCount = true;
                int currCount = 0;
                for (int i = 1; i < stringSlenght; i++)
                {
                    if (chars[i] == chars[i - 1])
                    {
                        if (firstCount)
                        {
                            result += 2;
                            firstCount = false;
                        }
                        else
                        {
                            currCount++;
                            if (currCount % 2 == 0)
                            {
                                currCount = 0;
                                result += 2;
                            }
                        }
                    }
                    else
                    {
                        firstCount = true;
                        currCount = 0;
                    }
                }
                if (result != stringSlenght)
                {
                    return result+1;
                }
                else
                {
                    return result;
                }
            }
        }
    }
}
