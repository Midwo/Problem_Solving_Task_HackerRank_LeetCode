using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2114
    {
        ////(2114.) Maximum Number of Words Found in Sentences (EASY)
        public int MostWordsFound(string[] sentences)
        {
            int maxWords = 0;

            foreach (string sentence in sentences)
            {
                maxWords = Math.Max(maxWords, sentence.Split(' ').Count());
            }

            return maxWords;
        }
    }
}
