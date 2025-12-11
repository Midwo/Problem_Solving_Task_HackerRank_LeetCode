using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3438
    {
        ////(3438.) Find Valid Pair of Adjacent Digits in String (EASY)
        public string FindValidPair(string s)
        {
            Dictionary<char,int> sDictionaryCharCount = new Dictionary<char,int>();

            foreach (char item in s) 
            {
                if (!sDictionaryCharCount.TryAdd(item, 1))
                {
                    sDictionaryCharCount[item]++;
                }
            }

            for(int i = 1; i < s.Length; i++)
            {
                //Console.WriteLine(sDictionaryCharCount[s[i - 1]] + sDictionaryCharCount[s[i]]);
                //Console.WriteLine((s[i] - '0') + (s[i - 1] - '0'));
                if (s[i] != s[i - 1] & sDictionaryCharCount[s[i - 1]] == (s[i] - '0') & sDictionaryCharCount[s[i]] == (s[i - 1] - '0'))
                {
                    return string.Concat(s[i - 1], s[i]);
                }
            }

            return "";
        }
    }
}
