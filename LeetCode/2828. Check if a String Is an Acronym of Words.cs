using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2828
    {
        ////(2828.) Check if a String Is an Acronym of Words (EASY)
        public bool IsAcronym(IList<string> words, string s)
        {
            bool result = true;
            int lengthS = s.Length;

            if(lengthS != words.Count)
            {
                return false;
            }

            for (int i = 0; i < lengthS; i++)
            {
                if (s[i] != words[i][0])
                {
                    return false;
                }
            }

            return result;
        }
    }
}
