using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_459
    {
        ////(459.) Repeated Substring Pattern (EASY)
        public bool RepeatedSubstringPattern(string s)
        {
            var str = s + s;
            return str.IndexOf(s, 1) != s.Length;
        }
    }
}
