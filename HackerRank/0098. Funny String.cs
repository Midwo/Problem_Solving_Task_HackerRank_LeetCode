using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.HackerRank
{
    internal class HackerRank_0098
    {
        ////98. Funny String (EASY)
        public string funnyString(string s)
        {
            ////Solution 1 (New - Better)
            var lengthS = s.Length;
            for (int i = 0; i < lengthS-1; i++) 
            {
                if (Math.Abs(s[i + 1] - s[i]) != Math.Abs(s[lengthS-2-i] - s[lengthS - 1 - i]))
                {
                    return "Not Funny";
                }
            
            }

            return "Funny";


            ////Solution 2 (Old - Poor)
            //string contentString = s;
            //string originalString = string.Empty;
            //for (int i = 0; i < contentString.Length - 1; i++)
            //{
            //    originalString += (Math.Abs((int)contentString[i] - (int)contentString[i + 1]));
            //}
            //string reverse = string.Empty;
            //foreach (char i in contentString.Reverse())
            //{
            //    reverse += i;
            //}

            //string reverseString = string.Empty;
            //for (int i = 0; i < contentString.Length - 1; i++)
            //{
            //    reverseString += (Math.Abs((int)reverse[i] - (int)reverse[i + 1]));
            //}
            //if (originalString == reverseString)
            //{
            //    return "Funny";
            //}
            //else
            //{
            //    return "Not Funny";
            //}
        }
    }
}
