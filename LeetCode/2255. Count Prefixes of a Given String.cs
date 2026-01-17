using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2255
    {
        ////(2255.) Count Prefixes of a Given String (EASY)
        public int CountPrefixes(string[] words, string s)
        {
            int countPrefixes = 0;
            int length = s.Length;
            int firstChar = s[0];

            for (int indexWords = 0; indexWords < words.Length; indexWords++)
            {
                string currWord = words[indexWords];
                if (firstChar == currWord[0] && currWord.Length <= length)
                {
                    bool statusCorrect = true;
                    for (int i = 0; i < currWord.Length; i++)
                    {
                        if (currWord[i] != s[i])
                        {
                            statusCorrect = false;
                            break;
                        }
                    }
                    if (statusCorrect)
                    {
                        countPrefixes++;
                    }
                }
            }

            return countPrefixes;
        }
    }
}
