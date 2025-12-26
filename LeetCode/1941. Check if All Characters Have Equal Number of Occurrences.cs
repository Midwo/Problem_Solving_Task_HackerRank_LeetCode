using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1941
    {
        ////(1941.) Check if All Characters Have Equal Number of Occurrences (EASY)
        public bool AreOccurrencesEqual(string s)
        {
            int[] countChar = new int[26];

            for (int i = 0; i < s.Length; i++) 
            {
                countChar[s[i] - 'a']++;
            }

            int firstCharCount = countChar[s[0]-'a'];

            for (int i = 0; i < 26; i++)
            {
                if (countChar[i] > 0 && countChar[i] != firstCharCount)
                {
                    return false;
                }
            }

            return true;



            //Dictionary<char, int> dictionaryCharsCount = new Dictionary<char, int>();

            //for (int i = 0; i < s.Length; i++)
            //{
            //    if (dictionaryCharsCount.ContainsKey(s[i]))
            //    {
            //        dictionaryCharsCount[s[i]]++;
            //    }
            //    else
            //    {
            //        dictionaryCharsCount.Add(s[i], 1);
            //    }
            //}

            //int countFirstChar = dictionaryCharsCount[s[0]];

            //foreach (int count in dictionaryCharsCount.Values)
            //{
            //    if (count != countFirstChar)
            //    {
            //        return false;
            //    }
            //}

            //return true;
        }
    }
}
