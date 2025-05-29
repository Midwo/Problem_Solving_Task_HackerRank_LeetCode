using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_151
    {
        ////(151.) Reverse Words in a String (MEDIUM)
        public string ReverseWords(string s)
        {
            string[] splitWords = s.Split(' ', StringSplitOptions.RemoveEmptyEntries);


            ////Option 1
            //List<string> words = new List<string>();

            //for (int i = splitWords.Length -1; i >=0; i--)
            //{
            //    words.Add(splitWords[i]);
            //}

            //return string.Join(' ', words);



            ////OR
            ////Option 2

            Array.Reverse(splitWords);
            return string.Join(' ', splitWords.ToArray());

        }
    }
}
