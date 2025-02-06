using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_345
    {
        ////(345.) Reverse Vowels of a String (EASY)
        public string ReverseVowels(string s)
        {
            List<char> listVowels = new List<char>() { 'a', 'A', 'E', 'e', 'I', 'i', 'O', 'o', 'U', 'u' };

            int howLongS = s.Length;

            char[] charsStringS = s.ToCharArray();

            for (int i = 0; i < howLongS; i++) 
            {
                if (listVowels.Contains(charsStringS[i]))
                {
                    for (int j = howLongS-1; j > i; j--)
                    {
                        howLongS--;
                        if (listVowels.Contains(charsStringS[j]))
                        {
                            char tempChar = charsStringS[i];
                            charsStringS[i] = charsStringS[j];
                            charsStringS[j] = tempChar;
                            break;
                        }
                    }
                }
            }

            return string.Join("", charsStringS);
        }
    }
}
