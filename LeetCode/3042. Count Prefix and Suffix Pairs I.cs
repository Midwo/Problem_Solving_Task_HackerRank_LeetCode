using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_3042
    {
        ////(3042.) Count Prefix and Suffix Pairs I (EASY)
        public int CountPrefixSuffixPairs(string[] words)
        {
            int count = 0;
            int length = words.Length;

            for (int i = 0; i < length -1; i++)
            {
                string currWords = words[i];
                int lengthWordI = currWords.Length;

                for (int j = i+1; j < length; j++)
                {
                    int lengthWordJ = words[j].Length;

                    //Console.WriteLine(words[j][0..lengthWordI]);
                    //Console.WriteLine(words[j][(lengthWordJ-lengthWordI)..lengthWordJ]);

                    if(lengthWordI <= lengthWordJ && currWords == words[j][0..lengthWordI] && words[j][(lengthWordJ - lengthWordI)..lengthWordJ] == currWords)
                    {
                        count++;
                    }
                }
            }

            return count;
        }
    }
}
