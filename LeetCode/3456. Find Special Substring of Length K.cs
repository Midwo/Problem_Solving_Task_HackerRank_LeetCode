using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3456
    {
        ////(3456.) Find Special Substring of Length K (EASY)
        public bool HasSpecialSubstring(string s, int k)
        {
            int length = s.Length;
            int count = 1;
            char lastChar = s[0];
            char currChar;

            if (length == 1) return k == 1;

            for (int i = 1; i < length; i++)
            {
                currChar = s[i];

                if (currChar == lastChar)
                {
                    count++;
                }
                else
                {
                    if (count == k)
                    {
                        int start = i - k;

                        if (start == 0 || s[start - 1] != lastChar)
                        {
                            return true;
                        }
                    }

                    count = 1;
                }

                if (count == k)
                {
                    int start = i - k + 1;

                    if (start == 0 || s[start - 1] != currChar)
                    {
                        if (i + 1 == length || s[i + 1] != currChar)
                            return true;
                    }
                }

                lastChar = currChar;
            }

            return false;
        }

    }

}

