using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2109
    {
        ////(2109.) Adding Spaces to a String (MEDIUM)
        public string AddSpaces(string s, int[] spaces)
        {
            StringBuilder sb = new StringBuilder();
            int ending = 0;

            foreach (int i in spaces) 
            {
                sb.Append(s[ending..i]);
                sb.Append(' ');
                ending = i;
            }
            sb.Append(s[ending..s.Length]);

            return sb.ToString();
        }
    }
}
