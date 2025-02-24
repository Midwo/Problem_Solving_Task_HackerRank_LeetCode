using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_500
    {
        ////(500.) Keyboard Row (EASY)
        public string[] FindWords(string[] words)
        {
            char[] rowConsitsChar1 = ['q', 'w', 'e', 'r', 't', 'y', 'u', 'i', 'o', 'p'];
            char[] rowConsitsChar2 = ['a', 's', 'd', 'f', 'g', 'h', 'j', 'k', 'l'];
            char[] rowConsitsChar3 = ['z', 'x', 'c', 'c', 'v', 'b', 'n', 'm'];
            List<string> result = new List<string>();
            for (int i = 0; i < words.Length; i++)
            {
                string tempString = words[i].ToLower();
                if (ValidationChars(tempString, rowConsitsChar1))
                {
                    result.Add(words[i]);
                }
                else if (ValidationChars(tempString, rowConsitsChar2))
                {
                    result.Add(words[i]);
                }
                else if (ValidationChars(tempString, rowConsitsChar3))
                {
                    result.Add(words[i]);
                }
            }
            return result.ToArray();
        }

        private static bool ValidationChars(string words, char[] chars)
        {
            bool result = true;
            for (int i = 0; i < words.Length; i++)
            {
                if (!chars.Contains(words[i]))
                {
                    result = false;
                    break;
                }
            }
            return result;
        }
    }
}
