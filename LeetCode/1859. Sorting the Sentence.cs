using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1859
    {
        ////(1859.) Sorting the Sentence (EASY)
        public string SortSentence(string s)
        {
            string[] words = s.Split(' ');
            string[] sortedWords = new string[words.Length];

            for (int i = 0; i < words.Length; i++) 
            {
                sortedWords[int.Parse(words[i][words[i].Length - 1].ToString())-1] = words[i][0..(words[i].Length-1)];
            }

            return string.Join(' ', sortedWords);
        }
    }
}
