using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2390
    {
        ////(2390.) Removing Stars From a String (MEDIUM)
        public string RemoveStars(string s)
        {
            StringBuilder reverseResultStringBuilder = new StringBuilder();
            int howManySkips = 0;

            for (int i = s.Length-1; i>= 0; i--)
            {
                if (s[i] == '*')
                {
                    howManySkips++;
                }
                else
                {
                    if(howManySkips > 0)
                    {
                        howManySkips--;
                    }
                    else
                    {
                        reverseResultStringBuilder.Append(s[i]);
                    }
                }
            }

            return new string(reverseResultStringBuilder.ToString().Reverse().ToArray());
        }
    }
}
