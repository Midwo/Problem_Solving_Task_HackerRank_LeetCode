using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_521
    {
        ////(521.) Longest Uncommon Subsequence I (EASY)
        public int FindLUSlength(string a, string b)
        {
            if (b.Length > a.Length) { return b.Length; }
            else if (a.Length > b.Length) { return a.Length; }
            bool theSame = true;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] != b[i])
                {
                    theSame = false;
                    break;
                }
            }
            if (theSame)
            {
                return -1;
            }
            else
            {
                return a.Length;
            }
        }
    }
}
