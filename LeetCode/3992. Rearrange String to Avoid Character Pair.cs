using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3992
    {
        ////(3992.) Rearrange String to Avoid Character Pair (EASY)
        public string RearrangeString(string s, char x, char y)
        {
            StringBuilder firstSection  = new StringBuilder();
            StringBuilder secondSection = new StringBuilder();
            StringBuilder lastSection = new StringBuilder();

            foreach (char currChar in s) 
            { 
                if(currChar == y)
                {
                    firstSection.Append(currChar);
                }
                else if (currChar == x)
                {
                    lastSection.Append(currChar);
                }
                else
                {
                    secondSection.Append(currChar);
                }
            }

            firstSection.Append(secondSection);
            firstSection.Append(lastSection);

            return firstSection.ToString();
        }
    }
}
