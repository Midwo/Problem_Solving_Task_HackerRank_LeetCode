using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2942
    {
        ////(2942.) Find Words Containing Character (EASY)
        public IList<int> FindWordsContaining(string[] words, char x)
        {
            List<int> result = new List<int>();

            for (int j = 0; j < words.Length; j++)
            { 
                if (words[j].Contains(x))
                {
                    result.Add(j);
                }   
            }

            return result.ToArray();
        }
    }
}
