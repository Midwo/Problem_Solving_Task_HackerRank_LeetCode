using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1071
    {
        ////(1071.) Greatest Common Divisor of Strings (EASY)

        public string GcdOfStrings(string str1, string str2)
        {
            if (str1 + str2 != str2 + str1)
            {
                return "";
            }

            int lengthStr1 = str1.Length;
            int lengthStr2 = str2.Length;
            int minLength = Math.Min(lengthStr1, lengthStr2);

            while (minLength > 0)
            {
                if (lengthStr1 % minLength == 0 && lengthStr2 % minLength == 0)
                {
                    return str1.Substring(0, minLength);
                }
                minLength--;
            }

            return "";
        }
    }
}
