using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1796
    {
        ////(1796.) Second Largest Digit in a String (EASY)
        public int SecondHighest(string s)
        {
            int secondHighestChar = -1;
            int highestChar = -1;

            for (int index = 0; index < s.Length; index++) 
            {
                if (s[index] >= '0' && s[index] <= '9')
                {
                    if(highestChar < s[index])
                    {
                        secondHighestChar = highestChar;
                        highestChar = s[index];
                    }
                    else if(secondHighestChar < s[index] && highestChar != s[index])
                    {
                        secondHighestChar = s[index];
                    }
                }
            }

            if (secondHighestChar == -1)
            {
                return -1;
            }
            else
            {
                return secondHighestChar-'0';
            }
        }
    }
}
