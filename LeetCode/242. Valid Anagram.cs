using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_242
    {
        ////(242.) Valid Anagram (EASY)
        public bool IsAnagram(string s, string t)
        {
            int howLongStringS = s.Length;
            if (howLongStringS != t.Length)
            {
                return false;
            }
            Dictionary<char, int> dictionaryCharsForStringS = new Dictionary<char, int>();
            Dictionary<char, int> dictionaryCharsForStringT = new Dictionary<char, int>();

            for (int i = 0; i < howLongStringS; i++)
            {
                if (dictionaryCharsForStringS.ContainsKey(s[i]))
                {
                    dictionaryCharsForStringS[s[i]]++;
                }
                else
                {
                    dictionaryCharsForStringS.Add(s[i], 1);
                }
                if (dictionaryCharsForStringT.ContainsKey(t[i]))
                {
                    dictionaryCharsForStringT[t[i]]++;
                }
                else
                {
                    dictionaryCharsForStringT.Add(t[i], 1);
                }
            }      
            return dictionaryCharsForStringS.All(s => dictionaryCharsForStringT.ContainsKey(s.Key) && dictionaryCharsForStringT[s.Key] == s.Value);
        }
    }
}
