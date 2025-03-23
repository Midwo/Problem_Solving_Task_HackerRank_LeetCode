using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_30
    {
        ////(30.) Substring with Concatenation of All Words (HARD)
        public IList<int> FindSubstring(string s, string[] words)
        {
            int howLongWord = words[0].Length;
            int howManyWords = words.Length;
            int totalLengthCombineWords = howLongWord * howManyWords;

            int slength = s.Length;

            List<int> result = new List<int>();

            if (totalLengthCombineWords > slength)
            {
                return result;
            }

            Dictionary<string, int> dictionaryWords = new Dictionary<string, int>();

            foreach (string word in words)
            {
                dictionaryWords[word] = dictionaryWords.GetValueOrDefault(word, 0) + 1;
            }

            if (dictionaryWords.Count == 1 && slength > 100)
            {
                Dictionary<char, int> tempDictionaryS = new Dictionary<char, int>();
                foreach (char item in s)
                {
                    tempDictionaryS[item] = tempDictionaryS.GetValueOrDefault(item, 0) + 1;
                }

                if(tempDictionaryS.Count == 1)
                {
                    if (s[0] == words[0][0])
                    {
                        int tempDictionaryDiff = tempDictionaryS[s[0]] - dictionaryWords[words[0]];
                        int x = -1;
                        while (x++ < tempDictionaryDiff)
                        {
                            result.Add(x);
                        } 
                    }
                    return result;
                }
            }
            


            for (int i = 0; i <= slength - totalLengthCombineWords; i++)
            {
                Dictionary<string, int> tempDictionaryWords = new Dictionary<string, int>(dictionaryWords);

                int tempHowManyWords = howManyWords;

                int currIndexWithWords = i;

                while (currIndexWithWords < i + totalLengthCombineWords)
                {
                    string currWordFromS = s.Substring(currIndexWithWords, howLongWord);

                    if (!tempDictionaryWords.ContainsKey(currWordFromS) || tempDictionaryWords[currWordFromS] == 0)
                    {
                        break;
                    }
                    else
                    {
                        tempDictionaryWords[currWordFromS] -= 1;
                        tempHowManyWords--;
                    }
                    currIndexWithWords += howLongWord;
                    if (tempHowManyWords == 0)
                    {
                        result.Add(i);
                    }
                }
            }
            return result;
        }
    }
}
