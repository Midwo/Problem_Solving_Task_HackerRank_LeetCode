using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_434
    {
        ////(434.) Number of Segments in a String (EASY)
        public int CountSegments(string s)
        {
            int result = 0;
            int lenghtS = s.Length;
            if (lenghtS < 1)
            { 
                return 0;
            }
            char lastchar = s[0];
            if (lastchar != ' ' && lastchar != ' ')
            {
                result++;
            }
            for (int i = 1; i < lenghtS; i++)
            {
                if (lastchar == ' ' && s[i] != ' ')
                {
                    result++;
                }
                lastchar = s[i];
            }
            if (result == 0)
            {
                s = s.Trim();
                if (s.Length > 0)
                {
                    return 1;
                }
                else return 0;
            }
            return result;
        }
    }
}
