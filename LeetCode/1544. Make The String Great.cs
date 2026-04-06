using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1544
    {
        ////(1544.) Make The String Great (EASY)
        public string MakeGood(string s)
        {
            char lastChar = ' ';
            
            StringBuilder sb = new StringBuilder();

            for (int index = 0; index < s.Length; index++)
            {
                char currChar = s[index];

                ////Check diff -> 32 char
                //Console.WriteLine((int)'a');
                //Console.WriteLine((int)'A');
                //Console.WriteLine(((int)'a'-(int)'A'));

                if (currChar + 32 != lastChar && currChar - 32 != lastChar)
                {
                    sb.Append(currChar);
                    lastChar = currChar;
                }
                else
                {
                    sb.Remove(sb.Length-1,1);
                    if(sb.Length > 0)
                    {
                        lastChar = sb[sb.Length-1];
                    }
                    else
                    {
                        lastChar = ' ';
                    }
                }
            }

            return sb.ToString();
        }
    }
}
