using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1160
    {
        ////(1160.) Find Words That Can Be Formed by Characters (EASY)
        public int CountCharacters(string[] words, string chars)
        {
            Dictionary<char, int> dictionaryChars = new Dictionary<char, int>();
            int result = 0;
            bool allCharsOk = true;

            foreach (char currChar in chars)
            {
                if (dictionaryChars.ContainsKey(currChar))
                {
                    dictionaryChars[currChar]++;
                }
                else
                {
                    dictionaryChars.Add(currChar, 1);
                }
            }

            for (int i = 0; i < words.Length; i++)
            {
                Dictionary<char, int> currDictionaryChars = new Dictionary<char, int>(dictionaryChars);
                allCharsOk = true;

                for (int j = 0; j < words[i].Length; j++)
                {
                    if (currDictionaryChars.ContainsKey(words[i][j]))
                    {
                        if (currDictionaryChars[words[i][j]]>1)
                        {
                            currDictionaryChars[words[i][j]]--;
                        }
                        else
                        {
                            currDictionaryChars.Remove(words[i][j]);
                        }
                    }
                    else
                    {
                        allCharsOk = false;
                        break;
                    }
                }

                if (allCharsOk)
                {
                    Console.WriteLine(words[i]);
                    result += words[i].Length;
                }
            }  

            return result;
        }
    }
}
