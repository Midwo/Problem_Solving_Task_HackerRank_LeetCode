using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1455
    {
        ////(1455.) Check If a Word Occurs As a Prefix of Any Word in a Sentence (EASY)
        public int IsPrefixOfWord(string sentence, string searchWord)
        {
            ////0ms, Beats: 100.00%
            int result = -1;
            int numberword = 1;
            bool check = true;
            int indexCheck = 0;
            int lastIndexSearchWord = searchWord.Length-1;
            for (int i = 0; i < sentence.Length; i++)
            {
                if (check)
                {
                    if (sentence[i] == searchWord[indexCheck])
                    {
                        if (indexCheck == lastIndexSearchWord)
                        {
                            return numberword;
                        }
                        indexCheck++;
                        continue;
                    }
                    else if (sentence[i] == ' ')
                    {
                        numberword++;
                        check = true;
                        indexCheck = 0;
                    }
                    else
                    {
                        check = false;
                        indexCheck = 0;
                    }
                    
                }
                else if (sentence[i] == ' ')
                {
                    indexCheck = 0;
                    check = true;
                    numberword++;
                }
            }

            return result;
        }
    }
}
