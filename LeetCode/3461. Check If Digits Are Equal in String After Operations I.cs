using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3461
    {
        ////(3461.) Check If Digits Are Equal in String After Operations I (EASY)
        public bool HasSameDigits(string s)
        {
            string newString = string.Empty;
            while (s.Length > 2)
            {
                newString = string.Empty;

                for (int j = 1; j < s.Length; j++)
                {
                    newString += (char)((((s[j] - '0') + (s[j - 1] - '0')) % 10) + '0');
                }
                s = newString;
            }

            if (s[0] == s[1])
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
