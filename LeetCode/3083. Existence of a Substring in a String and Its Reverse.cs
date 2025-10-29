using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3083
    {
        ////(3083.) Existence of a Substring in a String and Its Reverse (EASY)
        public bool IsSubstringPresent(string s)
        {
            string sReverse = new string(s.Reverse().ToArray());

            for (int i = 0; i < s.Length-1; i++)
            {
                if (sReverse.Contains(s[i..(i+2)]))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
