using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1807
    {
        ////(1807.) Evaluate the Bracket Pairs of a String (MEDIUM)
        public string Evaluate(string s, IList<IList<string>> knowledge)
        {
            Dictionary<string, string> dictKnowledge = new Dictionary<string, string>();

            foreach (var item in knowledge)
            {
                dictKnowledge.Add(item[0], item[1]);
            }

            StringBuilder sbResult = new StringBuilder();
            string currShortWord = string.Empty;
            bool statusStartWord = false;

            foreach (char currChar in s)
            {
                if(!statusStartWord && currChar != '(')
                {
                    sbResult.Append(currChar);
                }
                else if(!statusStartWord && currChar == '(')
                {
                    statusStartWord = true;
                }
                else if(statusStartWord && currChar != ')')
                {
                    currShortWord += currChar;
                }
                else
                {
                    statusStartWord = false;
                    if (dictKnowledge.ContainsKey(currShortWord))
                    {
                        sbResult.Append(dictKnowledge[currShortWord]);
                    }
                    else
                    {
                        sbResult.Append('?');
                    }
                    currShortWord = string.Empty;
                }
            }

            return sbResult.ToString();
        }
    }
}
