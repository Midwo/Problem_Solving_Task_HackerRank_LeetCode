using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2785
    {
        ////(2785.) Sort Vowels in a String (MEDIUM)
        public string SortVowels(string s)
        {
            char[] vowels = new char[s.Length];
            int[] numberAsciVowels = new int[s.Length];
            char[] resultChars = new char[s.Length];
            int indexVowels = 0;
            int length = s.Length;

            for (int i = 0; i < length; i++)
            {
                char currChar = s[i];
                if (currChar == 'a' || currChar == 'A' || currChar == 'e' || currChar == 'E' || currChar == 'i' || currChar == 'I' 
                    || currChar == 'o' || currChar == 'O' || currChar == 'u' || currChar == 'U')
                {
                    vowels[indexVowels] = currChar;
                    numberAsciVowels[indexVowels] = currChar;
                    indexVowels++;
                }
                else
                {
                    resultChars[i] = currChar;
                }
            }

            Array.Sort(numberAsciVowels, vowels);

            indexVowels = length-indexVowels;
            for (int i = 0; i < s.Length; i++)
            {
                if (resultChars[i] == 0)
                {
                    resultChars[i] = vowels[indexVowels];
                    indexVowels++;
                }
            }

            return new string(resultChars);
        }
    }
}
