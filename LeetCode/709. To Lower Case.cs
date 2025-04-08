using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_709
    {
        ////(709.) To Lower Case (EASY)
        public string ToLowerCase(string s)
        {
            char[] result = new char[s.Length];

            for (int i = 0; i < s.Length; i++)
            {
                char temp = s[i];
                if ('A' <= temp && 'Z' >= temp)
                {
                    result[i] = (char)(temp+32);
                }
                else
                {
                    result[i] = temp;
                }
            }
            return new string (result);

            //slow option
            //return s.ToLower();
        }
    }
}
