using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_819
    {
        ////(819.) Most Common Word (EASY)
        public string MostCommonWord(string paragraph, string[] banned)
        {
            Dictionary<string, int> countWords = new Dictionary<string, int>();

            ////!?',;.
            string word = string.Empty;
            for (int i = 0; i < paragraph.Length; i++)
            {
                char currChar = paragraph[i];
                if (currChar > 96 && currChar < 123 || currChar == 96 || currChar > 64 && currChar < 91)
                {
                    if (currChar < 91)
                    {
                        currChar += (char)(32);
                    }
                    word += currChar;
                }
                else
                {
                    //Console.WriteLine(word);
                    if (word.Length != 0)
                    {
                        if (!banned.Contains(word))
                        {
                            if (countWords.ContainsKey(word))
                            {
                                countWords[word]++;
                            }
                            else
                            {
                                countWords.Add(word, 1);
                            }
                        }
                        word = string.Empty;
                    }
                }
            }
            int maxCount = 0;
            foreach (var item in countWords) 
            {
                if (item.Value > maxCount)
                {
                    maxCount = item.Value;
                    word = item.Key;
                }
            }

            return word;
        }
    }
}
