using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_557
    {
        ////(557.) Reverse Words in a String III (EASY)
        public string ReverseWords(string s)
        {
            int start = 0;
            char[] resultChars = s.ToCharArray();
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == ' ' || i == s.Length - 1)
                {
                    if (i == s.Length - 1)
                    {
                        for (int j = start; j < start + (s.Length - start) / 2; j++)
                        {
                            char tempChar = resultChars[j];
                            resultChars[j] = resultChars[start - j + s.Length - 1];
                            resultChars[start - j + s.Length - 1] = tempChar;
                        }
                    }
                    else
                    {
                        for (int j = start; j < start + (i - start) / 2; j++)
                        {
                            char tempChar = resultChars[j];
                            resultChars[j] = resultChars[i - (j - start) - 1];
                            resultChars[i - (j - start) - 1] = tempChar;
                        }
                    }
                    start = i + 1;
                }
            }
            return new string(resultChars);
        }
    }
}
