using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2124
    {
        ////(2124.) Check if All A's Appears Before All B's (EASY)
        public bool CheckString(string s)
        {
            bool status = true;

            for (int i = 1; i < s.Length; i++)
            {
                if (s[i-1] == 'b' && s[i] == 'a')
                {
                    return false;
                }
            }

            return status;
        }
    }
}
