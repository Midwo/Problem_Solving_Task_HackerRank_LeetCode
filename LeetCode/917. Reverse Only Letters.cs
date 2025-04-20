using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_917
    {
        ////(917.) Reverse Only Letters (EASY)
        public string ReverseOnlyLetters(string s)
        {
            char[] charS = s.ToCharArray();

            int lenght = s.Length;

            for (int i = 0; i < lenght; i++)
            {
                char currChar = s[i];
                if (currChar > 64 && currChar < 91 || currChar > 96 && currChar < 123)
                {
                    for (int j = lenght - 1; j >= i; j--)
                    {
                        char currNewChar = s[j];
                        if (currNewChar > 64 && currNewChar < 91 || currNewChar > 96 && currNewChar < 123)
                        {
                            charS[i] = currNewChar;
                            charS[j] = currChar;
                            lenght = j;
                            break;
                        }

                    }

                }
            }
            return new string (charS);
        }
    }
}
