using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_824
    {
        ////(824.) Goat Latin (EASY)
        public string ToGoatLatin(string sentence)
        {
            string result = string.Empty;
            int length = sentence.Length;

            int stop = 0;
            bool wordBegin = true;
            int howManyAddCharA = 1;
            string currWord = string.Empty;
            bool isVowel = false;
            while (stop < length)
            {
                char currChar = sentence[stop];
                if (sentence[stop] == ' ')
                {
                    if (isVowel)
                    {
                        result += currWord + "ma";

                        for (int i = 0; i < howManyAddCharA; i++)
                        {
                            result += 'a';
                        }
                    }
                    else
                    {
                        result += currWord[1..currWord.Length].ToString() + currWord[0] + "ma";

                        for (int i = 0; i < howManyAddCharA; i++)
                        {
                            result += 'a';
                        }
                    }
                    currWord = string.Empty;
                    howManyAddCharA++;
                    wordBegin = true;
                    result += ' ';
                }
                else if (wordBegin)
                {
                    if (currChar == 'a' || currChar == 'e' || currChar == 'i' || currChar == 'o' || currChar == 'u' || 
                        currChar == 'A' || currChar == 'E' || currChar == 'I' || currChar == 'O' || currChar == 'U')
                    {
                        isVowel = true;
                    }
                    else
                    {
                        isVowel = false;
                    }
                    currWord += currChar;
                    wordBegin = false;
                }
                else
                {
                    currWord += currChar;
                }
                stop++;
            }
            if (isVowel)
            {
                result += currWord + "ma";

                for (int i = 0; i < howManyAddCharA; i++)
                {
                    result += 'a';
                }
            }
            else
            {
                result += currWord[1..currWord.Length].ToString() + currWord[0] + "ma";

                for (int i = 0; i < howManyAddCharA; i++)
                {
                    result += 'a';
                }
            }
            return result;
        }
    }
}
