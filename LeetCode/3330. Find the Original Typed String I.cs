using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3330
    {
        ////(3330.) Find the Original Typed String I (EASY)
        public int PossibleStringCount(string word)
        {
            int result = 1;
            char prevChar = word[0];

            for (int i = 1; i < word.Length; i++)
            {
                if (word[i] == prevChar)
                {
                    result++;
                }
                prevChar = word[i];
            }

            return result;
        }
    }
}
