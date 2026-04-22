using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2452
    {
        ////(2452.) Words Within Two Edits of Dictionary (MEDIUM)
        public IList<string> TwoEditWords(string[] queries, string[] dictionary)
        {          
            var resultCorrectWords = new List<string>();

            foreach (var word in queries)
            {

                foreach (var dictWord in dictionary)
                {
                    int diff = 0;
                    int index = 0;
                    while (diff <= 2 && index < word.Length)
                    {
                        if (dictWord[index] != word[index++])
                            diff++;
                    }
                    if (diff <= 2)
                    {
                        resultCorrectWords.Add(word);
                        break;
                    }
                }
            }

            return resultCorrectWords;
        }
    }
}
