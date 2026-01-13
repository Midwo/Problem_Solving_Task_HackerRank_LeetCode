using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2042
    {
        ////(2042.) Check if Numbers Are Ascending in a Sentence (EASY)
        public bool AreNumbersAscending(string s)
        {
            int lastValue = 0;
            int currValue = 0;

            for (int indexS = 0; indexS < s.Length; indexS++)
            {
                char temp = s[indexS];
                if (temp >= '0' && temp <= '9')
                {
                    if (currValue == 0)
                    {
                        currValue = temp - '0';
                    }
                    else
                    {
                        currValue *= 10;
                        currValue += temp - '0';
                    }
                }
                else if (currValue > 0) 
                {
                    if (currValue <= lastValue)
                    {
                        return false;
                    }
                    else
                    {
                        lastValue = currValue;
                        currValue = 0;
                    }
                }
            }

            if (currValue > 0 && currValue <= lastValue)
            {
                return false;
            }

            return true;
        }
    }
}
