using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1078
    {
        ////(1078.) Occurrences After Bigram (EASY)
        public string[] FindOcurrences(string text, string first, string second)
        {
            List<string> listWordInText = new List<string>();
            List<string> result = new List<string>();
            text += ' ';
            int lastWordStartIndex = 0;
            bool firstWord = false;
            bool secondWords = false;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == ' ')
                {
                    if (lastWordStartIndex == 0)
                    {
                        listWordInText.Add(text[lastWordStartIndex..i]);
                        lastWordStartIndex = i + 1;
                    }
                    else
                    {
                        listWordInText.Add(text[lastWordStartIndex..i]);
                        lastWordStartIndex = i + 1;
                    }
                }
            }

            foreach (string word in listWordInText)
            {

                if (firstWord == false)
                {
                    if (word == first)
                    {
                        firstWord = true;
                    }
                    else
                    {
                        firstWord = false;
                    }
                }
                else if (secondWords == false)
                {
                    if (word == second)
                    {
                        secondWords = true;
                    }
                    else
                    {
                        if (word != first)
                        {
                            firstWord = false;
                        }
                    }
                }
                else if (firstWord == true && secondWords == true)
                {
                    result.Add(word);
                    if (first == word)
                    {
                        firstWord = true;
                        secondWords = false;
                        if (first == second)
                        {
                            secondWords = true;
                        }
                    }
                    else
                    {
                        firstWord = false;
                        secondWords = false;
                    }
                }
            }

            return result.ToArray();
        }
    }
}
