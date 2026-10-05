using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_856
    {
        ////(856.) Score of Parentheses (MEDIUM)
        public int ScoreOfParentheses(string s)
        {
            int score = 0;
            Stack<int> stackScore = new Stack<int>();
           
            foreach (char currChar in s)
            {
                if(currChar == '(')
                {
                    stackScore.Push(score);
                    score = 0;
                }
                else
                {
                    score += stackScore.Pop() + Math.Max(score * 2, 1);   
                }
            }

            return score;
        }
    }
}
