using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1784
    {
        ////(1784.) Check if Binary String Has at Most One Segment of Ones (EASY)
        public bool CheckOnesSegment(string s)
        {
            bool zero = false;
            for (int i = 1; i < s.Length; i++)
            {
                if (s[i] == '0' && !zero) { zero = true; }
                else if (s[i] == '1' && zero) { return false; }
            }
            return true;
        }
    }
}
