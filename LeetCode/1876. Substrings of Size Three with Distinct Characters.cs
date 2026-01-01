using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1876
    {
        ////(1876.) Substrings of Size Three with Distinct Characters (EASY)
        public int CountGoodSubstrings(string s)
        {
            int length = s.Length;

            if(length < 3)
            {
                return 0;
            }

            char firstLetter = s[0];
            char secondLetter = s[1];
            char thirdLetter = s[2];

            int countGoodStrings = isGoodSubstrings(firstLetter, secondLetter, thirdLetter) ? 1: 0;

            for (int i = 3; i < length; i++) 
            {
                firstLetter = secondLetter;
                secondLetter = thirdLetter;
                thirdLetter = s[i];
                if (isGoodSubstrings(firstLetter, secondLetter, thirdLetter))
                {
                    countGoodStrings++;
                }
            }

            return countGoodStrings;
        }

        public bool isGoodSubstrings(char firstLetter, char secondLetter, char thirdLetter)
        {
            if (firstLetter != secondLetter && firstLetter != thirdLetter && secondLetter != thirdLetter)
            {
                return true;
            }
            return false;
        }
    }
}
