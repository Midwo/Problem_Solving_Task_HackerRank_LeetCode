using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_921
    {
        ////(921.) Minimum Add to Make Parentheses Valid (MEDIUM)
        public int MinAddToMakeValid(string s)
        {
            int left = 0;
            int length = s.Length;
            int howManyCorrect = 0;

            for (int i = 0; i < s.Length; i++) 
            {
                if (s[i] == '(')
                {
                    left++;
                }
                else if (left > 0)
                {
                    left--;
                    howManyCorrect += 2;
                }
            }

            return length - howManyCorrect;
        }
    }
}
