using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3760
    {
        ////(3760.) Maximum Substrings With Distinct Start (MEDIUM)
        public int MaxDistinct(string s)
        {
            var statusChar = new bool[26];

            foreach (char currChar in s) 
            {
                statusChar[currChar - 'a'] = true;
            }

            int maxDistinct = 0;
            foreach (var status in statusChar)
            {
                if (status == true)
                    maxDistinct++;
            }

            return maxDistinct;
        }
    }
}
