using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3227
    {
        ////(3227.) Vowels Game in a String (MEDIUM)
        public bool DoesAliceWin(string s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == 'a' || s[i] == 'e' || s[i] == 'i' || s[i] == 'o' || s[i] == 'u')
                {
                    return true;
                }
            }
            return false;
        }
    }
}
