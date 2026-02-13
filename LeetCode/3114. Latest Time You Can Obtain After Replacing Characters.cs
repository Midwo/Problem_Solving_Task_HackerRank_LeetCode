using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3114
    {
        ////(3114.) Latest Time You Can Obtain After Replacing Characters (EASY)
        public string FindLatestTime(string s)
        {
            char[] sToChars = s.ToCharArray();

            if (sToChars[0] == '?')
            {
                if (sToChars[1] > '1' && sToChars[1] <= '9')
                {
                    sToChars[0] = '0';
                }
                else
                {
                    sToChars[0] = '1';
                }
            } 
            if (sToChars[1] == '?')
            {
                if (sToChars[0] == '0')
                {
                    sToChars[1] = '9';
                }
                else
                {
                    sToChars[1] = '1';
                }
            }
            if (sToChars[3] == '?')
            {
                sToChars[3] = '5';
            }
            if (sToChars[4] == '?')
            {
                sToChars[4] = '9';
            }

            return new string(sToChars);
        }
    }
}
