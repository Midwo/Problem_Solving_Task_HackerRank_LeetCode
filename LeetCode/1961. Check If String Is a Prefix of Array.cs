using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1961
    {
        ////(1961.) Check If String Is a Prefix of Array (EASY)
        public bool IsPrefixString(string s, string[] words)
        {
            string currString = string.Empty;
            int lenghtS = s.Length;

            for (int i = 0; i < words.Length; i++)
            {
                if (currString.Length < lenghtS)
                {
                    currString += words[i];
                }
                else if (currString.Length == lenghtS)
                {
                    if(currString == s)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else 
                {
                    return false;
                }
            }

            if(currString.Length == lenghtS && currString == s)
            {
                return true;
            }
            return false;
        }
    }
}
