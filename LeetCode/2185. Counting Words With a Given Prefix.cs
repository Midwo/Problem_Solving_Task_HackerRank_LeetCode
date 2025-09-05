using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_2185
    {
        ////(2185.) Counting Words With a Given Prefix (EASY)
        public int PrefixCount(string[] words, string pref)
        {
            int count = 0;
            int prefLength = pref.Length;
            bool goodPref = false; 

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length >= prefLength)
                {
                    goodPref = true;
                    for (int j = 0; j < prefLength; j++)
                    {
                        if (pref[j] != words[i][j])
                        {
                            goodPref = false;
                            break;
                        }
                    }
                    if (goodPref)
                    {
                        count++;
                    }
                }
            }

            return count;
        }
    }
}
