using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2351
    {
        ////(2351.) First Letter to Appear Twice (EASY)
        public char RepeatedCharacter(string s)
        {
            ////0ms, Beats: 100.00%
            
            HashSet<char> distinctChars = new HashSet<char>();

            for (int i = 0; i < s.Length; i++) 
            {
                if (!distinctChars.Add(s[i]))
                {
                    return s[i];
                }
            }
            return ' ';
        }
    }
}
