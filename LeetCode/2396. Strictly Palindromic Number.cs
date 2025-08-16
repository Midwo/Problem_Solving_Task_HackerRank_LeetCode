using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2396
    {
        ////(2396.) Strictly Palindromic Number (MEDIUM)
        public bool IsStrictlyPalindromic(int n)
        {
            bool result = true;

            for (int i = 2; i <= n-2; i++)
            {
                string temp = Convert.ToString(n, i);

                if (temp != temp.Reverse())
                {
                    result = false;
                    break;
                }

            }

            return result;
        }
    }
}
