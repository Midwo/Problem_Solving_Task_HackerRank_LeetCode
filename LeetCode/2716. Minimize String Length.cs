using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2716
    {
        ////(2716.) Minimize String Length (EASY)
        public int MinimizedStringLength(string s)
        {
            ////6ms, Betas: 81.13%

            HashSet<char> countUniqueChars = new HashSet<char>();

            for (int i = 0; i < s.Length; i++)
            {
                countUniqueChars.Add(s[i]);
            }

            return countUniqueChars.Count;
        }
    }
}
