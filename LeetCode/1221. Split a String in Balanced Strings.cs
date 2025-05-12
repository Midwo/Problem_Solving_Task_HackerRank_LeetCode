using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1221
    {
        ////(1221.) Split a String in Balanced Strings (EASY)
        public int BalancedStringSplit(string s)
        {
            int result = 0;
            int balance = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == 'L')
                {
                    balance--;
                }
                else
                {
                    balance++;
                }

                if(balance == 0)
                {
                    result++;
                }
            }

            return result;
        }
    }
}
