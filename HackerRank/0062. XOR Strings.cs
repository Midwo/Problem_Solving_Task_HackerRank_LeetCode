using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.HackerRank
{
    internal class HackerRank_0062
    {
        ////62. XOR Strings (EASY)
        public string strings_xor(string s, string t)
        {

            string res = "";
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == t[i])
                    res += '0';
                else
                    res += '1';
            }

            return res;
        }
    }
}
