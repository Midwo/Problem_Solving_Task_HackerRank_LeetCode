using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_392
    {
        ////(392.) Is Subsequence (EASY)
        public bool IsSubsequence(string s, string t)
        {
            int indexStringT = 0;
            char currChar = '1';
            bool result = false;
            for (int i = 0; i < s.Length; i++)
            {
                result = false;
                currChar = s[i];
                for (int j = indexStringT; j < t.Length; j++)
                {
                    if (currChar == t[j])
                    {
                        indexStringT++;
                        result = true;
                        break;
                    }
                    indexStringT++;
                }
                if (result == false)
                {
                    return false;
                }
            }
            if (s.Length == 0)
            {
                return true;
            }
            return result;
        }
    }
}
