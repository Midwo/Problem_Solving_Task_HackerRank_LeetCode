using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3856
    {
        ////(3856.) Trim Trailing Vowels (EASY)
        public string TrimTrailingVowels(string s)
        {
            int indexStop = s.Length - 1;

            for (int i = indexStop; indexStop >= 0; indexStop--)
            {
                char currChar = s[indexStop];
                if (currChar != 'a' && currChar != 'e' && currChar != 'i' && currChar != 'o' && currChar != 'u')
                    break;
            }

            return s[0..(indexStop+1)];
        }
    }
}
