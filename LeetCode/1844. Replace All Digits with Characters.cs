using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1844
    {
        ////(1844.) Replace All Digits with Characters (EASY)
        public string ReplaceDigits(string s)
        {
            //0ms, Beats: 100.00%

            StringBuilder sb = new StringBuilder();
            char lastChar = s[0];
            for (int i = 0; i < s.Length; i++) 
            {
                if (i % 2 == 0)
                {
                    sb.Append(s[i]);
                    lastChar = s[i];
                }
                else
                {
                    //int temp = int.Parse(s[i].ToString());
                    sb.Append((char)(lastChar + char.GetNumericValue(s[i])));
                }
            }

            return new string(sb.ToString());
        }
    }
}
