using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1408
    {
        ////(1408.) String Matching in an Array (EASY)
        public IList<string> StringMatching(string[] words)
        {
            List<string> result = new List<string>();
            int lenght = words.Length;

            for (int i = 0; i < lenght; i++)
            {
                string currWord = words[i];
                for (int j = 0; j < lenght; j++)
                {
                    if (j != i && words[j].Contains(currWord))
                    {
                        result.Add(currWord);
                        break;
                    }

                }
            }

            return result;
        }
    }
}
