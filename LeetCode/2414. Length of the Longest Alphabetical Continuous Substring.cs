using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2414
    {
        ////(2414.) Length of the Longest Alphabetical Continuous Substring (MEDIUM)
        public int LongestContinuousSubstring(string s)
        {
            int maxLenghtAlphabeticalContinuous = 1;
            char lastChar = '\0';
            int currLenghtAlpabeticalContinuous = 1;

            foreach (char item in s)
            {
                if (lastChar+1 == item)
                {
                    currLenghtAlpabeticalContinuous++;
                    maxLenghtAlphabeticalContinuous = maxLenghtAlphabeticalContinuous < currLenghtAlpabeticalContinuous ? currLenghtAlpabeticalContinuous : maxLenghtAlphabeticalContinuous;
                }
                else
                {
                    currLenghtAlpabeticalContinuous = 1;
                }
                lastChar = item;
            }

            return maxLenghtAlphabeticalContinuous;
        }
    }
}
