using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3110
    {
        ////(3110.) Score of a String (EASY)
        public int ScoreOfString(string s)
        {
            int result = 0;
            for (int i = 0; i < s.Length - 1; i++)
            {
                result += Math.Abs((s[i] - '0') - (s[i + 1] - '0'));
            }

            return result;
        }
    }
}
