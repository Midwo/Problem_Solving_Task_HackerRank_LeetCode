using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2506
    {
        ////(2506.) Count Pairs Of Similar Strings (EASY)
        public int SimilarPairs(string[] words)
        {
            int length = words.Length;
            var boolCharsWordTable = new bool[length][];
            int countSimilarPairs = 0;
            for (int i = 0; i < length; i++)
            {
                boolCharsWordTable[i] = new bool[26];

                foreach (char currChar in words[i])
                {
                    boolCharsWordTable[i][currChar - 'a'] = true;
                }
            }

            for (int index = 0; index < length - 1; index++)
            {
                for (int j = index + 1; j < length; j++)
                {
                    bool status = true;
                    for (int indexChar = 0; indexChar < 26; indexChar++)
                    {
                        if (boolCharsWordTable[index][indexChar] != boolCharsWordTable[j][indexChar])
                        {
                            status = false;
                            break;
                        }
                    }
                    if (status)
                        countSimilarPairs++;
                }
            }

            return countSimilarPairs;
        }
    }
}
