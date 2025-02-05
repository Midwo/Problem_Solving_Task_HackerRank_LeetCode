using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_344
    {
        ////(344.) REverse String (EASY)
        public void ReverseString(char[] s) 
        {
            int howLong = s.Length;
            if (howLong >= 2)
            {
                if (howLong % 2 == 0)
                {
                    for (int i = 0; i < howLong/2; i++)
                    {
                        char tempChar = s[i];
                        s[i] = s[howLong - i-1];
                        s[howLong - i - 1] = tempChar;
                    }
                }
                else
                {
                    for (int i = 0; i < howLong/2; i++)
                    {
                        char tempChar = s[i];
                        s[i] = s[howLong - i-1];
                        s[howLong - i - 1] = tempChar;
                    }
                }
            }
            ////optional output
            Console.WriteLine(string.Join(",", s));
        }
    }
}
