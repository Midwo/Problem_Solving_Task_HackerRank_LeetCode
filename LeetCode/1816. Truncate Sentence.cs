using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1816
    {
        ////(1816.) Truncate Sentence (EASY) 
        public string TruncateSentence(string s, int k)
        {
            string[] wordList = s.Split(' ');

            string result = wordList[0];

            for (int i = 1; i < k; i++)
            {
                result += ' ' + wordList[i];
            }

            return result;
        }
    }
}
