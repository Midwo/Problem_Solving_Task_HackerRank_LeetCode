using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1021
    {
        ////(1021.) Remove Outermost Parentheses (EASY)
        public string RemoveOuterParentheses(string s)
        {
            
            int howMany = 0;
            StringBuilder result = new StringBuilder();

            foreach (char c in s) 
            { 
                if(c == '(')
                {
                    if(howMany > 0) result.Append('(');
                    howMany++;
                }
                else
                {
                    howMany--;
                    if (howMany > 0) result.Append(')');
                }
            }

            return result.ToString();
        }
    }
}
