using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2788
    {
        ////(2788.) Split Strings by Separator (EASY)
        public IList<string> SplitWordsBySeparator(IList<string> words, char separator)
        {
            IList<string> splitWordsList = new List<string>();

            for (int i = 0; i < words.Count; i++)
            {
                //string[] word = words[i].Split(separator);
                string[] word = words[i].Split(separator, StringSplitOptions.RemoveEmptyEntries);

                for (int j = 0; j < word.Length; j++)
                {
                    //if (word[j].Length > 0)
                    //{
                        splitWordsList.Add(word[j]);
                    //}
                }
            }

            return splitWordsList;
        }
    }
}
