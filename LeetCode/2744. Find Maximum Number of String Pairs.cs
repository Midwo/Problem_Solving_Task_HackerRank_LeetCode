using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2744
    {
        ////(2744.) Find Maximum Number of String Pairs (EASY)
        public int MaximumNumberOfStringPairs(string[] words)
        {
            HashSet<(char, char)> hashSetWords = new HashSet<(char, char)>();
            int countPair = 0;

            foreach (string word in words) 
            {
                char firstChar = word[0];
                char secondChar = word[1];
                
                if(firstChar > secondChar)
                {
                    char temp = firstChar;
                    firstChar = secondChar;
                    secondChar = temp;
                }

                if (!hashSetWords.Add((firstChar, secondChar)))
                    countPair++;
            }

            return countPair;
        }
    }
}
