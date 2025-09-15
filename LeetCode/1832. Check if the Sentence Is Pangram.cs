using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.LeetCode
{
    internal class LeetCode_1832
    {
        ////(1832.) Check if the Sentence Is Pangram (EASY)
        public bool CheckIfPangram(string sentence)
        {
            //// 1ms, Beats: 61,57%

            HashSet<char> hashSetChars = new HashSet<char>();

            for (int i = 0; i < sentence.Length; i++)
            {
                hashSetChars.Add(sentence[i]);
            }
            
            if(hashSetChars.Count == 26)
            {
                return true;
            }
            return false;
        }
    }
}
