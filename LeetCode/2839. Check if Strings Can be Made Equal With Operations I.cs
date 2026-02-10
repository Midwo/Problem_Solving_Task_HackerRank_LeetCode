using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2839
    {
        ////(2839.) Check if Strings Can be Made Equal With Operations I (EASY)
        public bool CanBeEqual(string s1, string s2)
        {
            bool statusEqual = true;

            char[] s1Chars = s1.ToCharArray();
            char[] s2Chars = s2.ToCharArray();

            for (int i = 0; i < 4; i++)
            {
                if(s1Chars[i] != s2Chars[i])
                {
                    if(i < 2 && s2Chars[i] == s1Chars[i + 2])
                    {
                        char temp = s1Chars[i];
                        s1Chars[i] = s1Chars[i + 2];
                        s1Chars[i + 2] = temp;
                    }
                    else
                    {
                        return false;
                    }
                }
            }

            return statusEqual;
        }
    }
}
