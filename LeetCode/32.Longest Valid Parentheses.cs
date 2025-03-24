using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_32
    {
        ////(32.) Longest Valid Parentheses (HARD)
        public int LongestValidParentheses(string s)
        {
            ////"(()"
            //// string s = ")()())"; 
            int maxValue = 0;
            int maxValueFromBehind = 0;
            int leftBracket = 0;
            int leftBracketFromBehind = 0;
            int rightBracket = 0;
            int rightBracketFromBehind = 0;
            int lastIndexS = s.Length - 1;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(')
                {
                    leftBracket++;
                }
                else
                {
                    rightBracket++;
                }
                if (leftBracket == rightBracket)
                {
                    maxValue = Math.Max(maxValue, rightBracket * 2);
                }
                else if (rightBracket > leftBracket)
                {
                    leftBracket = rightBracket = 0;
                }

                if (s[lastIndexS-i] == '(')
                {
                    leftBracketFromBehind++;
                }
                else
                {
                    rightBracketFromBehind++;
                }
                if (leftBracketFromBehind == rightBracketFromBehind)
                {
                    maxValueFromBehind = Math.Max(maxValueFromBehind, leftBracketFromBehind * 2);
                }
                else if (leftBracketFromBehind > rightBracketFromBehind)
                {
                    leftBracketFromBehind = rightBracketFromBehind = 0;
                }
            }
            return Math.Max(maxValue, maxValueFromBehind);
        }
    }
}
